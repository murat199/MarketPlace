using MarketPlace.Core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.EmployeeServices
{
    public class EmployeeService
    {
        // <summary>
        /// Gets or sets the UID
        /// </summary>
        public string UID { get; set; }

        /// <summary>
        /// Gets or sets the service price
        /// </summary>
        public Service Service { get; set; }

        /// <summary>
        /// Gets or sets the NameHidden
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets the service special note
        /// </summary>
        public string SpecialNote { get; set; }
    }
}
