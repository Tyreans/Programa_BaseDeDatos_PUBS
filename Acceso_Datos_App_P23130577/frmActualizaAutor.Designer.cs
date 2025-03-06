namespace Acceso_Datos_App_P23130577
{
    partial class frmActualizaAutor
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
            lblFName = new Label();
            tBFName = new TextBox();
            tBLName = new TextBox();
            label3 = new Label();
            tBPhone = new TextBox();
            label4 = new Label();
            tBAddress = new TextBox();
            label5 = new Label();
            tBCity = new TextBox();
            label6 = new Label();
            tBState = new TextBox();
            label7 = new Label();
            tBZip = new TextBox();
            label8 = new Label();
            cBContract = new CheckBox();
            btnAactualizar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // tBId
            // 
            tBId.Location = new Point(84, 31);
            tBId.Name = "tBId";
            tBId.ReadOnly = true;
            tBId.Size = new Size(150, 31);
            tBId.TabIndex = 1;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(38, 90);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(97, 25);
            lblFName.TabIndex = 2;
            lblFName.Text = "First Name";
            // 
            // tBFName
            // 
            tBFName.Location = new Point(141, 87);
            tBFName.Name = "tBFName";
            tBFName.Size = new Size(150, 31);
            tBFName.TabIndex = 3;
            tBFName.TextChanged += textBox2_TextChanged;
            // 
            // tBLName
            // 
            tBLName.Location = new Point(141, 155);
            tBLName.Name = "tBLName";
            tBLName.Size = new Size(150, 31);
            tBLName.TabIndex = 5;
            tBLName.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 158);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // tBPhone
            // 
            tBPhone.Location = new Point(141, 225);
            tBPhone.Name = "tBPhone";
            tBPhone.Size = new Size(150, 31);
            tBPhone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 225);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // tBAddress
            // 
            tBAddress.Location = new Point(141, 295);
            tBAddress.Name = "tBAddress";
            tBAddress.Size = new Size(150, 31);
            tBAddress.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 295);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 8;
            label5.Text = "Address";
            // 
            // tBCity
            // 
            tBCity.Location = new Point(141, 354);
            tBCity.Name = "tBCity";
            tBCity.Size = new Size(150, 31);
            tBCity.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 360);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 10;
            label6.Text = "City";
            // 
            // tBState
            // 
            tBState.Location = new Point(535, 31);
            tBState.Name = "tBState";
            tBState.Size = new Size(150, 31);
            tBState.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(445, 31);
            label7.Name = "label7";
            label7.Size = new Size(51, 25);
            label7.TabIndex = 12;
            label7.Text = "State";
            // 
            // tBZip
            // 
            tBZip.Location = new Point(535, 90);
            tBZip.Name = "tBZip";
            tBZip.Size = new Size(150, 31);
            tBZip.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(445, 90);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 14;
            label8.Text = "ZIP Code";
            // 
            // cBContract
            // 
            cBContract.AutoSize = true;
            cBContract.Location = new Point(449, 167);
            cBContract.Name = "cBContract";
            cBContract.Size = new Size(105, 29);
            cBContract.TabIndex = 16;
            cBContract.Text = "Contract";
            cBContract.UseVisualStyleBackColor = true;
            // 
            // btnAactualizar
            // 
            btnAactualizar.Location = new Point(524, 225);
            btnAactualizar.Name = "btnAactualizar";
            btnAactualizar.Size = new Size(133, 34);
            btnAactualizar.TabIndex = 17;
            btnAactualizar.Text = "Actualizar";
            btnAactualizar.UseVisualStyleBackColor = true;
            btnAactualizar.Click += btnAactualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(524, 281);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 34);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(487, 332);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(198, 34);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar Registro";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmActualizaAutor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAactualizar);
            Controls.Add(cBContract);
            Controls.Add(tBZip);
            Controls.Add(label8);
            Controls.Add(tBState);
            Controls.Add(label7);
            Controls.Add(tBCity);
            Controls.Add(label6);
            Controls.Add(tBAddress);
            Controls.Add(label5);
            Controls.Add(tBPhone);
            Controls.Add(label4);
            Controls.Add(tBLName);
            Controls.Add(label3);
            Controls.Add(tBFName);
            Controls.Add(lblFName);
            Controls.Add(tBId);
            Controls.Add(label1);
            Name = "frmActualizaAutor";
            Text = "frmActualizaAutor";
            Load += frmActualizaAutor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tBId;
        private Label lblFName;
        private TextBox tBFName;
        private TextBox tBLName;
        private Label label3;
        private TextBox tBPhone;
        private Label label4;
        private TextBox tBAddress;
        private Label label5;
        private TextBox tBCity;
        private Label label6;
        private TextBox tBState;
        private Label label7;
        private TextBox tBZip;
        private Label label8;
        private CheckBox cBContract;
        private Button btnAactualizar;
        private Button btnCancelar;
        private Button btnEliminar;
    }
}