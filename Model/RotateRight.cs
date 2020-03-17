namespace MarsRover
{
	class RotateRight : ICommand
	{
		public void Invoke(MarsRover marsRover)
		{
			marsRover.RotateRight();
		}
	}
}
