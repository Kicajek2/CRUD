using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using My_movies.Models;
using System.Data.Entity;

namespace My_movies.DAL 
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("connectionString")
        {

        }
        public DbSet<Movie> Movie { get; set; }
    }
}