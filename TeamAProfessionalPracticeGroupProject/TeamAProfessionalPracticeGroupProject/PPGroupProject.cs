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
            string[] questions = new string[50];
            string[] answers = new string[50];
            Random answerGenerator = new Random();
            string nameInput, temp = "";
            string hashlines = "################################################################";
            string welcomeText = "###########Welcome, Catch-Up-19 is Here To Help You!###########\nCovid-19 Lockdown has been tough, so we are here to check in.";
            int randomAnswer;
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

            //Question and answer Arrays are now populated with text content from external text files.

            //using switch to excute diffrent commands based on the user input
            switch (userChoice)
            {
                //Negative Mood 
                case 1:
                case 2:
                case 3:
                case 4:
                    //ask the user for why using the app 
                    // foreach loop in questions array from line 8 to 12 

                    foreach (string item in questions[1..8])
                    {
                        Console.WriteLine($"\n{item}");
                        Console.Write("Enter you answer: ");
                        temp = Console.ReadLine();
                        //generate randomised answer from the answers array for posiv
                        randomAnswer = answerGenerator.Next(2, 9);
                        Console.WriteLine(answers[randomAnswer]);
                    }
                    break;
                //Meh Mood
                case 5:
                case 6:
                    //for each loop
                    foreach (string item in questions[14..22])
                    {
                        Console.WriteLine($"\n{item}");
                        Console.Write("Enter you answer: ");
                        temp = Console.ReadLine();
                        randomAnswer = answerGenerator.Next(10, 14);
                        Console.WriteLine(answers[randomAnswer]);

                    }
                    break;
                // Positive Mood
                case 7:
                case 8:
                case 9:
                case 10:
                    // for each loop
                    foreach (string item in questions[24..27])
                    {
                        Console.WriteLine($"\n{item}");
                        Console.Write("Enter you answer: ");
                        temp = Console.ReadLine();
                        randomAnswer = answerGenerator.Next(15, 18);
                        Console.WriteLine(answers[randomAnswer]);
                    }
                    break;
            }
        }

    }

}

