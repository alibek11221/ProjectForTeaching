using Autofac;
using ProjectCoreLibrary.DataAccess;
using ProjectCoreLibrary.Models;
using System.Linq;
using System.Reflection;
using System;

namespace ProjectUi
{
	public static class ContainerConfig
	{


		public static IContainer Configure()
		{
			ContainerBuilder builder = new ContainerBuilder();
			builder.RegisterAssemblyTypes(Assembly.Load(nameof(ProjectCoreLibrary)))
				.Where(t => t.Namespace.Contains("Models"))
				.As(t => Array.Find(t.GetInterfaces(), i => i.Name == "I" + t.Name));
			builder.RegisterGeneric(typeof(FileDataAccess<>)).As(typeof(IDataAccess<>));
			return builder.Build();
		}
	}
}