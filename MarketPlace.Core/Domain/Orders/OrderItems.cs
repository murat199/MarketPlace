using MarketPlace.Core.Domain.EmployeeServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.Orders
{
    public class OrderItems
    {
        /// <summary>
        /// Gets or sets the UID
        /// </summary>
        public string UID { get; set; }

        /// <summary>
        ///  Gets or sets employeeService
        /// </summary>
        public EmployeeService EmployeeService { get; set; }
    }
}
