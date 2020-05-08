using System;

namespace ProjectCoreLibrary.Models
{
	public class EmployeeModel : IModel
	{
		private DateTime _birthDate;
		private string _name;
		private string _email;
		private int _age;
		private int _positionId;
		private PositionModel _position;
		private uint? id;

		public string Name
		{
			get => _name;
			set => _name = value;
		}

		public string Email
		{
			get => _email;
			set => _email = value;
		}

		public DateTime BirthDate
		{
			get => _birthDate;
			set
			{
				_birthDate = value;
				Age = DateTime.Now.Year - BirthDate.Year;
			}
		}

		public int Age
		{
			get => _age;
			private set => _age = value;
		}

		public int PositionId
		{
			get => _positionId;
			set => _positionId = value;
		}

		public PositionModel Position
		{
			get => _position;
			set => _position = value;
		}

		public uint? Id
		{
			get { return id; }
			set { id = value; }
		}
	}
}