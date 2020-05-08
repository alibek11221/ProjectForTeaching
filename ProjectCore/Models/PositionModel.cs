using System;

namespace ProjectCoreLibrary.Models
{
	public class PositionModel : IModel
	{
		public string Name { get; set; }
		public decimal Salary { get; set; }
		public int UnitId { get; set; }
		public EmployeeModel Employee { get; set; }
		public UnitModel Unit { get; set; }
		public uint? Id { get; set; }
	}
}