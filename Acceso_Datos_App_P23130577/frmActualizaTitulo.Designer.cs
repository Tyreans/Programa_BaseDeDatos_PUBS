namespace Acceso_Datos_App_P23130577
{
    partial class frmActualizaTitulo
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
            label1 = new Label();
            tBId = new TextBox();
            tBTitle = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cBType = new ComboBox();
            cBPub = new ComboBox();
            lblPub = new Label();
            tBPrice = new TextBox();
            label4 = new Label();
            tBAdvance = new TextBox();
            label5 = new Label();
            tBRyal = new TextBox();
            label6 = new Label();
            rtbNotes = new RichTextBox();
            label8 = new Label();
            label9 = new Label();
            dtpDate = new DateTimePicker();
            tBYrSales = new TextBox();
            label7 = new Label();
            btnInsertar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 16);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // tBId
            // 
            tBId.Location = new Point(56, 64);
            tBId.Name = "tBId";
            tBId.Size = new Size(150, 31);
            tBId.TabIndex = 1;
            // 
            // tBTitle
            // 
            tBTitle.Location = new Point(56, 162);
            tBTitle.Name = "tBTitle";
            tBTitle.Size = new Size(150, 31);
            tBTitle.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 114);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 221);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 4;
            label3.Text = "Type";
            // 
            // cBType
            // 
            cBType.FormattingEnabled = true;
            cBType.Items.AddRange(new object[] { "UNDECIDED", "business", "mod_cook", "popular_comp", "psychology", "trad_cook" });
            cBType.Location = new Point(64, 264);
            cBType.Name = "cBType";
            cBType.Size = new Size(182, 33);
            cBType.TabIndex = 5;
            // 
            // cBPub
            // 
            cBPub.FormattingEnabled = true;
            cBPub.Location = new Point(64, 375);
            cBPub.Name = "cBPub";
            cBPub.Size = new Size(182, 33);
            cBPub.TabIndex = 14;
            cBPub.SelectedIndexChanged += cBPub_SelectedIndexChanged;
            // 
            // lblPub
            // 
            lblPub.AutoSize = true;
            lblPub.Location = new Point(64, 323);
            lblPub.Name = "lblPub";
            lblPub.Size = new Size(84, 25);
            lblPub.TabIndex = 13;
            lblPub.Text = "Publisher";
            // 
            // tBPrice
            // 
            tBPrice.Location = new Point(454, 64);
            tBPrice.Name = "tBPrice";
            tBPrice.Size = new Size(150, 31);
            tBPrice.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 16);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 15;
            label4.Text = "Price";
            // 
            // tBAdvance
            // 
            tBAdvance.Location = new Point(454, 162);
            tBAdvance.Name = "tBAdvance";
            tBAdvance.Size = new Size(150, 31);
            tBAdvance.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 114);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 17;
            label5.Text = "Advance";
            // 
            // tBRyal
            // 
            tBRyal.Location = new Point(454, 269);
            tBRyal.Name = "tBRyal";
            tBRyal.Size = new Size(150, 31);
            tBRyal.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(462, 221);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 19;
            label6.Text = "Royalty";
            // 
            // rtbNotes
            // 
            rtbNotes.Location = new Point(664, 51);
            rtbNotes.Margin = new Padding(2);
            rtbNotes.Name = "rtbNotes";
            rtbNotes.Size = new Size(315, 152);
            rtbNotes.TabIndex = 118;
            rtbNotes.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(664, 16);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 117;
            label8.Text = "Notes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(454, 425);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(141, 25);
            label9.TabIndex = 120;
            label9.Text = "Date Publication";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(664, 425);
            dtpDate.Margin = new Padding(2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(351, 31);
            dtpDate.TabIndex = 119;
            // 
            // tBYrSales
            // 
            tBYrSales.Location = new Point(446, 371);
            tBYrSales.Name = "tBYrSales";
            tBYrSales.Size = new Size(150, 31);
            tBYrSales.TabIndex = 122;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(454, 323);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 121;
            label7.Text = "Year Sales";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(81, 474);
            btnInsertar.Margin = new Padding(2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 36);
            btnInsertar.TabIndex = 123;
            btnInsertar.Text = "Actualizar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(253, 483);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 124;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmActualizaTitulo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 562);
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
            Controls.Add(tBId);
            Controls.Add(label1);
            Name = "frmActualizaTitulo";
            Text = "frmActualizaTitulo";
            Load += frmActualizaTitulo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tBId;
        private TextBox tBTitle;
        private Label label2;
        private Label label3;
        private ComboBox cBType;
        private ComboBox cBPub;
        private Label lblPub;
        private TextBox tBPrice;
        private Label label4;
        private TextBox tBAdvance;
        private Label label5;
        private TextBox tBRyal;
        private Label label6;
        private RichTextBox rtbNotes;
        private Label label8;
        private Label label9;
        private DateTimePicker dtpDate;
        private TextBox tBYrSales;
        private Label label7;
        private Button btnInsertar;
        private Button button1;
    }
}