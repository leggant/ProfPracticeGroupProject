using System;
using System.IO; // For Importing Text Strings From Text Files

namespace TeamAProfessionalPracticeGroupProject
{
    class PPGroupProject
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("################################################################");
            Console.WriteLine("###########Welcome, This Program is Here To Help You!###########\nCovid-19 Lockdown has been tough, so we are here to check in.");
            Console.WriteLine("################################################################");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please Enter your name :");
            string NameInput = Console.ReadLine();
            Console.Write($"Hi {NameInput}");
            Console.WriteLine("On scale of 1 to 10 how you feeling today??");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    Console.WriteLine("you need moto");
                    break;
                case 2:
                    Console.WriteLine("you need moto");
                    break;
                case 3:
                    Console.WriteLine("you need moto");
                    break;
                case 4:
                    Console.WriteLine("you need moto");
                    break;
                case 5:
                    Console.WriteLine("you need moto");
                    break;
                default:
                    Console.WriteLine("bb");
                    break;
            }

            Console.ReadLine();
        }
    }
}
