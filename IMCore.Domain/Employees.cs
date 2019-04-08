using IMCore.TypesAndInterfaces.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("Employees")]
	public partial class User
    {
        public User()
        {
            ActivityListClosedBy = new HashSet<Activity>();
            ActivityListCreatedBy = new HashSet<Activity>();
            Discrepancies = new HashSet<Discrepancy>();
            JobsAssignedTo = new HashSet<Jobs>();
            JobsCreatedBy = new HashSet<Jobs>();
            Market = new HashSet<Market>();
            OrderBasicLaborDetails = new HashSet<OrderBasicLaborDetail>();
            OrderCustomDetails = new HashSet<OrderCustomDetail>();
            OrderOptionsDetails = new HashSet<OrderOptionalLaborDetail>();
            OrderRegMerchandiseDetails = new HashSet<OrderRegMerchandiseDetail>();
            OrderSomerchandiseDetails = new HashSet<OrderSOMerchandiseDetail>();
            OrdersAssignedTo = new HashSet<Order>();
            OrdersEnteredBy = new HashSet<Order>();
            OrdersReviewedBy = new HashSet<Order>();
            OrdersSalesPerson = new HashSet<Order>();
            Ponotes = new HashSet<PONote>();
            StoresAccountCoor = new HashSet<Client>();
            StoresAccountRep = new HashSet<Client>();
            UserMarketDivisionAssignments = new HashSet<UserMarketDivisionAssignments>();
            UserPermissions = new HashSet<UserPermissions>();
            UserTasksAddedBy = new HashSet<UserTask>();
            UserTasksAssignedTo = new HashSet<UserTask>();
            UserTasksCompletedBy = new HashSet<UserTask>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [StringLength(30)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string NickName { get; set; }
        [StringLength(255)]
        public string Address1 { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(10)]
        public string Zip { get; set; }
        [StringLength(30)]
        public string HomeNumber { get; set; }
        [StringLength(30)]
        public string MobileNumber { get; set; }
        [StringLength(30)]
        public string PagerNumber { get; set; }
        [Column("SSN")]
        [StringLength(11)]
        public string Ssn { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? HireDate { get; set; }
        public bool ReceiveCallNotes { get; set; }
        [Column("SMTPEmail")]
        [StringLength(50)]
        public string Smtpemail { get; set; }
        [StringLength(30)]
        public string UserName { get; set; }
        [Required]
        public bool? Active { get; set; }

        [InverseProperty("Employee")]
        public virtual Admin Admins { get; set; }
        [InverseProperty("ClosedBy")]
        public virtual ICollection<Activity> ActivityListClosedBy { get; set; }
        [InverseProperty("CreatedBy")]
        public virtual ICollection<Activity> ActivityListCreatedBy { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<Discrepancy> Discrepancies { get; set; }
        [InverseProperty("AssignedTo")]
        public virtual ICollection<Jobs> JobsAssignedTo { get; set; }
        [InverseProperty("CreatedBy")]
        public virtual ICollection<Jobs> JobsCreatedBy { get; set; }
        [InverseProperty("Manager")]
        public virtual ICollection<Market> Market { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<OrderBasicLaborDetail> OrderBasicLaborDetails { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<OrderCustomDetail> OrderCustomDetails { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<OrderOptionalLaborDetail> OrderOptionsDetails { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<OrderRegMerchandiseDetail> OrderRegMerchandiseDetails { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<OrderSOMerchandiseDetail> OrderSomerchandiseDetails { get; set; }
        [InverseProperty("AssignedTo")]
        public virtual ICollection<Order> OrdersAssignedTo { get; set; }
        [InverseProperty("EnteredBy")]
        public virtual ICollection<Order> OrdersEnteredBy { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<Order> OrdersReviewedBy { get; set; }
        [InverseProperty("SalesPerson")]
        public virtual ICollection<Order> OrdersSalesPerson { get; set; }
        [InverseProperty("EnteredByUser")]
        public virtual ICollection<PONote> Ponotes { get; set; }
        [InverseProperty("AccountCoor")]
        public virtual ICollection<Client> StoresAccountCoor { get; set; }
        [InverseProperty("AccountRep")]
        public virtual ICollection<Client> StoresAccountRep { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserMarketDivisionAssignments> UserMarketDivisionAssignments { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
        [InverseProperty("AddedBy")]
        public virtual ICollection<UserTask> UserTasksAddedBy { get; set; }
        [InverseProperty("AssignedTo")]
        public virtual ICollection<UserTask> UserTasksAssignedTo { get; set; }
        [InverseProperty("CompletedBy")]
        public virtual ICollection<UserTask> UserTasksCompletedBy { get; set; }

		[NotMapped]
		public string LastNameCommaFirstName
		{
			get
			{
				return LastName.SafeTrim() + ", " + FirstName.SafeTrim();
			}
		}

		[NotMapped]
		public string FirstNameSpaceLastName
		{
			get
			{
				return FirstName.SafeTrim() + " " + LastName.SafeTrim();
			}
		}

	}
}
