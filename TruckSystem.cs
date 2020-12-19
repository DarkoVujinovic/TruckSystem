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
    public partial class TruckSystem : Form
    {
        public List<Drivers> Drivers { get; set; }

        public TruckSystem()
        {
            InitializeComponent();
        }

        private List<Drivers> GetDrivers()
        {
            var list = new List<Drivers>();

            list.Add(new Drivers()
            {
                DriverId = 1,
                Name = "Milan",
                Surname = "Manojlovic",
                LivingAdress = "Branislava Nusica 52",
                LivingPlace = "Stara Pazova",
                Id_CardNumber = "2315647897",
                Id_DrivingLicense = "4564231354",
                MobilePhone = "062627740",
                DateOfBirth = DateTime.Parse("07/09/1990"),
                Working_From_Date = DateTime.Parse("01/02/2013"),
                Salary = 100000.00

            });

            list.Add(new Drivers()
            {
                DriverId = 2,
                Name = "Ilija",
                Surname = "Manojlovic",
                LivingAdress = "Branislava Nusica 52",
                LivingPlace = "Stara Pazova",
                Id_CardNumber = "6346346463",
                Id_DrivingLicense = "44444444444",
                MobilePhone = "062627740",
                DateOfBirth = DateTime.Parse("07/09/1985"),
                Working_From_Date = DateTime.Parse("01/02/2013"),
                Salary = 100000.00

            });

            return list;

        }

        private void LoadDrivers()
        {
            Drivers = GetDrivers();

            var drivers = this.Drivers;
            dataGridView1.DataSource = drivers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDrivers();
        }
    }
}
