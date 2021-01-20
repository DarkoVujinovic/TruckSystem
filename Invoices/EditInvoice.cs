using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckSystem
{
    public partial class EditInvoice : Form
    {
        private Invoices OriginalCopy;
        private static int invoiceId;

        TruckSystem _parent;

        public EditInvoice()
        {
            InitializeComponent();
        }

        public EditInvoice(TruckSystem truckSystem)
        {
            InitializeComponent();
            this._parent = truckSystem;
        }

        public void LoadSelectedInvoice(Invoices invoice)
        {
            OriginalCopy = invoice;

            this.textBox_EditInvoiceCompanyName.Text = invoice.NazivFirme;
            this.dateTimePicker_EditInvoiceDeliveryDate.Value = invoice.DatumIsporuke;
            this.textBox_EditInvoiceBaseValue.Text = invoice.OsnovnaCena;
            this.textBox_EditInvoiceVAT.Text = invoice.PDV;
            this.textBox_EditInvoiceFinalValue.Text = invoice.KonačnaCena;
            this.textBox_EditInvoiceVehicle.Text = invoice.VoziloId;
            this.textBox_EditInvoiceDriver.Text = invoice.DriverId;
            invoiceId = invoice.FakturaId;
        }

        private bool IsEqual(Invoices invoice)
        {
            if (invoice.NazivFirme == OriginalCopy.NazivFirme &&
                invoice.DatumIsporuke == OriginalCopy.DatumIsporuke &&
                invoice.OsnovnaCena == OriginalCopy.OsnovnaCena &&
                invoice.PDV == OriginalCopy.PDV &&
                invoice.KonačnaCena == OriginalCopy.KonačnaCena &&
                invoice.VoziloId == OriginalCopy.VoziloId &&
                invoice.DriverId == OriginalCopy.DriverId
                )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void EditInvoice_ApplyButton_Click_1(object sender, EventArgs e)
        {
            Invoices invoice = new Invoices();

            invoice.NazivFirme = this.textBox_EditInvoiceCompanyName.Text;
            invoice.DatumIsporuke = this.dateTimePicker_EditInvoiceDeliveryDate.Value.Date;
            invoice.OsnovnaCena = this.textBox_EditInvoiceBaseValue.Text;
            invoice.PDV = this.textBox_EditInvoiceVAT.Text;
            invoice.KonačnaCena = this.textBox_EditInvoiceFinalValue.Text;
            invoice.VoziloId = this.textBox_EditInvoiceVehicle.Text;
            invoice.DriverId = this.textBox_EditInvoiceDriver.Text;
            invoice.FakturaId = invoiceId;

            // check is something changed in edit Dialog (UpdateDriver)

            if (IsEqual(invoice))
            {
                //nothing changed, close dialog
                this.Close();
            }
            else
            {
                //values from dialog changed, perform update operation

                this._parent.EditInvoice(invoice);
                this.Close();
            }
        }

        private void EditInvoice_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
