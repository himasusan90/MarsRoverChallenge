namespace MarsRover
{
	public interface IPosition
	{
		 ICoordinates Point { get; }
		void IncreaseX();
		void DecreaseX();
		void IncreaseY();
		void DecreaseY();

		
	}
}
