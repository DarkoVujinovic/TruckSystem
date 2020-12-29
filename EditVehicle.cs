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
    public partial class EditVehicle : Form
    {
        private Vehicles OriginalCopy;
        private static int vehicleId;

        TruckSystem _parent;

        public EditVehicle()
        {
            InitializeComponent();
        }

        public EditVehicle(TruckSystem truckSystem)
        {
            InitializeComponent();
            this._parent = truckSystem;
        }

        public void LoadSelectedVehicle(Vehicles vehicle)
        {
            OriginalCopy = vehicle;

            this.textBox_EditVhclManufacturer.Text = vehicle.Proizvođač;
            this.textBox_EditVhclType.Text = vehicle.TipVozila;
            this.textBox_EditVhclMark.Text = vehicle.OznakaVozila;
            this.textBox_EditVhclRegPlate.Text = vehicle.RegistarskiBroj;
            this.dateTimePicker_EditBuyDate.Value = vehicle.DatumKupovine;
            this.dateTimePicker_EditFirstRegDate.Value = vehicle.DatumRegistracije;
            this.textBox_EditVhclOdoStartKM.Text = vehicle.PočetnaKilometraža;
            this.textBox_EditVhclChasisNo.Text = vehicle.BrojŠasije;
            this.textBox_EditVhclMaxPermisMass.Text = vehicle.DozvoljenaNosivost;
            this.textBox_EditVhclTyreDymensions.Text = vehicle.DimenzijePneumatika;
            vehicleId = vehicle.VoziloId;
        }

        private void EditVehicle_ApplyButton_Click(object sender, EventArgs e)
        {
            Vehicles vehicle = new Vehicles();

            vehicle.Proizvođač = this.textBox_EditVhclManufacturer.Text;
            vehicle.TipVozila = this.textBox_EditVhclType.Text;
            vehicle.OznakaVozila = this.textBox_EditVhclMark.Text;
            vehicle.RegistarskiBroj = this.textBox_EditVhclRegPlate.Text;
            vehicle.DatumKupovine = this.dateTimePicker_EditBuyDate.Value.Date;
            vehicle.DatumRegistracije = this.dateTimePicker_EditFirstRegDate.Value.Date;
            vehicle.PočetnaKilometraža = this.textBox_EditVhclOdoStartKM.Text;
            vehicle.BrojŠasije = this.textBox_EditVhclChasisNo.Text;
            vehicle.DozvoljenaNosivost = this.textBox_EditVhclMaxPermisMass.Text;
            vehicle.DimenzijePneumatika = this.textBox_EditVhclTyreDymensions.Text;
            vehicle.VoziloId = vehicleId;

            // check is something changed in edit Dialog (UpdateDriver)

            if (IsEqual(vehicle))
            {
                //nothing changed, close dialog
                this.Close();
            }
            else
            {
                //values from dialog changed, perform update operation

                this._parent.EditVehicle(vehicle);
                this.Close();
            }
        }
        private bool IsEqual(Vehicles vehicle)
        {
            if (vehicle.Proizvođač == OriginalCopy.Proizvođač &&
                vehicle.TipVozila == OriginalCopy.TipVozila &&
                vehicle.OznakaVozila == OriginalCopy.OznakaVozila &&
                vehicle.RegistarskiBroj == OriginalCopy.RegistarskiBroj &&
                vehicle.DatumKupovine == OriginalCopy.DatumKupovine &&
                vehicle.DatumRegistracije == OriginalCopy.DatumRegistracije &&
                vehicle.PočetnaKilometraža == OriginalCopy.PočetnaKilometraža &&
                vehicle.BrojŠasije == OriginalCopy.BrojŠasije &&
                vehicle.DozvoljenaNosivost == OriginalCopy.DozvoljenaNosivost &&
                vehicle.DimenzijePneumatika == OriginalCopy.DimenzijePneumatika
                )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void EditVehicle_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
