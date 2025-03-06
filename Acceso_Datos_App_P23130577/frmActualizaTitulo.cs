using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using static Azure.Core.HttpHeader;

namespace Acceso_Datos_App_P23130577
{
    public partial class frmActualizaTitulo : Form
    {
        Datos datos; DataSet ds;
        public frmActualizaTitulo(string id, string title, string type, string publisher, string price, string advance, string royalty, string yr, string date, string note)
        {
            InitializeComponent();
            tBId.Text = "BU1032";
            datos = new Datos();
            ds = datos.consulta("Select * From publishers");
            cBPub.DataSource = ds.Tables[0];
            cBPub.DisplayMember = "pub_name";
            cBPub.ValueMember = "pub_id";
            tBId.Text = id;
            tBTitle.Text = title;
            cBType.SelectedValue = type;
            if (int.TryParse(publisher, out int pubIdValue))
            {
                cBPub.SelectedValue = pubIdValue;
            }
            tBPrice.Text = price;
            tBAdvance.Text = advance;
            tBRyal.Text = royalty;
            tBYrSales.Text = yr;
            dtpDate.Text = date;
            rtbNotes.Text = note;
        }

        private void cBPub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView selectedRow = cBPub.SelectedItem as DataRowView;
                string pub_id = (selectedRow["pub_id"]) + "";
                string id = tBId.Text, Name = tBTitle.Text, type = cBType.SelectedText,
                    price = tBPrice.Text, advance = tBAdvance.Text, royalty = tBRyal.Text,
                    ytd_sales = tBYrSales.Text, notes = rtbNotes.Text, date = dtpDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

                Datos datos = new Datos();
                bool f = datos.comando("UPDATE titles SET " +
               "title='" + Name + "', " +
               "type='" + type + "', " +
               "pub_id='" + pub_id + "', " +
               "price=" + price + ", " +
               "advance=" + advance + ", " +
               "royalty=" + royalty + ", " +
               "ytd_sales=" + ytd_sales + ", " +
               "notes='" + notes + "', " +
               "pubdate='" + date + "' " +
               "WHERE title_id='" + id + "'");
                if (f == true)
                {
                    MessageBox.Show("Se han actualizado los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha salido algo mal");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseaes eliminar?", "Sistema", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Datos datos = new Datos();
                string id = tBId.Text;
                Boolean f = datos.comando("DELETE FROM TITLES WHERE title_id='" + id + "';");
                if (f == true)
                {
                    MessageBox.Show("Registro eliminado", "Sistema", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Registro eliminado", "Sistema", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void frmActualizaTitulo_Load(object sender, EventArgs e)
        {

        }
    }
}
