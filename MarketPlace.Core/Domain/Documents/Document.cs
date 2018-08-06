using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.Documents
{
    public class Document
    {
        public Boolean DocumentHidden { get; set; }

        /// <summary>
        /// Gets or sets document file url
        /// </summary>
        public string DocumentUrl { get; set; }

        /// <summary>
        ///  Gets or sets status
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
