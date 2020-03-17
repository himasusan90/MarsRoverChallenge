using System;

namespace MarsRover
{

	public class Direction : IDirection
	{

		public IPosition Position { get; }
		public string DirectionName { get; private set; }
		string[] cardinalDirections = Enum.GetNames(typeof(CardinalCompassPoints));


		public Direction(IPosition position, string directionName)
		{
			Position = position;
			DirectionName = directionName;

		}
		public ICoordinates Move()
		{

			if (string.Equals(DirectionName, CardinalCompassPoints.N.ToString()))
			{
				Position.IncreaseY();
			}
			else if (string.Equals(DirectionName, CardinalCompassPoints.E.ToString()))
			{
				Position.IncreaseX();
			}
			else if (string.Equals(DirectionName, CardinalCompassPoints.S.ToString()))
			{
				Position.DecreaseY();
			}
			else if (string.Equals(DirectionName, CardinalCompassPoints.W.ToString()))
			{
				Position.DecreaseX();
			}
			return Position.Point;
		}
		public void TurnLeft()
		{		
			if (string.Equals(DirectionName, cardinalDirections[0]))
			{
				DirectionName = cardinalDirections[cardinalDirections.Length-1];
			}
			else
			{
				DirectionName = cardinalDirections[Array.IndexOf(cardinalDirections, DirectionName)-1];
			}		

		}
		public void TurnRight()
		{			
			if (string.Equals(DirectionName, cardinalDirections[cardinalDirections.Length - 1]))
			{
				DirectionName = cardinalDirections[0];
			}
			else
			{
				DirectionName = cardinalDirections[Array.IndexOf(cardinalDirections, DirectionName)+1];
			}
		}
		public override string ToString()
		{
			return Position.ToString() + " " + DirectionName;
		}

	}
}
