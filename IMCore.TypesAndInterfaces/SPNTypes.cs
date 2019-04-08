using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Text;

namespace IMCore.TypesAndInterfaces
{
	public static class Shared
	{
		public enum EnDateFilterDisplay { Both, StartOnly, None };
		public static DateTime MinHireDate = new DateTime(1970, 1, 1);
		public static DateTime MaxHireDate = new DateTime(2099, 12, 31);

		public enum EnLaborType { Basic = 1, Optional = 2, Custom = 3 };

		public enum EnBusinessMode { HomeDepot, Commercial };

		public enum EntryMethod { Manual = 1, SpnImported = 2, SPNImportedHandmodified = 3, SPNImportedXMLDeleted = 4, SOSIImported = 5, SOSIImportedHandmodified = 6, SOSIImportedXMLDeleted = 7 }

		public enum EnJobStatus { InitialReview = 1, NeedsReview = 2, WaitingOnMaterials = 3, ReadyToSchedule = 4, Scheduled = 5, ReadyToBill = 6, Billed = 8, Done = 7, Cancelled = 9 };
		public enum EnNoteType
		{
			Internal = 1, NoteToExpeditor = 2, NoteFromExpeditor = 3, CallToCustomerHome = 4, CallToCustomerWork = 5, CallToCustomerAllNos = 6, CallFromCustomer = 7,
			CallToStore = 8, CallFromStore = 9, FaxToStore = 10, FaxFromStore = 11, InformationOnly = 12, CallToInstaller = 13, CallFromInstaller = 14, ManagerAction = 15,
			CallToCustomerMobile = 16
		};

		public enum EnUserTaskType { InitialCall = 1, SchedulingCall, ConfirmCall, PostCall, ReCall, PriorityReCall, InitialReview };

		public enum EnDiscrepancyType
		{
			Store = 1,
			Customer = 2,
			BasicLabor = 3,
			OptionsDetail = 4,
			RegularMerchandise = 5,
			SOMerchandise = 6,
			Other = 7,
			Options = 8,
			OptionPricing = 9,
			BasicPricing = 10,
			MaterialType = 11,
			BasicLaborDetail = 12,
			CustomLaborDetail = 13,
			BasicLaborPriceChange = 14,
			OptionPriceChange = 15
		};

		public enum EnDiscrepancySubType
		{
			Address1 = 1,
			Address2 = 2,
			City = 3,
			State = 4,
			Zip = 5,
			FirstName = 6,
			LastName = 7,
			HomePhone = 8,
			WorkPhone = 9,
			StoreFax = 10,
			StorePhone = 11,
			SKUNumber = 12,
			SKUDescription = 13,
			Quantity = 14,
			Price = 15,
			Extension = 16,
			NewItem = 17,
			ExtraItem = 18,
			ArrivalDate = 19,
			WarrantyPONotFound = 20,
			BasicLaborNotFound = 21,
			Retail = 22,
			BasicLaborIDMismatch = 23,
			ShortDescription = 24,
			Description = 25,
			CancelledPO = 26,
			Notes = 27,
			ScheduleDate = 28
		};

		public static int MaterialStatus_NOT_PRESENT = 1;
		public static int MaterialStatus_PRESENT = 2;
		public static int MaterialStatus_UNKNOWN = 16;

		public enum EnDivision { All = -1, SoftSurface = 1, HardSurface = 2, Commercial = 3, Measures = 4, Cabinets = 5, HDCommercial = 6 };
		public enum EnSpokeWith { MrCustomer = 0, MsCustomer = 1, Other = 2, LeftMessage = 3, NoAnswer = 4, NA = 5, SelectAnOption = 6, Installer = 7 };

		public static int PermissionType_EXPLICIT = 5;

		public static DateTime DateMinValue
		{
			get
			{
				return SqlDateTime.MinValue.Value;
			}
		}

		public static DateTime CloseOfBusinessDateTime()
		{
			DateTime dtNow = DateTime.Now;
			DateTime dt = new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 17, 0, 0);
			return dt;
		}

		public static String ToTitleCase(String InputString)
		{
			TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
			return myTI.ToTitleCase(InputString.ToLower());
		}

		public static String GetBuildDateTime(String VersionNumber)
		{
			// VersionNumber is Major.Minor.Build.Revision
			// Build is equal to the number of days since January 1, 2000, local time
			// Revision is equal to the number of seconds since midnight, January 1, 2000, local time, divided by 2.

			String buildDateTime = String.Empty;

			string[] versionInfo = VersionNumber.Split('.');
			if (versionInfo.Length == 4)
			{
				DateTime buildDT = new DateTime(1980, 1, 1);
				System.Double days = Convert.ToDouble(versionInfo[2]);
				//                System.Double seconds = Convert.ToDouble(versionInfo[3]) * 2;
				//                buildDT = buildDT.AddSeconds(seconds);
				buildDT = buildDT.AddDays(days);
				//              if (DateTime.Now.IsDaylightSavingTime())
				//                buildDT = buildDT.ToUniversalTime().ToLocalTime();
				buildDateTime = buildDT.ToShortDateString();
			}

			return buildDateTime;
		}

		public static string FormatDateTime(DateTime? dateTime)
		{
			var formattedDateTime = (dateTime == null) ? "" : dateTime.Value.ToString("MM/dd/yyyy HH:mm:ss");
			return formattedDateTime;
		}

		public static string FormatDateTimeWithAMPM(DateTime? dateTime)
		{
			var formattedDateTime = (dateTime == null) ? "" : dateTime.Value.ToString("MM/dd/yyyy hh:mm:ss tt");
			return formattedDateTime;
		}

		public static string FormatDate(DateTime? dateTime)
		{
			var formattedDate = (dateTime == null) ? "" : dateTime.Value.ToString("MM/dd/yyyy");
			return formattedDate;
		}

		public static bool NotInDesignMode()
		{
			try
			{
				return (System.Diagnostics.Process.GetCurrentProcess().ProcessName != "devenv");
			}
			catch (Exception)
			{
				return false;
			}
		}
	}

	public static class SPNTypes
	{
		public enum EnCFIPOStatus { OK, ERROR, EXACT_MATCH, DIFFERENCES, DIFFERENCES_NO_PRINT, FOUND, NOT_FOUND };
		public enum EnCompareStatus { ERROR, EXACT_MATCH, DIFFERENT_NO_PRINT, DIFFERENT };
		public enum EnSOSIXMLProcessStatus { OK, ERROR, DOCUMENT_TYPE_ERROR, OK_RENAME_FAILED, TRY_AGAIN, OK_WITH_DIFFERENCES, OK_WITH_DIFFERENCES_NO_PRINT };
		public enum EnSPNOperationResult { SUCCESS, FAILED, FAIL_PO_NOT_FOUND, FAIL_MAINTAINED_BY_OTHER_USER, FAIL_INVALID_PO_NUMBER, FAIL_WEB_ACCESS_ERROR, SUCCESS_NOTE_ALREADY_EXISTS, FAIL_PROCESSING_ERROR };
		public enum EnSPNSendNoteStatus { SUCCESS, UPLOADOK_EMAILFAILED, UPLOADFAILED_EMAILOK, FAILED, INVALID_PO_NUMBER };

		public struct ImportStats
		{
			public int NumInstPOsProcessed;
			public int NumMeasPOsProcessed;
			public int NumCustomersAdded;
			public int NumCustomersFound;
			public int NumCustomersUpdated;
			public int NumInstPOsImported;
			public int NumMeasPOsImported;
			public int NumInstPOsUpdated;
			public int NumMeasPOsUpdated;
			public int NumSKUsFound;
			public int NumSKUsNotFound;
		}

		public struct POStructure
		{
			public string StoreNumber;
			public string PONumber;
			public bool Changed;
		}

		public const string key_SPNSTATS_EMAIL = "SPNStatsEmail";
		//public const string key_SOSISTATS_EMAIL = "SOSIStatsEmail";
		//public const string key_MAINT_MESSAGE_EMAIL = "MaintMessageEmail";
		public const string key_ERROR_NOTIFY_EMAIL = "ErrorNotificationEmail";
		public const string key_WARNING_NOTIFY_EMAIL = "WarningNotificationEmail";
		public const string key_CANCELLEDPO_NOTIFY_EMAIL = "CancelledPONotificationEmail";

		public static DateTime ErrorNotificationEmailLastSent = DateTime.Now.AddHours(-7);

		public const int REG_MERCH_WILL_CALL_STATUS = 20;


		public const int ENTRY_METHOD_MANUAL = 1;
		public const int ENTRY_METHOD_SPN_IMPORTED = 2;
		public const int ENTRY_METHOD_SPN_IMPORTED_HANDMODIFIED = 3;
		public const int ENTRY_METHOD_SPN_IMPORTED_DELETED = 4;
		public const int ENTRY_METHOD_SOSI_IMPORTED = 5;
		public const int ENTRY_METHOD_SOSI_IMPORTED_HANDMODIFIED = 6;
		public const int ENTRY_METHOD_SOSI_IMPORTED_DELETED = 7;

		public enum EnActivityType
		{
			ChangedPOReceived = 1,
			CancelledPOReceived = 2,
			SPActionReceived = 3,
			MeasureApptRescheduledReceived = 4,
			ScheduleWillCall = 5,
			UpdateMeasureCapacity = 6,
			XMLErrorReceived = 7,
			CallCustomer = 8,
			InstallScheduleUpdate = 9,
			CompleteService = 10,
			ProductPickedUp = 11,
			CompleteServiceFailed = 12,
			BadgeExpiration = 13,
			ProductChangedPOReceived = 14,
			ScheduleUpdateFailed = 15,
			CSFollowUpDateFailed = 16,
			NoteToStoreFailed = 17
		}

		public const int ACTIVITY_TYPE_CHANGED_PO_RECEIVED = 1;
		public const int ACTIVITY_TYPE_CANCELLED_PO_RECEIVED = 2;
		public const int ACTIVITY_TYPE_SPACTION_RECEIVED = 3;
		public const int ACTIVITY_TYPE_MEASURE_APPT_RESCHEDULED_RECEIVED = 4;
		public const int ACTIVITY_TYPE_SCHEDULE_WILL_CALL = 5;
		public const int ACTIVITY_TYPE_UPDATE_MEASURE_CAPACITY = 6;
		public const int ACTIVITY_TYPE_XML_ERROR_RECEIVED = 7;
		public const int ACTIVITY_TYPE_CALL_CUSTOMER = 8;
		public const int ACTIVITY_TYPE_INSTALL_SCHEDULE_UPDATE = 9;
		public const int ACTIVITY_TYPE_COMPLETE_SERVICE = 10;
		public const int ACTIVITY_TYPE_PRODUCT_PICKED_UP = 11;
		public const int ACTIVITY_TYPE_COMPLETE_SERVICE_FAILED = 12;
		public const int ACTIVITY_TYPE_BADGE_EXPIRATION = 13;
		public const int ACTIVITY_TYPE_PRODUCT_CHANGED_PO_RECEIVED = 14;
		public const int ACTIVITY_TYPE_SCHEDULE_UPDATE_FAILED = 15;
		public const int ACTIVITY_TYPE_CS_FOLLOWUPDATE_FAILED = 16;
		public const int ACTIVITY_TYPE_NOTE_TO_STORE_FAILED = 17;

		public const int NOTE_TYPE_INTERNAL = 1;
		public const int NOTE_TYPE_NOTEFROMEXPEDITOR = 3;

		public const int SPN_DOWNLOAD_STORE_ATTEMPTS = 5;

		public const int CONTACTID_EXPEDITOR = 2;
		public const int CONTACTID_SPECIALTY_ASM = 8;

		public const int MaterialStatusNotPresent = 1;
		public const int MaterialStatusStorePickup = 4;
		public const int MaterialStatusUnknown = 16;
		public const int MaterialStatusCustomerPickup = 18;
		public const int MaterialStatusHomeDepotDelivery = 19;

		public static string NoteSeparator = " **** ";
	}
}
