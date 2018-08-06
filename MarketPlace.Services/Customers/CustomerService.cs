using MarketPlace.Core.Data;
using MarketPlace.Core.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Services.Customers
{
    public partial class CustomerService : ICustomerService
    {
        #region Fields

        private readonly IRepository<Customer> _customerRepository;

        #endregion

        #region Constructors

        public CustomerService(IRepository<Customer> customerRepository)
        {
            this._customerRepository = customerRepository;
        }


        #endregion

        #region Methods

        public virtual IList<Customer> GetAll()
        {
            var customers = new List<Customer>();
            var query = _customerRepository.Table;
            foreach (var item in query)
            {
                customers.Add(item);
            }
            return customers;
        }

        #endregion
    }
}
