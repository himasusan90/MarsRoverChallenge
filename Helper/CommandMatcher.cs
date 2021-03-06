﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MarsRover
{
	internal class CommandMatcher: ICommandMatcher
	{
		private static IDictionary<string, CommandType> commandTypeDictionary;

		 static CommandMatcher()
		{
			InitializeCommandTypeDictionary();
		}

		public static CommandType GetCommandType(string command)
		{
			try
			{
				var commandType = commandTypeDictionary.First(
					regexToCommandType => new Regex(regexToCommandType.Key).IsMatch(command));

				return commandType.Value;
			}
			catch (InvalidOperationException e)
			{
				var exceptionMessage = String.Format("String '{0}' is not a valid command", command);
				throw new ArgumentException(exceptionMessage, e);
			}
		}

		private static void InitializeCommandTypeDictionary()
		{
			commandTypeDictionary = new Dictionary<string, CommandType>
			{
				{ @"^\d+ \d+$", CommandType.PlateauCoordinates },
				{ @"^\d+ \d+ [NSEW]$", CommandType.RoverInitialCoordinates },
				{ @"^[LRM]+$", CommandType.RoverMovement }
			};
		}
	}
}