﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TruckSystem
{
    public partial class AddNewInvoice : Form
    {
        TruckSystem _parent;
        public List<Drivers> DriversAndIDs { get; set; }
        public List<Vehicles> VehiclesAndIDs { get; set; }
        public List<Companies> CompaniesAndIDs { get; set; }

        SortedDictionary<string, string> DriversAndIdsMap = new SortedDictionary<string, string>();
        SortedDictionary<string, string> VehiclesAndIdsMap = new SortedDictionary<string, string>();
        SortedDictionary<string, string> CompaniesAndIdsMap = new SortedDictionary<string, string>();

        public AddNewInvoice()
        {
            InitializeComponent();
        }

        public AddNewInvoice(TruckSystem truckSystem)
        {
            InitializeComponent();
            InsertValuesIntoComboBoxes();

            this._parent = truckSystem;
        }

        private void AddInvoice_ApplyButton_Click(object sender, EventArgs e)
        {
            Invoices invoice = new Invoices();

            // we do not see VoziloId, DriverId and FirmaId in the NewInvoiceForm, but we need this for statistics
            invoice.VoziloId = VehiclesAndIdsMap.GetValueOrDefault(this.comboBox_InvoiceVehicle.Text.ToString());
            invoice.DriverId = DriversAndIdsMap.GetValueOrDefault(this.comboBox_InvoiceDriver.Text.ToString());
            invoice.FirmaId = CompaniesAndIdsMap.GetValueOrDefault(this.comboBox_InvoiceCompanyName.Text.ToString());

            invoice.NazivFirme = this.comboBox_InvoiceCompanyName.Text;
            invoice.DatumIsporuke = this.dateTimePicker_InvoiceDeliveryDate.Value.Date;
            invoice.Kilometraža = this.textBox_InvoiceMileage.Text;
            invoice.BrojIstovara = this.textBox_InvoiceUnloadingNumber.Text;
            invoice.OsnovnaCena = this.textBox_InvoiceBaseValue.Text;
            invoice.PDV = this.textBox_InvoiceVAT.Text;
            invoice.KonačnaCena = this.textBox_InvoiceFinalValue.Text;
            invoice.NazivVozila = this.comboBox_InvoiceVehicle.Text;
            invoice.ImeVozača = this.comboBox_InvoiceDriver.Text;
            invoice.BrojFakture = this.textBox_InvoiceNumber.Text;
            invoice.Plaćeno = this.comboBox_InvoiceIsPayed.Text;
            invoice.VrstaPlaćanja = this.comboBox_InvoicePaymentType.Text;

            //values from dialog changed, perform update operation

            this._parent.AddInvoice(invoice);
            this.Close();
        }

        private void AddInvoice_CancelButton_Click(object sender, EventArgs e)
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
                this.comboBox_InvoiceDriver.Items.Add(item.Ime.ToString() + " " + item.Prezime.ToString());
                DriversAndIdsMap.Add(item.Ime.ToString() + " " + item.Prezime.ToString(), item.DriverId.ToString());
            }
            this.comboBox_InvoiceDriver.Text = "Odaberite vozača"; // this.comboBox_InvoiceDriver.Items[0].ToString();

            foreach (Vehicles item in VehiclesAndIDs)
            {
                this.comboBox_InvoiceVehicle.Items.Add(item.Proizvođač.ToString() + " " + item.TipVozila.ToString() + " - " + item.RegistarskiBroj.ToString());
                VehiclesAndIdsMap.Add(item.Proizvođač.ToString() + " " + item.TipVozila.ToString() + " - " + item.RegistarskiBroj.ToString(), item.VoziloId.ToString());
            }
            this.comboBox_InvoiceVehicle.Text = "Odaberite vozilo"; // this.comboBox_InvoiceVehicle.Items[0].ToString();

            foreach (Companies item in CompaniesAndIDs)
            {
                this.comboBox_InvoiceCompanyName.Items.Add(item.NazivFirme.ToString() + " - PIB:" + item.PIB.ToString());
                CompaniesAndIdsMap.Add(item.NazivFirme.ToString() + " - PIB:" + item.PIB.ToString(), item.FirmaId.ToString());
            }
            this.comboBox_InvoiceCompanyName.Text = "Odaberite firmu"; // this.comboBox_InvoiceCompanyName.Items[0].ToString();

            // add to IsPayed Combo
            this.comboBox_InvoiceIsPayed.Items.Add("Ne");
            this.comboBox_InvoiceIsPayed.Items.Add("Da");

            // add to PaymentType Combo
            this.comboBox_InvoicePaymentType.Items.Add("Keš");
            this.comboBox_InvoicePaymentType.Items.Add("Račun");
        }
    }
}
