using System.ComponentModel.DataAnnotations;

namespace progpoe.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public required string EmployeeEmail { get; set; }
        public required string EmployeePassword { get; set; }
        
    }
}
