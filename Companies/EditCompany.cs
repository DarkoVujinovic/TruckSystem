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
    public partial class EditCompany : Form
    {
        private Companies OriginalCopy;
        private static int companyId;

        TruckSystem _parent;

        public EditCompany()
        {
            InitializeComponent();
        }

        public EditCompany(TruckSystem truckSystem)
        {
            InitializeComponent();
            this._parent = truckSystem;
        }

        public void LoadSelectedCompany(Companies companies)
        {
            OriginalCopy = companies;

            textBox_EditCompanyName.Text = companies.NazivFirme.ToString();
            textBox_EditCompanyAddress.Text = companies.Adresa.ToString();
            textBox_EditCompanyHeadqCity.Text = companies.Grad.ToString();
            textBox_EditCompanyOwner.Text = companies.Vlasnik.ToString();
            textBox_EditCompanyTaxIdNum.Text = companies.PIB.ToString();
            textBox_EditCompanyBankAcct.Text = companies.BrojBankovnogRačuna.ToString();
            textBox_EditCompanyPhoneNo.Text = companies.KontaktTelefon.ToString();
            textBox_EditCompanyEmail.Text = companies.EMail.ToString();
            companyId = companies.FirmaId;

        }

        private void EditCompany_ApplyButton_Click(object sender, EventArgs e)
        {
            Companies companies = new Companies();

            companies.NazivFirme = textBox_EditCompanyName.Text;
            companies.Adresa = textBox_EditCompanyAddress.Text;
            companies.Grad = textBox_EditCompanyHeadqCity.Text;
            companies.Vlasnik = textBox_EditCompanyOwner.Text;
            companies.PIB = textBox_EditCompanyTaxIdNum.Text;
            companies.BrojBankovnogRačuna = textBox_EditCompanyBankAcct.Text;
            companies.KontaktTelefon = textBox_EditCompanyPhoneNo.Text;
            companies.EMail = textBox_EditCompanyEmail.Text;
            companies.FirmaId = companyId;

            // check is something changed in edit Dialog (EditCompany)

            if (IsEqual(companies))
            {
                //nothing changed, close dialog
                this.Close();
            }
            else
            {
                //values from dialog changed, perform update operation

                this._parent.EditCompany(companies);
                this.Close();
            }
        }
        private bool IsEqual(Companies companies)
        {
            if (companies.NazivFirme == OriginalCopy.NazivFirme &&
                companies.Adresa == OriginalCopy.Adresa &&
                companies.Grad == OriginalCopy.Grad &&
                companies.Vlasnik == OriginalCopy.Vlasnik &&
                companies.PIB == OriginalCopy.PIB &&
                companies.BrojBankovnogRačuna == OriginalCopy.BrojBankovnogRačuna &&
                companies.KontaktTelefon == OriginalCopy.KontaktTelefon &&
                companies.EMail == OriginalCopy.EMail
                )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void EditCompany_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
