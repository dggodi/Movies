using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies1.Model
{
    public class MoviesDB : DbContext
    {
        public MoviesDB() : base("name=MoviesContext") { }
    }
}
