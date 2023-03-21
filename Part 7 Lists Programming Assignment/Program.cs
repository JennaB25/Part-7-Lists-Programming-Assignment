using System;

namespace Part_7_Lists_Programming_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<int> randomNum = new List<int>() { 24 };           
            for (int i = 0; i < randomNum.Count; i++)
            {
                randomNum[i] = generator.Next(10, 21);               
                Console.WriteLine(randomNum[i]);
            }
                

        }   
    }
}