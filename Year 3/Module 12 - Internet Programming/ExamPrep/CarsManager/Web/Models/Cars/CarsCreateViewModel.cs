using System.ComponentModel.DataAnnotations;
using Data.Enumeration;
using Web.Attributes;

namespace Web.Models.Cars
{
    public class CarsCreateViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Brand name should be at most 50 characters")]
        public string Brand { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Model should be at most 50 characters")]
        public string Model { get; set; }

        [Required]
        [CarYear]
        public int Year { get; set; }

        [Required]
        public EngineEnum Engine { get; set; }
    }
}
