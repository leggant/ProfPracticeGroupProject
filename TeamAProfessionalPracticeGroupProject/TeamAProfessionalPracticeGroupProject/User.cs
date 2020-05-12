using System;
using System.Collections.Generic;
using System.Text;

namespace TeamAProfessionalPracticeGroupProject
{
    class User
    {
        public static string UsersName;
        public static int UsersCurrentMoodRating;
        public static string UsersCurrentMood;
        public static string getUsersName()
        {
            Console.Write("Please Enter your name: ");
            UsersName = Console.ReadLine();
            return UsersName;
        }
        public static int UsersMood()
        {
            Console.Write($"Hi {UsersName}, on a scale of 1-10, 1 being terrible and 10 being amazing, how would you rate your current mood?");
            //store the user information in a string
            UsersCurrentMood = Console.ReadLine();
            // Store rating as an integer
            //UsersCurrentMoodRating = UsersMoodIndex(UsersCurrentMood);
            bool recheck = true;
            do
            {
                try
                {
                    UsersCurrentMoodRating = Convert.ToInt32(UsersCurrentMood);
                    recheck = false;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInput error, please enter a number only.");
                    Console.Write("Please re-enter 1-10: ");
                    Console.WriteLine("");
                    UsersCurrentMood = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } 
            while (recheck);
            return UsersCurrentMoodRating;

            
        }
        public static int UsersMoodIndex(string ratingNum)
        {
            UsersCurrentMoodRating = Convert.ToInt32(ratingNum);
            Console.WriteLine($"Users Mood Rating: {UsersCurrentMoodRating}");
            return UsersCurrentMoodRating;
        }

    }
}
