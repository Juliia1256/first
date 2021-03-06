﻿using System.Collections.Generic;
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
        void Update(City city);
        IEnumerable<City> FindAll();
        City FindById(Guid id);
        City FindByTitle(string title);

    }
}
