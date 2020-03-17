using System;
using System.Text;

namespace MarsRover
{
	class Program
	{
		static void Main(string[] args)
		{
			var commandString = buildCommandString();
			executeCommandString(commandString);
			Console.ReadKey();
			
		}
		private static void executeCommandString(string commandString)
		{

			var commandCenter = new CommandCenterService();
			commandCenter.ProcessCommands(commandString);
		}
		private static string buildCommandString()
		{
			var sb = new StringBuilder();
			sb.AppendLine("5 5");
			sb.AppendLine("1 2 N");
			sb.AppendLine("LMLMLMLMM");
			sb.AppendLine("3 3 E");
			sb.AppendLine("MMRMMRMRRM");
			return sb.ToString();
		}
	}
}
