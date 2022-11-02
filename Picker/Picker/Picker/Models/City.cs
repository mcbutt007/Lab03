using System;
using System.Collections.Generic;
using System.Text;

namespace Picker.Models
{
    public class City : Country
    {
        public string CityId { get; set; }
        public string CityName { get; set; }
        public string CityImage { get; set; }
    }
}
