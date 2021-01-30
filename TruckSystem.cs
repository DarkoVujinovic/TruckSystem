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
        public List<Invoices> Invoices { get; set; }
        public List<Companies> Companies { get; set; }

        public int lastSelectedIndexDrivers = 0;
        public int lastSelectedIndexVehicles = 0;
        public int lastSelectedIndexInvoices = 0;
        public int lastSelectedIndexCompanies = 0;

        public LogFactory logManager = LogManager.LoadConfiguration("nlog.config");
        public Logger log = LogManager.GetCurrentClassLogger();

        public TruckSystem()
        {
            InitializeComponent();
        }

        //-------------------------DRIVERS SECTION BEGIN-------------------------------//
        private static List<Drivers> GetDrivers()
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

            if (lastSelectedIndexDrivers < 0)
            {
                lastSelectedIndexDrivers = 0;
                // select last selected column in dataGridView1
                dataGridView_Drivers.CurrentCell = dataGridView_Drivers.Rows[lastSelectedIndexDrivers].Cells[lastSelectedIndexDrivers];
                dataGridView_Drivers.Rows[lastSelectedIndexDrivers].Selected = true;
            }
            else
            {
                dataGridView_Drivers.CurrentCell = dataGridView_Drivers.Rows[lastSelectedIndexDrivers].Cells[lastSelectedIndexDrivers];
                dataGridView_Drivers.Rows[lastSelectedIndexDrivers].Selected = true;
            }
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
            command.CommandText = " UPDATE Drivers SET " +
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

        private void DeleteDriver_button_Click(object sender, EventArgs e)
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
                log.Debug("Vehicles not loaded correctly, please reload invoices.");
                MessageBox.Show("Molimo prvo učitajte fakture na listu pritiskom na dugme 'Učitaj Fakture'. ", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Drivers drivers = new Drivers();
            drivers = this.Drivers[Index];

            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da obrišete vozača " + drivers.Ime.ToString() + " " + drivers.Prezime.ToString() + " - Dozvola broj: " + drivers.BrojVDozvole.ToString() + "?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                lastSelectedIndexDrivers = lastSelectedIndexDrivers - 1; // lowered by 1, since last index will be deleted soon, we don't want errors
                DeleteDriver(drivers);
            }
        }

        private void DeleteDriver(Drivers drivers)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);
            SqlCommand command = sqlConn.CreateCommand();

            // query
            command.CommandText = "DELETE FROM Drivers where driver_id = @driver_id ";
            command.Parameters.AddWithValue("@driver_id", drivers.DriverId);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                command.Connection.Close();
                sqlConn.Close();
                log.Debug("TruckSystem nije uspeo da obriše Vozača iz baze podataka. Molimo kontaktirajte poršku. ");
                MessageBox.Show("TruckSystem nije uspeo da obriše Vozača iz baze podataka. Molimo kontaktirajte podršku. " + ex.Message);
            }

            sqlConn.Close();
            command.Connection.Close();

            //refresh data
            LoadDrivers();

        }

        //-------------------------DRIVERS SECTION END-------------------------------//

        //-------------------------VEHICLES SECTION BEGIN-------------------------------//

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
        private void LoadVehicles()
        {
            // load vehicles in dataGridView_Vehicles
            Vehicles = GetVehicles();
            dataGridView_Vehicles.DataSource = Vehicles;

            if (lastSelectedIndexVehicles < 0)
            {
                lastSelectedIndexVehicles = 0;
                // select last selected column in dataGridView1
                dataGridView_Vehicles.CurrentCell = dataGridView_Vehicles.Rows[lastSelectedIndexVehicles].Cells[lastSelectedIndexVehicles];
                dataGridView_Vehicles.Rows[lastSelectedIndexVehicles].Selected = true;
            }
            else
            {
                dataGridView_Vehicles.CurrentCell = dataGridView_Vehicles.Rows[lastSelectedIndexVehicles].Cells[lastSelectedIndexVehicles];
                dataGridView_Vehicles.Rows[lastSelectedIndexVehicles].Selected = true;
            }
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

        private void DeleteVehicle_button_Click(object sender, EventArgs e)
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
                log.Debug("Vehicles not loaded correctly, please reload invoices.");
                MessageBox.Show("Molimo prvo učitajte fakture na listu pritiskom na dugme 'Učitaj Fakture'. ", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Vehicles vehicles = new Vehicles();
            vehicles = this.Vehicles[Index];

            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da obrišete vozilo " + vehicles.Proizvođač.ToString() + " " + vehicles.TipVozila.ToString() + " - Registarski broj: " + vehicles.RegistarskiBroj.ToString() +  "?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                lastSelectedIndexVehicles = lastSelectedIndexVehicles - 1; // lowered by 1, since last index will be deleted soon, we don't want errors
                DeleteVehicle(vehicles);
            }
        }

        private void DeleteVehicle(Vehicles vehicle)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);
            SqlCommand command = sqlConn.CreateCommand();

            // query
            command.CommandText = "DELETE FROM Trucks where truck_id = @truck_id ";
            command.Parameters.AddWithValue("@truck_id", vehicle.VoziloId);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                command.Connection.Close();
                sqlConn.Close();
                log.Debug("TruckSystem nije uspeo da obriše Vozilo iz baze podataka. Molimo kontaktirajte poršku. ");
                MessageBox.Show("TruckSystem nije uspeo da obriše Vozilo iz baze podataka. Molimo kontaktirajte podršku. " + ex.Message);
            }

            sqlConn.Close();
            command.Connection.Close();

            //refresh data
            LoadVehicles();

        }

        //-------------------------VEHICLES SECTION END-------------------------------//

        //-------------------------INVOICES SECTION BEGIN-------------------------------//
        private static List<Invoices> GetInvoices()
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
            string strQuery = "SELECT * FROM Invoices";
            SqlCommand command = new SqlCommand(strQuery, sqlConn);

            SqlDataReader dataReader = command.ExecuteReader();
            var list = new List<Invoices>();

            while (dataReader.Read())
            {
                Invoices invoices = new Invoices();

                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (!(dataReader[i] is DBNull))
                    {
                        switch (i)
                        {
                            case 0:
                                invoices.FakturaId = Int32.Parse(dataReader[i].ToString());
                                break;
                            case 1:
                                invoices.NazivFirme = ((string)dataReader[i]).Trim();
                                break;
                            case 2:
                                invoices.DatumIsporuke = (DateTime)dataReader[i];
                                break;
                            case 3:
                                invoices.OsnovnaCena = ((string)dataReader[i]).Trim();
                                break;
                            case 4:
                                invoices.PDV = ((string)dataReader[i]).Trim();
                                break;
                            case 5:
                                invoices.KonačnaCena = ((string)dataReader[i]).Trim();
                                break;
                            case 6:
                                invoices.NazivVozila = dataReader[i].ToString();
                                break;
                            case 7:
                                invoices.ImeVozača = dataReader[i].ToString();
                                break;
                            case 8:
                                invoices.BrojFakture = dataReader[i].ToString();
                                break;
                            case 9:
                                invoices.DriverId = dataReader[i].ToString();
                                break;
                            case 10:
                                invoices.VoziloId = dataReader[i].ToString();
                                break;
                            
                        }
                    }

                }

                list.Add(invoices);
            }

            sqlConn.Close();

            return list;
        }
        private void LoadInvoices()
        {
            // load vehicles in dataGridView_Vehicles
            Invoices = GetInvoices();
            dataGridView_Invoices.DataSource = Invoices;

            // select last selected column in dataGridView1
            if (lastSelectedIndexInvoices < 0)
            {
                lastSelectedIndexInvoices = 0;
                dataGridView_Invoices.CurrentCell = dataGridView_Invoices.Rows[lastSelectedIndexInvoices].Cells[lastSelectedIndexInvoices];
                dataGridView_Invoices.Rows[lastSelectedIndexInvoices].Selected = true;
            }
            else
            {
                dataGridView_Invoices.CurrentCell = dataGridView_Invoices.Rows[lastSelectedIndexInvoices].Cells[lastSelectedIndexInvoices];
                dataGridView_Invoices.Rows[lastSelectedIndexInvoices].Selected = true;
            }
        }
        public void AddInvoice(Invoices invoice)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);
            SqlCommand command = sqlConn.CreateCommand();

            // query
            command.CommandText = " INSERT INTO Invoices " +
                                    "(company_name, delivery_date, base_value, vat," +
                                    " final_value, truck_name, driver_name, invoice_number, driver_id, truck_id, company_id)" +
                                    " VALUES ( " +
                                    " @company_name, " +
                                    " @delivery_date, " +
                                    " @base_value, " +
                                    " @vat, " +
                                    " @final_value, " +
                                    " @truck_name, " +
                                    " @driver_name, " +
                                    " @invoice_number, " +
                                    " @driver_id, " +
                                    " @truck_id, " +
                                    " @company_id) ";

            //command.Parameters.AddWithValue("@invoice_id", invoice.FakturaId);
            command.Parameters.AddWithValue("@company_id", invoice.FirmaId);
            command.Parameters.AddWithValue("@truck_id", invoice.VoziloId);
            command.Parameters.AddWithValue("@driver_id", invoice.DriverId);
            command.Parameters.AddWithValue("@invoice_number", invoice.BrojFakture);
            command.Parameters.AddWithValue("@driver_name", invoice.ImeVozača);
            command.Parameters.AddWithValue("@truck_name", invoice.NazivVozila);
            command.Parameters.AddWithValue("@final_value", invoice.KonačnaCena);
            command.Parameters.AddWithValue("@vat", invoice.PDV);
            command.Parameters.AddWithValue("@base_value", invoice.OsnovnaCena);
            command.Parameters.AddWithValue("@delivery_date", invoice.DatumIsporuke.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@company_name", invoice.NazivFirme);
            

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
            LoadInvoices();
        }
        public void EditInvoice(Invoices invoice)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);
            SqlCommand command = sqlConn.CreateCommand();

            // query
            command.CommandText =   " UPDATE Invoices SET " +
                                    " company_id = @company_id, " +
                                    " truck_id = @truck_id, " +
                                    " driver_id =@driver_id, " +
                                    " invoice_number = @invoice_number, " +
                                    " driver_name = @driver_name, " +
                                    " truck_name = @truck_name, " +
                                    " final_value = @final_value, " +
                                    " vat = @vat, " +
                                    " base_value = @base_value, " +
                                    " delivery_date = @delivery_date, " +
                                    " company_name = @company_name " +
                                    " WHERE invoice_id = @invoice_id ";

            command.Parameters.AddWithValue("@invoice_id", invoice.FakturaId);
            command.Parameters.AddWithValue("@company_id", invoice.FirmaId);
            command.Parameters.AddWithValue("@truck_id", invoice.VoziloId);
            command.Parameters.AddWithValue("@driver_id", invoice.DriverId);
            command.Parameters.AddWithValue("@invoice_number", invoice.BrojFakture);
            command.Parameters.AddWithValue("@driver_name", invoice.ImeVozača);
            command.Parameters.AddWithValue("@truck_name", invoice.NazivVozila);            
            command.Parameters.AddWithValue("@final_value", invoice.KonačnaCena);
            command.Parameters.AddWithValue("@vat", invoice.PDV);
            command.Parameters.AddWithValue("@base_value", invoice.OsnovnaCena);
            command.Parameters.AddWithValue("@delivery_date", invoice.DatumIsporuke.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@company_name", invoice.NazivFirme);

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
            LoadInvoices();
        }
        private void LoadInvoices_button_Click(object sender, EventArgs e)
        {
            LoadInvoices();
        }
        private void EditInvoice_button_Click(object sender, EventArgs e)
        {
            // get row index 
            int Index = 0;

            try
            {
                Index = dataGridView_Invoices.CurrentCell.RowIndex;
                lastSelectedIndexInvoices = Index;
            }
            catch
            {
                log.Debug("Invoices not loaded correctly, please reload invoices.");
                MessageBox.Show("Molimo prvo učitajte fakture na listu pritiskom na dugme 'Učitaj Fakture'. ", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            EditInvoice editInvoice = new EditInvoice(this);
            Invoices invoices = new Invoices();
            invoices = this.Invoices[Index];

            editInvoice.LoadSelectedInvoice(invoices);
            editInvoice.ShowDialog();

        }

        private void AddNewInvoice_button_Click(object sender, EventArgs e)
        {
            AddNewInvoice addNewInvoice = new AddNewInvoice(this);
            addNewInvoice.ShowDialog();
        }

        private void DeleteInvoice_button_Click(object sender, EventArgs e)
        {
            // get row index 
            int Index = 0;
            try
            {
                Index = dataGridView_Invoices.CurrentCell.RowIndex;
                lastSelectedIndexInvoices = Index;
            }
            catch
            {
                log.Debug("Invoices not loaded correctly, please reload invoices.");
                MessageBox.Show("Molimo prvo učitajte fakture na listu pritiskom na dugme 'Učitaj Fakture'. ", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Invoices invoices = new Invoices();
            invoices = this.Invoices[Index];

            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da obrišete fakturu " + invoices.BrojFakture.ToString() + " ?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                lastSelectedIndexInvoices = lastSelectedIndexInvoices - 1; // lowered by 1, since last index will be deleted soon, we don't want errors
                DeleteInvoice(invoices);
            }

        }

        private void DeleteInvoice(Invoices invoice)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);
            SqlCommand command = sqlConn.CreateCommand();

            // query
            command.CommandText = "DELETE FROM Invoices where invoice_id = @invoice_id ";
            command.Parameters.AddWithValue("@invoice_id", invoice.FakturaId);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                command.Connection.Close();
                sqlConn.Close();
                log.Debug("TruckSystem nije uspeo da obriše Fakturu iz baze podataka. Molimo pozovite poršku. ");
                MessageBox.Show("TruckSystem nije uspeo da obriše Fakturu iz baze podataka. Molimo kontaktirajte podršku. " + ex.Message);
            }

            sqlConn.Close();
            command.Connection.Close();

            //refresh data
            LoadInvoices();
        }

        //-------------------------INVOICES SECTION END-------------------------------//

        //-------------------------COMPANIES SECTION BEGIN-------------------------------//
        private static List<Companies> GetCompanies()
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
                                companies.FirmaId= Int32.Parse(dataReader[i].ToString());
                                break;
                            case 1:
                                companies.NazivFirme = ((string)dataReader[i]).Trim();
                                break;
                            case 2:
                                companies.Adresa = ((string)dataReader[i]).Trim();
                                break;
                            case 3:
                                companies.Grad = ((string)dataReader[i]).Trim();
                                break;
                            case 4:
                                companies.Vlasnik = ((string)dataReader[i]).Trim();
                                break;
                            case 5:
                                companies.PIB = ((string)dataReader[i]).Trim();
                                break;
                            case 6:
                                companies.BrojBankovnogRačuna = ((string)dataReader[i]).Trim();
                                break;
                            case 7:
                                companies.KontaktTelefon = ((string)dataReader[i]).Trim();
                                break;
                            case 8:
                                companies.EMail = ((string)dataReader[i]).Trim();
                                break;
                        }
                    }

                }

                list.Add(companies);
            }

            sqlConn.Close();

            return list;
        }

        private void LoadCompanies()
        {
            // load drivers in dataGridView_Companies
            Companies = GetCompanies();
            dataGridView_Companies.DataSource = Companies;

            if (lastSelectedIndexCompanies < 0)
            {
                lastSelectedIndexCompanies = 0;
                // select last selected column in dataGridView1
                dataGridView_Companies.CurrentCell = dataGridView_Companies.Rows[lastSelectedIndexCompanies].Cells[lastSelectedIndexCompanies];
                dataGridView_Companies.Rows[lastSelectedIndexCompanies].Selected = true;
            }
            else
            {
                dataGridView_Companies.CurrentCell = dataGridView_Companies.Rows[lastSelectedIndexCompanies].Cells[lastSelectedIndexCompanies];
                dataGridView_Companies.Rows[lastSelectedIndexCompanies].Selected = true;
            }
        }

        private void LoadCompanies_button_Click(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        private void EditCompany_button_Click(object sender, EventArgs e)
        {
            // get row index 
            int Index = 0;

            try
            {
                Index = dataGridView_Companies.CurrentCell.RowIndex;
                lastSelectedIndexCompanies = Index;
            }
            catch
            {
                log.Debug("Companies not loaded correctly, please reload invoices.");
                MessageBox.Show("Molimo prvo učitajte fakture na listu pritiskom na dugme 'Učitaj Firme'. ", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            EditCompany editCompany = new EditCompany(this);
            Companies companies = new Companies();
            companies = this.Companies[Index];

            editCompany.LoadSelectedCompany(companies);
            editCompany.ShowDialog();
        }

        private void AddNewCompany_button_Click(object sender, EventArgs e)
        {
            AddNewCompany addNewCompany = new AddNewCompany(this);
            addNewCompany.ShowDialog();
        }

        public void AddCompany(Companies companies)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);
            SqlCommand command = sqlConn.CreateCommand();

            // query
            command.CommandText = " INSERT INTO Companies " +
                                    "(company_name, company_address, company_headquaters_city, company_owner," +
                                    " company_taxIdNumber, company_bank_account, company_phone_number, company_email)" +
                                    " VALUES ( " +
                                    " @company_name, " +
                                    " @company_address, " +
                                    " @company_headquaters_city, " +
                                    " @company_owner, " +
                                    " @company_taxIdNumber, " +
                                    " @company_bank_account, " +
                                    " @company_phone_number, " +
                                    " @company_email) ";

            //command.Parameters.AddWithValue("@company_id", companies.FirmaId);
            command.Parameters.AddWithValue("@company_email", companies.EMail);
            command.Parameters.AddWithValue("@company_phone_number", companies.KontaktTelefon);
            command.Parameters.AddWithValue("@company_bank_account", companies.BrojBankovnogRačuna);
            command.Parameters.AddWithValue("@company_taxIdNumber", companies.PIB);
            command.Parameters.AddWithValue("@company_owner", companies.Vlasnik);
            command.Parameters.AddWithValue("@company_headquaters_city", companies.Grad);
            command.Parameters.AddWithValue("@company_address", companies.Adresa);
            command.Parameters.AddWithValue("@company_name", companies.NazivFirme);

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
            LoadCompanies();
        }
        public void EditCompany(Companies companies)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);
            SqlCommand command = sqlConn.CreateCommand();

            // query
            command.CommandText =   " UPDATE Companies SET " +
                                    " company_email = @company_email, " +
                                    " company_phone_number = @company_phone_number, " +
                                    " company_bank_account = @company_bank_account, " +
                                    " company_taxIdNumber = @company_taxIdNumber, " +
                                    " company_owner = @company_owner, " +
                                    " company_headquaters_city = @company_headquaters_city, " +
                                    " company_address = @company_address, " +
                                    " company_name = @company_name " +
                                    " WHERE company_id = @company_id ";

            command.Parameters.AddWithValue("@company_id", companies.FirmaId);
            command.Parameters.AddWithValue("@company_email", companies.EMail);
            command.Parameters.AddWithValue("@company_phone_number", companies.KontaktTelefon);
            command.Parameters.AddWithValue("@company_bank_account", companies.BrojBankovnogRačuna);
            command.Parameters.AddWithValue("@company_taxIdNumber", companies.PIB);
            command.Parameters.AddWithValue("@company_owner", companies.Vlasnik);
            command.Parameters.AddWithValue("@company_headquaters_city", companies.Grad);
            command.Parameters.AddWithValue("@company_address", companies.Adresa);
            command.Parameters.AddWithValue("@company_name", companies.NazivFirme);

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
            LoadCompanies();
        }

        private void DeleteCompany_button_Click(object sender, EventArgs e)
        {
            // get row index 
            int Index = 0;
            try
            {
                Index = dataGridView_Companies.CurrentCell.RowIndex;
                lastSelectedIndexCompanies = Index;
            }
            catch
            {
                log.Debug("Companies not loaded correctly, please reload companies.");
                MessageBox.Show("Molimo prvo učitajte firme na listu pritiskom na dugme 'Učitaj Firme'. ", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Companies companies = new Companies();
            companies = this.Companies[Index];

            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da obrišete fakturu " + companies.NazivFirme.ToString() + " - PIB:" + companies.PIB.ToString() + " ?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                lastSelectedIndexCompanies = lastSelectedIndexCompanies - 1; // lowered by 1, since last index will be deleted soon, we don't want errors
                DeleteCompany(companies);
            }

        }

        private void DeleteCompany(Companies companies)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=TruckData;User ID=sa;Password=pathfinder";
            SqlConnection sqlConn = new SqlConnection(connetionString);
            SqlCommand command = sqlConn.CreateCommand();

            // query
            command.CommandText = "DELETE FROM Companies where company_id = @company_id ";
            command.Parameters.AddWithValue("@invoice_id", companies.FirmaId);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                command.Connection.Close();
                sqlConn.Close();
                log.Debug("TruckSystem nije uspeo da obriše Firmu iz baze podataka. Molimo pozovite poršku. ");
                MessageBox.Show("TruckSystem nije uspeo da obriše Firmu iz baze podataka. Molimo kontaktirajte podršku. " + ex.Message);
            }

            sqlConn.Close();
            command.Connection.Close();

            //refresh data
            LoadCompanies();
        }

        //-------------------------COMPANIES SECTION END-------------------------------//
    }
}
