using System.Collections.Generic;
using CitiesAPI.ViewModels;
using CitiesAPI.Model;
using CitiesAPI.Controllers;
using System;
using System.Linq;
using System.Collections;

namespace CitiesAPI.Model
{
    public class Storage : IStorage
    {
        private static Storage _instance;

        public Storage() { }

        public List<City> Items { get; } = new List<City>
        {
            new City("Moscow", "The capital of Russia", 16_000_000),
            new City("Saint Petersburg", "The culture center of Russia", 6_000_000),
            new City("Saratov","Throughout history had one name",838000),
            new City("Ryazan'", "Contains pies with eyes", 500000)
        };

        public void Create(City city)
        {
            Items.Add(city);
        }

        public void Delete(Guid id)
        {
            var item = Items.FirstOrDefault(_ => _.Id == id);

            Items.Remove(item);
        }

        public void Update(int population, string description, Guid id)
        {
            FindById(id)
                .Population = population;

            FindById(id)
                .Description = description
                .Capitalize()
                .Trim();
        }
        public IEnumerable<City> FindAll()
        {
            return Items
                .OrderByDescending(city => city.Population)
                .ThenBy(city => city.Title);

            //TakeWhile(city => city.Title.StartsWith(firstLetter))
        }

        public City FindById(Guid id)
        {

            return Items
                .FirstOrDefault(_ => _.Id == id);
        }

        public City FindByTitle(string title)
        {
            return Items
                .FirstOrDefault(
                item => string.Equals(item.Title, title, StringComparison.OrdinalIgnoreCase));
        }


    }
}
