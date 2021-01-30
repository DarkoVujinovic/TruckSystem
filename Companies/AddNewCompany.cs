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
    public partial class AddNewCompany : Form
    {
        TruckSystem _parent;

        public AddNewCompany()
        {
            InitializeComponent();
        }

        public AddNewCompany(TruckSystem truckSystem)
        {
            InitializeComponent();
            this._parent = truckSystem;
        }

        private void AddCompany_ApplyButton_Click(object sender, EventArgs e)
        {
            Companies companies = new Companies();

            companies.NazivFirme = this.textBox_CompanyName.Text;
            companies.Adresa = this.textBox_CompanyAddress.Text;
            companies.Grad = this.textBox_Company_City_Headq.Text;
            companies.Vlasnik = this.textBox_CompanyOwner.Text;
            companies.PIB = this.textBox_CompanyTaxIdNum.Text;
            companies.BrojBankovnogRačuna = this.textBox_CompanyBankAcctNo.Text;
            companies.KontaktTelefon = this.textBox_CompanyTelephoneNo.Text;
            companies.EMail = this.textBox_CompanyEmail.Text;

            this._parent.AddCompany(companies);
            this.Close();

        }

        private void AddCompany_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
