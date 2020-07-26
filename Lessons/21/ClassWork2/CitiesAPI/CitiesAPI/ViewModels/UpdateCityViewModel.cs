using System;
using System.ComponentModel.DataAnnotations;
using CitiesAPI.ViewModels;
using CitiesAPI.Model;
using CitiesAPI.Controllers;

namespace CitiesAPI.ViewModels
{
    public class UpdateCityViewModel
    {
        public UpdateCityViewModel()
        {
        }

        [Required]
        [MaxLength(4095)]
        public string Description { get; set; }

        [Range(1, 100_000_000)]
        public int Population { get; set; }
    }
}
