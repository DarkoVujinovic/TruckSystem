using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace TruckSystem
{
    public partial class UpdateDriver : Form
    {
        private Drivers OriginalCopy;
        private static int driverId;

        TruckSystem _parent;

        public UpdateDriver()
        {
            InitializeComponent();
        }

        public UpdateDriver(TruckSystem truckSystem)
        {
            InitializeComponent();
            this._parent = truckSystem;
        }

        public void LoadSelectedDriver(Drivers driver)
        {
            OriginalCopy = driver;

            this.textBox1.Text = driver.Ime;
            this.textBox2.Text = driver.Prezime;
            this.textBox3.Text = driver.Adresa;
            this.textBox4.Text = driver.Mesto;
            this.textBox5.Text = driver.BrojLK;
            this.textBox6.Text = driver.BrojVDozvole;
            this.textBox7.Text = driver.Telefon;
            this.dateTimePicker_UpdDriverBirth.Value = driver.DatumRodjenja;
            this.dateTimePicker_UpdWorkFrom.Value = driver.PocetakRada;
            this.textBox10.Text = driver.Plata.ToString();
            driverId = driver.DriverId;
        }

        private void UpdateDriver_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDriver_ApplyButton_Click(object sender, EventArgs e)
        {
            Drivers driver = new Drivers();

            driver.Ime = this.textBox1.Text.ToString();
            driver.Prezime = this.textBox2.Text;
            driver.Adresa = this.textBox3.Text;
            driver.Mesto = this.textBox4.Text;
            driver.BrojLK = this.textBox5.Text;
            driver.BrojVDozvole = this.textBox6.Text;
            driver.Telefon = this.textBox7.Text;
            driver.DatumRodjenja = this.dateTimePicker_UpdDriverBirth.Value.Date;
            driver.PocetakRada = this.dateTimePicker_UpdWorkFrom.Value.Date;
            driver.Plata = Convert.ToDouble(this.textBox10.Text);
            driver.DriverId = driverId;

            // check is something changed in edit Dialog (UpdateDriver)

            if (IsEqual(driver))
            {
                //nothing changed, close dialog
                this.Close();
            }
            else
            {
                //values from dialog changed, perform update operation
                
                this._parent.UpdateDriver(driver);
                this.Close();
            }            
        }

        private bool IsEqual (Drivers driver)
        {
            if( driver.Ime == OriginalCopy.Ime &&
                driver.Prezime == OriginalCopy.Prezime &&
                driver.Adresa == OriginalCopy.Adresa &&
                driver.Mesto == OriginalCopy.Mesto &&
                driver.BrojLK == OriginalCopy.BrojLK &&
                driver.BrojVDozvole == OriginalCopy.BrojVDozvole &&
                driver.Telefon == OriginalCopy.Telefon &&
                driver.DatumRodjenja == OriginalCopy.DatumRodjenja &&
                driver.PocetakRada == OriginalCopy.PocetakRada &&
                driver.Plata == OriginalCopy.Plata
                )
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
