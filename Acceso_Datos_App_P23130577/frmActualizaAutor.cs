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
    public partial class frmActualizaAutor : Form
    {
        public frmActualizaAutor(string id, string fname, string lname, string phone, string address, string city, string state, string zcode, bool contract)
        {
            InitializeComponent();
            tBId.Text = id;
            tBFName.Text = fname;
            tBLName.Text = lname;
            tBPhone.Text = phone;
            tBAddress.Text = address;
            tBCity.Text = city;
            tBState.Text = state;
            tBZip.Text = zcode;
            cBContract.Checked = contract;
        }

        private void frmActualizaAutor_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAactualizar_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE authors SET " +
               $"au_fname = '{tBFName.Text}', " +
               $"au_lname = '{tBLName.Text}', " +
               $"phone = '{tBPhone.Text}', " +
               $"address = {(string.IsNullOrEmpty(tBAddress.Text) ? "NULL" : $"'{tBAddress.Text}'")}, " +
               $"city = {(string.IsNullOrEmpty(tBCity.Text) ? "NULL" : $"'{tBCity.Text}'")}, " +
               $"state = {(string.IsNullOrEmpty(tBState.Text) ? "NULL" : $"'{tBState.Text}'")}, " +
               $"zip = {(string.IsNullOrEmpty(tBZip.Text) ? "NULL" : $"'{tBZip.Text}'")}, " +
               $"contract = {(cBContract.Checked ? 1 : 0)} " +
               $"WHERE au_id = '{tBId.Text}';";

            Datos datos = new Datos();
            bool f = datos.comando(query);

            if (f)
            {
                MessageBox.Show("Datos Actualizados", "Sistema", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Sistema", MessageBoxButtons.OK);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Esta seguro de eliminar este registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from authors where au_id='" + tBId.Text + "'");
                if (f)
                {
                    MessageBox.Show("Se ha eliminado con exito");
                }
                else {
                    MessageBox.Show("Error al eliminar");
                }
                this.Close();
            }
            else { 
                
            }
        }
    }
}
