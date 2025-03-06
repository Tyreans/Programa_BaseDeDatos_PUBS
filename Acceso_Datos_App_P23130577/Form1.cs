namespace Acceso_Datos_App_P23130577
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            bool f = obj.prueba();
            if (f)
            {
                MessageBox.Show("Conexion Exitosa");
            }
            else {
                MessageBox.Show("Error en la conexion");
            }
        }
    }
}
