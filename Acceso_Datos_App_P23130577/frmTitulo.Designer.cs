namespace Acceso_Datos_App_P23130577
{
    partial class frmTitulo
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
            tBYrSales = new TextBox();
            label7 = new Label();
            label9 = new Label();
            dtpDate = new DateTimePicker();
            rtbNotes = new RichTextBox();
            label8 = new Label();
            tBRyal = new TextBox();
            label6 = new Label();
            tBAdvance = new TextBox();
            label5 = new Label();
            tBPrice = new TextBox();
            label4 = new Label();
            cBPub = new ComboBox();
            lblPub = new Label();
            cBType = new ComboBox();
            label3 = new Label();
            tBTitle = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(275, 544);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 146;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(103, 535);
            btnInsertar.Margin = new Padding(2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 36);
            btnInsertar.TabIndex = 145;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // tBYrSales
            // 
            tBYrSales.Location = new Point(468, 432);
            tBYrSales.Name = "tBYrSales";
            tBYrSales.Size = new Size(150, 31);
            tBYrSales.TabIndex = 144;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(476, 384);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 143;
            label7.Text = "Year Sales";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(476, 486);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(141, 25);
            label9.TabIndex = 142;
            label9.Text = "Date Publication";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(686, 486);
            dtpDate.Margin = new Padding(2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(351, 31);
            dtpDate.TabIndex = 141;
            // 
            // rtbNotes
            // 
            rtbNotes.Location = new Point(686, 112);
            rtbNotes.Margin = new Padding(2);
            rtbNotes.Name = "rtbNotes";
            rtbNotes.Size = new Size(315, 152);
            rtbNotes.TabIndex = 140;
            rtbNotes.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(686, 77);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 139;
            label8.Text = "Notes";
            // 
            // tBRyal
            // 
            tBRyal.Location = new Point(476, 330);
            tBRyal.Name = "tBRyal";
            tBRyal.Size = new Size(150, 31);
            tBRyal.TabIndex = 138;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 282);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 137;
            label6.Text = "Royalty";
            // 
            // tBAdvance
            // 
            tBAdvance.Location = new Point(476, 223);
            tBAdvance.Name = "tBAdvance";
            tBAdvance.Size = new Size(150, 31);
            tBAdvance.TabIndex = 136;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 175);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 135;
            label5.Text = "Advance";
            // 
            // tBPrice
            // 
            tBPrice.Location = new Point(476, 125);
            tBPrice.Name = "tBPrice";
            tBPrice.Size = new Size(150, 31);
            tBPrice.TabIndex = 134;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 77);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 133;
            label4.Text = "Price";
            // 
            // cBPub
            // 
            cBPub.FormattingEnabled = true;
            cBPub.Location = new Point(86, 436);
            cBPub.Name = "cBPub";
            cBPub.Size = new Size(182, 33);
            cBPub.TabIndex = 132;
            // 
            // lblPub
            // 
            lblPub.AutoSize = true;
            lblPub.Location = new Point(86, 384);
            lblPub.Name = "lblPub";
            lblPub.Size = new Size(84, 25);
            lblPub.TabIndex = 131;
            lblPub.Text = "Publisher";
            // 
            // cBType
            // 
            cBType.FormattingEnabled = true;
            cBType.Items.AddRange(new object[] { "UNDECIDED", "business", "mod_cook", "popular_comp", "psychology", "trad_cook" });
            cBType.Location = new Point(86, 325);
            cBType.Name = "cBType";
            cBType.Size = new Size(182, 33);
            cBType.TabIndex = 130;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 282);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 129;
            label3.Text = "Type";
            // 
            // tBTitle
            // 
            tBTitle.Location = new Point(78, 223);
            tBTitle.Name = "tBTitle";
            tBTitle.Size = new Size(150, 31);
            tBTitle.TabIndex = 128;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 175);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 127;
            label2.Text = "Title";
            // 
            // frmTitulo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 655);
            Controls.Add(button1);
            Controls.Add(btnInsertar);
            Controls.Add(tBYrSales);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(dtpDate);
            Controls.Add(rtbNotes);
            Controls.Add(label8);
            Controls.Add(tBRyal);
            Controls.Add(label6);
            Controls.Add(tBAdvance);
            Controls.Add(label5);
            Controls.Add(tBPrice);
            Controls.Add(label4);
            Controls.Add(cBPub);
            Controls.Add(lblPub);
            Controls.Add(cBType);
            Controls.Add(label3);
            Controls.Add(tBTitle);
            Controls.Add(label2);
            Name = "frmTitulo";
            Text = "frmTitulo";
            Load += frmTitulo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnInsertar;
        private TextBox tBYrSales;
        private Label label7;
        private Label label9;
        private DateTimePicker dtpDate;
        private RichTextBox rtbNotes;
        private Label label8;
        private TextBox tBRyal;
        private Label label6;
        private TextBox tBAdvance;
        private Label label5;
        private TextBox tBPrice;
        private Label label4;
        private ComboBox cBPub;
        private Label lblPub;
        private ComboBox cBType;
        private Label label3;
        private TextBox tBTitle;
        private Label label2;
    }
}