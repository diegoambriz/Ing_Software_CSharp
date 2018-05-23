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
    public partial class Productos : Form
    {
        int numeroProducto, existencias, numProdAux;
        decimal costoProducto, precioProducto;
        string nombreProducto, descripcion;
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            //this.productosTableAdapter.Update(this.gym_Manager1DataSet.Productos);
            //this.productosTableAdapter.Fill(this.gym_Manager1DataSet.Productos);
            Eliminar.Enabled = false;
            Modificar.Enabled = false;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valida_Registro() == true)
                {
                    if (buscaClave(numeroProducto) != 1)
                    {
                        //this.productosTableAdapter.Alta_Producto(numeroProducto, nombreProducto, costoProducto, precioProducto, existencias, descripcion);
                        MessageBox.Show("Registro Guardado Exitosamente");
                        //this.productosTableAdapter.Fill(this.gym_Manager1DataSet.Productos);
                        //this.productosTableAdapter.Update(this.gym_Manager1DataSet.Productos);
                        Limpia_Registro();
                        Numero_de_Producto.Focus();
                    }
                }
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error de concurrencia:\n" + ex.Message);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Numero_de_Producto.Text != "")
            {
                try
                {
                   // this.productosTableAdapter.Baja_Producto(Convert.ToInt32(Numero_de_Producto.Text));
                    MessageBox.Show("Registro Eliminado Exitosamente");
                    //this.productosTableAdapter.Fill(this.gym_Manager1DataSet.Productos);
                    //this.productosTableAdapter.Update(this.gym_Manager1DataSet.Productos);
                    Limpia_Registro();
                    Eliminar.Enabled = false;
                    Modificar.Enabled = false;
                    Numero_de_Producto.Focus();
                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show("Error de concurrencia:\n" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID de Producto Valido para Continuar");
                Numero_de_Producto.Focus();
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if(Numero_de_Producto.Text != "")
            {
                    if (Valida_Registro() == true)
                    {
                       try
                       {
                            //this.productosTableAdapter.Modifica_Producto(numeroProducto, nombreProducto, costoProducto, precioProducto, existencias, descripcion, numProdAux);
                            MessageBox.Show("Registro Actualizado Exitosamente");
                            //this.productosTableAdapter.Update(this.gym_Manager1DataSet.Productos);
                            //this.productosTableAdapter.Fill(this.gym_Manager1DataSet.Productos);
                            Eliminar.Enabled = false;
                            Modificar.Enabled = false;
                            Limpia_Registro();
                            Numero_de_Producto.Focus();
                        }
                        catch (DBConcurrencyException ex)
                        {
                            MessageBox.Show("Error de concurrencia:\n" + ex.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
            }
            else
            {
                MessageBox.Show("Ingrese un ID de Producto Valido para Continuar");
                Numero_de_Producto.Focus();
            }
            
        }

        private void Buscar_Producto_Click(object sender, EventArgs e)
        {
            int datoT = 0, claveAux = 0;
            //this.productosTableAdapter.Update(this.gym_Manager1DataSet.Productos);

            if (Numero_Producto_Buscar.Text != "")
            {
                claveAux = int.Parse(Numero_Producto_Buscar.Text);
                if (buscaProducto(claveAux) != 1)
                {
                    MessageBox.Show("El Id de Producto " + claveAux + " No Existe en la base de Datos, Ingrese un Id de Producto Valido");
                    Limpia_Registro();
                    Numero_Producto_Buscar.Clear();
                    Numero_Producto_Buscar.Focus();
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        datoT = Convert.ToInt32(row.Cells["idProductoDataGridViewTextBoxColumn"].Value);
                        if (datoT == claveAux)
                        {
                            Numero_de_Producto.Text = Convert.ToString(row.Cells["idProductoDataGridViewTextBoxColumn"].Value);
                            Nombre_Producto.Text = Convert.ToString(row.Cells["nombreProductoDataGridViewTextBoxColumn"].Value);
                            Costo_Producto.Text = Convert.ToString(row.Cells["costoProductoDataGridViewTextBoxColumn"].Value);
                            Precio_Producto.Text = Convert.ToString(row.Cells["precioProductoDataGridViewTextBoxColumn"].Value);
                            Existencias2.Text = Convert.ToString(row.Cells["existenciasDataGridViewTextBoxColumn"].Value);
                            Descripcion2.Text = Convert.ToString(row.Cells["descripcionDataGridViewTextBoxColumn"].Value);
                            numProdAux = Convert.ToInt32(Numero_Producto_Buscar.Text);
                            Numero_Producto_Buscar.Clear();
                            Eliminar.Enabled = true;
                            Modificar.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Id de Producto Valido para Continuar");
                Limpia_Registro();
                //this.productosTableAdapter.Fill(this.gym_Manager1DataSet.Productos);
                Numero_Producto_Buscar.Focus();
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private int buscaClave(int idProducto)
        {
            //this.productosTableAdapter.Update(this.gym_Manager1DataSet.Productos);
            int existe = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int idProductoAux = Convert.ToInt32(row.Cells["idProductoDataGridViewTextBoxColumn"].Value);
                if (idProductoAux == idProducto)
                {
                    MessageBox.Show("El idProducto " + idProducto + " ya Existe en la Base de Datos, Ingrese una clave diferente");
                    Numero_de_Producto.Focus();
                    existe = 1;
                    break;
                }
            }
            return existe;
        }

        private int buscaProducto(int nProducto)
        {
            //this.productosTableAdapter.Update(this.gym_Manager1DataSet.Productos);

            int idProductoAux, existe = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                idProductoAux = Convert.ToInt32(row.Cells["idProductoDataGridViewTextBoxColumn"].Value);
                if (idProductoAux == nProducto)
                {
                    existe = 1;
                    break;
                }
            }
            return existe;
        }

        private bool Valida_Registro()
        {
            bool band;

            if (Numero_de_Producto.Text != "" && Convert.ToInt32(Numero_de_Producto.Text) > 0)
            {
                numeroProducto = Convert.ToInt32(Numero_de_Producto.Text);
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Numero de Producto' Para continuar");
                Numero_de_Producto.Focus();
                band = false;
                return band;
            }

            if (Nombre_Producto.Text != "")
            {
                nombreProducto = Nombre_Producto.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Nombre de Producto' Para continuar");
                Nombre_Producto.Focus();
                band = false;
                return band;
            }

            if (Costo_Producto.Text != "" && Convert.ToDecimal(Costo_Producto.Text) > 0)
            {
                costoProducto = Convert.ToDecimal(Costo_Producto.Text);
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Costo de Producto' Para continuar");
                Costo_Producto.Focus();
                band = false;
                return band;
            }

            if (Precio_Producto.Text != "" && Convert.ToDecimal(Precio_Producto.Text) > 0)
            {
                precioProducto = Convert.ToDecimal(Precio_Producto.Text);
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Precio de Producto' Para continuar");
                Precio_Producto.Focus();
                band = false;
                return band;
            }

            if (Existencias2.Text != "" && Convert.ToInt32(Existencias2.Text) > 0)
            {
                existencias = Convert.ToInt32(Existencias2.Text);
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Existencias' Para continuar");
                Existencias2.Focus();
                band = false;
                return band;
            }

            if (Descripcion2.Text != "")
            {
                descripcion = Descripcion2.Text;
                band = true;
            }
            else
            {
                descripcion = null;
            }

            return band;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Limpia_Registro();
            Eliminar.Enabled = false;
            Modificar.Enabled = false;
        }

        private void Limpia_Registro()
        {
            Numero_de_Producto.Clear();
            Nombre_Producto.Clear();
            Costo_Producto.Clear();
            Precio_Producto.Clear();
            Existencias2.Clear();
            Descripcion2.Clear();
        }

        private void Numero_de_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Costo_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Precio_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Existencias2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Numero_Producto_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
