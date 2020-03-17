using System;
using System.Collections.Generic;

namespace MarsRover
{
	public enum CommandType
	{
		PlateauCoordinates,
		RoverInitialCoordinates,
		RoverMovement
	}
	public  class CommandCenter
	{
		private readonly IPlateau plateau;
		public CommandCenter()
		{
			plateau = new Plateau();
		}
		public void ProcessCommands(string commandString)
		{
			var commands = commandString.Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
			
			var commandMatcher = new CommandMatcher();
			
			RobotAdmin robotAdmin = new RobotAdmin(plateau);

			foreach (var command in commands)
			{
				if (!string.IsNullOrEmpty(command.Trim()))
				{
					var commandtype = commandMatcher.GetCommandType(command);
					if (commandtype == CommandType.PlateauCoordinates)
					{
						var upperBounds = Parser.ParsePlateau(command);
						plateau.SetUpperCoordinates(upperBounds);

					}
					 if (commandtype == CommandType.RoverInitialCoordinates)
					{
						string directionName = "";
						var coordinates = Parser.ParsePosition(command, out directionName);

						robotAdmin = new RobotAdmin(plateau);
						robotAdmin.AddRover(coordinates, directionName);
					}
					if (commandtype == CommandType.RoverMovement)
					{
						List<ICommand> movementCommands = Parser.MaptoCommands(command);
						foreach (var movementCommand in movementCommands)
						{
							movementCommand.Invoke(robotAdmin.CurrentRover);
						}
						Console.WriteLine($"{robotAdmin.CurrentRover.ToString()}");
					}
				}
			}

		}
		
	}
}