using System;
using System.Collections.Generic;
using System.Text;

namespace TeamAProfessionalPracticeGroupProject
{
    class User
    {
        public static string UsersName;
        //public static string UsersCurrentMood;
        public static string getUsersName()
        {
            Console.Write("Please Enter your name: ");
            UsersName = Console.ReadLine();
            return UsersName;
        }
        public static string UsersMood()
        {
            string UsersCurrentMood;
            Console.WriteLine($"Hi {UsersName}, How you feeling today? \nif you feeling ok enter 1 or enter 2 if you feel unwell");
            //store the user information in a string
            UsersCurrentMood = Console.ReadLine();
            return UsersCurrentMood;
        }
    }
}
