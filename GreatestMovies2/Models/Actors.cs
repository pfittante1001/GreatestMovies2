using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreatestMovies2.Models
{
    public class Actors
    {
        [Key]

        public int ActorsID { get; set; }
        public string ActorName { get; set; }
        public DateTime DOB { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }


        //This sets up a many to one relationship with Movies
        //Do not and cannot use foriegnKey on many to many relationships 
        public Movies Movies { get; set; }
        //will need an ICollection for actors in Movies.cs to set up many to many relationship
        public ICollection<Movies> Movie { get; set; }
    }
}