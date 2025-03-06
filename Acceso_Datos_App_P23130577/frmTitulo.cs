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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Acceso_Datos_App_P23130577
{
    public partial class frmTitulo : Form
    {
        string id = null;
        Datos datos; DataSet ds;
        public frmTitulo()
        {
            InitializeComponent();
            datos = new Datos();
            ds = datos.consulta("Select * From publishers");
            cBPub.DataSource = ds.Tables[0];
            cBPub.DisplayMember = "pub_name";
            cBPub.ValueMember = "pub_id";
        }

        private void frmTitulo_Load(object sender, EventArgs e)
        {

        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView selectedRow = cBPub.SelectedItem as DataRowView;
                Random random = new Random();
                int numeroAleatorio = random.Next(1000, 9999);
                id = (cBType.Text.ToString()).Substring(0,2)+numeroAleatorio;
                MessageBox.Show(id);
                string Name = tBTitle.Text, type = cBType.Text, pub_id = (selectedRow["pub_id"]) + "";

                string price = tBPrice.Text, advance = tBAdvance.Text, royalty = tBRyal.Text,
                    ytd_sales = tBYrSales.Text, notes = rtbNotes.Text, date = dtpDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

                Datos datos = new Datos();
                bool f = datos.comando("INSERT INTO titles(title_id,title,type,pub_id,price,advance,royalty,ytd_sales,notes,pubdate) VALUES" + "('" + id + "','" + Name + "','" + type + "','" + pub_id + "','" + price + "','" + advance + "','" + royalty + "'," + "'" + ytd_sales + "','" + notes + "','" + date + "')");
                if (f == true)
                {
                    MessageBox.Show("Se han insertado los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al insertar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                frmAgregarRegalias frm = new frmAgregarRegalias(id, Name);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo ha salido mal");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
