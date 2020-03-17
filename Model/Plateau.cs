namespace MarsRover
{
	public class Plateau: IPlateau
	{
		public ICoordinates UpperCoordinates { get; set; } = new Coordinates(0, 0);
		public ICoordinates BottomCoordinates { get; set; } = new Coordinates(0, 0);

		public void SetUpperCoordinates(ICoordinates coordinates)
		{
			UpperCoordinates = coordinates;			 
		}

		public bool isWithinPlateauDimensions(int XCoordinate, int YCoordinate)
		{
			
				var isValidX = XCoordinate >= 0 && XCoordinate <= UpperCoordinates.XCoordinate;
				var isValidY = YCoordinate >= 0 && YCoordinate <= UpperCoordinates.YCoordinate;
				return isValidX && isValidY;
			
		}
	}
}
