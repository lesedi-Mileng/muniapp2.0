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
    public partial class ReportsForm : Form
    {
        private readonly string connectionString = @"Data Source=.;Initial Catalog=MunicpalityDB;Integrated Security=True";
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            DateTime startOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime endOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));


            label2.Text = DateTime.Now.ToString("yyyy/mm/dd");
            label5.Text = "Top 10 Services Rendered from "+startOfMonth.ToString() + " - " + endOfMonth.ToString()+ " ordered by Service_type descending";
        }

        private void LoadTopServices()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Assuming "Service_count" is a column representing service usage frequency
                    string query = @"
    SELECT Service_descr, COUNT(Service_descr) AS ServiceCount
    FROM SERVICE
    GROUP BY Service_descr
    ORDER BY ServiceCount DESC"; 

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable topServicesTable = new DataTable();
                    adapter.Fill(topServicesTable);
                    dgvtopServices.DataSource = topServicesTable;

                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvtopServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            LoadTopServices();
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
            ServicesForm s1 = new ServicesForm();
            s1.Show();

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
            RequestForm requestForm = new RequestForm();
            requestForm.Show();

            this.Hide();
        }

        private void bttnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
