using System;
using System.Security.Cryptography;
using Rij;
namespace CommandChecker
{
	public class Checker
    {   //encryption class
        RijAlgo rij = new RijAlgo();
        string output_file_name = "Default_Encrypted.txt";

       private void encrypt_with_flags_check(string[] command_params,AesManaged aes)
        {
            if (command_params.Length == 3)
            {
                string key = Convert.ToBase64String(aes.Key); 
                
                rij.EncryptFile(command_params[2], output_file_name);
                Console.WriteLine(key);
            }
            else
            {
                //save key (in file) flag option
            }
        }
       private void route_valid_command (
            AesManaged aes,
            string[] command_params)
        {
        
             if (command_params[0] == "encrypt" && command_params[1] == "-r")
            {
                encrypt_with_flags_check(command_params, aes);
            }
            else if (command_params[0] == "encrypt")
            {
                Console.WriteLine("Works well");
            }
            else
            {
                Console.WriteLine("Invalid Command!");
            }
        }
		public void route_command(string command , AesManaged aes)
        {
            string[] command_params = command.Split(" ");
            if (command_params[0] == "--help")
            {

            }
            else if (command_params.Length < 2)
            {
                Console.WriteLine("Please make sure you provide a second parameter");
            }
            else
            {
                route_valid_command(aes,command_params);
            }
           
        }
	}
}