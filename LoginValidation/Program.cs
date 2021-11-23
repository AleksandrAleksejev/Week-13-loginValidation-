using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //loginc admin
            //password: pass1234

            //declane variables
            //assign value
            string login = "admin";
            string password = "pass1234";

            string userName, userPassword;
            Console.WriteLine("Enter your login:");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your password");
            userPassword = Console.ReadLine();

            if (login == userName && password == userPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("oops...Someyhing went wrong!");
            }
         
            
        }

    }
}
