namespace MarsRover
{
	public interface IPosition
	{
		 ICoordinates Point { get; }
		bool CheckIfPositionIsInitialized();
		void IncreaseX();
		void DecreaseX();
		void IncreaseY();
		void DecreaseY();

		
	}
}
