using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ProjectCoreLibrary.Models;

namespace ProjectCoreLibrary.DataAccess
{
	public class FileDataAccess<T> : IDataAccess<T> where T : IModel
	{
		private readonly string _path = $"{typeof(T).Name}.json";

		public List<T> Load()
		{
			if (!File.Exists(_path)) return new List<T>();
			var text = File.ReadAllText(_path);
			return JsonConvert.DeserializeObject<List<T>>(text);
		}

		public void Save(T obj)
		{
			string jsonString;
			var others = Load();
			if (obj.Id == null)
			{
				obj.Id = setId(others);
			}
			others.Add(obj);
			jsonString = JsonConvert.SerializeObject(others);
			File.WriteAllText(_path, jsonString);
		}
		private uint? setId(List<T> objects)
		{
			if (objects.Count == 0)
			{
				return 1;
			}
			else
			{
				return objects.Last().Id + 1;
			}
		}
	}
}