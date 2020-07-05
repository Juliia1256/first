using System;
using CitiesAPI.ViewModels;
using CitiesAPI.Model;
using CitiesAPI.Controllers;

namespace CitiesAPI.Model
{
    public class City
    {

        public City(string title, string description, int population)
        {
            Id = Guid.NewGuid();
            Title = title.Capitalize();
            Description = description;
            Population = population;

        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Population { get; set; }
        public Guid Id { get; set; }


    }
}
