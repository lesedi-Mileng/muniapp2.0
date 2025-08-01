
namespace muniapp
{
    partial class RequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnDel = new System.Windows.Forms.Button();
            this.dgv_Request = new System.Windows.Forms.DataGridView();
            this.txtbxLocation = new System.Windows.Forms.TextBox();
            this.cal_Request = new System.Windows.Forms.MonthCalendar();
            this.cmbxClient = new System.Windows.Forms.ComboBox();
            this.cmbxOfficer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOfficers = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Request)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnEdit
            // 
            this.bttnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnEdit.Location = new System.Drawing.Point(407, 285);
            this.bttnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(150, 45);
            this.bttnEdit.TabIndex = 15;
            this.bttnEdit.Text = "Edit";
            this.bttnEdit.UseVisualStyleBackColor = false;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnAdd.Location = new System.Drawing.Point(222, 285);
            this.bttnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(150, 45);
            this.bttnAdd.TabIndex = 14;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnDel
            // 
            this.bttnDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnDel.Location = new System.Drawing.Point(590, 285);
            this.bttnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnDel.Name = "bttnDel";
            this.bttnDel.Size = new System.Drawing.Size(150, 45);
            this.bttnDel.TabIndex = 13;
            this.bttnDel.Text = "Delete";
            this.bttnDel.UseVisualStyleBackColor = false;
            this.bttnDel.Click += new System.EventHandler(this.bttnDel_Click);
            // 
            // dgv_Request
            // 
            this.dgv_Request.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Request.Location = new System.Drawing.Point(250, 373);
            this.dgv_Request.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Request.Name = "dgv_Request";
            this.dgv_Request.RowHeadersWidth = 62;
            this.dgv_Request.RowTemplate.Height = 28;
            this.dgv_Request.Size = new System.Drawing.Size(1099, 285);
            this.dgv_Request.TabIndex = 22;
            this.dgv_Request.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Service_CellContentClick);
            // 
            // txtbxLocation
            // 
            this.txtbxLocation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbxLocation.Location = new System.Drawing.Point(222, 232);
            this.txtbxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxLocation.Name = "txtbxLocation";
            this.txtbxLocation.Size = new System.Drawing.Size(138, 22);
            this.txtbxLocation.TabIndex = 23;
            // 
            // cal_Request
            // 
            this.cal_Request.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cal_Request.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cal_Request.Location = new System.Drawing.Point(478, 23);
            this.cal_Request.Name = "cal_Request";
            this.cal_Request.TabIndex = 26;
            this.cal_Request.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal_Request_DateChanged);
            // 
            // cmbxClient
            // 
            this.cmbxClient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbxClient.FormattingEnabled = true;
            this.cmbxClient.Location = new System.Drawing.Point(222, 66);
            this.cmbxClient.Name = "cmbxClient";
            this.cmbxClient.Size = new System.Drawing.Size(236, 24);
            this.cmbxClient.TabIndex = 27;
            // 
            // cmbxOfficer
            // 
            this.cmbxOfficer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbxOfficer.FormattingEnabled = true;
            this.cmbxOfficer.Location = new System.Drawing.Point(222, 156);
            this.cmbxOfficer.Name = "cmbxOfficer";
            this.cmbxOfficer.Size = new System.Drawing.Size(236, 24);
            this.cmbxOfficer.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(219, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(219, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Muncipal Officer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(219, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Client: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(777, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(572, 290);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(215, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "REQUEST";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnRequest);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnOfficers);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnServices);
            this.panel1.Controls.Add(this.btnClients);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 710);
            this.panel1.TabIndex = 38;
            // 
            // btnRequest
            // 
            this.btnRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRequest.Location = new System.Drawing.Point(0, 438);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(207, 52);
            this.btnRequest.TabIndex = 9;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.Location = new System.Drawing.Point(4, 529);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 52);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOfficers
            // 
            this.btnOfficers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOfficers.FlatAppearance.BorderSize = 0;
            this.btnOfficers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfficers.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfficers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnOfficers.Location = new System.Drawing.Point(0, 386);
            this.btnOfficers.Margin = new System.Windows.Forms.Padding(4);
            this.btnOfficers.Name = "btnOfficers";
            this.btnOfficers.Size = new System.Drawing.Size(207, 52);
            this.btnOfficers.TabIndex = 6;
            this.btnOfficers.Text = "Officers";
            this.btnOfficers.UseVisualStyleBackColor = true;
            this.btnOfficers.Click += new System.EventHandler(this.btnOfficers_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 238);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 123);
            this.pnlNav.TabIndex = 5;
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReports.Location = new System.Drawing.Point(0, 334);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(207, 52);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnServices
            // 
            this.btnServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnServices.Location = new System.Drawing.Point(0, 282);
            this.btnServices.Margin = new System.Windows.Forms.Padding(4);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(207, 52);
            this.btnServices.TabIndex = 3;
            this.btnServices.Text = "Services";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnClients
            // 
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClients.Location = new System.Drawing.Point(0, 230);
            this.btnClients.Margin = new System.Windows.Forms.Padding(4);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(207, 52);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 178);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(207, 52);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 178);
            this.panel2.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserName.Location = new System.Drawing.Point(83, 143);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(16, 16);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "...";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Cyan;
            this.lblUser.Location = new System.Drawing.Point(50, 110);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(103, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User Name";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(457, 246);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 39;
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1450, 710);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxOfficer);
            this.Controls.Add(this.cmbxClient);
            this.Controls.Add(this.cal_Request);
            this.Controls.Add(this.txtbxLocation);
            this.Controls.Add(this.dgv_Request);
            this.Controls.Add(this.bttnEdit);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.bttnDel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequestForm";
            this.Text = "ReprotForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Request)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnDel;
        private System.Windows.Forms.DataGridView dgv_Request;
        private System.Windows.Forms.TextBox txtbxLocation;
        private System.Windows.Forms.MonthCalendar cal_Request;
        private System.Windows.Forms.ComboBox cmbxClient;
        private System.Windows.Forms.ComboBox cmbxOfficer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOfficers;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDate;
    }
}