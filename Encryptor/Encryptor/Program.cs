using System;
using LoggingSystem;
using CommandChecker;
using System.Security.Cryptography;

namespace Encryptor
{
    class Program
    {
        public static bool running = true;
        public static AesManaged aes = new AesManaged();        //default encryption key
        public static Logger logger = new Logger();
        public static Checker checker = new Checker();

     
        static void Main(string[] args)
        {

            logger.intro();
           
            while (running == true) {
                string command = Console.ReadLine();
                if (command == "quit")
                {
                    running = false;
                }
                checker.route_command(command, aes);



            }
            
        }
    }
}
