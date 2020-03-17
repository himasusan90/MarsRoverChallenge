using System.Collections.Generic;

namespace MarsRover
{
	public class RobotAdmin
	{
		public List<MarsRover> Rovers { get; private set; }
		public IPlateau Plateau { get; set; }
		public MarsRover CurrentRover { get; set; }
		public RobotAdmin(IPlateau plateau)
		{
			Rovers = new List<MarsRover>();
			Plateau = plateau;
		}

		public void AddRover(ICoordinates coordinates, string direction)
		{
			
			var initialPosition = new Position(Plateau, coordinates);
			CurrentRover = new MarsRover(initialPosition, direction);
			Rovers.Add(CurrentRover);
		}
	}
}
