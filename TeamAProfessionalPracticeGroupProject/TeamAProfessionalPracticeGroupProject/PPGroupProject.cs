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
            string userChoice = User.UsersMood();

            Console.WriteLine(nameInput);

            Console.WriteLine(userChoice);

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

            // Question and answer Arrays are now populated with text content from external text files.

            //using switch to excute diffrent commands based on the user input

            switch (userChoice)
            {
                //if the user enters 1 
                case "1":
                    //ask the user for why using the app 
                    Console.WriteLine("what brings you here ?.");
                    //let the user pick a reason from the provided opions ,also we can expand these 
                    Console.WriteLine("bored,need moto,need something to do ");
                    //store the user choice in a string
                    string firstQ = Console.ReadLine();

                    //switch the use choice
                    switch (firstQ)
                    {
                        //if the user pick bored 
                        case "bored":
                        case "Bored":
                        case "boring":
                            //we can add random items in this array to be picked and display it to the user 
                            Console.Write("there are plenty of things to do , how about you ");
                            Random rand = new Random();
                            string[] x = { "play video games", "watch movies", "go clubing ", "Eat food", "listen to music" };
                            int A = rand.Next(x.Length);
                            string[] y = { "study", "clean your room", "do push ups ", "sleep", "jump around " };
                            int B = rand.Next(x.Length);
                            Console.WriteLine(x[A]);
                            while (true)
                            {
                                Console.WriteLine($"So {nameInput.ToUpper()} still bored? yes or no ");
                                string ans = Console.ReadLine();

                                if (ans == "yes")
                                {
                                    Console.WriteLine($"why dont you try to {y[B]}");
                                    Console.WriteLine("we can add more things here");

                                }
                                else
                                {
                                    Console.WriteLine("Great :)");
                                    Console.WriteLine("have a good day ");
                                    
                                    break;
                                }
                            }

                            break;

                        case "need moto":
                            Console.WriteLine("text");
                            Console.WriteLine("watch videos or study etc");
                            Console.WriteLine("some text ");
                            break;
                        case "somthing to do":
                            Console.WriteLine("text");
                            Console.WriteLine("paly games ");
                            Console.WriteLine("have a good day");
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


            Console.ReadLine();
        }
    }
}
