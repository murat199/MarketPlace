using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.CreditCards
{
    public class CreditCard
    {
        /// <summary>
        /// Gets or sets the UID
        /// </summary>
        //public string Id { get; set; }

        /// <summary>
        /// Gets or sets the token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the Card Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the status, cancel-deactive: 0, active: 1, delete: 2
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
