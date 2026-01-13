using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Intro_To_CSharp.Basics
{
    internal class Arrays
    {
        public static void DemonstrateArray()
        {
            // Declaration of an Array
            string[] arr = new string[] { "Pikachu", 
                                           "Bulbasuar" , 
                                           "Charmander" , 
                                           "Eevee" , 
                                           "Frokie" };

            // Acessing Array Elements
            Console.WriteLine("First Pokemon: " + arr[0] + "\n");
            Console.WriteLine("List of Pokemons");
            // Accessing all elements using Loop
            for(int x = 1; x < arr.Length; x++)
            {
                Console.WriteLine("Pokemon " + x + ": " + arr[x]);
            }

            // Modifying Array Elements
            Console.WriteLine("\nModifying the last Pokemon to 'Squirtle'\n");
            arr[4] = "Squirtle";
            Console.WriteLine("Updated List of Pokemons");
            for (int x = 0; x < arr.Length; x++)
            {
                Console.WriteLine("Pokemon " + (x + 1) + ": " + arr[x]);
            }
        }
    }
}
