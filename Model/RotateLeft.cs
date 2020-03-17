namespace MarsRover
{
	public class RotateLeft : ICommand
	{
		public void Invoke(MarsRover marsRover)
		{
			marsRover.RotateLeft();
		}
	}
}
