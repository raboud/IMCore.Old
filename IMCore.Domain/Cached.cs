using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IMCore.Domain
{
	public class Cached
	{
		static public bool Refresh(IIMContext ctx, ILogger logger)
		{
			bool ok = false;
			try
			{
				DiscrepancyType.RefreshCache(ctx, logger);
				//DiscrepancySubType.RefreshCache(ctx, logger);
				//Department.RefreshCache(ctx, logger);
				//ContactTitle.RefreshCache(ctx, logger);
				//Client.RefreshCache(ctx, logger);
				//ClientType.RefreshCache(ctx, logger);
				//ClientContact.RefreshCache(ctx, logger);
				//ReportType.RefreshCache(ctx, logger);
				//SpokeWith.RefreshCache(ctx, logger);

				//UnitOfMeasure.RefreshCache(ctx, logger);
				//Item.RefreshCache(ctx, logger);
				//BasicLabor.RefreshCache(ctx, logger);
				//OptionalLabor.RefreshCache(ctx, logger);
				//Program.RefreshCache(ctx, logger);
				//MaterialStatus.RefreshCache(ctx, logger);
				//JobStatus.RefreshCache(ctx, logger);
				//Market.RefreshCache(ctx, logger);
				//User.RefreshCache(ctx, logger);
				//NoteType.RefreshCache(ctx, logger);
				//UserTaskType.RefreshCache(ctx, logger);
				//Division.RefreshCache(ctx, logger);
				//JobType.RefreshCache(ctx, logger);
				//ok = true;
			}
			catch (Exception e)
			{
				logger.LogDebug(e, "Refresh");
			}
			return ok;
		}
	}

	public partial class DiscrepancySubType
	{
		public sealed class CacheIndexer
		{
			public DiscrepancySubType this[int? index]
			{
				get
				{
					DiscrepancySubType sw = null;
					if (index != null)
					{
						lock (_cache)
						{
							if (_cache.ContainsKey(index.Value))
							{
								sw = _cache[index.Value];
							}
						}
					}
					return sw;
				}
			}

			public List<DiscrepancySubType> Values
			{
				get
				{
					List<DiscrepancySubType> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, DiscrepancySubType> _cache { get; set; }
		static public void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, DiscrepancySubType>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (DiscrepancySubType u in ctx.DiscrepancySubTypes.AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}
	}

	public partial class DiscrepancyType
	{
		public sealed class CacheIndexer
		{
			public DiscrepancyType this[int? index]
			{
				get
				{
					DiscrepancyType sw = null;
					if (index != null)
					{
						lock (_cache)
						{
							if (_cache.ContainsKey(index.Value))
							{
								sw = _cache[index.Value];
							}
						}
					}
					return sw;
				}
			}

			public List<DiscrepancyType> Values
			{
				get
				{
					List<DiscrepancyType> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, DiscrepancyType> _cache { get; set; }
		static public void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, DiscrepancyType>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (DiscrepancyType u in ctx.DiscrepancyTypes.AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}
	}

	//public partial class Discrepancy
	//{
	//	public DiscrepancySubType DiscrepancySubType { get { return DiscrepancySubType.Cache[this.DiscrepancySubTypeId]; } }
	//	public virtual DiscrepancyType DiscrepancyType { get { return DiscrepancyType.Cache[this.DiscrepancyTypeId]; } }
	//}

	public partial class SpokeWith
	{
		public sealed class CacheIndexer
		{
			public bool ContainsKey(int index)
			{
				bool sw = false;
				lock (_cache)
				{
					sw = _cache.ContainsKey(index);
				}
				return sw;
			}

			public SpokeWith this[int index]
			{
				get
				{
					SpokeWith sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<SpokeWith> Values
			{
				get
				{
					List<SpokeWith> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, SpokeWith> _cache { get; set; }
		static public void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, SpokeWith>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (SpokeWith u in ctx.SpokeWiths.AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}
	}

	public partial class Department
	{
		public sealed class CacheIndexer
		{
			public Department this[int index]
			{
				get
				{
					Department sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<Department> Values
			{
				get
				{
					List<Department> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, Department> _cache { get; set; }
		static public void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, Department>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (Department u in ctx.Departments.AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}
	}

	public partial class ContactTitle
	{
		public sealed class CacheIndexer
		{
			public ContactTitle this[int index]
			{
				get
				{
					ContactTitle sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<ContactTitle> Values
			{
				get
				{
					List<ContactTitle> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, ContactTitle> _cache { get; set; }
		static public void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, ContactTitle>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (ContactTitle u in ctx.ContactTitles.AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}
	}

	public partial class ReportType
	{
		public sealed class CacheIndexer
		{
			public ReportType this[int index]
			{
				get
				{
					ReportType sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<ReportType> Values
			{
				get
				{
					List<ReportType> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, ReportType> _cache { get; set; }
		static public void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, ReportType>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (ReportType u in ctx.ReportTypes.AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}
	}

	public partial class ClientType
	{
		public sealed class CacheIndexer
		{
			public ClientType this[int index]
			{
				get
				{
					ClientType sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<ClientType> Values
			{
				get
				{
					List<ClientType> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, ClientType> _cache { get; set; }
		static public void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, ClientType>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (ClientType u in ctx.ClientTypes.AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}
	}

	public partial class ClientContact
	{
		public sealed class CacheIndexer
		{
			public List<ClientContact> Values
			{
				get
				{
					List<ClientContact> l;
					lock (_cache)
					{
						l = _cache.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static public List<ClientContact> _cache { get; set; }
		static public void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new List<ClientContact>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (ClientContact u in ctx.ClientContacts.AsNoTracking())
				{
					_cache.Add(u);
				}
			}
		}

	}

	public partial class Client
	{
		public sealed class CacheIndexer
		{
			public Client this[int index]
			{
				get
				{
					Client sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<Client> Values
			{
				get
				{
					List<Client> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, Client> _cache { get; set; }
		static public void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, Client>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (Client u in ctx.Clients.Include(c => c.StoreContacts).AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}

		// public Branch Branch { get { return Domain.Branch.Cache[this.BranchId]; } }
		public ClientType ClientType { get { return ClientType.Cache[this.StoreTypeId]; } }
		//        public List<CFI.DB.Entities.ClientContact> Contacts { get { return CFI.DB.Entities.ClientContact.Cache.Where(c => c.ClientID == this.ID).ToList(); } }

		static public Client FindStore(string storeNum)
		{
			return Cache.Values.Where(s => s.StoreNumber == storeNum).FirstOrDefault();
		}
	}

	partial class User
	{
		public sealed class CacheIndexer
		{
			public User this[int index]
			{
				get
				{
					User sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<User> Values
			{
				get
				{
					List<User> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, User> _cache = null;
		static public void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, User>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (User ms in ctx.Users.AsNoTracking())
				{
					_cache.Add(ms.Id, ms);
				}
			}
		}
	}

	//partial class ProgramBranchMapping
	//{
	//	public Market Branch
	//	{
	//		get
	//		{
	//			return Market.Cache[BranchID];
	//		}
	//	}
	//}

	//partial class Material
	//{
	//	public CFI.DB.Entities.UnitOfMeasure UnitOfMeasure
	//	{
	//		get
	//		{
	//			return CFI.DB.Entities.UnitOfMeasure.Cache[this.UnitOfMeasureID];
	//		}
	//	}
	//}
	//partial class OrderRegMerchandiseDetail
	//{
	//	public MaterialStatus MaterialStatus
	//	{
	//		get { return MaterialStatus.Cache[this.StatusID ?? 0]; }
	//		set { this.StatusID = value.MatStatusID; }
	//	}

	//}
	//partial class OrderSOMerchandiseDetail
	//{
	//	public MaterialStatus MaterialStatus
	//	{
	//		get { return MaterialStatus.Cache[this.MaterialStatusID ?? 0]; }
	//		set { this.MaterialStatusID = value.MatStatusID; }
	//	}

	//}

	partial class Division
	{
		public sealed class CacheIndexer
		{
			public Division this[int index]
			{
				get
				{
					Division sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<Division> Values
			{
				get
				{
					List<Division> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, Division> _cache { get; set; }
		static internal void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, Division>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (Division ms in ctx.Divisions.Include(dg => dg.DivisionGroup).AsNoTracking())
				{
					_cache.Add(ms.Id, ms);
				}
			}
		}
	}

	////-------------------------------------------------------------------------------------------
	partial class UserTaskType
	{
		public sealed class CacheIndexer
		{
			public UserTaskType this[int index]
			{
				get
				{
					UserTaskType sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<UserTaskType> Values
			{
				get
				{
					List<UserTaskType> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, UserTaskType> _cache { get; set; }
		static internal void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, UserTaskType>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (UserTaskType ms in ctx.UserTaskTypes.AsNoTracking())
				{
					_cache.Add(ms.Id, ms);
				}
			}
		}

	}

	partial class NoteType
	{
		public sealed class CacheIndexer
		{
			public NoteType this[int index]
			{
				get
				{
					NoteType sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<NoteType> Values
			{
				get
				{
					List<NoteType> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, NoteType> _cache { get; set; }
		static internal void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, NoteType>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (NoteType ms in ctx.NoteTypes.AsNoTracking())
				{
					_cache.Add(ms.Id, ms);
				}
			}
		}
	}

	partial class JobType
	{
		public sealed class CacheIndexer
		{
			public JobType this[int index]
			{
				get
				{
					JobType sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<JobType> Values
			{
				get
				{
					List<JobType> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, JobType> _cache { get; set; }
		static internal void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, JobType>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (JobType ms in ctx.JobTypes.AsNoTracking())
				{
					_cache.Add(ms.Id, ms);
				}
			}
		}
	}

	partial class MaterialStatus
	{
		public sealed class CacheIndexer
		{
			public MaterialStatus this[int index]
			{
				get
				{
					MaterialStatus sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<MaterialStatus> Values
			{
				get
				{
					List<MaterialStatus> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, MaterialStatus> _cache { get; set; }
		static internal void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, MaterialStatus>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (MaterialStatus ms in ctx.MaterialStatus.AsNoTracking())
				{
					_cache.Add(ms.Id, ms);
				}
			}
		}

		public override string ToString()
		{
			return this.Status;
		}
	}

	partial class Branch
	{
		public sealed class CacheIndexer
		{
			public Branch this[int index]
			{
				get
				{
					Branch sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<Branch> Values
			{
				get
				{
					List<Branch> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, Branch> _cache { get; set; }
		static public void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, Branch>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (Branch u in ctx.Branches.AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}
	}

	partial class JobStatus
	{
		public sealed class CacheIndexer
		{
			public JobStatus this[int index]
			{
				get
				{
					JobStatus sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<JobStatus> Values
			{
				get
				{
					List<JobStatus> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, JobStatus> _cache { get; set; }
		static internal void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, JobStatus>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (JobStatus u in ctx.JobStatus.AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}
	}

	public partial class Program
	{
		public sealed class CacheIndexer
		{
			public Program this[int index]
			{
				get
				{
					Program sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<Program> Values
			{
				get
				{
					List<Program> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, Program> _cache { get; set; }
		static public void RefreshCache(IIMContext ctx, ILogger logger)
		{
			try
			{
				if (_cache == null)
				{
					_cache = new Dictionary<int, Program>();
				}
				lock (_cache)
				{
					_cache.Clear();
					foreach (Program u in ctx.Programs
						.Include(p => p.ProgramBranchMappings)
						.Include(p => p.BasicLabor.Select(i => i.MaterialBasicLaborMappings.Select(mp => mp.Material.MaterialCost)))
						.Include(p => p.BasicLabor.Select(i => i.Costs))
						.Include(p => p.BasicLabor.Select(i => i.Prices))
						.Include(p => p.BasicLabor.Select(i => i.Retails))
						.Include(p => p.Options.Select(i => i.MaterialOptionsMappings.Select(mp => mp.Material.MaterialCost)))
						.Include(p => p.Options.Select(i => i.Costs))
						.Include(p => p.Options.Select(i => i.Prices))
						.Include(p => p.Options.Select(i => i.Retails))
						//						.AsNoTracking()
						)
					{
						_cache.Add(u.Id, u);
					}
				}
			}
			catch (Exception e)
			{
				logger.LogCritical(e, "RefreshCache");
			}
		}

		//public Division Division
		//{
		//	get { return Division.Cache[this.DivisionId ?? 0]; }
		//}

		//public JobType JobType
		//{
		//	get { return JobType.Cache[this.JobTypeId ?? 0]; }
		//}

		public ClientType ClientType
		{
			get { return ClientType.Cache[this.StoreTypeId ?? 0]; }
		}
	}

	public partial class UnitOfMeasure
	{
		public sealed class CacheIndexer
		{
			public UnitOfMeasure this[int index]
			{
				get
				{
					UnitOfMeasure sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<UnitOfMeasure> Values
			{
				get
				{
					List<UnitOfMeasure> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, UnitOfMeasure> _cache { get; set; }
		static internal void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, UnitOfMeasure>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (UnitOfMeasure u in ctx.UnitOfMeasures.AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}

	}

	//public partial class Order
	//{
	//	public CFI.DB.Entities.Program Program { get { return CFI.DB.Entities.Program.Cache[this.ProgramID]; } }
	//	public CFI.DB.Entities.Client Client { get { return CFI.DB.Entities.Client.Cache[this.StoreID]; } }
	//}

	#region Item
	public partial class Item
	{
		public sealed class CacheIndexer
		{
			public Item this[int index]
			{
				get
				{
					Item sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<Item> Values
			{
				get
				{
					List<Item> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		static private Dictionary<int, Item> _cache { get; set; }
		static internal void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, Item>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (Item u in ctx.Items
					.Include(i => i.Costs)
					.Include(i => i.Prices)
					.Include(i => i.MaterialItemMappings).ThenInclude(mc => mc.Material.MaterialCost)
					.AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}


//		public IMCore.Domain.UnitOfMeasure UnitOfMeasure { get { return IMCore.Domain.UnitOfMeasure.Cache[this.UnitOfMeasureId.Value]; } }
	}

	#endregion

	#region Basic
	public partial class BasicLabor
	{
		public sealed class CacheIndexer
		{
			public BasicLabor this[int index]
			{
				get
				{
					BasicLabor sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<BasicLabor> Values
			{
				get
				{
					List<BasicLabor> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		private static Dictionary<int, BasicLabor> _cache { get; set; }
		static internal void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, BasicLabor>();
			}
			lock (_cache)
			{
				_cache.Clear();
				foreach (BasicLabor u in ctx.BasicLabors
								  .Include(i => i.MaterialBasicLaborMappings)
								  .Include(i => i.Costs)
								  .Include(i => i.Prices)
								  .Include(i => i.Retails)
//								  .Include(i => i.Materials.Select(m => m.Costs))
								  .AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}

//		public IMCore.Domain.UnitOfMeasure UnitOfMeasure { get { return IMCore.Domain.UnitOfMeasure.Cache[this.UnitOfMeasureId.Value]; } }
	}
	#endregion

	#region Option
	public partial class Option
	{
		public sealed class CacheIndexer
		{
			public Option this[int index]
			{
				get
				{
					Option sw = null;
					lock (_cache)
					{
						if (_cache.ContainsKey(index))
						{
							sw = _cache[index];
						}
					}
					return sw;
				}
			}

			public List<Option> Values
			{
				get
				{
					List<Option> l;
					lock (_cache)
					{
						l = _cache.Values.ToList();
					}
					return l;
				}
			}
		}

		private static CacheIndexer Indexer;

		public static CacheIndexer Cache
		{
			get { return Indexer ?? (Indexer = new CacheIndexer()); }
		}

		private static Dictionary<int, Option> _cache { get; set; }
		static internal void RefreshCache(IIMContext ctx, ILogger logger)
		{
			if (_cache == null)
			{
				_cache = new Dictionary<int, Option>();
			}
			lock (_cache)
			{
				_cache.Clear();

				foreach (Option u in ctx.OptionalLabor
								  .Include(i => i.MaterialOptionsMappings)
								  .Include(i => i.Costs)
								  .Include(i => i.Prices)
								  .Include(i => i.Retails)
//								  .Include(i => i.Materials.Select(m => m.Costs))
								  .AsNoTracking())
				{
					_cache.Add(u.Id, u);
				}
			}
		}

//		public IMCore.Domain.UnitOfMeasure UnitOfMeasure { get { return IMCore.Domain.UnitOfMeasure.Cache[this.UnitOfMeasureId.Value]; } }

		//public Item Item
		//{
		//	get
		//	{
		//		Item i = null;
		//		{
		//			if (this.ItemId != null)
		//			{
		//				i = Item.Cache[this.ItemId.Value];
		//			}
		//			return i;
		//		}

		//	}
		//}
	}
	#endregion



}
