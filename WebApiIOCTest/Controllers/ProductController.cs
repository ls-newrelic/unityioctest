using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiIOCTest.Interfaces;

namespace WebApiIOCTest.Controllers
{
    public class ProductController : ApiController
    {
		private readonly IProductRepository _repository;

		public ProductController()
		{

		}

		public ProductController(IProductRepository repository)
		{
			_repository = repository;
		}

        // GET: api/Product
        public IEnumerable<string> Get()
        {
            return _repository.GetAll().Select(s => s.Name).ToArray();
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return _repository.Get(id).Name;
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
