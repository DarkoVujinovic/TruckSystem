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
        public decimal OsnovnaCena { get; set; }
        public int PDV { get; set; }
        public decimal KonačnaCena { get; set; }
        public int VoziloId { get; set; }
        public int DriverId { get; set; }
    }
}
