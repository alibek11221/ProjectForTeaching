using Autofac;
using ProjectCoreLibrary.DataAccess;
using ProjectCoreLibrary.Models;
using System.Linq;
using System.Reflection;
using System;
using System.Collections.Generic;

namespace ProjectUi
{
	public static class ContainerConfig
	{
		public static IContainer Configure()
		{
			string s = "dasd";
			s.Contains("ds");
			ContainerBuilder builder = new ContainerBuilder();
			builder
				.RegisterAssemblyTypes(Assembly.Load(nameof(ProjectCoreLibrary)))
				.Where(t => t.Namespace.Contains("Models"))
				.As(t => Array.Find(t.GetInterfaces(), i => i.Name == "I" + t.Name));
			builder.RegisterGeneric(typeof(IDataAccess<>)).As(typeof(FileDataAccess<>));
			return builder.Build();
		}
	}
}