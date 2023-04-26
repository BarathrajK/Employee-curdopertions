using System.ComponentModel.DataAnnotations;

namespace curdProject.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? EmployeeFirstName { get; set; }
        public string? EmployeeLastName { get; set; }
        public string? EmployeeEmailId { get; set; }
        public DateTime? EmployeeDob { get; set; }
        public string? EmployeeSalary { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public string? EmployeePhoneNO { get; set; }

    }
}
