using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Ch3Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Console.WriteLine("Enter a sentence:");
            string myString = Console.ReadLine().ToLower();
            
            char[] myArray = myString.ToCharArray();

            Dictionary<char, int> myDictionary = new Dictionary<char, int>();

            foreach (char myChar in myArray)
            {
                if (Char.IsLetter(myChar))
                {
                    if (myDictionary.ContainsKey(myChar))
                    {
                        myDictionary[myChar]++;
                    }
                    else
                    {
                        myDictionary.Add(myChar, 1);
                    }
                }
            }
            foreach (char key in myDictionary.Keys)
            {
                Console.WriteLine(key + ": " + myDictionary[key]);
            }
        }
    }
}
