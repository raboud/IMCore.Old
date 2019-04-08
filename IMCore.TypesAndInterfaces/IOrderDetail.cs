using System;

namespace IMCore.TypesAndInterfaces
{
	public interface IOrderDetail
	{
		bool Reviewed { get; set; }
		bool Deleted { get; set; }
		bool Cancelled { get; }
		int EntryMethodId { get; set; }
		int? ReviewedBy { get; set; }
		Nullable<DateTime> ReviewedDate { get; set; }
	}

}
