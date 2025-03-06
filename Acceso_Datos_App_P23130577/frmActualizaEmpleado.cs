using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Acceso_Datos_App_P23130577
{
    public partial class frmActualizaEmpleado : Form
    {
        Datos datos; DataSet ds; DataSet dsp; int Index;
        public frmActualizaEmpleado(string id, string fn, string ln, string job_id, string lvl, string pub, string hire)
        {

            InitializeComponent();
            tBLvl.Enabled = true;
            datos = new Datos();
            ds = datos.consulta("Select * From jobs");
            dsp = datos.consulta("Select * From publishers");
            cBJobs.DataSource = ds.Tables[0];
            cBJobs.DisplayMember = "job_desc";
            cBJobs.ValueMember = "job_id";
            cBPub.DataSource = dsp.Tables[0];
            cBPub.DisplayMember = "pub_name";
            cBPub.ValueMember = "pub_id";
            cBPub.SelectedValue = pub;

            tBId.Text = id;
            tBFName.Text = fn;
            tbLName.Text = ln;

            if (int.TryParse(job_id, out int jobIdValue))
            {
                cBJobs.SelectedValue = jobIdValue;
            }
            else
            {
                MessageBox.Show("Error al convertir job_id: " + job_id);
            }

            //if (int.TryParse(lvl, out int lvlValue))
            //{
            //    tBLvl.Value = lvlValue;
            //    lblLvl.Text = lvl;
            //}

            //if (int.TryParse(pub, out int pubIdValue))
            //{
            //    cBPub.SelectedValue = pubIdValue;
            //}
            //else
            //{
            //    MessageBox.Show("Error al convertir job_id: " + job_id);
            //}

            dtpHireDate.Text = hire;


        }

        private void cBJobs_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cBJobs.SelectedIndex != -1 && cBJobs.SelectedValue != null)
            {
                DataRowView selectedRow = cBJobs.SelectedItem as DataRowView;

                if (selectedRow != null)
                {
                    lblNvl.Text = "...";
                    Index = (Convert.ToInt32(selectedRow["job_id"]));
                    tBLvl.Enabled = true;
                    tBLvl.Maximum = Convert.ToInt32(ds.Tables[0].Rows[Index - 1]["max_lvl"]);
                    tBLvl.Minimum = Convert.ToInt32(ds.Tables[0].Rows[Index - 1]["min_lvl"]);
                }
            }
        }

        private void tBLvl_Scroll(object sender, EventArgs e)
        {
            lblNvl.Text = tBLvl.Value.ToString();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView selectedRow = cBPub.SelectedItem as DataRowView;
                string id = tBId.Text;
                string lname = tbLName.Text;
                string fname = tBFName.Text;
                char minit = fname[0];
                string idjob = Index + "";
                string lvljob = tBLvl.Value.ToString();
                string idpub = (selectedRow["pub_id"]) + "";
                string date = dtpHireDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

                Datos datos = new Datos();
                bool f = datos.comando("UPDATE employee SET " +
                     "fname='" + fname + "', " +
                    "lname='" + lname + "', " +
                    "minit='" + minit + "', " +
                    "job_id='" + idjob + "', " +
                    "job_lvl='" + lvljob + "', " +
                    "pub_id='" + idpub + "', " +
                    "hire_date='" + date + "' " +
                    "WHERE emp_id='" + id + "';"
                );

                if (f)
                {
                    MessageBox.Show("Registro Exitoso");

                }
                else
                {
                    MessageBox.Show("No se pudo realizar");
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
                bool f = datos.comando("DELETE FROM employee WHERE emp_id='" + id + "';");
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

        private void frmActualizaEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void cBPub_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
