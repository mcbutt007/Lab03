using App_Shell_FlyoutPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Shell_FlyoutPage.Services
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
    public class MockSmartphoneDataStore : ISmartphoneDataStore<Smartphone>
    {
        readonly List<Smartphone> smartphones;

        public MockSmartphoneDataStore()
        {
            smartphones = new List<Smartphone>()
            {
                new Smartphone { SmartphoneID = Guid.NewGuid().ToString(), SmartphoneName = "Samsung Galaxy Z Flip4", 
                SmartphoneImage="https://cdn.tgdd.vn/Products/Images/42/258047/samsung-galaxy-z-flip4-230922-100343.jpg",
                SmartphoneRatings="4.0", SmartphonePrice="16.000.000 VND", SmartphoneType="Samsung"},
                new Smartphone { SmartphoneID = Guid.NewGuid().ToString(), SmartphoneName = "Xperia 1 III",
                SmartphoneImage="https://www.sony.com.vn/image/bec37fd1196426136aae242507e874b0",
                SmartphoneRatings="4.9", SmartphonePrice="17.000.000 VND", SmartphoneType="Sony"},
                new Smartphone { SmartphoneID = Guid.NewGuid().ToString(), SmartphoneName = "Samsung Galaxy S22 Ultra",
                SmartphoneImage="https://cdn.tgdd.vn/Products/Images/42/235838/samsung-galaxy-s22-ultra-11-2.jpg",
                SmartphoneRatings="4.0", SmartphonePrice="18.000.000 VND", SmartphoneType="Samsung"},
                new Smartphone { SmartphoneID = Guid.NewGuid().ToString(), SmartphoneName = "Xperia PRO-I",
                SmartphoneImage="https://www.sony.com.vn/image/5d5ecc984b1e4a3628bbce5f3404b10b",
                SmartphoneRatings="4.9", SmartphonePrice="19.000.000 VND", SmartphoneType="Sony"},
                new Smartphone { SmartphoneID = Guid.NewGuid().ToString(), SmartphoneName = "iPhone 13 Pro Max",
                SmartphoneImage="https://cdn2.cellphones.com.vn/358x/media/catalog/product/3/_/3_51_1_7.jpg",
                SmartphoneRatings="4.0", SmartphonePrice="20.000.000 VND", SmartphoneType="Iphone"},
                new Smartphone { SmartphoneID = Guid.NewGuid().ToString(), SmartphoneName = "iPhone 14 Pro",
                SmartphoneImage="https://cdn2.cellphones.com.vn/358x/media/catalog/product/t/_/t_m_12.png",
                SmartphoneRatings="4.9", SmartphonePrice="21.000.000 VND", SmartphoneType="Iphone"},
            };
        }

        public async Task<bool> AddSmartphoneAsync(Smartphone smartphone)
        {
            smartphones.Add(smartphone);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateSmartphoneAsync(Smartphone smartphone)
        {
            var oldSmartphone = smartphones.Where((Smartphone arg) => arg.SmartphoneID == smartphone.SmartphoneID).FirstOrDefault();
            smartphones.Remove(oldSmartphone);
            smartphones.Add(smartphone);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteSmartphoneAsync(string id)
        {
            var oldSmartphone = smartphones.Where((Smartphone arg) => arg.SmartphoneID == id).FirstOrDefault();
            smartphones.Remove(oldSmartphone);

            return await Task.FromResult(true);
        }

        public async Task<Smartphone> GetSmartphoneAsync(string id)
        {
            return await Task.FromResult(smartphones.FirstOrDefault(s => s.SmartphoneID == id));
        }

        public async Task<IEnumerable<Smartphone>> GetSmartphonesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(smartphones);
        }
    }
    public class MockLaptopDataStore : ILaptopDataStore<Laptop>
    {
        readonly List<Laptop> laptops;

        public MockLaptopDataStore()
        {
            laptops = new List<Laptop>()
            {
                new Laptop { LaptopID = Guid.NewGuid().ToString(), LaptopName = "Gaming laptop Asus", 
                LaptopImage="https://cdn2.cellphones.com.vn/358x/media/catalog/product/4/h/4h43.png",
                LaptopPrice="33.000.000 VND", LaptopRatings="1.2", LaptopType="Gaming"},
                new Laptop { LaptopID = Guid.NewGuid().ToString(), LaptopName = "Gaming laptop Lenovo",
                LaptopImage="https://cdn2.cellphones.com.vn/358x/media/catalog/product/t/e/text_ng_n_1__2.png",
                LaptopPrice="23.000.000 VND", LaptopRatings="2.3", LaptopType="Gaming"},
                new Laptop { LaptopID = Guid.NewGuid().ToString(), LaptopName = "Office laptop Huawei",
                LaptopImage="https://ae01.alicdn.com/kf/Hfa859f2f28fb4fad99b5df558ba817003/HUAWEI-Laptop-MateBook-X-Pro-2022-I7-1195G7-I5-1155G7-Hoa-T-n-Xe-H-a.jpg_Q90.jpg",
                LaptopPrice="19.000.000 VND", LaptopRatings="3.4", LaptopType="Office"},
                new Laptop { LaptopID = Guid.NewGuid().ToString(), LaptopName = "Office laptop Dell",
                LaptopImage="https://images.fpt.shop/unsafe/filters:quality(5)/fptshop.com.vn/Uploads/images/2015/Tin-Tuc/QuanLNH2/dell-inspiron-3501-3.jpg",
                LaptopPrice="8.000.000 VND", LaptopRatings="4.5", LaptopType="Office"},
                new Laptop { LaptopID = Guid.NewGuid().ToString(), LaptopName = "Macbook Pro",
                LaptopImage="https://www.cnet.com/a/img/resize/af0b56bbac3ef1c46689f20b88b3a03d988def55/hub/2017/08/14/ec0fa893-faf2-46c3-8933-6898773804ba/apple-macbook-air-2017-05.jpg?auto=webp&width=768",
                LaptopPrice="35.000.000 VND", LaptopRatings="4.3", LaptopType="Macbook"},
                new Laptop { LaptopID = Guid.NewGuid().ToString(), LaptopName = "Macbook Air",
                LaptopImage="https://www.digitaltrends.com/wp-content/uploads/2021/11/macbook-pro-2021-01.jpg?resize=625%2C417&p=1",
                LaptopPrice="42.000.000 VND", LaptopRatings="3.2", LaptopType="Macbook"},
            };
        }

        public async Task<bool> AddLaptopAsync(Laptop laptop)
        {
            laptops.Add(laptop);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateLaptopAsync(Laptop laptop)
        {
            var oldLaptop = laptops.Where((Laptop arg) => arg.LaptopID == laptop.LaptopID).FirstOrDefault();
            laptops.Remove(oldLaptop);
            laptops.Add(laptop);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteLaptopAsync(string id)
        {
            var oldLaptop = laptops.Where((Laptop arg) => arg.LaptopID == id).FirstOrDefault();
            laptops.Remove(oldLaptop);

            return await Task.FromResult(true);
        }

        public async Task<Laptop> GetLaptopAsync(string id)
        {
            return await Task.FromResult(laptops.FirstOrDefault(s => s.LaptopID == id));
        }

        public async Task<IEnumerable<Laptop>> GetLaptopsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(laptops);
        }
    }
    public class MockAccessoryDataStore : IAccessoryDataStore<Accessory>
    {
        readonly List<Accessory> accessories;

        public MockAccessoryDataStore()
        {
            accessories = new List<Accessory>()
            {
                new Accessory { AccessoryID = Guid.NewGuid().ToString(), AccessoryName = "Lenovo TH10", 
                AccessoryImage="https://cf.shopee.vn/file/sg-11134202-22100-hdn6gh202viv8e",
                AccessoryRatings="3.5", AccessoryPrice="2.600.000 VND", AccessoryType="Headphone"},
                new Accessory { AccessoryID = Guid.NewGuid().ToString(), AccessoryName = "SanDisk Cruzer Glide CZ600",
                AccessoryImage="https://bizweb.sapocdn.net/thumb/1024x1024/100/329/122/products/cz600-01-5070df8a-e72a-45f1-91da-33357c56b998-e70ca42c-779c-41ec-b10d-455cc2915a3a.jpg",
                AccessoryRatings="4.5", AccessoryPrice="250.000 VND", AccessoryType="USB"},
                new Accessory { AccessoryID = Guid.NewGuid().ToString(), AccessoryName = "Generic Headphone",
                AccessoryImage="https://lzd-img-global.slatic.net/g/p/acd9e2d35154fdfd7ba2c476be30015e.png_720x720q80.jpg",
                AccessoryRatings="3.5", AccessoryPrice="1.500.000 VND", AccessoryType="Headphone"},
                new Accessory { AccessoryID = Guid.NewGuid().ToString(), AccessoryName = "Generic USB",
                AccessoryImage="https://cdn.mediamart.vn/images/product/usb-sandisk-16gb-sdcz600016gg35-Jgtyl0.png",
                AccessoryRatings="4.5", AccessoryPrice="350.000 VND", AccessoryType="USB"},
            };
        }

        public async Task<bool> AddAccessoryAsync(Accessory accessory)
        {
            accessories.Add(accessory);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAccessoryAsync(Accessory accessory)
        {
            var oldAccessory = accessories.Where((Accessory arg) => arg.AccessoryID == accessory.AccessoryID).FirstOrDefault();
            accessories.Remove(oldAccessory);
            accessories.Add(accessory);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAccessoryAsync(string id)
        {
            var oldAccessory = accessories.Where((Accessory arg) => arg.AccessoryID == id).FirstOrDefault();
            accessories.Remove(oldAccessory);

            return await Task.FromResult(true);
        }

        public async Task<Accessory> GetAccessoryAsync(string id)
        {
            return await Task.FromResult(accessories.FirstOrDefault(s => s.AccessoryID == id));
        }

        public async Task<IEnumerable<Accessory>> GetAccessoriesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(accessories);
        }
    }
}