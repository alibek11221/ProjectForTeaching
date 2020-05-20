using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProjectCoreLibrary.DataAccess;
using ProjectCoreLibrary.Models;

namespace ProjectCoreLibrary.Controllers
{
	public class EmployeeController
	{
		private readonly IDataAccess<IEmployeeModel> _dataAccess;

		public EmployeeController(IDataAccess<IEmployeeModel> dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public void SaveEmployee(IEmployeeModel employee)
		{
			_dataAccess.Save(employee);
		}

		public List<IEmployeeModel> LoadEmployee()
		{
			return _dataAccess.Load();
		}
	}
}