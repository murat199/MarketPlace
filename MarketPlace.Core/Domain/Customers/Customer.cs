using MarketPlace.Core.Domain.Addresses;
using MarketPlace.Core.Domain.CreditCards;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.Customers
{
    public partial class Customer : BaseEntity
    {
        public Customer()
        {
            Addresss = new List<Address>();
            CreditCards = new List<CreditCard>();
        }
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
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets address list
        /// </summary>
        public List<Address> Addresss { get; set; }

        /// <summary>
        /// Gets or sets credit card list
        /// </summary>
        public List<CreditCard> CreditCards { get; set; }
    }
}
