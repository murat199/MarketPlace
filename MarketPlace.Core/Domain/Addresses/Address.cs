using MarketPlace.Core.Domain.Cities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.Addresses
{
    public class Address
    {
        public Address()
        {
            City = new List<City>();
        }
        /// <summary>
        /// Gets or sets the UID
        /// </summary>
        //public string Id { get; set; }

        /// <summary>
        /// Gets or sets the address title
        /// </summary>
        public string AddressTitle { get; set; }

        /// <summary>
        /// Gets or sets open adress text
        /// </summary>
        public string OpenAddress { get; set; }

        /// <summary>
        /// Gets or sets the status, cancel-deactive: 0, active: 1, delete: 2
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets id
        /// </summary>
        public List<City> City { get; set; }

        /// <summary>
        /// Gets or sets district
        /// </summary>
        //public District District { get; set; }

        /// <summary>
        /// Gets or sets district
        /// </summary>
        //public Neighborhood Neighborhood { get; set; }
    }
}
