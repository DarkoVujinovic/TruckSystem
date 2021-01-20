using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckSystem
{
    public partial class AddNewInvoice : Form
    {
        TruckSystem _parent;

        public AddNewInvoice()
        {
            InitializeComponent();
        }

        public AddNewInvoice(TruckSystem truckSystem)
        {
            InitializeComponent();
            this._parent = truckSystem;
        }

        private void AddInvoice_ApplyButton_Click(object sender, EventArgs e)
        {
            Invoices invoice = new Invoices();

            invoice.NazivFirme = this.textBox_InvoiceCompanyName.Text;
            invoice.DatumIsporuke = this.dateTimePicker_InvoiceDeliveryDate.Value.Date;
            invoice.OsnovnaCena = this.textBox_InvoiceBaseValue.Text;
            invoice.PDV = this.textBox_InvoiceVAT.Text;
            invoice.KonačnaCena = this.textBox_InvoiceFinalValue.Text;
            invoice.VoziloId = this.textBox_InvoiceVehicle.Text;
            invoice.DriverId = this.textBox_InvoiceDriver.Text;

            //values from dialog changed, perform update operation

            this._parent.AddInvoice(invoice);
            this.Close();
        }

        private void AddInvoice_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
