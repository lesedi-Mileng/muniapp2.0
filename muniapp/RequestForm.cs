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
    public partial class RequestForm : Form
    {

        private string connectionString = @"Data Source=.;Initial Catalog=MunicpalityDB;Integrated Security=True";
        public RequestForm()
        {
            InitializeComponent();              
            LoadRequest();
            
            ComboClient();
            ComboOfficer();

            

        }

        private void ComboClient() 
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString)) 
                {
                    conn.Open();
                    string sql = @"SELECT DISTINCT Client_Lname, Client_ID FROM CLIENT";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds, "CLIENT");

                    cmbxClient.DisplayMember = "Client_Lname";
                    cmbxClient.ValueMember = "Client_ID";
                    cmbxClient.DataSource = ds.Tables["CLIENT"];

                    conn.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Failed to populate combo box: " + ex.Message);
            }
        }

        private void ComboOfficer()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"SELECT DISTINCT Muni_off_LName, Officer_ID  FROM MUNICIPAL_OFFICER";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Using SqlDataReader to fetch data directly
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Binding the data to the ComboBox
                    cmbxOfficer.DisplayMember = "Muni_off_LName";
                    cmbxOfficer.ValueMember = "Officer_ID";
                    cmbxOfficer.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to populate combo box: " + ex.Message);
            }
        }

        private void LoadRequest()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); 
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM REQUEST", conn); 
                    DataTable requestDetailsTable = new DataTable();
                    adapter.Fill(requestDetailsTable);
                    dgv_Request.DataSource = requestDetailsTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading request details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Get the selected date from the MonthCalendar
                    DateTime selectedDate = cal_Request.SelectionStart;

                    // Optionally, display the selected date in the TextBox for confirmation
                    txtDate.Text = selectedDate.ToString("yyyy-MM-dd");

                    // SQL insert statement with parameters
                    SqlCommand cmd = new SqlCommand("INSERT INTO REQUEST (Client_ID, Officer_ID, location, date_time) VALUES (@Client_ID, @Officer_ID, @location, @date_time)", conn);

                    // Add parameters to the SQL command
                    cmd.Parameters.AddWithValue("@Client_ID", cmbxClient.SelectedValue);
                    cmd.Parameters.AddWithValue("@Officer_ID", cmbxOfficer.SelectedValue);
                    cmd.Parameters.AddWithValue("@location", txtbxLocation.Text);

                    // Pass the DateTime value directly without converting it to a string
                    cmd.Parameters.AddWithValue("@date_time", selectedDate);

                    // Execute the insert query
                    cmd.ExecuteNonQuery();

                    // Optionally, refresh the request list or any other necessary action
                    LoadRequest();

                    // Show a success message
                    MessageBox.Show("Added request successfully");
                }
            }
            catch (Exception ex)
            {
                // Show any errors that occur
                MessageBox.Show("Error adding request detail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cal_Request_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int requestDetailId = Convert.ToInt32(dgv_Request.SelectedRows[0].Cells["Request_ID"].Value);
                    DateTime selectedDate = cal_Request.SelectionStart;
                    SqlCommand cmd = new SqlCommand("UPDATE REQUEST SET Client_ID = @Client_ID, Officer_ID = @Officer_ID, Service_ID = @Service_ID, location = @location, date_time = @date_time WHERE Request_ID = @Request_ID", conn);
                    cmd.Parameters.AddWithValue("@Request_ID", requestDetailId); 
                    cmd.Parameters.AddWithValue("@Client_ID", cmbxClient.SelectedValue); 
                    cmd.Parameters.AddWithValue("@Officer_ID", cmbxOfficer.SelectedValue); 
                    cmd.Parameters.AddWithValue("@location", txtbxLocation.Text); 
                    cmd.Parameters.AddWithValue("@date_time", selectedDate); 
                    cmd.ExecuteNonQuery(); 
                    LoadRequest(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating request detail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnDel_Click(object sender, EventArgs e)
        {
            if (dgv_Request.SelectedRows.Count > 0) 
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open(); 
                        int requestId = Convert.ToInt32(dgv_Request.SelectedRows[0].Cells["Request_ID"].Value);
                                                                                                                                          
                        SqlCommand cmd = new SqlCommand("DELETE FROM REQUEST WHERE Request_ID = @Request_ID", conn);
                        cmd.Parameters.AddWithValue("@Request_ID", requestId);
                        cmd.ExecuteNonQuery(); 
                        LoadRequest();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting request detail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

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

        private void btnOfficers_Click(object sender, EventArgs e)
        {
            OfficersForm officersForm = new OfficersForm();
            officersForm.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {

        }
    }
}

