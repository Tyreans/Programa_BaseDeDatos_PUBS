namespace Acceso_Datos_App_P23130577
{
    partial class frmInsertEmployees
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
            button1 = new Button();
            btnInsertar = new Button();
            dtpHireDate = new DateTimePicker();
            label7 = new Label();
            cBPub = new ComboBox();
            lblPub = new Label();
            lblNvl = new Label();
            lblLvl = new Label();
            tBLvl = new TrackBar();
            cBJobs = new ComboBox();
            lblJob = new Label();
            tbLName = new TextBox();
            lblLName = new Label();
            tBFName = new TextBox();
            lblFName = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            tBSName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)tBLvl).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(577, 386);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 92;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(390, 386);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 34);
            btnInsertar.TabIndex = 91;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(440, 303);
            dtpHireDate.Margin = new Padding(2);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(324, 31);
            dtpHireDate.TabIndex = 90;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(440, 277);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 89;
            label7.Text = "Hire Date";
            // 
            // cBPub
            // 
            cBPub.FormattingEnabled = true;
            cBPub.Location = new Point(507, 202);
            cBPub.Name = "cBPub";
            cBPub.Size = new Size(182, 33);
            cBPub.TabIndex = 88;
            // 
            // lblPub
            // 
            lblPub.AutoSize = true;
            lblPub.Location = new Point(507, 174);
            lblPub.Name = "lblPub";
            lblPub.Size = new Size(84, 25);
            lblPub.TabIndex = 87;
            lblPub.Text = "Publisher";
            // 
            // lblNvl
            // 
            lblNvl.AutoSize = true;
            lblNvl.Location = new Point(670, 94);
            lblNvl.Name = "lblNvl";
            lblNvl.Size = new Size(24, 25);
            lblNvl.TabIndex = 86;
            lblNvl.Text = "...";
            // 
            // lblLvl
            // 
            lblLvl.AutoSize = true;
            lblLvl.Location = new Point(507, 31);
            lblLvl.Name = "lblLvl";
            lblLvl.Size = new Size(134, 25);
            lblLvl.TabIndex = 85;
            lblLvl.Text = "Employee Level";
            // 
            // tBLvl
            // 
            tBLvl.Enabled = false;
            tBLvl.Location = new Point(507, 89);
            tBLvl.Name = "tBLvl";
            tBLvl.Size = new Size(156, 69);
            tBLvl.TabIndex = 84;
            tBLvl.Scroll += tBLvl_Scroll;
            // 
            // cBJobs
            // 
            cBJobs.FormattingEnabled = true;
            cBJobs.Location = new Point(39, 357);
            cBJobs.Name = "cBJobs";
            cBJobs.Size = new Size(182, 33);
            cBJobs.TabIndex = 83;
            cBJobs.SelectedIndexChanged += cBJobs_SelectedIndexChanged;
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Location = new Point(39, 329);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(40, 25);
            lblJob.TabIndex = 82;
            lblJob.Text = "Job";
            // 
            // tbLName
            // 
            tbLName.Location = new Point(36, 271);
            tbLName.Name = "tbLName";
            tbLName.Size = new Size(150, 31);
            tbLName.TabIndex = 81;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(39, 230);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(95, 25);
            lblLName.TabIndex = 80;
            lblLName.Text = "Last Name";
            // 
            // tBFName
            // 
            tBFName.Location = new Point(36, 174);
            tBFName.Name = "tBFName";
            tBFName.Size = new Size(150, 31);
            tBFName.TabIndex = 79;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(39, 133);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(97, 25);
            lblFName.TabIndex = 78;
            lblFName.Text = "First Name";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(48, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 31);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 94;
            label1.Text = "Sex";
            // 
            // tBSName
            // 
            tBSName.Location = new Point(233, 174);
            tBSName.Name = "tBSName";
            tBSName.Size = new Size(150, 31);
            tBSName.TabIndex = 96;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 133);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 95;
            label2.Text = "Second Name";
            // 
            // frmInsertEmployees
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tBSName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(btnInsertar);
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
            Name = "frmInsertEmployees";
            Text = "frmInsertEmployees";
            Load += frmInsertEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)tBLvl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnInsertar;
        private DateTimePicker dtpHireDate;
        private Label label7;
        private ComboBox cBPub;
        private Label lblPub;
        private Label lblNvl;
        private Label lblLvl;
        private TrackBar tBLvl;
        private ComboBox cBJobs;
        private Label lblJob;
        private TextBox tbLName;
        private Label lblLName;
        private TextBox tBFName;
        private Label lblFName;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox tBSName;
        private Label label2;
    }
}