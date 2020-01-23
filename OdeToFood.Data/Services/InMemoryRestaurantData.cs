﻿using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Prems", Cuisine = CuisineType.Indian},
                new Restaurant { Id = 2, Name = "LaRosa's", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 3, Name = "Chaat Cafe", Cuisine = CuisineType.Indian },
                new Restaurant { Id = 4, Name = "Chili's", Cuisine = CuisineType.American},
                new Restaurant { Id = 5, Name = "BW2s", Cuisine = CuisineType.American }
            };

        }
        public void Add(Restaurant r)
        {
            restaurants.Add(r);
            r.Id = restaurants.Max(resto => resto.Id) + 1;
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
