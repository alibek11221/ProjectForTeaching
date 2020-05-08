using System.Collections.Generic;
using ProjectCoreLibrary.Models;

namespace ProjectCoreLibrary.DataAccess
{
	public interface IDataAccess<T> where T : IModel
	{
		void Save(T obj);
		List<T> Load();
	}
}