using System.ComponentModel.DataAnnotations;
using Data.Enumeration;
using Microsoft.AspNetCore.Mvc;
using Web.Attributes;

namespace Web.Models.Cars
{
    public class CarsEditViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

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
