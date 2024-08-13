using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product.Models
{
    [Table("Employee_Tbl")]
    public class Employee
    {
        [Key]
        [Column("EmployeeCode")]
        public string EmployeeCode { get; set; }

        [Required]
        [Column("EmployeeName")]
        public string EmployeeName { get; set; }

        [Required]
        [ForeignKey("Department")]
        [Column("DepartmentCode")]
        public string DepartmentCode { get; set; }

        [Column("Rank")]
        public string Rank { get; set; }

        // Navigation property
        public Department Department { get; set; }
    }
}
