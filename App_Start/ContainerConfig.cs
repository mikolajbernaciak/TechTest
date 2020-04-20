using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using TechTest.Models;
using TechTest.Services;

namespace TechTest
{
	public class ContainerConfig
	{
		internal static void RegisterContainer()
		{
			var builder = new ContainerBuilder();
			builder.RegisterControllers(typeof(MvcApplication).Assembly);
			builder.RegisterType<CurrencyService>()
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();

			builder.RegisterType<MyDBContext>()
				.InstancePerLifetimeScope();

			var container = builder.Build();
			DependencyResolver.SetResolver((new AutofacDependencyResolver(container)));
		}
	}
}