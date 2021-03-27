using System;
using LoggingSystem;
using CommandChecker;
namespace Encryptor
{
    class Program
    {
        public static Logger logger = new Logger();
        public static Checker checker = new Checker();

        static void Main(string[] args)
        {

            logger.intro();
            bool running = true;
            while (running == true) {
                string command = Console.ReadLine();
                checker.route_command(command, ref running);



            }
            
        }
    }
}
