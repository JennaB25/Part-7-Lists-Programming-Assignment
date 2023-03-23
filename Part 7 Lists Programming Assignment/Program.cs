﻿//    _ _____  _      _      ____ 
//   / |/  __// \  /|/ \  /|/  _ \
//   | ||  \  | |\ ||| |\ ||| / \|
///\_| ||  /_ | | \||| | \||| |-||
//\____/\____\\_/  \|\_/  \|\_/ \|
//////////////////////////////////
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;
using static System.Formats.Asn1.AsnWriter;

namespace Part_7_Lists_Programming_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Part One: List of Integers");
                Console.WriteLine("2 - Part Two: List of Strings");
                Console.WriteLine("---------------");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();

                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                if (choice == "1")
                {
                    Console.WriteLine("You chose Part One: List of Integers");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    PartOne();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose Part Two: List of Strings");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    PartTwo();
                }                
                else if (choice == "q")
                {
                    choice = "q";
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
        public static void PartOne()
        {
            //Part 1: List of Integers//
            Console.Clear();
            Random generator = new Random();
            string choice = "";
            string num;
            int num_;
            int randomTotal = 0;
            while (choice != "q")
            {
                List<int> randomNum = new List<int>();
                Console.WriteLine("                          ----Random-Numbers----");
                for (int i = 0; i < 25; i++)
                {
                    randomNum.Add(generator.Next(10, 21));
                    Console.Write(randomNum[i] + ",");
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1: Sort the list");
                Console.WriteLine("2: Make a new list of random numbers");
                Console.WriteLine("3: Remove a number");
                Console.WriteLine("4: Add a number");
                Console.WriteLine("5: Count the number of a specified number");
                Console.WriteLine("6: Print the largest value");
                Console.WriteLine("7: Print the smallest value");
                Console.WriteLine("8: Print the sum and average");
                Console.WriteLine("Q: Quit");
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                if (choice == "1")
                {
                    randomNum.Sort();
                    for (int i = 0; i < 25; i++)
                    {
                        Console.Write(randomNum[i] + ",");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Hit Enter to return to main menu:");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == "2")
                {
                    randomNum.Clear();
                    for (int i = 0; i < 25; i++)
                    {
                        randomNum.Add(generator.Next(10, 21));
                        Console.Write(randomNum[i] + ",");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Hit Enter to return to main menu:");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Type the number you want removed:");
                    num = Console.ReadLine();
                    if (Int32.TryParse(num, out int result))
                    {
                        num_ = Convert.ToInt32(num);
                        //randomNum.RemoveAll(num_);
                        for (int i = 0; i < 24; i++)
                        {
                            Console.Write(randomNum[i] + ",");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Hit Enter to return to main menu:");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, press ENTER to continue.");
                        Console.ReadLine();
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Type the number you want added:");
                    num = Console.ReadLine();
                    if (Int32.TryParse(num, out int result))
                    {
                        num_ = Convert.ToInt32(num);
                        randomNum.Add(num_);
                        for (int i = 0; i < 26; i++)
                        {
                            Console.Write(randomNum[i] + ",");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Hit Enter to return to main menu:");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, press ENTER to continue.");
                        Console.ReadLine();
                    }
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Type the number you want to be checked for:");
                    num = Console.ReadLine();
                    if (Int32.TryParse(num, out int result))
                    {
                        num_ = Convert.ToInt32(num);
                        //randomNum.FindAll(num_);
                        //Console.WriteLine($"There are {containsNum} number {num_} in this line");
                        Console.WriteLine("");
                        Console.WriteLine("Hit Enter to return to main menu:");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, press ENTER to continue.");
                        Console.ReadLine();
                    }
                }
                else if (choice == "6")
                {
                    randomNum.Sort();
                    Console.WriteLine($"The largest value is: {randomNum[randomNum.Count - 1]}");
                    Console.WriteLine("");
                    Console.WriteLine("Hit Enter to return to main menu:");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == "7")
                {
                    randomNum.Sort();
                    Console.WriteLine($"The smallest value is: {randomNum[0]}");
                    Console.WriteLine("");
                    Console.WriteLine("Hit Enter to return to main menu:");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == "8")
                {
                    for (int i = 0; i < 25; i++)
                    {
                        randomTotal += randomNum[i];
                    }
                    Console.Write($"The total sum is: {randomTotal}");
                    Console.WriteLine("");
                    Console.WriteLine($"The average is: {randomTotal / 25}");
                    Console.WriteLine("");
                    Console.WriteLine("Hit Enter to return to main menu:");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == "q")
                {
                    choice = "q";
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }

            }
        }
        
        public static void PartTwo()
        {
            //Part 2: List of Strings//
            Console.Clear();
            string choice = "";
            string input;
            bool done = false;
            List<string> vegNames = new List<string>() { "", "CABBAGE", "CARROT", "CELERY", "MUSHROOM", "POTATO" };
            while (choice != "q")
            {               
                Console.WriteLine("----Vegetables----");
                for (int i = 1; i < vegNames.Count; i++)
                {
                    Console.WriteLine(i + "-" + vegNames[i]);
                }
                Console.WriteLine("");                
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1: Remove a vegetable by index");
                Console.WriteLine("2: Remove a vegetable by value");
                Console.WriteLine("3: Search for a vegetable");
                Console.WriteLine("4: Add a vegetable");
                Console.WriteLine("5: Sort list");
                Console.WriteLine("Q: Quit");
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                if (choice == "1")
                {

                }
                else if (choice == "2")
                {

                }
                else if (choice == "3")
                {
                    Console.WriteLine("Enter the vegetable you want to locate:");
                    input = Console.ReadLine().ToUpper();
                    if (vegNames.Contains(input))
                    {
                        //Console.WriteLine($"It is included at position: {}");
                    }
                    else
                    {
                        Console.WriteLine("The vegetable specified is not included");
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Type the vegetable you want added:");
                    while (!done)
                    {
                        input = Console.ReadLine().ToUpper();
                        if (vegNames.Contains(input))
                        {
                            Console.WriteLine("Error: Enter choice again");
                        }
                        else
                        {
                            vegNames.Add(input);
                            Console.Clear();
                            for (int i = 1; i < vegNames.Count; i++)
                            {
                                Console.WriteLine(i + "-" + vegNames[i]);
                            }
                            done = true;
                        }                       
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Hit Enter to return to main menu:");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == "5")
                {
                    vegNames.Sort();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(vegNames[i]);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Hit Enter to return to main menu:");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == "q")
                {
                    choice = "q";
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}