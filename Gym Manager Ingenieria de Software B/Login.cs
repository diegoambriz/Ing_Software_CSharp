using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Gym_Manager_Ingenieria_de_Software_B
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Gym Manager1.accdb");
            Conexion.Open();
            String Consulta = "select contraseña,usuario from Usuarios where contraseña='" + textBox2.Text + "' and usuario ='" + textBox1.Text + "';";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
            OleDbDataReader LectorDatos;
            LectorDatos = Comando.ExecuteReader();
            Boolean ExistenciaRegistros = LectorDatos.HasRows;

            if (ExistenciaRegistros)
            {
                MessageBox.Show("Bienvenido al sistema " + textBox1.Text, "Usuario autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }

            else
            {
                MessageBox.Show("Acceso denegado " + textBox1.Text, "Usuario NO autorizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Conexion.Close();
        }
    }
}
