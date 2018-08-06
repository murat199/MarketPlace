using MarketPlace.Core.Domain.Addresses;
using MarketPlace.Core.Domain.Documents;
using MarketPlace.Core.Domain.Reviews;
using MarketPlace.Core.Domain.Services;
using MarketPlace.Core.Domain.WorkingHours;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.Employees
{
    public class Employee
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
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the identity number
        /// </summary>
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Gets or sets the gsm phone
        /// </summary>
        public string GsmPhone { get; set; }

        // <summary>
        /// Gets or sets the date and time of entity creation
        /// </summary>
        public string CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of last update
        /// </summary>
        public string UpdatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the birt date
        /// </summary>
        public string BirthDate { get; set; }

        /// <summary>
        /// Gets or sets status id, pasif=0, aktif=1, silinmiş=2, aktivasyon bekliyor=3 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the address
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets employee services
        /// </summary>
        public Service[] Services { get; set; }

        /// <summary>
        /// Gets or sets employee reviews
        /// </summary>
        public Review[] Reviews { get; set; }

        /// <summary>
        /// Gets or sets employee reviews
        /// </summary>
        public EmployeeWorkingArea[] WorkAreas { get; set; }

        /// <summary>
        /// Gets or sets employee documents
        /// </summary>
        public Document[] Documents { get; set; }

        /// <summary>
        /// Gets or sets working hours
        /// </summary>
        public WorkingHour[] WorkingHours { get; set; }
    }
}
