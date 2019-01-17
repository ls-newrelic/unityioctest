using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiIOCTest.Models;

namespace WebApiIOCTest.Interfaces
{
	public interface IProductRepository { 
		IEnumerable<Product> GetAll();
		Product Get(int id);
		Product Add(Product item);
	}
}
