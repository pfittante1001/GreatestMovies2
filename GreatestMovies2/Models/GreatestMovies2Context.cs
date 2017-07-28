using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GreatestMovies2.Models
{
    public class GreatestMovies2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public GreatestMovies2Context() : base("name=GreatestMovies2Context")
        {
        }

        public System.Data.Entity.DbSet<GreatestMovies2.Models.Actors> Actors { get; set; }

        public System.Data.Entity.DbSet<GreatestMovies2.Models.Genres> Genres { get; set; }

        public System.Data.Entity.DbSet<GreatestMovies2.Models.Movies> Movies { get; set; }
    }
}
