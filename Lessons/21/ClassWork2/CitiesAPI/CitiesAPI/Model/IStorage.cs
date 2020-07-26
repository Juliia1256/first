using System.Collections.Generic;
using System;
using CitiesAPI.ViewModels;
using CitiesAPI.Model;
using CitiesAPI.Controllers;

namespace CitiesAPI.Model
{
    public interface IStorage
    {
        void Create(City city);
        void Delete(Guid id);
        void Update(int population, string description, Guid id);
        IEnumerable<City> FindAll();
        City FindById(Guid id);
        City FindByTitle(string title);

    }
}
