using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Acceso_Datos_App_P23130577
{
    public partial class frmInsertEmployees : Form
    {
        Datos datos; DataSet ds; DataSet dsp; int Index;
        public frmInsertEmployees()
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
        }

        private void frmInsertEmployees_Load(object sender, EventArgs e)
        {

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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int numeroAleatorio = random.Next(10000, 99999);
                DataRowView selectedRow = cBPub.SelectedItem as DataRowView;
                string sex = comboBox1.Text;
                string id;
                string lname = tbLName.Text;
                string fname = tBFName.Text;
                string a = tBSName.Text; string minit;
                if (a == "")
                {
                    id = fname[0].ToString() + "-" + lname[0].ToString() + numeroAleatorio.ToString() + sex[0].ToString();
                    MessageBox.Show(id);
                    minit = null;
                }
                else {
                    id = fname[0].ToString() + a[0].ToString() + lname[0].ToString() + numeroAleatorio.ToString() + sex[0].ToString();
                    MessageBox.Show(id);
                    minit = a[0].ToString();
                }
                string idjob = Index + "";
                string lvljob = tBLvl.Value.ToString();
                string idpub = (selectedRow["pub_id"]) + "";
                string date = dtpHireDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

                Datos datos = new Datos();
                bool f = datos.comando("insert into employee(emp_id,fname,lname,minit,job_id,job_lvl,pub_id,hire_date)" + "values ('" + id + "','" + fname + "','" + lname + "','" + minit + "','" + idjob + "','" + lvljob + "','" + idpub + "','" + date + "');");

                if (f)
                {
                    MessageBox.Show("Registro Exitoso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar, verifique que el formato del ID es el corrector (AAA10000F o AAA10000M)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha salido algo mal");
            }
        }
    }
}
