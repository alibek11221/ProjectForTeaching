using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCoreLibrary.Models
{
	public interface IEmployeeModel : IModel
	{
		string Name { get; set; }
		string Email { get; set; }
		DateTime BirthDate { get; set; }
		int Age { get;  }
		int PositionId { get; set; }
		PositionModel Position { get; set; }
	}
}
