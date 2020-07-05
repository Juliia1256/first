using System;
using System.ComponentModel.DataAnnotations;
using CitiesAPI.ViewModels;
using CitiesAPI.Model;
using CitiesAPI.Controllers;

namespace CitiesAPI.ViewModels
{
    public class CreateCityViewModel
    {
        [Required(ErrorMessage = "Название города не заполнено")]  //валидация атрибутами
        [MaxLength(255)]
        public string Title { get; set; }
        [Required]
        [MaxLength(4095)]
        public string Description { get; set; }
        [Range(1, 100_000_000)]
        public int Population { get; set; }
    }
}
