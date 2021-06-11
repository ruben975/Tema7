using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tema7.Model;

namespace Tema7.Data
{
    public class Tema7Context : DbContext
    {
        public Tema7Context (DbContextOptions<Tema7Context> options)
            : base(options)
        {
        }

        public DbSet<Tema7.Model.Movie> Movie { get; set; }
    }
}
