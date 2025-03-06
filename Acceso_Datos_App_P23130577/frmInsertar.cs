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
using Microsoft.VisualBasic;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net;

namespace Acceso_Datos_App_P23130577
{
    public partial class frmInsertar : Form
    {
        public frmInsertar()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("INSERT INTO authors(au_id,au_fname,au_lname,phone,address,city,state,zip,contract) VALUES ('" +
                tBId.Text + "','" +
                tBFName.Text + "','" +
                tBLName.Text + "','" +
                tBPhone.Text + "','" +
                tBAddress.Text + "','" +
                tBCity.Text + "','" +
                tBZip.Text + "','" +
                (cBContract.Checked ? 1 : 0) + "');"
            );


            if (f == true)
            {
                MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertar_Load(object sender, EventArgs e)
        {

        }
    }
}
