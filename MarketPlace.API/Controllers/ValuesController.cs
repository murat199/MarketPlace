using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Services.Customers;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        #region Fields

        private readonly ICustomerService _customerService;

        #endregion

        #region Constructors

        public ValuesController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        #endregion

        #region Methods
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var customers = _customerService.GetAll();
            return Ok(customers);
        }
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    var customers = _customerService.GetAll();
        //    return new string[] { customers[0].FirstName, customers[0].LastName };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        #endregion
    }
}
/*
    {
      CreatedOnUtc: '02.08.2018 10:02:30',
      Email: 'sinandogan@gmail.com',
      BirthDate: '02.08.2018 10:02:30',
      FirstName: 'Sinan',
      GsmPhone: '0539 ',
      LastName: 'Doğan',
      Password: 'Pas123',
      IdentityNumber: '23213583891',
      Status: 1,
      TypeName: 'Customer',
      Addresss: [
        {
          Status: 1,
          OpenAddress: 'Açık adres emek mah.',
          AddressTitle: 'Ev adresi',
          City: [
            {
              AreaType: 'City',
              Name: 'İstanbul',
              TypeName: 'City',
              Districts: [
                {
                  Name: 'Sancaktepe',
                  TypeName: 'District',
                  Neighborhoods: [
                    {
                      Name: 'Emek mahallesi'
                    }
                  ]
                }
              ]
            }
          ]
        }
      ],
      CreditCards: [
        {
          CreatedOnUtc: '02.08.2018 10:02:30',
          Name: 'Sin',
          Status: 1,
          Token: 'token093-dfs-334-df',
          UpdatedOnUtc: '02.08.2018 10:02:30'
        }
      ],
      UpdatedOnUtc: '02.08.2018 10:02:30'
    }
*/
