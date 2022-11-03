using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Picker.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
    public interface ICountryDataStore<T>
    {
        Task<bool> AddCountryAsync(T country);
        Task<bool> UpdateCountryAsync(T country);
        Task<bool> DeleteCountryAsync(string id);
        Task<T> GetCountryAsync(string id);
        Task<IEnumerable<T>> GetCountriesAsync(bool forceRefresh = false);
    }
    public interface ICityDataStore<T>
    {
        Task<bool> AddCityAsync(T city);
        Task<bool> UpdateCityAsync(T city);
        Task<bool> DeleteCityAsync(string id);
        Task<T> GetCityAsync(string id);
        Task<IEnumerable<T>> GetCitiesAsync(bool forceRefresh = false);
    }
}
