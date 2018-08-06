using MarketPlace.Core.Domain.Areas;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.EmployeeWorkAreas
{
    public class EmployeeWorkArea
    {
        // <summary>
        /// Gets or sets the UID
        /// </summary>
        public string UID { get; set; }

        /// <summary>
        /// Gets or sets disttrict, neigborhood, city
        /// </summary>
        public IArea WorkArea { get; set; }
    }
}
