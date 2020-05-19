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
            string[] positiveQuestions = new string[2];
            string[] positiveAnswers = new string[2];
            string[] mehQuestions = new string[5];
            string[] mehAnswers = new string[7];
            string[] negativeQuestions = new string[12];
            string[] negativeAnswers = new string[7];
            string[] affirmations = new string[6];
            Random answerGenerator = new Random();
            int affirmationslen, randAffirmations, questionSelector;
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
            //positive questions and answer text reader objects
            StreamReader positiveQuestionsTextFileReader = new StreamReader("PositiveQuestionStrings.txt");
            StreamReader positiveAnswersTextFileReader = new StreamReader("PositiveAnswerStrings.txt");
            //meh questions and answer text reader objects
            StreamReader mehQuestionsTextFileReader = new StreamReader("MehQuestionStrings.txt");
            StreamReader mehAnswersTextFileReader = new StreamReader("MehAnswerStrings.txt");
            //negative questions and answer text reader objects
            StreamReader negativeQuestionsTextFileReader = new StreamReader("NegativeQuestionStrings.txt");
            StreamReader negativeAnswersTextFileReader = new StreamReader("NegativeAnswerStrings.txt");
            // Positive Affirmations
            StreamReader positiveAffirmationText = new StreamReader("PositiveAffirmations.txt");

            //while (temp != null)
            //{
            //positive questions and answers
            for (int i = 0; i < positiveQuestions.Length; i++)
            {
                temp = positiveQuestionsTextFileReader.ReadLine();
                positiveQuestions[i] = temp;
            }
            for (int i = 0; i < positiveAnswers.Length; i++)
            {
                temp = positiveAnswersTextFileReader.ReadLine();
                positiveAnswers[i] = temp;
            }
            // meh questions and answers
            for (int i = 0; i < mehQuestions.Length; i++)
            {
                temp = mehQuestionsTextFileReader.ReadLine();
                mehQuestions[i] = temp;
            }
            for (int i = 0; i < mehAnswers.Length; i++)
            {
                temp = mehAnswersTextFileReader.ReadLine();
                mehAnswers[i] = temp;
            }
            // negative questions and answers
            for (int i = 0; i < negativeQuestions.Length; i++)
            {
                temp = negativeQuestionsTextFileReader.ReadLine();
                negativeQuestions[i] = temp;
            }
            for (int i = 0; i < negativeAnswers.Length; i++)
            {
                temp = negativeAnswersTextFileReader.ReadLine();
                negativeAnswers[i] = temp;
            }
            //positive affirmations
            for (int i = 0; i < affirmations.Length; i++)
            {
                temp = positiveAffirmationText.ReadLine();
                affirmations[i] = temp;
            }
            //}
            positiveQuestionsTextFileReader.Close();
            positiveAnswersTextFileReader.Close();
            negativeQuestionsTextFileReader.Close();
            negativeAnswersTextFileReader.Close();
            mehQuestionsTextFileReader.Close();
            mehAnswersTextFileReader.Close();
            positiveAffirmationText.Close();
            //Question, answer and affirmation arrays are now populated with text content from external text files.

            //using switch to excute diffrent commands based on the user input.
            switch (userChoice)
            {
                //Negative Mood
                case 1:
                case 2:
                case 3:
                case 4:
                    var QuestionsandAnswers = negativeQuestions.Zip(negativeAnswers, (q, a) => new { question = q, answer = a });
                    foreach (var qa in QuestionsandAnswers)
                    {
                        Console.WriteLine(qa.question);
                        Console.Write("Please Enter your answer");
                        temp = Console.ReadLine();
                        if (temp !=null)
                        {
                            Console.WriteLine();
                            Console.WriteLine(qa.answer);
                        }
                        // ask the user if they want to continue or to stop the program
                        Console.WriteLine();
                            Console.Write($"Need more help {nameInput}..(yes or no)");
                            temp = Console.ReadLine();
                            if (temp != "yes")
                            {
                                break;
                            }
                        
                    }
                    Console.WriteLine($"Thank you {nameInput} and stay safe");
                    break;
                case 5:
                case 6:
                    //Meh Mood
                    var QuestionsandAnswers2 = mehQuestions.Zip(mehAnswers, (q, a) => new { question = q, answer = a });
                    foreach (var qa in QuestionsandAnswers2)
                    {
                        Console.WriteLine(qa.question);

                        Console.Write("Please Enter you answer");
                        temp = Console.ReadLine();
                        if (temp != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine(qa.answer);
                        }
                        Console.WriteLine();
                        Console.Write($"Need more help {nameInput}..(yes or no)");
                        temp = Console.ReadLine();
                        if (temp != "yes")
                        {
                            break;
                        }
                    }
                    Console.WriteLine($"Thank you {nameInput} and stay safe");
                    break;
                // Positive Mood
                case 7:
                case 8:
                case 9:
                case 10:
                    //questionSelector = answerGenerator.Next(positiveQuestions.Length);
                    //Console.Write($"{positiveQuestions[questionSelector]} : ");
                    ////read in answer? or follow a set script?
                    affirmationslen = affirmations.Length;
                    randAffirmations = answerGenerator.Next(1, affirmationslen);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\n{affirmations[randAffirmations]}");
                    Console.ForegroundColor = ConsoleColor.White;



                    //we can add an array of random text here to say somthing to the user after the random quote is executed

                    break;
            }
            Console.ReadLine();
        }
    }
}