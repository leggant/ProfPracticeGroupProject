using System;
using System.IO; // For Importing Text Strings From Text Files

namespace TeamAProfessionalPracticeGroupProject
{
    class PPGroupProject
    {
        static void Main()
        {
            // Variable Declarations
            string[] questions = new string[10];
            string[] answers = new string[10];
            int userchoice;
            string NameInput, temp = "";
            string hashlines = "################################################################";
            string welcomeText = "###########Welcome, This Program is Here To Help You!###########\nCovid-19 Lockdown has been tough, so we are here to check in.";
            
            //Start Program
            // Welcome User & Ask for their name

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(hashlines);
            Console.WriteLine(welcomeText);
            Console.WriteLine(hashlines);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please Enter your name :");
            NameInput = Console.ReadLine();
            Console.Write($"Hi {NameInput}, on scale of 1 to 10 how you feeling today?? ");
            userchoice = Convert.ToInt32(Console.ReadLine());

            //Loading text string data in to an array here.
            
            StreamReader questionsTextFileReader = new StreamReader("QuestionStrings.txt");
            StreamReader answersTextFileReader = new StreamReader("AnswerStrings.txt");
            
            while (temp != null)
            {
                for (int i = 0; i < questions.Length; i++)
                {
                    temp = questionsTextFileReader.ReadLine();
                    questions[i] = temp;
                }
                for (int i = 0; i < answers.Length; i++)
                {
                    temp = answersTextFileReader.ReadLine();
                    answers[i] = temp;
                }
            }
            questionsTextFileReader.Close();
            answersTextFileReader.Close();
            //Console.WriteLine(questions[0]);
            //Console.WriteLine(answers[0]);
            // Arrays are now populated with text content from external text files.

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
