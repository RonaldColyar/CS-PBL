using System;
namespace CommandChecker
{
	public class Checker
	{
		
		public bool valid_command()
        {
			return true;
        }
		public void route_command(string command , ref bool running)
        {
			if(command == "test1")
            {
				Console.WriteLine("Works well");

            }
            else
            {
                Console.WriteLine("Ending program");
                running = false; 

            }
        }
	}
}