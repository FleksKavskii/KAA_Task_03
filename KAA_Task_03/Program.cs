using System;

namespace KAA_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "password";
            string userPass;
            int attempt = 3;
            Console.WriteLine("Введите пароль: ");
            for (attempt= 3; attempt >= 1; --attempt)
            {
                userPass = Console.ReadLine();
                if (userPass == pass)
                {
                    Console.WriteLine("seсret message");
                    break;
                }
                else
                    Console.WriteLine("Повторите попытку: ");
                    
            }
        }
    }
}
