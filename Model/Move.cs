namespace MarsRover
{
	class Move : ICommand
	{
		public void Invoke(MarsRover marsRover)
		{
			marsRover.Move();
		}
	}
}
