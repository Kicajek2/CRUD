﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_movies.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
    }
}