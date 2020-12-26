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
        public int lastSelectedIndex = 0;

        public LogFactory logManager = LogManager.LoadConfiguration("nlog.config");
        public Logger log = LogManager.GetCurrentClassLogger();

        public TruckSystem()
        {
            InitializeComponent();
        }

        private List<Drivers> GetDrivers()
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
            // load drivers in dataGridView1
            Drivers = GetDrivers();
            dataGridView1.DataSource = Drivers;

            // select last selected column in dataGridView1
            dataGridView1.CurrentCell = dataGridView1.Rows[lastSelectedIndex].Cells[lastSelectedIndex];
            dataGridView1.Rows[lastSelectedIndex].Selected = true; 
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
                Index = dataGridView1.CurrentCell.RowIndex;
                lastSelectedIndex = Index;
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
    }
}
