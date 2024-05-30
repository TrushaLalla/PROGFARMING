using System.ComponentModel.DataAnnotations;

namespace progpoe.Models
{
    public class Farmer
    {
        [Key]
        public int Id { get; set; }
       
        public required string FarmerEmail { get; set; }

        public required string FarmerPassword { get; set; }

    }
}
