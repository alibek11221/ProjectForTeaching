using System;
using System.Collections.Generic;

namespace ProjectCoreLibrary.Models
{
	public class UnitModel : IModel
	{
		public string Name { get; set; }
		public List<PositionModel> Positions { get; set; }
		public uint? Id { get; set; }
	}
}