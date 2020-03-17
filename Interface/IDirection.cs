namespace MarsRover
{
	public interface IDirection
	{
		IPosition Position { get; }
		string DirectionName { get; }
		void TurnRight();
		void TurnLeft();
		ICoordinates Move();
	}
}
