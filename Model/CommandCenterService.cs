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
	public class CommandCenterService
	{
		private readonly IPlateau plateau;

		public CommandCenterService()
		{
			plateau = new Plateau();
		}
		public void ProcessCommands(string commandString)
		{
			var commands = commandString.Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.None);

			RobotAdmin robotAdmin = new RobotAdmin(plateau);

			foreach (var command in commands)
			{
				if (!string.IsNullOrEmpty(command.Trim()))
				{
					var commandtype = CommandMatcher.GetCommandType(command);
					if (commandtype == CommandType.PlateauCoordinates)
					{
						var upperBounds = Parser.ParsePlateau(command);
						plateau.SetUpperCoordinates(upperBounds);

					}
					if (commandtype == CommandType.RoverInitialCoordinates)
					{
						string directionName = "";
						var coordinates = Parser.ParsePosition(command, out directionName);

						robotAdmin.AddRover(coordinates, directionName);
					}
					if (commandtype == CommandType.RoverMovement)
					{
						if (robotAdmin.CurrentRover != null)
						{
							List<ICommand> movementCommands = Parser.MaptoCommands(command);
							foreach (var movementCommand in movementCommands)
							{
								movementCommand.Invoke(robotAdmin.CurrentRover);
							}
						}
						else
						{
							throw new ArgumentException("Please provide the rover coordinates to deploy the rover");
						}

						Console.WriteLine($"{robotAdmin.CurrentRover.ToString()}");
					}
				}
			}

		}

	}
}