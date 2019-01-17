using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using WebApiIOCTest.Interfaces;
using Unity.AutoRegistration;

namespace WebApiIOCTest
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();

			container.RegisterType<IProductRepository, ProductRepository>();

			container.ConfigureAutoRegistration()
				.ExcludeSystemAssemblies()
				.ExcludeAssemblies(x => x.FullName.Contains(value: "NewRelic"))
				.ExcludeAssemblies(x => x.FullName.Contains(value: "Microsoft"))
				.ApplyAutoRegistration();

			GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
		}
	}
}
