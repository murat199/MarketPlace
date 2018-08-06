using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.Services
{
    public class Service
    {
        /// <summary>
        /// Gets or sets the UID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the typeName ( tablo kayıt tipi, alacağı örnek değerler : Customer, Employee vs.
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  Gets or sets service Average Price
        /// </summary>
        public int AveragePrice { get; set; }

        /// <summary>
        /// Gets or sets the status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the date and time of entity creation
        /// </summary>
        public string CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of last update
        /// </summary>
        public string UpdatedOnUtc { get; set; }
    }
}
