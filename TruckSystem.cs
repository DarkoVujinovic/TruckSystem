using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Dapper.Contrib.Extensions;
using NLog;

namespace TruckSystem
{
    public partial class TruckSystem : Form
    {
        public List<Drivers> Drivers { get; set; }
        public List<Vehicles> Vehicles { get; set; }

        public int lastSelectedIndexDrivers = 0;
        public int lastSelectedIndexVehicles = 0;

        public LogFactory logManager = LogManager.LoadConfiguration("nlog.config");
        public Logger log = LogManager.GetCurrentClassLogger();

        public TruckSystem()
        {
            InitializeComponent();
        }

        private static List<Drivers> GetDrivers()
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);

            try
            {
                sqlConn.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }


            // query

            string strQuery = "Select * from Drivers";
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
                                drivers.DriverId = Int32.Parse(dataReader[i].ToString());
                                break;
                            case 1:
                                drivers.Ime = ((string)dataReader[i]).Trim();
                                break;
                            case 2:
                                drivers.Prezime = ((string)dataReader[i]).Trim();
                                break;
                            case 3:
                                drivers.Adresa = ((string)dataReader[i]).Trim();
                                break;
                            case 4:
                                drivers.Mesto = ((string)dataReader[i]).Trim();
                                break;
                            case 5:
                                drivers.BrojLK = ((string)dataReader[i]).Trim();
                                break;
                            case 6:
                                drivers.BrojVDozvole = ((string)dataReader[i]).Trim();
                                break;
                            case 7:
                                drivers.Telefon = ((string)dataReader[i]).Trim();
                                break;
                            case 8:
                                drivers.DatumRodjenja = (DateTime)dataReader[i];
                                break;
                            case 9:
                                drivers.PocetakRada = (DateTime)dataReader[i];
                                break;
                            case 10:
                                drivers.Plata = Double.Parse(((string)dataReader[i]).Trim());
                                break;
                        }
                    }

                }

                list.Add(drivers);
            }

            sqlConn.Close();

            return list;
        }

        private void LoadDrivers()
        {
            // load drivers in dataGridView_Drivers
            Drivers = GetDrivers();
            dataGridView_Drivers.DataSource = Drivers;

            // select last selected column in dataGridView1
            dataGridView_Drivers.CurrentCell = dataGridView_Drivers.Rows[lastSelectedIndexDrivers].Cells[lastSelectedIndexDrivers];
            dataGridView_Drivers.Rows[lastSelectedIndexDrivers].Selected = true; 
        }

        private void LoadVehicles()
        {
            // load vehicles in dataGridView_Vehicles
            Vehicles = GetVehicles();
            dataGridView_Vehicles.DataSource = Vehicles;

            // select last selected column in dataGridView1
            dataGridView_Vehicles.CurrentCell = dataGridView_Vehicles.Rows[lastSelectedIndexVehicles].Cells[lastSelectedIndexVehicles];
            dataGridView_Vehicles.Rows[lastSelectedIndexVehicles].Selected = true;
        }

        private static List<Vehicles> GetVehicles()
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


            // query

            string strQuery = "Select * from Trucks";
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
                                vehicles.VoziloId = Int32.Parse(dataReader[i].ToString());
                                break;
                            case 1:
                                vehicles.Proizvođač = ((string)dataReader[i]).Trim();
                                break;
                            case 2:
                                vehicles.TipVozila = ((string)dataReader[i]).Trim();
                                break;
                            case 3:
                                vehicles.OznakaVozila = ((string)dataReader[i]).Trim();
                                break;
                            case 4:
                                vehicles.RegistarskiBroj = ((string)dataReader[i]).Trim();
                                break;
                            case 5:
                                vehicles.DatumKupovine = (DateTime)dataReader[i];
                                break;
                            case 6:
                                vehicles.DatumRegistracije = (DateTime)dataReader[i];
                                break;
                            case 7:
                                vehicles.PočetnaKilometraža = ((string)dataReader[i]).Trim();
                                break;
                            case 8:
                                vehicles.BrojŠasije = ((string)dataReader[i]).Trim();
                                break;
                            case 9:
                                vehicles.DozvoljenaNosivost = ((string)dataReader[i]).Trim();
                                break;
                            case 10:
                                vehicles.DimenzijePneumatika = ((string)dataReader[i]).Trim();
                                break;
                        }
                    }

                }

                list.Add(vehicles);
            }

            sqlConn.Close();

            return list;
        }

        public void AddDriver(Drivers driver)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);
            SqlCommand command = sqlConn.CreateCommand();

            // query
            command.CommandText = " INSERT INTO Drivers " +
                                    "(name, surname, living_address, living_place," +
                                    " id_cardnumber, id_drivinglicense, mobilephone," +
                                    " dateofbirth, working_from_date, salary)" +
                                    " VALUES (@name, " +
                                    " @surname, " +
                                    " @living_address, " +
                                    " @living_place, " +
                                    " @id_cardnumber, " +
                                    " @id_drivinglicense, " +
                                    " @mobilephone, " +
                                    " @dateofbirth, " +
                                    " @working_from_date, " +
                                    " @salary) ";

            command.Parameters.AddWithValue("@salary", driver.Plata);
            command.Parameters.AddWithValue("@working_from_date", driver.PocetakRada.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@dateofbirth", driver.DatumRodjenja.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@mobilephone", driver.Telefon);
            command.Parameters.AddWithValue("@id_drivinglicense", driver.BrojVDozvole);
            command.Parameters.AddWithValue("@id_cardnumber", driver.BrojLK);
            command.Parameters.AddWithValue("@living_place", driver.Mesto);
            command.Parameters.AddWithValue("@living_address", driver.Adresa);
            command.Parameters.AddWithValue("@surname", driver.Prezime);
            command.Parameters.AddWithValue("@name", driver.Ime);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                command.Connection.Close();
                sqlConn.Close();
                MessageBox.Show(ex.Message);
            }

            sqlConn.Close();
            command.Connection.Close();

            //refresh data
            LoadDrivers();
        }

        public void UpdateDriver(Drivers driver)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);
            SqlCommand command = sqlConn.CreateCommand();
            
            // query
            command.CommandText =   " UPDATE Drivers SET " +
                                    " name = @name, " +
                                    " surname = @surname, " +
                                    " living_address = @living_address, " +
                                    " living_place = @living_place, " +
                                    " id_cardnumber =@id_cardnumber, " +
                                    " id_drivinglicense = @id_drivinglicense, " +
                                    " mobilephone = @mobilephone, " +
                                    " dateofbirth = @dateofbirth, " +
                                    " working_from_date = @working_from_date, " +
                                    " salary = @salary " +
                                    " WHERE driver_id = @driveId ";

            command.Parameters.AddWithValue("@driveId", driver.DriverId);
            command.Parameters.AddWithValue("@salary", driver.Plata);
            command.Parameters.AddWithValue("@working_from_date", driver.PocetakRada.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@dateofbirth", driver.DatumRodjenja.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@mobilephone", driver.Telefon);
            command.Parameters.AddWithValue("@id_drivinglicense", driver.BrojVDozvole);
            command.Parameters.AddWithValue("@id_cardnumber", driver.BrojLK);
            command.Parameters.AddWithValue("@living_place", driver.Mesto);
            command.Parameters.AddWithValue("@living_address", driver.Adresa);
            command.Parameters.AddWithValue("@surname", driver.Prezime);
            command.Parameters.AddWithValue("@name", driver.Ime);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                command.Connection.Close();
                sqlConn.Close();
                MessageBox.Show(ex.Message);
            }

            sqlConn.Close();
            command.Connection.Close();

            //refresh data
            LoadDrivers();
        }

        private void LoadDrivers_button_Click(object sender, EventArgs e)
        {
            LoadDrivers();
        }

        private void UpdateDriver_button_Click(object sender, EventArgs e)
        {
            // get row index 
            int Index = 0;

            try
            {
                Index = dataGridView_Drivers.CurrentCell.RowIndex;
                lastSelectedIndexDrivers = Index;
            }
            catch
            {
                log.Debug("Drivers not loaded correctly, please reload drivers.");
                MessageBox.Show("Molimo prvo učitajte vozače na listu pritiskom na dugme 'Učitaj Vozače'. ", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UpdateDriver ud = new UpdateDriver(this);
            Drivers driver = new Drivers();
            driver = this.Drivers[Index];

            ud.LoadSelectedDriver(driver);
            ud.ShowDialog();
        }

        private void AddDriver_button_Click(object sender, EventArgs e)
        {
            AddDriver addDriver = new AddDriver(this);
            //addDriver.AddNewDriver(driver);
            addDriver.ShowDialog();
        }

        private void LoadVehicles_button_Click(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        private void EditVehicle_button_Click(object sender, EventArgs e)
        {
            // get row index 
            int Index = 0;

            try
            {
                Index = dataGridView_Vehicles.CurrentCell.RowIndex;
                lastSelectedIndexVehicles = Index;
            }
            catch
            {
                log.Debug("Vehicles not loaded correctly, please reload vehicles.");
                MessageBox.Show("Molimo prvo učitajte vozila na listu pritiskom na dugme 'Učitaj Vozila'. ", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            EditVehicle editVehicle = new EditVehicle(this);
            Vehicles vehicle = new Vehicles();
            vehicle = this.Vehicles[Index];

            editVehicle.LoadSelectedVehicle(vehicle);
            editVehicle.ShowDialog();
        }

        private void AddNewVehicle_button_Click(object sender, EventArgs e)
        {
            AddNewVehicle addNewVehicle = new AddNewVehicle(this);
            addNewVehicle.ShowDialog();
        }

        public void AddVehicle(Vehicles vehicle)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);
            SqlCommand command = sqlConn.CreateCommand();

            // query
            command.CommandText = " INSERT INTO Trucks " +
                                    "(truck_manufacturer, truck_type, special_truck_label, license_plate," +
                                    " buy_date, registration_date, odometer_km," +
                                    " chassis_number, load_capacity, tyre_dymension)" +
                                    " VALUES (@truck_manufacturer, " +
                                    " @truck_type, " +
                                    " @special_truck_label, " +
                                    " @license_plate, " +
                                    " @buy_date, " +
                                    " @registration_date, " +
                                    " @odometer_km, " +
                                    " @chassis_number, " +
                                    " @load_capacity, " +
                                    " @tyre_dymension) ";

            command.Parameters.AddWithValue("@truck_manufacturer", vehicle.Proizvođač);
            command.Parameters.AddWithValue("@truck_type", vehicle.TipVozila);
            command.Parameters.AddWithValue("@special_truck_label", vehicle.OznakaVozila);
            command.Parameters.AddWithValue("@license_plate", vehicle.RegistarskiBroj);
            command.Parameters.AddWithValue("@buy_date", vehicle.DatumKupovine.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@registration_date", vehicle.DatumRegistracije.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@odometer_km", vehicle.PočetnaKilometraža);
            command.Parameters.AddWithValue("@chassis_number", vehicle.BrojŠasije);
            command.Parameters.AddWithValue("@load_capacity", vehicle.DozvoljenaNosivost);
            command.Parameters.AddWithValue("@tyre_dymension", vehicle.DimenzijePneumatika);         

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                command.Connection.Close();
                sqlConn.Close();
                MessageBox.Show(ex.Message);
            }

            sqlConn.Close();
            command.Connection.Close();

            //refresh data
            LoadVehicles();
        }

        public void EditVehicle(Vehicles vehicle)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);
            SqlCommand command = sqlConn.CreateCommand();

            // query
            command.CommandText = " UPDATE Trucks SET " +
                                    " truck_manufacturer = @truck_manufacturer, " +
                                    " truck_type = @truck_type, " +
                                    " special_truck_label = @special_truck_label, " +
                                    " license_plate = @license_plate, " +
                                    " buy_date =@buy_date, " +
                                    " registration_date = @registration_date, " +
                                    " odometer_km = @odometer_km, " +
                                    " chassis_number = @chassis_number, " +
                                    " load_capacity = @load_capacity, " +
                                    " tyre_dymension = @tyre_dymension " +
                                    " WHERE truck_id = @truck_id ";

            command.Parameters.AddWithValue("@truck_id", vehicle.VoziloId);
            command.Parameters.AddWithValue("@truck_manufacturer", vehicle.Proizvođač);
            command.Parameters.AddWithValue("@truck_type", vehicle.TipVozila);
            command.Parameters.AddWithValue("@special_truck_label", vehicle.OznakaVozila);
            command.Parameters.AddWithValue("@license_plate", vehicle.RegistarskiBroj);
            command.Parameters.AddWithValue("@buy_date", vehicle.DatumKupovine.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@registration_date", vehicle.DatumRegistracije.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@odometer_km", vehicle.PočetnaKilometraža);
            command.Parameters.AddWithValue("@chassis_number", vehicle.BrojŠasije);
            command.Parameters.AddWithValue("@load_capacity", vehicle.DozvoljenaNosivost);
            command.Parameters.AddWithValue("@tyre_dymension", vehicle.DimenzijePneumatika);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                command.Connection.Close();
                sqlConn.Close();
                MessageBox.Show(ex.Message);
            }

            sqlConn.Close();
            command.Connection.Close();

            //refresh data
            LoadVehicles();
        }

        private void LoadInvoices_button_Click(object sender, EventArgs e)
        {

        }

        private void EditInvoice_button_Click(object sender, EventArgs e)
        {
            
        }

        private void AddNewInvoice_button_Click(object sender, EventArgs e)
        {
            AddNewInvoice addNewInvoice = new AddNewInvoice(this);
            addNewInvoice.ShowDialog();
        }
    }
}
