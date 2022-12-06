using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final.Models;

    public class ShelterContext : DbContext
    {
        public ShelterContext (DbContextOptions<ShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Final.Models.Animal> Animal { get; set; } = default!;
    }
