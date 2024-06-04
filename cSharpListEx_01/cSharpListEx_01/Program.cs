using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cSharpListEx_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that represent a list of objects that can be accessed by index.
            //          similar to array, but can dynamically increase / decrease in size 
            //          using system.collections.generic.



            //string[] food = new string[3];


            //food[0] = "pizza";
            //food[1] = "hamburger";
            //food[2] = "hotdog";
            //food[3] = "chicken fry"                       // It can not be used in Array that why we need a list to add dynamically.

            List<string> food = new List<string>();

            //food.Add("pizza");
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("Chicken fry");

            //food.Remove("Chicken fry");                   // we can also use remove method in list to remove indivituall data
            //food.Insert(0, "chicken ball");                 // we can also insert data in index wise

            // Console.WriteLine(food.Count);                     //We can use count property to show total index amount

            //Console.WriteLine(food.IndexOf("pizza"));       // We can find indivitual index by useing this
            //Console.WriteLine(food.LastIndexOf("hotdog"));    // to check last index
            //Console.WriteLine(food.Contains("pizza"));          //We can check boolen expression 

            // Console.WriteLine(food[1]);                   // we can also use this in List to output as we want


            //food.Sort();                                      // can sort it
            //food.Reverse();                                   //can reverse it 
            //food.Clear();                                     // we can clear all 

            //string[] foodArray = food.ToArray();              // we can also declar a array

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            
        }
    }
}
