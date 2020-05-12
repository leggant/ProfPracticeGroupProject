using System;
using System.IO; // For Importing Text Strings From Text Files
using TeamAProfessionalPracticeGroupProject;

namespace CatchUp19
{
    class PPGroupProject
    {
        static void Main()
        {
            // Variable Declarations
            string[,] questions = new string[30, 30];
            string[,] answers = new string[50, 50];

            string nameInput, temp = "";
            string hashlines = "################################################################";
            string welcomeText = "###########Welcome, Catch-Up-19 is Here To Help You!###########\nCovid-19 Lockdown has been tough, so we are here to check in.";

            //Start Program
            // Welcome User & Ask for their name

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(hashlines);
            Console.WriteLine(welcomeText);
            Console.WriteLine($"{hashlines}\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            // User Class Method Returns Users Name
            //ask the user for their name
            nameInput = User.getUsersName();
            // this needs to be converted to an integer to check that the user has entered a number and not a word.
            int userChoice = User.UsersMood();

            //Loading text string data in to an array here.

            StreamReader questionsTextFileReader = new StreamReader("QuestionStrings.txt");
            StreamReader answersTextFileReader = new StreamReader("AnswerStrings.txt");

            while (temp != null)
            {
                for (int i = 0; i < questions.Length; i+=2)
                {
                    temp = questionsTextFileReader.ReadLine();
                    questions[i, i] = temp;
                }

                //for (int i = 0; i < answers.Length; i++)
                //{
                //    temp = answersTextFileReader.ReadLine();
                //    answers[i][i] = temp;
                //}
            }
            questionsTextFileReader.Close();
            answersTextFileReader.Close();

            //Console.WriteLine(questions[0]);

            //Question and answer Arrays are now populated with text content from external text files.

            //using switch to excute diffrent commands based on the user input

            switch (userChoice)
            {
                //Positive Mood 
                case 1:
                case 2:
                case 3:
                case 4:
                    //ask the user for why using the app 
                    // for each loop
                    Console.WriteLine(questions[0,0]);
                    break;
                //Meh Mood
                case 5:
                case 6:
                case 7:
                    //for each loop
                    break;
                // Really Negative Mood
                case 8:
                case 9:
                case 10:
                    // for each loop
                    break;

            }


            Console.ReadLine();
        }
    }
}
