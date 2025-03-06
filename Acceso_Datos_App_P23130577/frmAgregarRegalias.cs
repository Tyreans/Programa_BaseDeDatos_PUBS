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
    public partial class frmAgregarRegalias : Form
    {
        string id2 = null; StringBuilder query;
        public frmAgregarRegalias(string id, string nombre)
        {
            InitializeComponent();
            label1.Text = "Regalias para el libro '" + nombre + "'";
            id2 = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lorange = null; string hirange = null; string royalty = null;

            query = new StringBuilder();
            query.Append("INSERT INTO roysched (title_id, lorange, hirange, royalty) VALUES");
            try
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++) { 
                    lorange = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    hirange = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    royalty = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    if (i > 0)
                        query.Append(", ");
                    query.Append("('"+id2+"', '"+lorange+"', '"+hirange+"', '"+royalty+"')");
                }
                query.Append(";");
                string cons = query.ToString();
                Datos datos = new Datos();
                if (datos.comando(cons))
                {
                    MessageBox.Show("exito");
                }
                else {
                    MessageBox.Show("No se pudo realizar");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ha salido algo mal");
            }
        }
    }
}
