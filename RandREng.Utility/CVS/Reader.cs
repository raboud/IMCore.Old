﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RandREng.Utility.CVS
{
	public class Reader
	{
		#region Constants

		/// <summary>
		/// Defines the default delimiter character separating each field.
		/// </summary>
		private const char _defaultDelimiter = ',';

		/// <summary>
		/// Defines the default quote character wrapping every field.
		/// </summary>
		private const char _defaultQuote = '"';

		/// <summary>
		/// Defines the default escape character letting insert quotation characters inside a quoted field.
		/// </summary>
		private const char _defaultEscape = '"';

		/// <summary>
		/// Defines the default comment character indicating that a line is commented out.
		/// </summary>
		private const char _defaultComment = '#';

		#endregion

		/// <summary>
		/// Defines the default delimiter character separating each field.
		/// </summary>
		public char Delimiter { get; set; }

		/// <summary>
		/// Defines the default quote character wrapping every field.
		/// </summary>
		public char Quote { get; set; }

		/// <summary>
		/// Defines the default escape character letting insert quotation characters inside a quoted field.
		/// </summary>
		public char Escape { get; set; }

		/// <summary>
		/// Defines the default comment character indicating that a line is commented out.
		/// </summary>
		public char Comment { get; set; }

		public ILogger Logger { get; set; }

		public Reader()
		{
			this.Comment = Reader._defaultComment;
			this.Delimiter = Reader._defaultDelimiter;
			this.Escape = Reader._defaultEscape;
			this.Quote = Reader._defaultQuote;
		}

		public Dictionary<string, List<string>> ParseBuffer(string buffer)
		{
			return Parse(new StringReader(buffer));
		}

		public Dictionary<string, List<string>> Parse(TextReader sr)
		{
			Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
			try
			{
				List<string> header = null;
				String line;
				// Read and display lines from the file until the end of
				// the file is reached.
				int lineCount = 0;
				while ((line = sr.ReadLine()) != null)
				{
					List<string> items = parseLine(line);
					if (data.Count == 0)
					{
						// add headers
						header = items;
						foreach (string item in items)
						{
							data.Add(item, new List<string>());
						}
					}
					else if (data.Count == items.Count)
					{
						for (int index = 0; index < items.Count; index++)
						{
							data[header[index]].Add(items[index]);
						}
					}
					else
					{
						Logger.LogError("CVS Reader: LIne: " + lineCount);
					}
					lineCount++;
				}
				sr.Close();
			}

			catch (Exception ex)
			{
				// Let the user know what went wrong.
				Logger.LogCritical(ex, "Parse");
			}
			return data;
		}
		public Dictionary<string, List<string>> Parse(string fileName)
		{
			Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
			try
			{
				// Create an instance of StreamReader to read from a file.
				// The using statement also closes the StreamReader.
				using (TextReader sr = new StreamReader(fileName))
				{
					data = Parse(sr);
				}
			}

			catch (Exception ex)
			{
				// Let the user know what went wrong.
				Logger.LogCritical(ex, "Parse");
			}
			return data;
		}

		private List<string> parseLine(string line)
		{
			string temp = line;
			List<string> items = new List<string>();

			if (temp[0] != this.Comment)
			{
				if (temp.EndsWith(this.Quote.ToString()))
				{
					temp = temp.TrimEnd(this.Quote);

				}
				if (temp.EndsWith(this.Delimiter.ToString()))
				{
					temp += this.Quote;
				}

				while (!string.IsNullOrEmpty(temp))
				{
					string delimeter = this.Delimiter.ToString(); ;
					if (temp[0] == this.Quote)
					{
						temp = temp.Substring(1);
						delimeter = this.Quote.ToString() + this.Delimiter.ToString();
					}

					int index = temp.IndexOf(delimeter);
					string item = temp;
					if (index > -1)
					{
						item = temp.Substring(0, index);
						temp = temp.Substring(index + delimeter.Length);
					}
					else
					{
						temp = string.Empty;
					}
					items.Add(item);

				}
			}
			return items;
		}
	}
}
