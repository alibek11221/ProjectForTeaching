using System;
using ProjectCoreLibrary.DataAccess;
using ProjectCoreLibrary.Models;

namespace ProjectCoreLibrary.Controllers
{
	public class EmployeeController
	{
		private readonly IDataAccess<EmployeeModel> _dataAccess;

		public EmployeeController(IDataAccess<EmployeeModel> dataAccess)
		{
			this._dataAccess = dataAccess;
		}

		public void SaveEmployee(EmployeeModel employee)
		{
			_dataAccess.Save(employee);
		}

		public void LoadEmployee()
		{
			foreach (var item in _dataAccess.Load())
			{
				Console.WriteLine($"{item.Id}\n{item.Name}\n{item.Email}\n{item.Age}");
			}
		}
	}
}