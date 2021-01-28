﻿using System;

namespace Lab_10___Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie[] movies = new Movie[10];
            movies[0] = new Movie("Monsters Inc.", "animated");
            movies[1] = new Movie("Redline", "animated");
            movies[2] = new Movie("Marriage Story", "drama");
            movies[3] = new Movie("Whiplash", "drama");
            movies[4] = new Movie("Hereditary", "horror");
            movies[5] = new Movie("Gonjiam", "horror");
            movies[6] = new Movie("Alien", "scifi");
            movies[7] = new Movie("Predator", "scifi");
            movies[8] = new Movie("Christmas With The Cranks", "christmas");
            movies[9] = new Movie("Home Alone 2", "christmas");
            char checkFlag = 'y';
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("\nThere are 10 movies in this list.");

            while(checkFlag == 'y')
            {
                string[] categoryArray = { "Animated", "Drama", "Horror", "Scifi" , "Christmas"};
                Console.WriteLine("\nWhat category are you interested in?");
                for (int i = 0; i < categoryArray.Length; i++)
                {
                    Console.WriteLine(i+1 + ". " + categoryArray[i]);
                }
                int categorySelect = int.Parse(Console.ReadLine())-1;
                string category = categoryArray[categorySelect];

                Console.WriteLine();

                foreach(Movie m in movies)
                {
                    if (m.Category.Equals(category.ToLower()))
                    {
                        Console.WriteLine(m.Title);
                    }
                }

                Console.WriteLine("\nContinue? (y/n)");
                checkFlag = char.ToLower(Console.ReadLine()[0]);
            }
        }
    }
}
