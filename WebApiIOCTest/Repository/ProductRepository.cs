using System;
using System.Collections.Generic;
using WebApiIOCTest.Interfaces;
using WebApiIOCTest.Models;

namespace WebApiIOCTest
{
	public class ProductRepository : IProductRepository
	{
		private List<Product> products = new List<Product>();
		private int _nextId = 1;

		public ProductRepository()
		{
			// Add products for the Demonstration
			Add(new Product { Name = "Basketball", Category = "Sports", Price = 40 });
			Add(new Product { Name = "Paper", Category = "Office", Price = 5 });
			Add(new Product { Name = "Brocolli", Category = "Grocery", Price = 2 });
			Add(new Product { Name = "Oil Filter", Category = "Automotive", Price = 20 });
		}

		public IEnumerable<Product> GetAll()
		{
			return products;
		}

		public Product Get(int id)
		{
			return products.Find(p => p.Id == id);
		}

		public Product Add(Product item)
		{
			if (item == null)
			{
				throw new ArgumentNullException("item");
			}

			item.Id = _nextId++;
			products.Add(item);
			return item;
		}
	}
}
