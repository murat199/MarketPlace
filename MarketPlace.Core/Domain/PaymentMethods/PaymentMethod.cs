using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Core.Domain.PaymentMethods
{
    public class PaymentMethod
    {
        /// <summary>
        /// Gets or sets the UID
        /// </summary>
        public string UID { get; set; }

        /// <summary>
        /// Gets or sets the methodName
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// Gets or sets the payment method system name
        /// </summary>
        public string PaymentMethodSystemName { get; set; }

        /// <summary>
        /// Gets or sets the status, cancel-deactive: 0, active: 1, delete: 2
        /// </summary>
        public int Status { get; set; }
    }
}
