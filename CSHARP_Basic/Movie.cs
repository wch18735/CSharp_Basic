﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_Basic
{
    class Movie
    {
        private string name;
        private string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            name = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set { 
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
