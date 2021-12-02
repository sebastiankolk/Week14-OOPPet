using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MoviesFromFile
{
    class Program
    {
        class Movie
        {
            string name;
            string rating;
            string year;
            public Movie(string _name,string _year,string _rating)
            {
                name = _name;
                year = _year;
                rating = _rating;
            }
            public string Year
            {
                get { return year; }
            }
            public string Name
            {
                get { return name; }
            }
            public string Rating
            {
                get { return rating; }
            }
        }
        static void Main(string[] args)
        {
            List<string> movieListFromFile = getMoviesFromFile().ToList();
            List<Movie> listOfMovies = new List<Movie>();

            foreach(string movieRecord in movieListFromFile)
            {
                string[] tempArray = movieRecord.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);

                listOfMovies.Add(newMovie);
            }
            foreach(Movie movie in listOfMovies)
            {
                Console.WriteLine($"Title: {movie.Name} - Rating: {movie.Rating} - Year: {movie.Year}");
            }
        }
        public static string[] getMoviesFromFile()
        {
            string fullfilePath = @"C:\Users\opilane\samples\movies.txt";

            string[] dataFromFile = File.ReadAllLines(fullfilePath);
            return dataFromFile;
        }
        public static void ShowDataFromArray(string[] somearray)
        {
            foreach(string line in somearray)
            {
                Console.WriteLine(line);
            }
        }
    }
}
