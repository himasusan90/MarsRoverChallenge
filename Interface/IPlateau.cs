namespace MarsRover
{
	public interface IPlateau
	{
		bool isWithinPlateauDimensions(int XCoordinate, int YCoordinate);
		void SetUpperCoordinates(ICoordinates coordinates);

	}
}