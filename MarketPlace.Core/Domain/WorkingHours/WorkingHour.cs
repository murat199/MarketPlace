using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.WorkingHours
{
    public class WorkingHour
    {
        /// <summary>
        /// Gets or sets the UID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Day Of Week, example --> Monday = 1
        /// </summary>
        public int DayOfWeek { get; set; }

        /// <summary>
        /// Gets or sets the start hour
        /// </summary>
        public int StartHour { get; set; }

        /// <summary>
        /// Gets or sets the start minute
        /// </summary>
        public int StartMinute { get; set; }

        /// <summary>
        /// Gets or sets the end hour
        /// </summary>
        public int EndHour { get; set; }

        /// <summary>
        /// Gets or sets the end minute
        /// </summary>
        public int EndMinute { get; set; }

        /// <summary>
        /// Gets or sets employee have special note
        /// </summary>
        public string SpecialNote { get; set; }
    }
}
