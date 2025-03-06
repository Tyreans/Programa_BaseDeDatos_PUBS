using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceso_Datos_App_P23130577
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            frmEmployees frmEmployees = new frmEmployees();
            frmEmployees.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTitles frmTitles = new frmTitles();
            frmTitles.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAutores frmAutores = new frmAutores();
            frmAutores.Show();
        }
    }
}
