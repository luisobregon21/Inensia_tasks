using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;


/* 
step 1: console application reads the file 'input.txt'

Step 2: create Class: MovieStar -> each person will be an instance

Step 3: Loop and Display each MovieStar 

Step 4: calculate the age of each actor
*/



namespace Inesia
{
    class Task1
    {
        static void Main(string[] args)
        {
            var MovieStars = listOfMovieStars();
            if (MovieStars != null)
            {
                for (int idx = 0; idx < MovieStars.Count; idx++)
                {
                    MovieStars[idx].actor();
                    Console.WriteLine();
                }
            }
        }

        static List<MovieStar> listOfMovieStars()
        {
            string filePath = "./input.txt";

            if(File.Exists(filePath))
            {
                var MovieStars = JsonConvert.DeserializeObject<List<MovieStar>>(File.ReadAllText(filePath));

                return MovieStars;
            }

            return null;
        }
    }
}