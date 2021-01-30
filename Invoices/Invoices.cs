using System;
using System.Collections.Generic;
using System.Text;

namespace TruckSystem
{
    public class Invoices
    {
        public int FakturaId { get; set; }
        public string NazivFirme { get; set; }
        public DateTime DatumIsporuke { get; set; }
        public string OsnovnaCena { get; set; }
        public string PDV { get; set; }
        public string KonačnaCena { get; set; }
        public string ImeVozača { get; set; }
        public string NazivVozila { get; set; }
        public string BrojFakture { get; set; }
        public string VoziloId { get; set; }
        public string DriverId { get; set; }
        public string FirmaId { get; set; }
    }
}
