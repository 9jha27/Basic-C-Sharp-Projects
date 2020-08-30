using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignmentSixParts
{
    class Program
    {
        static void Main(string[] args)
        {   //PART ONE: Created a one-dimensional array of strings, asked for user input, reated a loop that prints off each string and also the added user's text
            //string[] array = { "I am: ", "I am also: ", "I am still: ", "Ddin't change.. I'm still:" };
            //Console.WriteLine("Please describe yourself in one: ");
            //string userInput = Console.ReadLine();
            //for (int i=0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i] + userInput);
            //}
            //Console.ReadLine();

            //PART TWO: Create an infinite loop

            //with the while loop
            //while (true)
            //{
            //    Console.WriteLine("This will continue until you exit the terminal.");
            //}

            //PART THREE: Create a loop where the comparison is used to determine whether to continue iterating the loop
            //List<int> ages = new List<int>() { 4, 6, 5, 7, 10, 9, 8 };
            //foreach (int age in ages)
            //{
            //    if (age <= 8)
            //    {
            //        Console.WriteLine(age);
            //    }
            //}
            //Console.ReadLine();

            List<int> toppings = new List<int>() { 0, 1, 2, 3, 4, 5};
            foreach (int topping in toppings)
            {
                if (topping < 3)
                {
                    Console.WriteLine("I would like " + topping + " toppings.");
                }
            }
            Console.ReadLine();

            //JUST FOR FUN PRACTICE FOR MYSELF
            //List<string> mountains = new List<string>() { "Shasta", "Hood", "Rainier", "Sisters", "Adams" }; 
            //foreach (string mountain in mountains)
            //{
            //    string mountainLow = mountain.ToLower();
            //    string s = "s";
            //    string r = "r";

            //    if (mountainLow.Contains(s) && mountain.Contains(r))
            //    {
            //        Console.WriteLine("The " + mountain + " has both the letters \"" + s + "\" and \"" + r + "\".");
            //    }
            //}
            //Console.ReadLine();

            //PART FOUR: Create a list of unique strings and ask the user for input. Iterate through the loop to find the text matching the input.
            List<string> drinks = new List<string>() { "beer", "margarita", "gin and tonic", "moscow mule", 
                "vodka and soda", "red wine", "white wine", "water", "soda", "tea", "coffee" };
            Console.WriteLine("What would you like to drink?");
            string drinkInput = Console.ReadLine();
            bool match = false;
            foreach (string drink in drinks)
            {
                if (drinkInput == drink)
                {
                    Console.WriteLine("That drink is in position number: " + drinks.IndexOf(drink)); //displays the index of the array that contains matching text
                    match = true;
                    break;
                }
            }
            if (!match)               
            {
                Console.WriteLine("I'm sorry! Your drink of choice is not on our list.");
            }
            Console.ReadLine();

            

            //PART 5: A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            List<string> animals = new List<string>() { "dog", "cat", "dog", "bird", "mouse", "horse", "goat" };
            Console.WriteLine("Pick one of the following animals to determine the position number: dog, cat, bird, mouse, horse, goat");
            string animalInput = Console.ReadLine();
            bool match1 = false;
            //iterate through loop and display the indices of the array that contains the matching text on the screen
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] == animalInput)
                {
                    Console.WriteLine("That animal is in index number: " + i);
                    match1 = true;
                    continue;
                }
            }
            if (!match1)
            {
                Console.WriteLine("Your animal is not on our list! Sorry :( ");
            }
            
            Console.ReadLine();

            //PART 6: Create a list that has at least two identical strings in the list
            List<string> letters = new List<string>() { "A", "B", "D", "C", "B", "Z", "N", "A"};
            List<string> backupList = new List<string>();


            foreach (string letter in letters)
            {
                Console.WriteLine(letter + " is in our list.");
                foreach (string letter2 in backupList)//add code to tell the user that the text isn't in the list
                {
                    if (letter == letter2)
                    {
                        Console.WriteLine("The letter " + letter + " has occurred before in the list");
                    }
                }
                backupList.Add(letter);
            }

            Console.ReadLine();
            
        }
    }
}
