using System;
using System.Collections.Generic;
using System.Text;

namespace TruckSystem
{
    public class Vehicles
    {
        public int VoziloId { get; set; }
        public string Proizvođač { get; set; }
        public string TipVozila { get; set; }
        public string OznakaVozila { get; set; }
        public string RegistarskiBroj { get; set; }
        public DateTime DatumKupovine { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string PočetnaKilometraža { get; set; }
        public string BrojŠasije { get; set; }
        public string DozvoljenaNosivost { get; set; }
        public string DimenzijePneumatika { get; set; }
    }
}
