namespace Acceso_Datos_App_P23130577
{
    partial class frmActualizaEmpleado
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
            lblId = new Label();
            tBId = new TextBox();
            tBFName = new TextBox();
            lblFName = new Label();
            tbLName = new TextBox();
            lblLName = new Label();
            lblJob = new Label();
            cBJobs = new ComboBox();
            tBLvl = new TrackBar();
            lblLvl = new Label();
            lblNvl = new Label();
            cBPub = new ComboBox();
            lblPub = new Label();
            dtpHireDate = new DateTimePicker();
            label7 = new Label();
            btnAct = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)tBLvl).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(31, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // tBId
            // 
            tBId.Enabled = false;
            tBId.Location = new Point(28, 64);
            tBId.Name = "tBId";
            tBId.Size = new Size(150, 31);
            tBId.TabIndex = 1;
            // 
            // tBFName
            // 
            tBFName.Location = new Point(28, 161);
            tBFName.Name = "tBFName";
            tBFName.Size = new Size(150, 31);
            tBFName.TabIndex = 3;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(31, 120);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(97, 25);
            lblFName.TabIndex = 2;
            lblFName.Text = "First Name";
            // 
            // tbLName
            // 
            tbLName.Location = new Point(28, 258);
            tbLName.Name = "tbLName";
            tbLName.Size = new Size(150, 31);
            tbLName.TabIndex = 5;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(31, 217);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(95, 25);
            lblLName.TabIndex = 4;
            lblLName.Text = "Last Name";
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Location = new Point(31, 316);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(40, 25);
            lblJob.TabIndex = 6;
            lblJob.Text = "Job";
            // 
            // cBJobs
            // 
            cBJobs.FormattingEnabled = true;
            cBJobs.Location = new Point(31, 344);
            cBJobs.Name = "cBJobs";
            cBJobs.Size = new Size(182, 33);
            cBJobs.TabIndex = 7;
            cBJobs.SelectedIndexChanged += cBJobs_SelectedIndexChanged;
            // 
            // tBLvl
            // 
            tBLvl.Enabled = false;
            tBLvl.Location = new Point(499, 76);
            tBLvl.Name = "tBLvl";
            tBLvl.Size = new Size(156, 69);
            tBLvl.TabIndex = 8;
            tBLvl.Scroll += tBLvl_Scroll;
            // 
            // lblLvl
            // 
            lblLvl.AutoSize = true;
            lblLvl.Location = new Point(499, 18);
            lblLvl.Name = "lblLvl";
            lblLvl.Size = new Size(134, 25);
            lblLvl.TabIndex = 9;
            lblLvl.Text = "Employee Level";
            // 
            // lblNvl
            // 
            lblNvl.AutoSize = true;
            lblNvl.Location = new Point(662, 81);
            lblNvl.Name = "lblNvl";
            lblNvl.Size = new Size(24, 25);
            lblNvl.TabIndex = 10;
            lblNvl.Text = "...";
            // 
            // cBPub
            // 
            cBPub.FormattingEnabled = true;
            cBPub.Location = new Point(499, 189);
            cBPub.Name = "cBPub";
            cBPub.Size = new Size(182, 33);
            cBPub.TabIndex = 12;
            cBPub.SelectedIndexChanged += cBPub_SelectedIndexChanged;
            // 
            // lblPub
            // 
            lblPub.AutoSize = true;
            lblPub.Location = new Point(499, 161);
            lblPub.Name = "lblPub";
            lblPub.Size = new Size(84, 25);
            lblPub.TabIndex = 11;
            lblPub.Text = "Publisher";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(432, 290);
            dtpHireDate.Margin = new Padding(2);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(324, 31);
            dtpHireDate.TabIndex = 73;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(432, 264);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 72;
            label7.Text = "Hire Date";
            // 
            // btnAct
            // 
            btnAct.Location = new Point(382, 373);
            btnAct.Name = "btnAct";
            btnAct.Size = new Size(112, 34);
            btnAct.TabIndex = 74;
            btnAct.Text = "Actualizar";
            btnAct.UseVisualStyleBackColor = true;
            btnAct.Click += btnAct_Click;
            // 
            // button1
            // 
            button1.Location = new Point(569, 373);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 75;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmActualizaEmpleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnAct);
            Controls.Add(dtpHireDate);
            Controls.Add(label7);
            Controls.Add(cBPub);
            Controls.Add(lblPub);
            Controls.Add(lblNvl);
            Controls.Add(lblLvl);
            Controls.Add(tBLvl);
            Controls.Add(cBJobs);
            Controls.Add(lblJob);
            Controls.Add(tbLName);
            Controls.Add(lblLName);
            Controls.Add(tBFName);
            Controls.Add(lblFName);
            Controls.Add(tBId);
            Controls.Add(lblId);
            Name = "frmActualizaEmpleado";
            Text = "frmActualizaEmpleado";
            Load += frmActualizaEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)tBLvl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox tBId;
        private TextBox tBFName;
        private Label lblFName;
        private TextBox tbLName;
        private Label lblLName;
        private TextBox textBox3;
        private Label lblJob;
        private ComboBox cBJobs;
        private TrackBar tBLvl;
        private Label lblLvl;
        private Label lblNvl;
        private ComboBox cBPub;
        private Label lblPub;
        private DateTimePicker dtpHireDate;
        private Label label7;
        private Button btnAct;
        private Button button1;
    }
}