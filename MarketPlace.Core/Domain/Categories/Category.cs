using MarketPlace.Core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.Categories
{
    public class Category
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
        ///  Gets or sets display order number
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        ///  Gets or sets status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the collection of category services
        /// </summary>
        public Service[] Services { get; set; }
    }
}
