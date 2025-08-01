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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace muniapp
{
    public partial class ClientForm : Form
    {
        private string connectionString = @"Data Source=.;Initial Catalog=MunicpalityDB;Integrated Security=True";

        public ClientForm()
        {
            InitializeComponent();
            LoadClients();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadClients()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CLIENT", conn);
                DataTable clientsTable = new DataTable();
                adapter.Fill(clientsTable);
                dgvClients.DataSource = clientsTable;
                conn.Close();
            }
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            bttnAdd.BackColor = Color.FromArgb(46, 51, 73);
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO CLIENT (Client_Lname, Client_Name, Contact_details) VALUES (@Client_Lname, @Client_Name, @Contact_Details)", conn);
                    cmd.Parameters.AddWithValue("@Client_Lname", txtbxSurname.Text);
                    cmd.Parameters.AddWithValue("@Client_Name", txtbxName.Text);
                    cmd.Parameters.AddWithValue("@Contact_Details", txtbxCon_Details.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    LoadClients();
                    MessageBox.Show("Added successfully");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClients.SelectedRows.Count > 0) // Check if a row is selected in the DataGridView
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        int clientId = Convert.ToInt32(dgvClients.SelectedRows[0].Cells["Client_ID"].Value);

                        SqlCommand cmd = new SqlCommand("UPDATE CLIENT SET Client_Lname = @Client_Lname, Client_Name = @Client_Name, Contact_details = @Contact_details WHERE Client_ID = @Client_ID", conn);
                        cmd.Parameters.AddWithValue("@Client_ID", clientId);
                        cmd.Parameters.AddWithValue("@Client_Lname", txtbxSurname.Text);
                        cmd.Parameters.AddWithValue("@Client_Name", txtbxName.Text);
                        cmd.Parameters.AddWithValue("@Contact_details", txtbxCon_Details.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated Client details");
                        conn.Close();
                        LoadClients();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void bttnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClients.SelectedRows.Count > 0)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        int clientId = Convert.ToInt32(dgvClients.SelectedRows[0].Cells["Client_ID"].Value);

                        SqlCommand cmd = new SqlCommand("DELETE FROM CLIENT WHERE Client_ID = @Client_ID", conn);
                        cmd.Parameters.AddWithValue("@Client_ID", clientId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Deleted Client details");
                        LoadClients();


                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {

                txtbxName.Text = dgvClients.SelectedRows[0].Cells["Client_Name"].Value.ToString();
                txtbxSurname.Text = dgvClients.SelectedRows[0].Cells["Client_Lname"].Value.ToString();
                txtbxCon_Details.Text = dgvClients.SelectedRows[0].Cells["Contact_details"].Value.ToString();
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            this.Hide();

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
   
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand($"SELECT * FROM CLIENT WHERE Client_Name LIKE '%{txtbxName.Text}%'", conn);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        DataSet ds = new DataSet();

                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "CLIENT");

                        dgvClients.DataSource = ds;
                        dgvClients.DataMember = "CLIENT"; 

                        conn.Close();
                    }
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ServicesForm s1 = new ServicesForm();

            s1.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm rt1 = new ReportsForm();

            rt1.Show();
            this.Hide();
        }

        private void btnOfficers_Click(object sender, EventArgs e)
        {
            OfficersForm o1 = new OfficersForm();

            o1.Show();
            this.Hide();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            RequestForm r1 = new RequestForm();
            r1.Show();
            this.Hide();
        }

        private void btnApprRej_Click(object sender, EventArgs e)
        {

        }
    }
}