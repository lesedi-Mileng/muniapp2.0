// 42903289 Dela Lumor, 41822579 Mncedisi Motsepe, 45941106 Lesedi Mileng

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace muniapp
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse

            );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnClients.Height;
            pnlNav.Top = btnClients.Top;
            pnlNav.Left = btnClients.Left;
            btnClients.BackColor = Color.FromArgb(46, 51, 73);
            ClientForm cf = new ClientForm();
            cf.Show();
            this.Hide();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnServices.Height;
            pnlNav.Top = btnServices.Top;
            pnlNav.Left = btnServices.Left;
            btnServices.BackColor = Color.FromArgb(46, 51, 73);

            ServicesForm s1 = new ServicesForm();

            s1.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReports.Height;
            pnlNav.Top = btnReports.Top;
            pnlNav.Left = btnReports.Left;
            btnReports.BackColor = Color.FromArgb(46, 51, 73);
            ReportsForm rt1 = new ReportsForm();

            rt1.Show();
            this.Hide();
        }

        private void btnOfficers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOfficers.Height;
            pnlNav.Top = btnOfficers.Top;
            pnlNav.Left = btnOfficers.Left;
            btnOfficers.BackColor = Color.FromArgb(46, 51, 73);

            OfficersForm o1 = new OfficersForm();

            o1.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnExit.Height;
            pnlNav.Top = btnExit.Top;
            pnlNav.Left = btnExit.Left;
            btnExit.BackColor = Color.FromArgb(46, 51, 73);
            this.Hide();
        }

        private void btnApprRej_Click(object sender, EventArgs e)
        {
            AssignOfficer as1 = new AssignOfficer();
            as1.Show();
            this.Hide();

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            RequestForm r1 = new RequestForm();
            r1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
