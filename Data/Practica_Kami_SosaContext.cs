using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practica_Kami_Sosa.Models;

    public class Practica_Kami_SosaContext : DbContext
    {
        public Practica_Kami_SosaContext (DbContextOptions<Practica_Kami_SosaContext> options)
            : base(options)
        {
        }
    //Aumentar la tabla dentro del contexto
        public DbSet<Practica_Kami_Sosa.Models.Burger> Burger { get; set; } = default!;
        public DbSet<Practica_Kami_Sosa.Models.Promo> Promo { get; set; } = default!;

}
