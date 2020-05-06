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
            Console.WriteLine($"Hi {NameInput}, How you felling today? /n if you feeling ok enter 1 or enter 2 if you feel unwell");
            string userchoice = Console.ReadLine();

            switch (userchoice)
            {
                case "1":

                    Console.WriteLine("what brings you here ?.");
                    Console.WriteLine("bored,need moto,need something to do ");
                    string firstQ = Console.ReadLine();


                    switch (firstQ)
                    {
                        case "bored":
                            Console.WriteLine("quote");
                            Console.WriteLine("there are plenty of thing to do , here are some ");
                            Console.WriteLine("have a good day a good day ");
                            break;
                        case "need moto":
                            Console.WriteLine("quote");
                            Console.WriteLine("watch videos or study etc");
                            Console.WriteLine("some text ");
                            break;
                        case "somthing to do":
                            Console.WriteLine("quote");
                            Console.WriteLine("paly games ");
                            Console.WriteLine("have a good day a good day ");
                            break;
                    }
                    break;

                case "2":

                    Console.WriteLine("How was you day toady");
                    Console.WriteLine("(Good,Bad,very bad)??");
                    string SecondQ = Console.ReadLine();

                    switch (SecondQ)
                    {
                        case "Good":
                        case "good":
                            Console.WriteLine("Had any problems with:");
                            Console.WriteLine("(Family,Frinds,Relationship)");
                            string secFQ = Console.ReadLine();

                            switch (secFQ)
                            {
                                case "family":
                                case "Family":
                                    Console.WriteLine("provide help for problems with family ");
                                    break;

                                case "frinds":
                                case "Frinds":
                                case "frind":
                                    Console.WriteLine("provide help for problems with frinds");
                                    break;
                                case "Relationship":
                                case "GF":
                                case "gf":
                                case "relationship":
                                    Console.WriteLine("provide help for problems with relationships");
                                    break;
                            }
                            break;
                    }
                    break;


            }
            




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



            Console.ReadLine();
        }
    }
}
