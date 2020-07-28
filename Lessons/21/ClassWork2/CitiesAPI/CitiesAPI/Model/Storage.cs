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
            new City(Guid.NewGuid(),"Moscow", "The capital of Russia", 16_000_000),
            new City(Guid.NewGuid(),"Saint Petersburg", "The culture center of Russia", 6_000_000),
            new City(Guid.NewGuid(),"Saratov","Throughout history had one name",838000),
            new City(Guid.NewGuid(),"Ryazan'", "Contains pies with eyes", 500000)
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

        public void Update(City city)
        {
           var item= Items.FirstOrDefault(item => item.Id == city.Id);

            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            item = city;
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
