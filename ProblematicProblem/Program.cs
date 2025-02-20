using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Threading.Channels;

namespace ProblematicProblem
{ 
  
    public class Program
    {
        public static Random rng = new Random();
        public static bool cont = true;

        public static List<string> activities = new List<string>()
            { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

       
    



    static void Main(string[] args)
        {
            Console.Write(
                "Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            //bool cont = bool.Parse(Console.ReadLine());
            var userInput = Console.ReadLine();
            if (userInput.ToLower() == "yes")
            {
                bool cont = true;
            }
            else //if (userInput.ToLower() == "no")
            {
                bool cont = false;
                Console.WriteLine("Thank you for your time!");
                Environment.Exit(0); //end program!!
                
            }
            
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Would you like to see the current list of activities? Yes/No thanks: ");
            bool seeList; //= bool.Parse(Console.ReadLine());
            var userInput2 = Console.ReadLine();
            if (userInput2?.ToLower() == "yes")
            {
                seeList = true;
            }
            else //if (userInput.ToLower() == "no")
            {
                seeList = false;
                //Console.WriteLine("thank you for your time");
                //Environment.Exit(0); //end program!!
                
            }
            //Program activities = new Program();
            if (seeList == true)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList;//bool.Parse(Console.ReadLine());
                var userInput3 = Console.ReadLine();
                if (userInput3?.ToLower() == "yes")
                {
                    addToList = true;
                }
                else //if (userInput.ToLower() == "no")
                {
                    addToList = false;
                    //Console.WriteLine("thank you for your time");
                    //Environment.Exit(0); //end program!!
                
                }
                Console.WriteLine();
                while (addToList == true)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    //string addToList2 = bool.Parse(Console.ReadLine());
                    var userInput4 = Console.ReadLine();
                    if (userInput4?.ToLower() == "yes")
                    {
                        addToList = true;
                    }
                    else //if (userInput.ToLower() == "no")
                    {
                        addToList = false;
                        //Console.WriteLine("thank you for your time");
                        //Environment.Exit(0); //end program!!
                
                    }
                }
            }

            while (cont == true)
            {
                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();
                Console.Write("Choosing your random activity");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();
                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];
                if (userAge >= 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");
                    activities.Remove(randomActivity);
                    randomNumber = rng.Next(activities.Count);
                    randomActivity = activities[randomNumber];
                }

                Console.Write(
                    $"Ah got it! {userName}, your random activity is: {randomActivity}! Would you like to see another random activity? Yes/No: ");
                Console.WriteLine();
                //bool cont = bool.Parse(Console.ReadLine());
                var userInput4 = Console.ReadLine();
                if (userInput4?.ToLower() == "yes")
                {
                    Console.WriteLine("Alright, lets connect to the database and try again");
                }
                else //if (userInput.ToLower() == "no")
                {
                    cont = false;
                    Console.WriteLine("Thanks for using this program!\nHave a nice day!");
                    //Environment.Exit(0); //end program!!
                
                }
            }
        }
    }
}
    
