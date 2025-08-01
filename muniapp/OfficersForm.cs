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

namespace muniapp
{
    public partial class OfficersForm : Form
    {
        private string connectionString = @"Data Source=.;Initial Catalog=MunicpalityDB;Integrated Security=True";
        public OfficersForm()
        {
            InitializeComponent();
            LoadServices();
            LoadOfficers();
        }

        private void LoadServices()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); // Open the database connection
                    SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT DISTINCT Service_descr FROM SERVICE", conn); // Create a DataAdapter for the Services table
                    DataTable servicesTable = new DataTable(); // Create a DataTable to hold the services data
                    adapter.Fill(servicesTable); // Fill the DataTable with data from the Services table
                    cmbOffiicers.DataSource = servicesTable; // Bind the DataTable to the ComboBox
                    cmbOffiicers.DisplayMember = "Service_descr"; // Display the service name
                    cmbOffiicers.ValueMember = "Service_descr"; // Store the service ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading services: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOfficers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); // Open the database connection
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM MUNICIPAL_OFFICER", conn); // Create a DataAdapter for the Officers table
                    DataTable MUNICIPAL_OFFICER = new DataTable(); // Create a DataTable to hold the officers data
                    adapter.Fill(MUNICIPAL_OFFICER); // Fill the DataTable with data from the Officers table
                    dgvOfficers.DataSource = MUNICIPAL_OFFICER; // Bind the DataTable to the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading officers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); // Open the database connection
                                 // SQL command to insert a new officer into the Officers table
                    SqlCommand cmd = new SqlCommand("INSERT INTO MUNICIPAL_OFFICER (Muni_off_LName, Service_ID) VALUES (@OfficerName, @Service_ID)", conn);
                    cmd.Parameters.AddWithValue("@OfficerName", txtbxSurname.Text); // Add parameter for OfficerName
                    cmd.Parameters.AddWithValue("@Service_ID", cmbOffiicers.SelectedValue); // Add parameter for ServiceID
                    cmd.ExecuteNonQuery(); // Execute the SQL command
                    LoadOfficers(); // Refresh the DataGridView to include the new officer
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding officer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void OfficersForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbOffiicers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

            this.Hide();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();

            this.Hide();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ServicesForm servicesForm = new ServicesForm();
            servicesForm.Show();

            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();

            this.Hide();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
                RequestForm requestForm = new RequestForm();
                requestForm.Show();

                this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbxSurname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = $"SELECT * FROM MUNICIPAL_OFFICER WHERE Muni_off_LName LIKE '%{txtbxSurname.Text}%'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();

                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(ds, "MUNICIPAL_OFFICER");

                    dgvOfficers.DataSource = ds;
                    dgvOfficers.DataMember = "MUNICIPAL_OFFICER";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
