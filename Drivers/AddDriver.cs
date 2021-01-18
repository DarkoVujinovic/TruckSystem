using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TruckSystem
{
    public partial class AddDriver : Form
    {
        TruckSystem _parent;
        public AddDriver()
        {
            InitializeComponent();
        }

        public AddDriver(TruckSystem truckSystem)
        {
            InitializeComponent();
            this._parent = truckSystem;
        }

        private void AddDriver_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDriver_ApplyButton_Click(object sender, EventArgs e)
        {
            Drivers driver = new Drivers();

            driver.Ime = this.textBox1.Text.ToString();
            driver.Prezime = this.textBox2.Text;
            driver.Adresa = this.textBox3.Text;
            driver.Mesto = this.textBox4.Text;
            driver.BrojLK = this.textBox5.Text;
            driver.BrojVDozvole = this.textBox6.Text;
            driver.Telefon = this.textBox7.Text;
            driver.DatumRodjenja = this.dateTimePicker_Birth.Value.Date;
            driver.PocetakRada = this.dateTimePicker_WorkingFrom.Value.Date;
            driver.Plata = Convert.ToDouble(this.textBox10.Text);

            //values from dialog changed, perform update operation

            this._parent.AddDriver(driver);
            this.Close();

        }
    }
}
