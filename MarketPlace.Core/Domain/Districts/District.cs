using MarketPlace.Core.Domain.Neighborhoods;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.Districts
{
    public class District
    {
        public District()
        {
            Neighborhoods = new List<Neighborhood>();
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
        /// Gets or sets district name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets neighborhoods
        /// </summary>
        public List<Neighborhood> Neighborhoods { get; set; }
    }
}
