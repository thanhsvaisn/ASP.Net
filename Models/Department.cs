using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product.Models
{
    [Table("Department_Tbl")]
    public class Department
    {
        [Key]
        [Column("DepartmentCode")]
        public string DepartmentCode { get; set; }

        [Required]
        [Column("DepartmentName")]
        public string DepartmentName { get; set; }

        [Column("Location")]
        public string Location { get; set; }

        [Column("NumberOfPersonnels")]
        public int NumberOfPersonnels { get; set; }

        [Column("AdditionalFields")]
        public string AdditionalFields { get; set; }

        // Navigation property
        public ICollection<Employee> Employees { get; set; }
    }
}
