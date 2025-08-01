using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace muniapp
{
    public partial class AssignOfficer : Form
    {
        private string connectionString = @"Data Source=.;Initial Catalog=MunicpalityDB;Integrated Security=True";
        public AssignOfficer()
        {
            InitializeComponent();
        }

        private void LoadServiceRequests()
        {
            // Define your SQL query to get service requests
            string query = "SELECT Request_ID, date_time FROM REQUEST";

            // Connection string to your database
            

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dgvRequest.DataSource = dt;

                    // Optionally, set the headers and format columns
                    dgvRequest.Columns["Request_ID"].HeaderText = "Request ID";
                    dgvRequest.Columns["date_time"].HeaderText = "Date";
                    dgvRequest.Columns["date_time"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void LoadOfficers()
        {
            // Define your SQL query to get officers
            string query = "SELECT OfficerID, Muni_off_LName FROM MUNICIPAL_OFFICER";

            // Connection string to your database
            string connectionString = " ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add officer details to the ComboBox
                        cmbxOfficer.Items.Add($"{reader["Officer_ID"]} - {reader["Muni_off_LName"]}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void bttnAssign_Click(object sender, EventArgs e)
        {
            if (dgvRequest.SelectedRows.Count > 0 && cmbxOfficer.SelectedItem != null)
            {
                
                string selectedRequestID = cmbxService.Text;

                
                string selectedOfficer = cmbxOfficer.SelectedItem.ToString();
                string selectedOfficerID = selectedOfficer.Split('-')[0].Trim();


                string query = "UPDATE Request SET Officer_ID = @Officer_ID WHERE Request_ID = @Request_ID";
          
                string connectionString = " ";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Officer_ID", selectedOfficerID);
                    cmd.Parameters.AddWithValue("@Request_ID", selectedRequestID);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Officer assigned successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a service request and an officer.");
            }
        }

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                DataGridViewRow row = dgvRequest.Rows[e.RowIndex];

                
                string selectedRequestID = row.Cells["Request_ID"].Value.ToString();
                string date = row.Cells["date_time"].Value.ToString();

                
                cmbxService.Text = selectedRequestID;
                cmbxService.Text = date;
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ServicesForm sf = new ServicesForm();
            sf.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            this.Hide();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssignOfficer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
