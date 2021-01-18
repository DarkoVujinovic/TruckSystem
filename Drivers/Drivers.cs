using System;
using System.Collections.Generic;
using System.Text;

namespace TruckSystem
{
    public class Drivers
    {
        public int DriverId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Mesto { get; set; }
        public string BrojLK { get; set; }
        public string BrojVDozvole { get; set; }
        public string Telefon { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime PocetakRada { get; set; }
        public double Plata { get; set; }

    }
}
