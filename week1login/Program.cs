using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "Lillian";
            string password = "Xu";
            bool LFlag = true;
            do
            {
                Console.WriteLine("Please press L to start login!");
                string PressVale = Console.ReadLine();
                if (PressVale == "L")
                    LFlag = false;
            }
            while (LFlag);


            bool LogFlag = true;
            do { Console.WriteLine("enter your username!");
                string UserName = Console.ReadLine();
                Console.WriteLine("enter your password!");
                string PassWord = Console.ReadLine();
                if (UserName == username && PassWord == password)
                    LogFlag = false;
                }
            while (LogFlag);
            Console.WriteLine("Welcome!");

            Console.ReadKey();
        }
    }
}
