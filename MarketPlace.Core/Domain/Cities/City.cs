using MarketPlace.Core.Domain.Districts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.Cities
{
    public class City
    {
        public City()
        {
            Districts = new List<District>();
        }
        /// <summary>
        /// Gets or sets the UID
        /// </summary>
        //public string Id { get; set; }

        /// <summary>
        /// Gets or sets the typeName ( tablo kayıt tipi, alacağı örnek değerler : Customer, Employee vs.
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets city name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Districts
        /// </summary>
        public List<District> Districts { get; set; }

        /// <summary>
        /// Gets or sets AreaType
        /// </summary>
        public string AreaType { get; set; }
    }
}
