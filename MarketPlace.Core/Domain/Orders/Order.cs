using MarketPlace.Core.Domain.Addresses;
using MarketPlace.Core.Domain.Customers;
using MarketPlace.Core.Domain.Employees;
using MarketPlace.Core.Domain.PaymentMethods;
using MarketPlace.Core.Domain.WorkingHours;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.Orders
{
    public class Order
    {
        /// <summary>
        /// Gets or sets the UID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the status, cancel-deactive: 0, active: 1, delete: 2
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the payment status, ödenmedi: 0, ödendi: 1
        /// </summary>
        public int PaymentStatus { get; set; }

        /// <summary>
        /// Gets or sets the order total
        /// </summary>
        public decimal OrderTotal { get; set; }

        /// <summary>
        /// Gets or sets order note
        /// </summary>
        public string OrderNote { get; set; }

        /// <summary>
        /// Gets or sets the date and time of entity creation
        /// </summary>
        public string CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of last update
        /// </summary>
        public string UpdatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the employee
        /// </summary>
        public Employee Employee { get; set; }

        /// <summary>
        /// Gets or sets the order address
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the payment method
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the working hour
        /// </summary>
        public WorkingHour WorkingHour { get; set; }

        /// <summary>
        /// Gets or sets the order items
        /// </summary>
        public OrderItems[] OrderItems { get; set; }
    }
}
