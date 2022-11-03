using Picker.Models;
using Picker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picker.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
    public class CountryDataStore : ICountryDataStore<Country>
    {
        readonly List<Country> countries;


        public CountryDataStore()
        {
            countries = new List<Country>()
            {
                new Country { CountryId = "1", CountryName = "Việt Nam", CountryImage="https://dynamic-media-cdn.tripadvisor.com/media/photo-o/15/a3/2a/f2/big-hand-ang-golden-bridge.jpg?w=600&h=400&s=1" },
                new Country { CountryId = "2", CountryName = "Đức", CountryImage="https://cdn.britannica.com/49/179449-138-9F4EC401/Overview-Berlin.jpg?w=800&h=450&c=crop" },
                new Country { CountryId = "3", CountryName = "Bồ Đào Nha", CountryImage="https://cdn.internationalliving.com/wp-content/uploads/2020/01/Portugal-Feature.jpg" },
            };
        }

        public async Task<bool> AddCountryAsync(Country country)
        {
            countries.Add(country);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateCountryAsync(Country country)
        {
            var oldCountry = countries.Where((Country arg) => arg.CountryId == country.CountryId).FirstOrDefault();
            countries.Remove(oldCountry);
            countries.Add(country);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteCountryAsync(string id)
        {
            var oldCountry = countries.Where((Country arg) => arg.CountryId == id).FirstOrDefault();
            countries.Remove(oldCountry);

            return await Task.FromResult(true);
        }

        public async Task<Country> GetCountryAsync(string id)
        {
            return await Task.FromResult(countries.FirstOrDefault(s => s.CountryId == id));
        }

        public async Task<IEnumerable<Country>> GetCountriesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(countries);
        }
    }
    public class CityDataStore : ICityDataStore<City>
    {
        readonly List<City> cities;

        public CityDataStore()
        {
            cities = new List<City>()
            {
                new City { CityId = Guid.NewGuid().ToString(), CityName = "Ha Noi", CityImage="https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/33/f7/12/caption.jpg?w=700&h=-1&s=1", CountryID="1"},
                new City { CityId = Guid.NewGuid().ToString(), CityName = "Ho Chi Minh", CityImage="https://img.traveltriangle.com/blog/wp-content/uploads/2019/01/Cover-for-Things-To-Do-In-Ho-Chi-Minh.jpg", CountryID="1"},
                new City { CityId = Guid.NewGuid().ToString(), CityName = "Munich", CityImage="https://www.munich.travel/var/ger_muc/storage/images/_aliases/teaser_medium/4/4/1/1/2181144-1-ger-DE/marienplatz-D-2687s-v1-foto-redline.jpg", CountryID="2"},
                new City { CityId = Guid.NewGuid().ToString(), CityName = "Berlin", CityImage="https://cdn.britannica.com/39/6839-050-27891400/Brandenburg-Gate-Berlin.jpg", CountryID="2"},
                new City { CityId = Guid.NewGuid().ToString(), CityName = "Lisbon", CityImage="https://cdn.britannica.com/88/124588-050-3E59FF15/Lisbon.jpg", CountryID="3"},
                new City { CityId = Guid.NewGuid().ToString(), CityName = "Porto", CityImage="https://static.independent.co.uk/s3fs-public/thumbnails/image/2017/06/26/18/porto-main.jpg?quality=75&width=982&height=726&auto=webp", CountryID="3"},
            };
        }

        public async Task<bool> AddCityAsync(City city)
        {
            cities.Add(city);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateCityAsync(City city)
        {
            var oldCity = cities.Where((City arg) => arg.CityId == city.CityId).FirstOrDefault();
            cities.Remove(oldCity);
            cities.Add(city);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteCityAsync(string id)
        {
            var oldCity = cities.Where((City arg) => arg.CityId == id).FirstOrDefault();
            cities.Remove(oldCity);

            return await Task.FromResult(true);
        }

        public async Task<City> GetCityAsync(string id)
        { 
            return await Task.FromResult(cities.FirstOrDefault(s => s.CityId == id));
        }

        public async Task<IEnumerable<City>> GetCitiesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(cities);
        }
    }
}
