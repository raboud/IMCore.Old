using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Employees
    {
        public Employees()
        {
            ActivityListClosedBy = new HashSet<ActivityList>();
            ActivityListCreatedBy = new HashSet<ActivityList>();
            Discrepancies = new HashSet<Discrepancies>();
            JobsAssignedTo = new HashSet<Jobs>();
            JobsCreatedBy = new HashSet<Jobs>();
            Market = new HashSet<Market>();
            OrderBasicLaborDetails = new HashSet<OrderBasicLaborDetails>();
            OrderCustomDetails = new HashSet<OrderCustomDetails>();
            OrderOptionsDetails = new HashSet<OrderOptionsDetails>();
            OrderRegMerchandiseDetails = new HashSet<OrderRegMerchandiseDetails>();
            OrderSomerchandiseDetails = new HashSet<OrderSomerchandiseDetails>();
            OrdersAssignedTo = new HashSet<Orders>();
            OrdersEnteredBy = new HashSet<Orders>();
            OrdersReviewedBy = new HashSet<Orders>();
            OrdersSalesPerson = new HashSet<Orders>();
            Ponotes = new HashSet<Ponotes>();
            StoresAccountCoor = new HashSet<Stores>();
            StoresAccountRep = new HashSet<Stores>();
            UserMarketDivisionAssignments = new HashSet<UserMarketDivisionAssignments>();
            UserPermissions = new HashSet<UserPermissions>();
            UserTasksAddedBy = new HashSet<UserTasks>();
            UserTasksAssignedTo = new HashSet<UserTasks>();
            UserTasksCompletedBy = new HashSet<UserTasks>();
        }

        [Column("ID")]
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
        public virtual Admins Admins { get; set; }
        [InverseProperty("ClosedBy")]
        public virtual ICollection<ActivityList> ActivityListClosedBy { get; set; }
        [InverseProperty("CreatedBy")]
        public virtual ICollection<ActivityList> ActivityListCreatedBy { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<Discrepancies> Discrepancies { get; set; }
        [InverseProperty("AssignedTo")]
        public virtual ICollection<Jobs> JobsAssignedTo { get; set; }
        [InverseProperty("CreatedBy")]
        public virtual ICollection<Jobs> JobsCreatedBy { get; set; }
        [InverseProperty("Manager")]
        public virtual ICollection<Market> Market { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<OrderBasicLaborDetails> OrderBasicLaborDetails { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<OrderCustomDetails> OrderCustomDetails { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<OrderOptionsDetails> OrderOptionsDetails { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<OrderRegMerchandiseDetails> OrderRegMerchandiseDetails { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<OrderSomerchandiseDetails> OrderSomerchandiseDetails { get; set; }
        [InverseProperty("AssignedTo")]
        public virtual ICollection<Orders> OrdersAssignedTo { get; set; }
        [InverseProperty("EnteredBy")]
        public virtual ICollection<Orders> OrdersEnteredBy { get; set; }
        [InverseProperty("ReviewedBy")]
        public virtual ICollection<Orders> OrdersReviewedBy { get; set; }
        [InverseProperty("SalesPerson")]
        public virtual ICollection<Orders> OrdersSalesPerson { get; set; }
        [InverseProperty("EnteredByUser")]
        public virtual ICollection<Ponotes> Ponotes { get; set; }
        [InverseProperty("AccountCoor")]
        public virtual ICollection<Stores> StoresAccountCoor { get; set; }
        [InverseProperty("AccountRep")]
        public virtual ICollection<Stores> StoresAccountRep { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserMarketDivisionAssignments> UserMarketDivisionAssignments { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
        [InverseProperty("AddedBy")]
        public virtual ICollection<UserTasks> UserTasksAddedBy { get; set; }
        [InverseProperty("AssignedTo")]
        public virtual ICollection<UserTasks> UserTasksAssignedTo { get; set; }
        [InverseProperty("CompletedBy")]
        public virtual ICollection<UserTasks> UserTasksCompletedBy { get; set; }
    }
}
