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
            string[] postiveQuestions = new string[16];
            string[] positiveAnswers = new string[18];
            string[] mehQuestions = new string[16];
            string[] mehAnswers = new string[18];
            string[] negativeQuestions = new string[16];
            string[] negativeAnswers = new string[18];
            string[] affirmations = new string[6];
            Random answerGenerator = new Random();
            int affirmationslen, randAffirmations;
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
            StreamReader positiveAffirmationText = new StreamReader("PositiveAffirmations.txt");

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
                for (int i = 0; i < affirmations.Length; i++)
                {
                    temp = positiveAffirmationText.ReadLine();
                    affirmations[i] = temp;
                }
            }
            questionsTextFileReader.Close();
            answersTextFileReader.Close();
            positiveAffirmationText.Close();
            //Question, answer and affirmation arrays are now populated with text content from external text files.

            //using switch to excute diffrent commands based on the user input
            switch (userChoice)
            {
                //Negative Mood 
                case 1:
                case 2:
                case 3:
                case 4:
                    //iterate 2 arrays in a single foreach loop
                    var QuestionsandAnswers = questions[1..8].Zip(answers[1..8], (q, a) => new { question = q, answer = a });
                    foreach (var qa in QuestionsandAnswers)
                    {
                        Console.WriteLine();
                        Console.WriteLine(qa.question);

                        Console.Write("Please Enter..(yes or no)");
                        temp = Console.ReadLine();
                        if (temp == "yes" || temp == "YES")
                        {
                            Console.WriteLine();
                            Console.WriteLine(qa.answer);
                            //ask the user if they want to continue or to stop the program
                            Console.WriteLine();
                            Console.Write($"Need more help {nameInput}..(yes or no)");
                            temp = Console.ReadLine();
                            if (temp != "yes")
                            {
                                break;
                            }
                        }
                    }
                    // a message for the user before exiting the program
                    Console.WriteLine("\nThank you and stay safe");
                    break;
                //Meh Mood
                case 5:
                case 6:
                    //iterate 2 arrays in a single foreach loop
                    var questionsAndAnswers2 = questions[11..15].Zip(answers[17..21], (q, a) => new { question = q, answer = a });
                    foreach (var qa in questionsAndAnswers2)
                    {
                        Console.WriteLine(qa.question);
                        Console.WriteLine("Enter your answer");
                        temp = Console.ReadLine();
                        if (temp == "yes")
                        {
                            Console.WriteLine(qa.answer);
                            //ask the user if they want to continue or to stop the program
                            Console.WriteLine("\nFeel better ? or Need more help");
                            temp = Console.ReadLine();
                            if (temp != "yes")
                            {
                                break;
                            }
                        }
                    }
                    // a message for the user before exiting the program
                    Console.WriteLine("\nThank you and stay safe");
                    break;
                // Positive Mood
                case 7:
                case 8:
                case 9:
                case 10:
                    affirmationslen = affirmations.Length;
                    randAffirmations = answerGenerator.Next(1, affirmationslen);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\n\t{affirmations[randAffirmations]}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.ReadLine();
        }
    }
}