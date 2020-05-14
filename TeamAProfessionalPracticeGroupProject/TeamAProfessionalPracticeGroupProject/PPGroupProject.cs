using System;
using System.IO; // For Importing Text Strings From Text Files
using System.Linq;
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

                    //iterate 2 arrays in a single foreach loop
                    var Qustionsandanswers = questions[1..8].Zip(answers[1..8], (q, a) => new { qustion = q, answer = a });
                    foreach (var qa in Qustionsandanswers)
                    {
                        Console.WriteLine();
                        Console.WriteLine(qa.qustion);

                        Console.Write("Please Enter..(yes or no)");
                        temp = Console.ReadLine();

                        if (temp == "yes" || temp == "YES")
                        {
                            Console.WriteLine();
                            Console.WriteLine(qa.answer);
                            //ask the user if they want to continue or to stop the program
                            Console.WriteLine();
                            Console.Write($" Need more help {nameInput}..(yes or no)");
                            temp = Console.ReadLine();
                            if (temp != "yes")
                            {
                                break;
                            }

                        }
                    }
                    // a message for the user before exiting the program
                    Console.WriteLine();
                    Console.WriteLine("Thank you and stay safe");

                    break;
                //Meh Mood
                case 5:
                case 6:
                    //iterate 2 arrays in a single foreach loop
                    var Qustionsandanswers2 = questions[11..15].Zip(answers[17..21], (q, a) => new { qustion = q, answer = a });
                    foreach (var qa in Qustionsandanswers2)
                    {
                        Console.WriteLine(qa.qustion);
                        Console.WriteLine("Enter your answer");
                        temp = Console.ReadLine();
                        if (temp == "yes")
                        {
                            Console.WriteLine(qa.answer);
                            //ask the user if they want to continue or to stop the program
                            Console.WriteLine("Feel better ? or Need more help");
                            temp = Console.ReadLine();
                            if (temp != "yes")
                            {
                                break;
                            }

                        }

                    }
                    // a message for the user before exiting the program
                    Console.WriteLine();
                    Console.WriteLine("Thank you and stay safe");
                    break;
                // Positive Mood
                case 7:
                case 8:
                case 9:
                case 10:
                    //iterate 2 arrays in a single foreach loop
                    var Qustionsandanswers3 = questions[17..19].Zip(answers[27..29], (q, a) => new { qustion = q, answer = a });
                    foreach (var qa in Qustionsandanswers3)
                    {
                        Console.WriteLine(qa.qustion);
                        Console.WriteLine("Enter your answer");
                        temp = Console.ReadLine();
                        if (temp == "yes")
                        {
                            Console.WriteLine(qa.answer);
                            //ask the user if they want to continue or to stop the program
                            Console.WriteLine("Feel better ? or Need more help");
                            temp = Console.ReadLine();
                            if (temp != "yes")
                            {
                                break;
                            }

                        }
                    }
                    // a message for the user before exiting the program
                    Console.WriteLine();
                    Console.WriteLine("Thank you and stay safe");
                    break;

            }
        }

    }

}

