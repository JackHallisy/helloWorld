﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part one greeting statement
            string messageOne = "Hello World!";
            string messageTwo = "I am Spartacus";

            //            //Part two set initial Spartacus attributes
            //            int ageOne = 35;
            //            int ageTwo = 45;
            //            int ageThree = 80;
            //            double heightOne = 72.50;
            //            double heightTwo = 91.45;
            //            float weightOne = 210.0284606f;
            //            float weightTwo = 331.12345678f;
            //            bool isGodLikeOne = true;
            //            bool isGodLikeTwo = false;
            //            char genderMale = 'M';
            //            char genderFemale = 'F';

            //            /*
            //            ////Part three display variable values
            //            //Console.WriteLine(messageOne);
            //            //Console.WriteLine(messageTwo);

            //            ////Part four mathematical operator, bool and char examples
            //            //Console.WriteLine(ageOne + ageTwo);
            //            //Console.WriteLine(heightOne - heightTwo);
            //            //Console.WriteLine(weightOne * weightTwo);
            //            //Console.WriteLine(isGodLikeOne);//bool example
            //            //Console.WriteLine(genderMale);//char example

            //            ////Part five variable reassignment
            //            //ageTwo = 70;
            //            //heightTwo = 35.12345f;
            //            //weightTwo = -429.1234573f;

            //            ////Part six mathematical operator examples
            //            //Console.WriteLine(ageTwo + ageOne);
            //            //Console.WriteLine(heightOne - heightTwo);
            //            //Console.WriteLine(weightOne * weightTwo);
            //            //Console.WriteLine(ageOne + ageTwo);
            //            //Console.WriteLine(ageTwo / ageOne);
            //            //Console.WriteLine(ageTwo % ageOne);
            //            //Console.WriteLine(ageThree / ageOne);
            //            //Console.WriteLine(ageThree % ageOne);

            //            ////Part seven increment and decrament operator examples
            //            //ageTwo = ageTwo + 1;
            //            //Console.WriteLine(ageTwo);
            //            //ageTwo++;
            //            //Console.WriteLine(ageTwo);
            //            //ageTwo--;
            //            //Console.WriteLine(ageTwo);
            //            //Console.WriteLine("pete" != "PETE");*/

            //            //Part eight concatenation example
            //            //Console.WriteLine(messageOne + " " + messageTwo + " .");
            //            //Console.WriteLine("I am "  + ageOne + " years old, and it is " + isGodLikeOne + " that I am godlike.");
            //            //Console.WriteLine("I weight around " + weightOne + "pounds, and I am around " + heightOne + "inches tall,");
            //            //Console.WriteLine("I am {0} years old, and it is {1} that he is a god.", ageOne, isGodLikeOne);
            //            //Console.WriteLine("I am {0} years old, and yes it's {1} I am godlike,", ageOne, isGodLikeOne);
            //            //Console.WriteLine("I weight around {0} pounds, and" I am around { 1} inches tall););

            //            ////Part nine string equality examples
            //            //Console.WriteLine(messageTwo.Equals(messageOne));
            //            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            //            ////Part ten string length examples
            //            //int messOneLength = messageOne.Length;
            //            //int messTwoLength = messageTwo.Length;

            //            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //            //Console.WriteLine("The length of messageTwo is " + messTwoLength);

            //            // //Part eleven conditional example
            //            // string cityOne = "Vesuvius";
            //            // string cityTwo = "Nola";
            //            // string cityThree = "Nuceria";
            //            // int cityOneDistance, cityTwoDistance, cityThreeDistance;

            //            // //Solicit user input
            //            // Console.WriteLine("What is the distance to {0}?", cityOne);
            //            // cityOneDistance = int.Parse(Console.ReadLine());
            //            // Console.WriteLine("What is the distance to " + cityTwo + "?");
            //            // cityTwoDistance = int.Parse(Console.ReadLine());
            //            // Console.WriteLine("What is the distance to Nuceria?");
            //            // cityThreeDistance = int.Parse(Console.ReadLine());

            //            // if ((cityOneDistance <= 125) && ((cityOneDistance < cityTwoDistance) && (cityOneDistance < cityThreeDistance)))
            //            // {
            //            //     Console.WriteLine("We will march to {0}", cityOne);
            //            // }
            //            // if ((cityTwoDistance <= 125) && ((cityTwoDistance < cityOneDistance) && (cityTwoDistance < cityThreeDistance)))
            //            // {
            //            //     Console.WriteLine("We will march to " + cityTwo);
            //            // }
            //            // if ((cityThreeDistance <= 125) && ((cityThreeDistance < cityOneDistance) && (cityThreeDistance < cityTwoDistance)))
            //            //{
            //            //     Console.WriteLine("We will march to {0}", cityThree);

            //            Console.WriteLine("What is your rank soldier?");
            //            string rank = Console.ReadLine().ToLower();

            //            Console.WriteLine("What is your age soldier?");
            //            int age = int.Parse(Console.ReadLine());

            //            Console.WriteLine("What is your job soldier?");
            //            string job = Console.ReadLine().ToLower();

            //            if ((rank == "officer") || (age <= 26))
            //            {
            //                Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //            }
            //            else if ((job == "cook") && (age >= 26))
            //            {
            //                Console.WriteLine("My army has to eat. Pack your pots and pans.");
            //            }

            //            else
            //            {
            //                Console.WriteLine("Sorry, you are staying home.");
            //            }
            //                switch (job)
            //                {
            //                    case "infantry":
            //                        Console.WriteLine("You will carry a sword.");
            //                        break;

            //                    case "archer":
            //                        Console.WriteLine("You will carry a bow and arrow.");
            //                        break;

            //                    case "supply":
            //                        Console.WriteLine("You will carry pots and pans.");
            //                        break;

            //                    case "specialist":
            //                        Console.WriteLine("You will operate the catapult.");
            //                        break;

            //                    default:
            //                        Console.WriteLine("You will ride horseback.");
            //                        break;
            //                }
            //            }

            //        }
            //    }


            //Part twelve array examples
            //string[] foodList = new string[5];

            //foodList[0] = "milk";
            //foodList[1] = "fruit";
            //foodList[2] = "meat";
            //foodList[3] = "wine";
            //foodList[4] = "bread";

            //Console.WriteLine(foodList[0]);

            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);


            //int[] foodAmount = new int[] { 1000, 1000, 2000, 10000, 1500 };
            //Console.WriteLine(foodAmount[0] + ", " + foodAmount[1] + ", " +
            //    foodAmount[2] + ", " + foodAmount[3] + ", " + foodAmount[4]);
            //Console.WriteLine(foodList.Length);


            //string[] elements = messageTwo.Split(' ');
            //Console.WriteLine(elements[0]); // prints "I"
            //Console.WriteLine(elements[1]); // prints "am"
            //Console.WriteLine(elements[2]); // prints "Spartacus"


            //List<string> foodList = new List<string>();
            //foodList.Add("Milk");
            //foodList.Add("Fruit");
            //foodList.Add("Meat");
            //foodList.Add("Wine");
            //foodList.Add("Bread");

            //foodList.Add("Pepsi");
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4], foodList[5]);

            //foodList.Remove("Pepsi");
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

            //foodList.Insert(1, "Pepsi");
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4], foodList[5]);

            //foodList.RemoveAt(1);
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);



            // Part thirteen while loop example

            //This is very important for the project

            //string action = " ";
            //while (action != "exit")
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //string rank = Console.ReadLine();

            //Console.WriteLine("What is your age soldier?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your job soldier?");
            //string job = Console.ReadLine();

            //if ((rank == "officer") || (age <= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else if ((job == "cook") || (age >= 26))
            //{
            //    Console.WriteLine("My army has to eat. Pack your pots and pans");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you are staying home.");

            //}
            //Console.WriteLine("Add another? Type exit to quit");
            //action = Console.ReadLine();

            string action = " ";
            do
            {
                Console.WriteLine("What is your rank soldier?");
                string rank = Console.ReadLine();

                Console.WriteLine("What is your age soldier?");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your job soldier?");
                string job = Console.ReadLine();

                if ((rank == "officer") || (age <= 26))
                {
                    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
                }
                else if ((job == "cook") || (age >= 26))
                {
                    Console.WriteLine("My army has to eat. Pack your pots and pans");
                }
                else
                {
                    Console.WriteLine("Sorry you are staying home.");
                }
                Console.WriteLine("Add another? Type exit to quit");

            }
            Console.WriteLine("add another? Type exit to quit");
            action - Console.ReadLine();

        }while (Action != "exit");



            }
        }
    }

}
