using MarketPlace.Core.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Services.Customers
{
    public partial interface ICustomerService
    {
        IList<Customer> GetAll();
    }
}
