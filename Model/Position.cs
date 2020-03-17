namespace MarsRover
{
	class Position : IPosition
	{
		readonly IPlateau Plateau;
		public ICoordinates Point { get; private set; } 
		public Position(IPlateau plateau,ICoordinates cordinates)
		{
			Plateau = plateau;
			Point = cordinates;
		}
		public void IncreaseX()
		{
			if (Plateau.isWithinPlateauDimensions(Point.XCoordinate,Point.YCoordinate))
			{

				Point.GetNewXCoordinate(1);
			}
		}
		public void DecreaseX()
		{
			if (Plateau.isWithinPlateauDimensions(Point.XCoordinate, Point.YCoordinate))
			{
				Point.GetNewXCoordinate(-1);
			}
		}
		public void IncreaseY()
		{
			if (Plateau.isWithinPlateauDimensions(Point.XCoordinate, Point.YCoordinate))
			{
				Point.GetNewYCoordinates(1);
			}
		}
		public void DecreaseY()
		{
			if (Plateau.isWithinPlateauDimensions(Point.XCoordinate, Point.YCoordinate))
			{
				Point.GetNewYCoordinates(-1);
			}
		}

		public bool CheckIfPositionIsInitialized()
		{
			return Point==null? false: true;
		}

		public override string ToString()
		{
			return Point.XCoordinate + " " + Point.YCoordinate;
		}
	}
}
