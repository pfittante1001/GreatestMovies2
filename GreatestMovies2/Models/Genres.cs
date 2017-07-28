using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreatestMovies2.Models
{
    public class Genres
    {
        [Key]
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        //This sets up a many to many relationship with Movies
        public ICollection<Movies> Movies { get; set; }
        //will need an ICollection for actors in Movies.cs to set up many to many relationship
    }
}