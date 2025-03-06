using System;
using System.Collections;
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
        
    public partial class frmEmployees : Form
    {
        DataSet ds2;
        int job_id = 0; string pub_id=null;
        public frmEmployees()
        {
            InitializeComponent();
            Datos dts = new Datos();
            ds2 = dts.consulta("Select * from employee");
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            Datos obj = new Datos();
                DataSet ds = obj.consulta("SELECT emp_id AS ID, fname AS [First Name], minit AS [Middle Initial], lname AS [Last Name], job_desc AS 'Job Name', job_lvl AS Job_Level, pub_name AS Publisher, hire_date AS Hire_Date FROM employee INNER JOIN jobs ON employee.job_id = jobs.job_id INNER JOIN publishers ON employee.pub_id = publishers.pub_id ");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void frmEmployees_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dataGridView1[0, e.RowIndex].Value.ToString();
            string b = dataGridView1[1, e.RowIndex].Value.ToString();
            string c = dataGridView1[3, e.RowIndex].Value.ToString();
            string d = dataGridView1[4, e.RowIndex].Value.ToString();
            string ex = dataGridView1[5, e.RowIndex].Value.ToString();
            string f = dataGridView1[6, e.RowIndex].Value.ToString();
            string g = dataGridView1[7, e.RowIndex].Value.ToString();
            job_id = Convert.ToInt32(ds2.Tables[0].Rows[e.RowIndex]["job_id"]);
            pub_id = (ds2.Tables[0].Rows[e.RowIndex]["pub_id"]).ToString();
            frmActualizaEmpleado frm = new frmActualizaEmpleado(a, b, c, job_id.ToString(), ex, pub_id, g);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInsertEmployees frm = new frmInsertEmployees();
            frm.Show();
        }
    }
}
