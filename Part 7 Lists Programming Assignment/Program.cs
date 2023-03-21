using System;
using static System.Formats.Asn1.AsnWriter;

namespace Part_7_Lists_Programming_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            string choice = "";
            string num;
            int num_;
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
                Console.WriteLine("9: Quit");              
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
                }
                else if (choice == "5")
                {

                }
                else if (choice == "6")
                {

                }
                else if (choice == "7")
                {

                }
                else if (choice == "8")
                {

                }
                else if (choice == "9")
                {

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