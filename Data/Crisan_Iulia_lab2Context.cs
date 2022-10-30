using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crisan_Iulia_lab2.Models;

namespace Crisan_Iulia_lab2.Data
{
    public class Crisan_Iulia_lab2Context : DbContext
    {
        public Crisan_Iulia_lab2Context (DbContextOptions<Crisan_Iulia_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Crisan_Iulia_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Crisan_Iulia_lab2.Models.Publisher> Publisher { get; set; }
    }
}
