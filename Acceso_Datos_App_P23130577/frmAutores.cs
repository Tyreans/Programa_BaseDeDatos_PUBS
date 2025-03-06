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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void frmAutores_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dataGridView1[0, e.RowIndex].Value.ToString();
            string b = dataGridView1[1, e.RowIndex].Value.ToString();
            string c = dataGridView1[2, e.RowIndex].Value.ToString();
            string d = dataGridView1[3, e.RowIndex].Value.ToString();
            string ex = dataGridView1[4, e.RowIndex].Value.ToString();
            string f = dataGridView1[5, e.RowIndex].Value.ToString();
            string g = dataGridView1[6, e.RowIndex].Value.ToString();
            string h = dataGridView1[7, e.RowIndex].Value.ToString();
            bool i = Convert.ToBoolean(dataGridView1[8, e.RowIndex].Value);

            frmActualizaAutor frm = new frmActualizaAutor(a, b, c, d, ex, f, g, h, i);
            frm.Show();
        }

        private void ActualizarGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select au_id as ID, au_lname as " +
                "[Last Name], au_fname as [First Name], phone as Phone, " +
                "authors.address as Address, city as City, state as State, " +
                "zip as Zip, contract as Contract From authors");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void frmAutores_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInsertar f = new frmInsertar();
            f.Show();
        }
    }
}
