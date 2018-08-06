using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.Appointments
{
    public class Appointment
    {
        // <summary>
        /// Gets or sets the UID
        /// </summary>
        public string UID { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public int EmployedId { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets Working Hour
        /// </summary>
        public int WorkingHourId { get; set; }

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
