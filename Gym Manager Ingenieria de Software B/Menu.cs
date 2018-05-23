using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Manager_Ingenieria_de_Software_B
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void Socios_Click(object sender, EventArgs e)
        {
            Socios socios = new Socios();
            this.Hide();
            socios.Show();
        }

        private void Productos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            this.Hide();
            productos.Show();
        }

        private void Proveedores_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            this.Hide();
            proveedores.Show();
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            this.Hide();
            ventas.Show();
        }

        private void Compras_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            this.Hide();
            compras.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
