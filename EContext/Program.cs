using E.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Net.Cache;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Emit;
public class EContext : DbContext
{
    public DbSet<Agent> agent { get; set; }

    public DbSet<Entreprise> etreprise { get; set; }

    public DbSet<Locataire> locataire { get; set; }

    public DbSet<Personne> personne { get; set; }
    public DbSet<Reservation> reservation { get; set; }
    public DbSet<Vehicule> vehicule { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer(@"Data Source=(localdb)\test;Initial Catalog=AirportManagementDB;Integrated Security=true");
        base.OnConfiguring(optionsBuilder);


    }
 
   

}
