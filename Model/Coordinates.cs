namespace MarsRover
{
	public class Coordinates: ICoordinates
	{
		public int XCoordinate { get; set; }
		public int YCoordinate { get; set; } 
		public Coordinates( int xCoordinate,  int yCoordinate)
		{
			XCoordinate = xCoordinate;	
			YCoordinate = yCoordinate;
		}

		public void GetNewXCoordinate(int value)
		{
			XCoordinate = XCoordinate + value;
		}

		public void GetNewYCoordinates(int value)
		{
			YCoordinate = YCoordinate + value;
		}

		

	}
}
