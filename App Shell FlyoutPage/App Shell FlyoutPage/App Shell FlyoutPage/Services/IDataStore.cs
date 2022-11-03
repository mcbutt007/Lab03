using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App_Shell_FlyoutPage.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
    public interface ILaptopDataStore<T>
    {
        Task<bool> AddLaptopAsync(T laptop);
        Task<bool> UpdateLaptopAsync(T laptop);
        Task<bool> DeleteLaptopAsync(string id);
        Task<T> GetLaptopAsync(string id);
        Task<IEnumerable<T>> GetLaptopsAsync(bool forceRefresh = false);
    }
    public interface ISmartphoneDataStore<T>
    {
        Task<bool> AddSmartphoneAsync(T smartphone);
        Task<bool> UpdateSmartphoneAsync(T smartphone);
        Task<bool> DeleteSmartphoneAsync(string id);
        Task<T> GetSmartphoneAsync(string id);
        Task<IEnumerable<T>> GetSmartphonesAsync(bool forceRefresh = false);
    }
    public interface IAccessoryDataStore<T>
    {
        Task<bool> AddAccessoryAsync(T accessory);
        Task<bool> UpdateAccessoryAsync(T accessory);
        Task<bool> DeleteAccessoryAsync(string id);
        Task<T> GetAccessoryAsync(string id);
        Task<IEnumerable<T>> GetAccessoriesAsync(bool forceRefresh = false);
    }
}
