using System;
using System.Security.Cryptography.X509Certificates;
using Autofac;
using ProjectCoreLibrary.Controllers;
using ProjectCoreLibrary.DataAccess;
using ProjectCoreLibrary.Models;

namespace ProjectUi
{
	internal static class Program
	{
		private static void Main(string[] args)
		{
			//IEmployeeModel emp = new EmployeeModel()
			//{
			//	BirthDate = new DateTime(1998, 4, 8),
			//	Name = "asdasda"
			//};
			//IDataAccess<IEmployeeModel> dataAccess = new FileDataAccess<IEmployeeModel>();
			//IModel ddd = new EmployeeModel();
			//EmployeeController employeeController = new EmployeeController(dataAccess);

			//employeeController.SaveEmployee(emp);
			//foreach (var item in employeeController.LoadEmployee())
			//{
			//	Console.WriteLine(item.Name);
			//}

			dar(x=>x.PositionId == 1);
		}
		public static void dar(Func<EmployeeModel, bool> func)
		{
			EmployeeModel[] employeeModels = new EmployeeModel[]
			{
				new EmployeeModel(){Id=1,PositionId=1}, 
				new EmployeeModel(){Id=2,PositionId=1}
			};
			foreach (var item in employeeModels)
			{
				if (func(item))
				{
					Console.WriteLine("Совпадение");
				}
			}
		}
	}
}