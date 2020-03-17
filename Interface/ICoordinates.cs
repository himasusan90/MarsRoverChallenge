namespace MarsRover
{
	public interface ICoordinates
	{
		int XCoordinate { get; set; }
		int YCoordinate { get; set; }
		void GetNewXCoordinate(int value);
		void GetNewYCoordinates(int value);
	}
}