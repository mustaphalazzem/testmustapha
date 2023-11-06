using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Reservation 
    {
        public DateTime DateReservation { get; set; }
        [RegularExpression(@"^[1-30]$", ErrorMessage = "Invalid duree de jours!")]
        
        public int DureeJours { get; set; }
        public Locataire Locataire { get; set; }
        public Vehicule Vehicule { get; set; }
     
        public int LocataireKey { get; set; }
  
        public string Vehiculekey { get; set; }

    }
}
