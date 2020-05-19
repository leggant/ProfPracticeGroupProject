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
            Random rand = new Random();
            //random welcom msg
            string[] WelcomeMsg = { "Hi", "Welcome", "Good day", "Hey" };
            int msg = rand.Next(WelcomeMsg.Length);
            Console.WriteLine();

            //random feelings to greet the user
            string[] feelings = { "good", "great", "wonderful", "amazing","motivated", };
            int feel = rand.Next(feelings.Length);
            Console.WriteLine($"{WelcomeMsg[msg]} {UsersName} hope you feeling {feelings[feel]} today :)");
            Console.WriteLine();
            Console.Write("On a scale of 1 - 10, 1 being terrible and 10 being amazing,\n how would you rate your current mood ? ");
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
