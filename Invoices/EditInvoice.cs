using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TruckSystem
{
    public partial class EditInvoice : Form
    {
        private Invoices OriginalCopy;
        public List<Drivers> DriversAndIDs { get; set; }
        public List<Vehicles> VehiclesAndIDs { get; set; }
        public List<Companies> CompaniesAndIDs { get; set; }

        SortedDictionary<string, string> DriversAndIdsMap = new SortedDictionary<string, string>();
        SortedDictionary<string, string> VehiclesAndIdsMap = new SortedDictionary<string, string>();
        SortedDictionary<string, string> CompaniesAndIdsMap = new SortedDictionary<string, string>();

        private static int invoiceId;
        private static string sVoziloId;
        private static string sDriverId;

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

            this.dateTimePicker_EditInvoiceDeliveryDate.Value = invoice.DatumIsporuke;
            this.textBox_EditInvoiceBaseValue.Text = invoice.OsnovnaCena;
            this.textBox_EditInvoiceVAT.Text = invoice.PDV;
            this.textBox_EditInvoiceFinalValue.Text = invoice.KonačnaCena;
            this.textBox_EditInvoiceNumber.Text = invoice.BrojFakture;
            this.textBox_EditInvoiceMileage.Text = invoice.Kilometraža;
            this.textBox_EditInvoiceUnloadingNumber.Text = invoice.BrojIstovara;

            // insert into ComboBox and fetch from Invoice class
            InsertValuesIntoComboBoxes();

            this.comboBox_EditInvoiceVehicle.Text = invoice.NazivVozila;
            this.comboBox_EditInvoiceDriver.Text = invoice.ImeVozača;
            this.comboBox_EditInvoiceCompanyName.Text = invoice.NazivFirme;
            this.comboBox_EditInvoiceIsPayed.Text = invoice.Plaćeno;
            this.comboBox_EditInvoicePaymentType.Text = invoice.VrstaPlaćanja;



            sVoziloId = invoice.VoziloId;
            sDriverId = invoice.DriverId;
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
                invoice.DriverId == OriginalCopy.DriverId &&
                invoice.FirmaId == OriginalCopy.FirmaId &&
                invoice.BrojFakture == OriginalCopy.BrojFakture &&
                invoice.NazivVozila == OriginalCopy.NazivVozila &&
                invoice.ImeVozača == OriginalCopy.ImeVozača &&
                invoice.Kilometraža == OriginalCopy.Kilometraža &&
                invoice.BrojIstovara == OriginalCopy.BrojIstovara &&
                invoice.Plaćeno == OriginalCopy.Plaćeno &&
                invoice.VrstaPlaćanja == OriginalCopy.VrstaPlaćanja
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

            invoice.NazivFirme = this.comboBox_EditInvoiceCompanyName.Text;
            invoice.DatumIsporuke = this.dateTimePicker_EditInvoiceDeliveryDate.Value.Date;
            invoice.Kilometraža = this.textBox_EditInvoiceMileage.Text;
            invoice.BrojIstovara = this.textBox_EditInvoiceUnloadingNumber.Text;
            invoice.OsnovnaCena = this.textBox_EditInvoiceBaseValue.Text;
            invoice.PDV = this.textBox_EditInvoiceVAT.Text;
            invoice.KonačnaCena = this.textBox_EditInvoiceFinalValue.Text;
            invoice.BrojFakture = this.textBox_EditInvoiceNumber.Text;
            invoice.NazivVozila = this.comboBox_EditInvoiceVehicle.Text;
            invoice.Plaćeno = this.comboBox_EditInvoiceIsPayed.Text;
            invoice.VrstaPlaćanja = this.comboBox_EditInvoicePaymentType.Text;
            invoice.ImeVozača = this.comboBox_EditInvoiceDriver.Text; 
            invoice.VoziloId = VehiclesAndIdsMap.GetValueOrDefault(this.comboBox_EditInvoiceVehicle.Text.ToString());
            invoice.DriverId = DriversAndIdsMap.GetValueOrDefault(this.comboBox_EditInvoiceDriver.Text.ToString());
            invoice.FirmaId = CompaniesAndIdsMap.GetValueOrDefault(this.comboBox_EditInvoiceCompanyName.Text.ToString());

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

        private static List<Drivers> LoadDriversFromDriversTable()
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);

            try
            {
                sqlConn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            // SQL query
            string strQuery = "SELECT * FROM Drivers";
            SqlCommand command = new SqlCommand(strQuery, sqlConn);

            SqlDataReader dataReader = command.ExecuteReader();
            var list = new List<Drivers>();

            while (dataReader.Read())
            {
                Drivers drivers = new Drivers();

                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (!(dataReader[i] is DBNull))
                    {
                        switch (i)
                        {
                            case 0:
                                drivers.DriverId = (int)dataReader[i];
                                break;
                            case 1:
                                drivers.Ime = dataReader[i].ToString();
                                break;
                            case 2:
                                drivers.Prezime = dataReader[i].ToString();
                                break;
                        }
                    }
                }

                list.Add(drivers);
            }

            sqlConn.Close();

            return list;
        }

        private static List<Vehicles> LoadVehiclesFromTrucksTable()
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);

            try
            {
                sqlConn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            // SQL query
            string strQuery = "SELECT * FROM Trucks";
            SqlCommand command = new SqlCommand(strQuery, sqlConn);

            SqlDataReader dataReader = command.ExecuteReader();
            var list = new List<Vehicles>();

            while (dataReader.Read())
            {
                Vehicles vehicles = new Vehicles();

                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (!(dataReader[i] is DBNull))
                    {
                        switch (i)
                        {
                            case 0:
                                vehicles.VoziloId = (int)dataReader[i];
                                break;
                            case 1:
                                vehicles.Proizvođač = dataReader[i].ToString();
                                break;
                            case 2:
                                vehicles.TipVozila = dataReader[i].ToString();
                                break;
                            case 4:
                                vehicles.RegistarskiBroj = dataReader[i].ToString();
                                break;
                        }
                    }
                }

                list.Add(vehicles);
            }

            sqlConn.Close();

            return list;
        }

        private static List<Companies> LoadCompaniesFromCompaniesTable()
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);

            try
            {
                sqlConn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            // SQL query
            string strQuery = "SELECT * FROM Companies";
            SqlCommand command = new SqlCommand(strQuery, sqlConn);

            SqlDataReader dataReader = command.ExecuteReader();
            var list = new List<Companies>();

            while (dataReader.Read())
            {
                Companies companies = new Companies();

                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (!(dataReader[i] is DBNull))
                    {
                        switch (i)
                        {
                            case 0:
                                companies.FirmaId = (int)dataReader[i];
                                break;
                            case 1:
                                companies.NazivFirme = dataReader[i].ToString();
                                break;
                            case 3:
                                companies.Grad = dataReader[i].ToString();
                                break;
                            case 5:
                                companies.PIB = dataReader[i].ToString();
                                break;
                        }
                    }
                }

                list.Add(companies);
            }

            sqlConn.Close();

            return list;
        }

        private void InsertValuesIntoComboBoxes()
        {
            DriversAndIDs = LoadDriversFromDriversTable();
            VehiclesAndIDs = LoadVehiclesFromTrucksTable();
            CompaniesAndIDs = LoadCompaniesFromCompaniesTable();

            foreach (Drivers item in DriversAndIDs)
            {
                this.comboBox_EditInvoiceDriver.Items.Add(item.Ime.ToString() + " " + item.Prezime.ToString());
                DriversAndIdsMap.Add(item.Ime.ToString() + " " + item.Prezime.ToString(), item.DriverId.ToString());
            }
            //this.comboBox_EditInvoiceDriver.Text = "Odaberite vozača"; // this.comboBox_InvoiceDriver.Items[0].ToString();

            foreach (Vehicles item in VehiclesAndIDs)
            {
                this.comboBox_EditInvoiceVehicle.Items.Add(item.Proizvođač.ToString() + " " + item.TipVozila.ToString() + " - " + item.RegistarskiBroj.ToString());
                VehiclesAndIdsMap.Add(item.Proizvođač.ToString() + " " + item.TipVozila.ToString() + " - " + item.RegistarskiBroj.ToString(), item.VoziloId.ToString());
            }
            //this.comboBox_EditInvoiceVehicle.Text = "Odaberite vozilo"; // this.comboBox_InvoiceVehicle.Items[0].ToString();

            foreach (Companies item in CompaniesAndIDs)
            {
                this.comboBox_EditInvoiceCompanyName.Items.Add(item.NazivFirme.ToString() + " - PIB:" + item.PIB.ToString());
                CompaniesAndIdsMap.Add(item.NazivFirme.ToString() + " - PIB:" + item.PIB.ToString(), item.FirmaId.ToString());
            }
            //this.comboBox_EditInvoiceCompanyName.Text = "Odaberite firmu"; // this.comboBox_EditInvoiceCompanyName.Items[0].ToString();

            // add to IsPayed Combo
            this.comboBox_EditInvoiceIsPayed.Items.Add("Ne");
            this.comboBox_EditInvoiceIsPayed.Items.Add("Da");

            // add to PaymentType Combo
            this.comboBox_EditInvoicePaymentType.Items.Add("Keš");
            this.comboBox_EditInvoicePaymentType.Items.Add("Račun");

        }
    }
}
