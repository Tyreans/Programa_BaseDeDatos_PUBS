namespace Acceso_Datos_App_P23130577
{
    partial class Menu
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
            Empleados = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Empleados
            // 
            Empleados.Location = new Point(68, 18);
            Empleados.Name = "Empleados";
            Empleados.Size = new Size(112, 34);
            Empleados.TabIndex = 0;
            Empleados.Text = "Empleados";
            Empleados.UseVisualStyleBackColor = true;
            Empleados.Click += Empleados_Click;
            // 
            // button2
            // 
            button2.Location = new Point(68, 85);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Titulos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(68, 167);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "Autores";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 238);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Empleados);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button Empleados;
        private Button button2;
        private Button button3;
    }
}