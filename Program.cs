using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Students();
                run = Continue();
            }
        }

        public static void Students()
        {
            int usernum;
            string[] names = new string[19]; //name array 
            names[0] = "Karrar";
            names[1] = "Ronald";
            names[2] = "Laura";
            names[3] = "Brian";
            names[4] = "Levi";
            names[5] = "Steve";
            names[6] = "Kent";
            names[7] = "Stephen";
            names[8] = "Rudy";
            names[9] = "Justin";
            names[10] = "Kendrea";
            names[11] = "Mauricio";
            names[12] = "Noha";
            names[13] = "Evan";
            names[14] = "Jackie";
            names[15] = "Anna";
            names[16] = "Tommy";

            string[] hometown = new string[19]; //hometwon array
            hometown[0] = "San Diego";
            hometown[1] = "Lincoln Park";
            hometown[2] = "Albuquerque";
            hometown[3] = "Bloomfield Hills";
            hometown[4] = "Detroit";
            hometown[5] = "Perryburgh";
            hometown[6] = "Sterling Heights";
            hometown[7] = "Pontiac";
            hometown[8] = "Detriot";
            hometown[9] = "Saganaw";
            hometown[10] = "Oak Park";
            hometown[11] = "Royal Oak";
            hometown[12] = "Windsor";
            hometown[13] = "Waterville, Ohio";
            hometown[14] = "Grosse Point";
            hometown[15] = "Ann Arbor";
            hometown[16] = "Raleigh, North Carolina";

            string[] food = new string[19]; //food array
            food[0] = "Pizza";
            food[1] = "Saganaki";
            food[2] = "Bibimbap";
            food[3] = "Pot Roast";
            food[4] = "Pizza";
            food[5] = "Pizza";
            food[6] = "Pizza";
            food[7] = "Chocolate";
            food[8] = "Salad";
            food[9] = "Burgers";
            food[10] = "Veggie Burger & Fries";
            food[11] = "Chcolate";
            food[12] = "Pizza";
            food[13] = "Grilled Octopus";
            food[14] = "Sushi";
            food[15] = "Chicken Shawarma";
            food[16] = "Chicken Curry";

            Console.WriteLine("Welcome to our C# class.");

            while (true) // while loop for student name
            {
                Console.WriteLine("Which person would you like to learn more about? (Enter a number 0 - 16)");
                try //try for 
                {

                    usernum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Person {0}:", names[usernum]);
                    break;
                }

                catch (IndexOutOfRangeException) //incase user goes out of range it catches these two exeptions
                {
                    Console.WriteLine("That student doesn't exist, try agian");
                    continue;
                }


                catch (FormatException)
                {
                    Console.WriteLine("That student doesn't exist, try agian");
                    continue;
                }

            }

            Console.WriteLine("Would you like to know more about this student? Enter hometown or favoritefood ");
            string input = Console.ReadLine().ToLower();
            while (input != "hometown" && input != "favoritefood")// loop for the hometown/favoritefood validation
            {

                Console.WriteLine("That data type does not exist try agian");


                input = Console.ReadLine().ToLower(); //reading user input
            }

            if (input == "hometown") //if hometown it prints hometown else food
            {
                Console.WriteLine("{0} is from {1}", names[usernum], hometown[usernum]);
            }

            else
            {
                Console.WriteLine("{0}\'s favorite food is {1}", names[usernum], food[usernum]);
            }

        }

        public static bool Continue()//continue method
        {
            Console.WriteLine("Would you like to run this program agian?(y/n)");
            string input = Console.ReadLine().ToLower();
            bool stuff;
            if (input == "y")
            {
                stuff = true;
            }
            else if (input == "n")
            {
                stuff = false; 
            }
            else
            {
                Console.WriteLine("Sorry I didn't catch that. Please try agian (y/n)");
                stuff = Continue();
            }

            return stuff;
        }

    }
}
