using System;
namespace LoggingSystem
{
 
    
    public class Logger
    {

        int row_number = 0;
        public void display_bottom_line()
        {
            Console.WriteLine("---------------------------");
            row_number += 1;
        }
        public void intro()
        {
            Console.WriteLine("Welcome To Encryptor! Version 1.2");
            Console.WriteLine("For command help run  --help");




        }
    }
}
