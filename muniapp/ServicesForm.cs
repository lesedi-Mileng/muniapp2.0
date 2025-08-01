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
    public partial class ServicesForm : Form
    {
        string service_type;
        private string connectionString = @"Data Source=.;Initial Catalog=MunicpalityDB;Integrated Security=True";
        public ServicesForm()
        {
            InitializeComponent();
            LoadServices();
            
        }

        private void LoadServices()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SERVICE", conn);
                    DataTable servicesTable = new DataTable();
                    adapter.Fill(servicesTable);
                    dgv_Service.DataSource = servicesTable;

                    conn.Close();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {

        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO SERVICE (Service_type, Service_descr, duration) VALUES (@Service_type, @Service_descr, @duration)", conn);
                    cmd.Parameters.AddWithValue("@Service_type", service_type);
                    cmd.Parameters.AddWithValue("@Service_descr", txtbxDescrip.Text);
                    cmd.Parameters.AddWithValue("@duration", txtbxDuration.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadServices();
                    MessageBox.Show("Added Service successfully");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if(rbtnBuidling.Checked)
            {
                service_type = rbtnBuidling.Text;
            }
            else if(rbtnEducation.Checked)
            {
                service_type = rbtnEducation.Text;
            }
            else if (rbtnHousing.Checked)
            {
                service_type = rbtnHousing.Text;
            }
            else if (rbtnRoad.Checked)
            {
                service_type = rbtnRoad.Text;
            }
            else if (rbtnWater.Checked)
            {
                service_type = rbtnWater.Text;
            }
            else if (rbtnOther.Checked)
            {
                service_type = rbtnOther.Text;
            }
            else 
            {
                MessageBox.Show("Please choose the type of service");
            }
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Service.SelectedRows.Count > 0)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        int serviceId = Convert.ToInt32(dgv_Service.SelectedRows[0].Cells["Service_ID"].Value);

                        SqlCommand cmd = new SqlCommand("UPDATE SERVICE SET Service_type = @Service_type, Service_descr = @Service_descr,  duration = @duration WHERE Service_ID = @Service_ID", conn);
                        cmd.Parameters.AddWithValue("@Service_ID", serviceId);
                        cmd.Parameters.AddWithValue("@Service_type", service_type);
                        cmd.Parameters.AddWithValue("@Service_descr", txtbxDescrip.Text);
                        cmd.Parameters.AddWithValue("@duration", txtbxDuration.Text);
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        LoadServices();
                        MessageBox.Show("Edited service details successfully");
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
                if (dgv_Service.SelectedRows.Count > 0)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        int serviceId = Convert.ToInt32(dgv_Service.SelectedRows[0].Cells["Service_ID"].Value);

                        SqlCommand cmd = new SqlCommand("DELETE FROM SERVICE WHERE Service_ID = @Service_ID", conn);
                        cmd.Parameters.AddWithValue("@Service_ID", serviceId);
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        LoadServices();
                        MessageBox.Show("Deleted Service details");
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

        private void dgv_Service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Service.SelectedRows.Count > 0)
            {
                service_type = dgv_Service.SelectedRows[0].Cells["Service_type"].Value.ToString();
                txtbxDescrip.Text = dgv_Service.SelectedRows[0].Cells["Service_descr"].Value.ToString();
                txtbxDuration.Text = dgv_Service.SelectedRows[0].Cells["duration"].Value.ToString();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientForm frm = new ClientForm();
            frm.Show();

            this.Hide();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {

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

        private void btnRequest_Click(object sender, EventArgs e)
        {
            ReportsForm requestForm = new ReportsForm();
            requestForm.Show();

            this.Hide();
        }

        private void txtbxDescrip_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = $"SELECT * FROM SERVICE WHERE Service_descr LIKE '%{txtbxDescrip.Text}%'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();

                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(ds, "SERVICE");
                    
                    dgv_Service.DataSource = ds;
                    dgv_Service.DataMember = "SERVICE";
                   
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }
    }
}
