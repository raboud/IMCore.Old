﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;

namespace RandREng.Utility.Mail
{
	public class Mailer
	{
		private ILogger Logger;

		public enum EnEmailAddressStatusCode { Valid, Blank, IncorrectFormat };

		public string SMTPServer { get; set; }
		public int Port { get; set; }
		public bool UseSSL { get; set; }
		public string AuthAccount { get; set; }
		public string AuthPasswrd { get; set; }

		public string FromAddress { get; set; }
		public string FromFriendlyName { get; set; }

		private List<string> toAddresses = null;
		public List<string> ToAddresses
		{
			get
			{
				if (this.toAddresses == null)
				{
					toAddresses = new List<string>();
				}
				return toAddresses;
			}

			set
			{
				toAddresses = value;
			}
		}

		private List<string> ccAddresses = null;
		public List<string> CCAddresses
		{
			get
			{
				if (this.ccAddresses == null)
				{
					ccAddresses = new List<string>();
				}
				return ccAddresses;
			}

			set
			{
				ccAddresses = value;
			}
		}

		public bool BodyIsHtml { get; set; }
		private SmtpClient client = null;
		private SmtpClient Client
		{
			get
			{
				if (this.client == null)
				{
					if (!string.IsNullOrEmpty(this.SMTPServer))
					{
						this.client = new SmtpClient(this.SMTPServer, this.Port);
						this.client.DeliveryMethod = SmtpDeliveryMethod.Network;
						this.client.EnableSsl = this.UseSSL;
					}
				}
				return (this.client);
			}

			set
			{
				this.client = value;
			}
		}

		public Mailer(ILogger logger)
		{
			SMTPServer = AppSettings.GetAppSetting("SMTPServer", "");
			Port = AppSettings.GetAppSetting("SMTPServerPort", 25);
			UseSSL = AppSettings.GetAppSetting("UseSSL", false);
			AuthAccount = AppSettings.GetAppSetting("AuthAccount", "");
			AuthPasswrd = AppSettings.GetAppSetting("AuthPasswrd", "");

			string ToAddress = AppSettings.GetAppSetting("ToAddress", "");
			if (Mailer.IsValidEmail(ToAddress))
			{
				Logger.LogDebug(String.Format("Adding address: {0}", ToAddress));
				ToAddresses.Add(ToAddress);
			}
			FromAddress = AppSettings.GetAppSetting("FromAddress", "");
			FromFriendlyName = AppSettings.GetAppSetting("FromFriendlyName", "");

			Logger = logger;
			this.BodyIsHtml = false;
		}

		public Mailer(string server, ILogger logger) : this(server, 25, false, logger)
		{
		}

		public Mailer(string server, int port, bool useSSL, ILogger logger)
		{
			SMTPServer = server;
			this.BodyIsHtml = false;
			Port = port;
			UseSSL = useSSL;
			Logger = logger;
		}

		public bool SendMail(string Subject, string Body, ref string errors)
		{
			return SendMail(Subject, Body, false, ref errors);
		}

		public bool SendMail(string Subject, string Body, bool HighPriority, ref string errors)
		{
			return SendMail(Subject, Body, HighPriority, "", ref errors);
		}

		public bool SendMail(string Subject, string Body, bool HighPriority, string Attachment, ref string errors)
		{
			return SendMail(Subject, Body, HighPriority, Attachment, ToAddresses, FromAddress, FromFriendlyName, ref errors);
		}

		public bool SendMail(string Subject, string Body, bool HighPriority, string Attachment, string To, string From, string DisplayName, ref string errors)
		{
			if (String.IsNullOrWhiteSpace(To))
			{
				Logger.LogError(String.Format("Cannot add an empty To address to email with subject: {0}", Subject));
				return false;
			}
			ToAddresses.Clear();  // need to clear any existing addresses that may have been added
			Logger.LogDebug(String.Format("Adding address: {0}", To));
			ToAddresses.Add(To);
			return SendMail(Subject, Body, HighPriority, Attachment, ToAddresses, From, DisplayName, AuthAccount, AuthPasswrd, ref errors);
		}

		public bool SendMail(string Subject, string Body, bool HighPriority, string Attachment, List<string> ToAddresses, string From, string DisplayName, ref string errors)
		{
			return SendMail(Subject, Body, HighPriority, Attachment, ToAddresses, From, DisplayName, AuthAccount, AuthPasswrd, ref errors);
		}

		public bool SendMail(string Subject, string Body, bool HighPriority, string Attachment, string To, string CC, string From, string DisplayName, string Account, string Password, ref string errors)
		{
			if (String.IsNullOrWhiteSpace(To))
			{
				Logger.LogError(String.Format("Cannot add an empty To address to email with subject: {0}", Subject));
				return false;
			}
			ToAddresses.Clear();  // need to clear any existing addresses that may have been added
			ToAddresses.Add(To);

			CCAddresses.Clear();
			CCAddresses.Add(CC);

			return SendMail(Subject, Body, HighPriority, Attachment, ToAddresses, From, DisplayName, Account, Password, ref errors);
		}

		public bool SendMail(string Subject, string Body, bool HighPriority, string Attachment, List<string> ToAddresses, string From, string DisplayName, string Account, string Password, ref string errors)
		{
			bool retVal = false;
			try
			{
				if (ToAddresses.Count > 0 && !string.IsNullOrWhiteSpace(From) && !string.IsNullOrWhiteSpace(SMTPServer) &&
					!string.IsNullOrWhiteSpace(Account) && !string.IsNullOrWhiteSpace(Password))
				{
					MailMessage message = new MailMessage();
					this.Client.Credentials = new NetworkCredential(Account, Password);

					try
					{
						message.From = new MailAddress(From, DisplayName);
					}
					catch (Exception e)
					{
						Logger.LogCritical(e, "SendMail");
						Logger.LogError(string.Format("From - {0}", From));
						return false;
					}

					try
					{
						message.ReplyToList.Add(From);
					}
					catch (Exception e)
					{
						if (!string.IsNullOrEmpty(errors))
						{
							errors += Environment.NewLine;
						}
						errors += e.Message;
						Logger.LogCritical(e, "SendMail");
						Logger.LogError(string.Format("ReplyTo - {0}", From));
						return false;
					}
					message.Body = Body;
					message.To.Clear();  // need to clear any existing addresses that may have been added
					foreach (string ToAddress in ToAddresses)
					{
						if (!String.IsNullOrWhiteSpace(ToAddress))
						{
							try
							{
								message.To.Add(ToAddress);
							}
							catch (Exception e)
							{
								if (!string.IsNullOrEmpty(errors))
								{
									errors += Environment.NewLine;
								}
								errors += e.Message;
								Logger.LogCritical(e, "SendMail");
								Logger.LogError(string.Format("CC - {0}", ToAddress));
								return false;
							}
						}
						else
						{
							Logger.LogError(String.Format("Found an empty ToAddress when sending an email with the subject: '{0}", Subject));
						}

					}

					message.CC.Clear();  // need to clear any existing addresses that may have been added
					foreach (string CCAddress in CCAddresses)
					{
						if (!string.IsNullOrWhiteSpace(CCAddress))
						{
							try
							{
								message.CC.Add(CCAddress);
							}
							catch (Exception e)
							{
								if (!string.IsNullOrEmpty(errors))
								{
									errors += Environment.NewLine;
								}
								errors += e.Message;
								Logger.LogCritical(e, "SendMail");
								Logger.LogError(string.Format("CC - {0}", CCAddress));
								return false;
							}
						}
						else
						{
							Logger.LogError(String.Format("Found an empty CCAddress when sending an email with the subject: '{0}", Subject));
						}

					}

					if (!string.IsNullOrEmpty(Attachment))
					{
						message.Attachments.Add(new Attachment(Attachment, new ContentType(MediaTypeNames.Application.Octet)));
					}

					message.Subject = Subject;
					message.IsBodyHtml = this.BodyIsHtml;
					message.Priority = (HighPriority) ? MailPriority.High : MailPriority.Normal;
					try
					{
						this.Client.Send(message);
						retVal = true;
					}
					catch (Exception ex)
					{
						string error = "SendMail - ";
						foreach (string adr in ToAddresses)
						{
							error += adr + " - ";
						}
						error += string.Format(" From {0} - DispalyName {1} - Account {2} - Password {3}", From, DisplayName, Account, Password);
						Logger.LogError(error);
						if (!string.IsNullOrEmpty(errors))
						{
							errors += Environment.NewLine;
						}
						errors += ex.Message;
						Logger.LogCritical(ex, "SendMail");
					}
				}
				else
				{
					Logger.LogInformation("SendMail() - ToAddress, FromAddress, or SMTPServer name was empty.");
				}
			}
			catch (Exception e)
			{
				Logger.LogCritical(e, "SendMail");
			}
			return retVal;
		}

		public bool SendMail(MailMessage message, string Account, string Password, ref string Messages)
		{
			bool retVal = false;
			try
			{
				this.Client.Credentials = new NetworkCredential(Account, Password);

				this.Client.Send(message);
				retVal = true;
			}
			catch (Exception e)
			{
				Logger.LogError(message.ToString());
				Messages += e.Message;
				Logger.LogCritical(e, "SendMail");
			}
			return retVal;
		}

		public static bool IsValidEmail(string emailAddress)
		{
			EnEmailAddressStatusCode code = EnEmailAddressStatusCode.Blank;
			return IsValidEmail(emailAddress, out code);
		}

		public static bool IsValidEmail(string emailAddress, out EnEmailAddressStatusCode statusCode)
		{
			statusCode = EnEmailAddressStatusCode.Valid;

			if (String.IsNullOrEmpty(emailAddress))
			{
				statusCode = EnEmailAddressStatusCode.Blank;
				return false;
			}

			// Use IdnMapping class to convert Unicode domain names.
			emailAddress = Regex.Replace(emailAddress, @"(@)(.+)$", Mailer.DomainMapper);

			if (String.IsNullOrEmpty(emailAddress))
			{
				statusCode = EnEmailAddressStatusCode.IncorrectFormat;
				return false;
			}

			// Return true if emailAddress is in valid e-mail format.
			bool valid = Regex.IsMatch(emailAddress,
								@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
								@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
								RegexOptions.IgnoreCase);

			if (!valid)
			{
				statusCode = EnEmailAddressStatusCode.IncorrectFormat;
			}

			return valid;
		}

		private static string DomainMapper(Match match)
		{

			// IdnMapping class with default property values.
			IdnMapping idn = new IdnMapping();

			string domainName = match.Groups[2].Value;

			try
			{
				domainName = idn.GetAscii(domainName);
			}
			catch (ArgumentException)
			{
				return string.Empty;
			}

			return match.Groups[1].Value + domainName;
		}
	}
}
