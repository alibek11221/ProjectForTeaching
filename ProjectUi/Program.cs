using System;
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
			EmployeeModel emp = new EmployeeModel()
			{
				BirthDate = new DateTime(1998, 4, 8),
				Name = "asdasda"
			};
			IDataAccess<EmployeeModel> dataAccess = new FileDataAccess<EmployeeModel>();
			EmployeeController employeeController = new EmployeeController(dataAccess);

			employeeController.SaveEmployee(emp);
			employeeController.LoadEmployee();
			
		}
	}
}