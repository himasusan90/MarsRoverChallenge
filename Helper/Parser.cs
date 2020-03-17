using System;
using System.Collections.Generic;

namespace MarsRover
{
	public class Parser
	{
		static IDictionary<char, ICommand> dict = new Dictionary<char, ICommand>()
											{
												{'L', new RotateLeft() },
												{ 'R', new RotateRight() },
												{'M', new Move() },
											};
		public static ICoordinates ParsePlateau(string command)
		{
			string[] coordinates = command.Split(' ');
			int xCoordinate = Int32.Parse(coordinates[0]);
			int yCoordinate = Int32.Parse(coordinates[1]);
			return new Coordinates(xCoordinate, yCoordinate);
		}

		public static ICoordinates ParsePosition(string positionString, out string directionName)
		{
			string[] positionArray = positionString.Split(' ');
			int xCoordinate = Int32.Parse(positionArray[0]);
			int yCoordinate = Int32.Parse(positionArray[1]);
			directionName = positionArray[2];
			var Coordinates = new Coordinates(xCoordinate, yCoordinate);
			return Coordinates;
		}



		public static List<ICommand> MaptoCommands(string CommandString)
		{
			if (string.IsNullOrEmpty(CommandString))
			{
				throw new ArgumentException("Invalid input");
			}
			return BuildCommands(CommandString);
		}

		private static List<ICommand> BuildCommands(String commandString)
		{
			List<ICommand> commands = new List<ICommand>();
			ICommand cmd;
			foreach (var charecter in commandString.ToCharArray())
			{

				dict.TryGetValue(charecter, out cmd);
				if (cmd != null)
				{
					commands.Add(cmd);
				}
				else
				{
					throw new ArgumentException("Invalid command");
				}

			}

			return commands;
		}
	}
}