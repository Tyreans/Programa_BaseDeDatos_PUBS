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
    public partial class frmTitles : Form
    {
        public frmTitles()
        {
            InitializeComponent();
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("SELECT title_id AS ID, title AS Title, type AS Type, " +
                "pub_id AS Publication_ID, price AS Price, advance AS Advance, " +
                "royalty AS Royalty, ytd_sales AS Year_To_Date_Sales, " +
                "notes AS Notes, pubdate AS Publication_Date " +
                "FROM titles");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void frmTitles_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dataGridView1[0, e.RowIndex].Value.ToString();
            string b = dataGridView1[1, e.RowIndex].Value.ToString();
            string c = dataGridView1[2, e.RowIndex].Value.ToString();
            string d = dataGridView1[3, e.RowIndex].Value.ToString();
            string ex = dataGridView1[4, e.RowIndex].Value.ToString();
            string f = dataGridView1[5, e.RowIndex].Value.ToString();
            string g = dataGridView1[6, e.RowIndex].Value.ToString();
            string h = dataGridView1[7, e.RowIndex].Value.ToString();
            string i = dataGridView1[8, e.RowIndex].Value.ToString();
            string j = dataGridView1[9, e.RowIndex].Value.ToString();


            frmActualizaTitulo frm = new frmActualizaTitulo(a, b, c, d, ex, f, g, h, j, i);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTitulo frm = new frmTitulo();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegalias frmRegalias = new frmRegalias();
            frmRegalias.Show();
        }
    }
}
