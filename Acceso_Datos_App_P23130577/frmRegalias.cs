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
    public partial class frmRegalias : Form
    {
        public frmRegalias()
        {
            InitializeComponent();
        }

        private void frmRegalias_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void actualizarGrid() {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select title_id as 'ID Libro', lorange as 'Min. Sales', hirange as 'Max. Sales', royalty as Royalty From roysched");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
