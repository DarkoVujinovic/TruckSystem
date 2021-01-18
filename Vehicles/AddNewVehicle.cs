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
    public partial class AddNewVehicle : Form
    {
        TruckSystem _parent;

        public AddNewVehicle()
        {
            InitializeComponent();
        }

        public AddNewVehicle(TruckSystem truckSystem)
        {
            InitializeComponent();
            this._parent = truckSystem;
        }

        private void AddVehicle_ApplyButton_Click(object sender, EventArgs e)
        {
            Vehicles vehicle = new Vehicles();

            vehicle.Proizvođač = this.textBox_VhclManufacturer.Text;
            vehicle.TipVozila = this.textBox_VhclType.Text;
            vehicle.OznakaVozila = this.textBox_VhclMark.Text;
            vehicle.RegistarskiBroj = this.textBox_VhclRegPlate.Text;
            vehicle.DatumKupovine = this.dateTimePicker_BuyDate.Value.Date;
            vehicle.DatumRegistracije = this.dateTimePicker_FirstRegDate.Value.Date;
            vehicle.PočetnaKilometraža = this.textBox_VhclOdoStartKM.Text;
            vehicle.BrojŠasije = this.textBox_VhclChasisNo.Text;
            vehicle.DozvoljenaNosivost = this.textBox_VhclMaxPermisMass.Text;
            vehicle.DimenzijePneumatika = this.textBox_VhclTyreDymensions.Text;

            //values from dialog changed, perform update operation

            this._parent.AddVehicle(vehicle);
            this.Close();
        }

        private void AddVehicle_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
