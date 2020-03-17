namespace MarsRover
{
	public class MarsRover:IRover
	{
		public IDirection Direction { get; private set; }
		public IRobotAdmin RobotAdmin { get; set; }
		public IPosition Position { get; set; }
		public MarsRover(IPosition position,string direction)
		{
			Direction = new Direction(position,direction);
			Position = position;
			
		}

		public void RotateRight()
		{
			Direction.TurnRight();
		}

		public void RotateLeft()
		{
			Direction.TurnLeft();
		}

		public void Move()
		{
			Direction.Move();
		}
		public override string ToString()
		{
			return Direction.ToString();
		}
	}
}
