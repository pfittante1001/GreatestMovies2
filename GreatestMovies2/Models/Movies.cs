using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GreatestMovies2.Models
{
    public class Movies
    {
        [Key]

        public int MovieID { get; set; }
        public string Title { get; set; }
        public DateTime RelDate { get; set; }
        public double BoxOfficeGross { get; set; }

        //This sets up a many to many relationship with Actors 
        //Do not and cannot use foriegnKey on many to many relationships 
        public int ActorID { get; set; }
        public Actors Actors { get; set; }
        //will need an ICollection for actors in Actors.cs to set up many to many relationship
        public ICollection<Actors> Actor { get; set; }

        //This sets up a many to many relationship with Genre
        [ForeignKey("Genres")]
        public int GenreID { get; set; }
        public Genres Genre { get; set; }
        //will need an ICollection for actors in Genre.cs to set up many to many relationship
        public ICollection<Genres> Genres { get; set; }
    }
}