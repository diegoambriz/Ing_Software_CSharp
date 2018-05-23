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
    public partial class Ventas : Form
    {
        int idSocio, idProducto, idVenta, idDetalleVenta, cantidad, existencias, cantidadAux, idDetalleAux;
        decimal subtotal, total, precio;
        string fechaVenta;
        public Ventas()
        {
            InitializeComponent();
            idSocio = 0;
            idProducto = 0;
            idVenta = dataGridView3.RowCount+1;
            idDetalleVenta = 1;
            cantidad = 0;
            subtotal = 0;
            total = 0;
            precio = 0;
            Fecha_de_Venta.MaxDate = DateTime.Now;
            Fecha_de_Venta.Value = DateTime.Now;
            Id_de_Venta.Text = idVenta.ToString();
            fechaVenta = Fecha_de_Venta.Value.ToString();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            this.sociosTableAdapter.Update(this.gym_Manager1DataSet.Socios);
            this.ventasTableAdapter.Update(this.gym_Manager1DataSet.Ventas);
            this.productosTableAdapter.Update(this.gym_Manager1DataSet.Productos);
            this.detalle_VentaTableAdapter.Update(this.gym_Manager1DataSet.Detalle_Venta);

            this.sociosTableAdapter.Fill(this.gym_Manager1DataSet.Socios);
            this.ventasTableAdapter.Fill(this.gym_Manager1DataSet.Ventas);
            this.productosTableAdapter.Fill(this.gym_Manager1DataSet.Productos);
            this.detalle_VentaTableAdapter.Fill(this.gym_Manager1DataSet.Detalle_Venta);
        }

        private void Cobrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.dataGridView1.RowCount > 0)
                {
                    this.ventasTableAdapter.Alta_Venta(idVenta, idSocio, fechaVenta, total);
                    this.ventasTableAdapter.Update(this.gym_Manager1DataSet.Ventas);
                    this.ventasTableAdapter.Fill(this.gym_Manager1DataSet.Ventas);
                    this.detalle_VentaTableAdapter.Limpia_Detalle(idVenta);
                    this.detalle_VentaTableAdapter.Update(this.gym_Manager1DataSet.Detalle_Venta);
                    this.detalle_VentaTableAdapter.Fill(this.gym_Manager1DataSet.Detalle_Venta);
                    idVenta++;
                    Id_de_Venta.Text = idVenta.ToString();
                    Total.Text = "$0.00";
                    Id_Socio.Clear();
                    Id_Socio.Enabled = true;
                    Id_Socio.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese por lo menos un detalle de Venta Para Continuar");
                }
                
            }
            catch(DBConcurrencyException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.detalle_VentaTableAdapter.Limpia_Detalle(idVenta);
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private int buscaSocio(int nSocio)
        {
            this.sociosTableAdapter.Update(this.gym_Manager1DataSet.Socios);

            int idSocioAux, existe = 0;
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                idSocioAux = Convert.ToInt32(row.Cells["numeroSocioDataGridViewTextBoxColumn"].Value);
                if (idSocioAux == nSocio)
                {
                    existe = 1;
                    break;
                }
            }
            return existe;
        }
        private int buscaProducto(int nProducto)
        {
            this.productosTableAdapter.Update(this.gym_Manager1DataSet.Productos);

            int idProductoAux, existe = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                idProductoAux = Convert.ToInt32(row.Cells["idProductoDataGridViewTextBoxColumn1"].Value);
                if (idProductoAux == nProducto)
                {
                    existe = 1;
                    break;
                }
            }
            return existe;
        }

        private int buscaProductoVenta(int nProducto)
        {
            this.detalle_VentaTableAdapter.Update(this.gym_Manager1DataSet.Detalle_Venta);

            int idProductoAux;
            int existe = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                idProductoAux = Convert.ToInt32(row.Cells["idProductoDataGridViewTextBoxColumn"].Value);
                if (idProductoAux == nProducto)
                {
                    existe = 1;
                    idDetalleAux = Convert.ToInt32(row.Cells["idDetalleVentaDataGridViewTextBoxColumn"].Value);
                    break;
                }
            }
            return existe;
        }

        private void Id_Producto_TextChanged(object sender, EventArgs e)
        {
            int datoT = 0, claveAux = 0;
            this.productosTableAdapter.Update(this.gym_Manager1DataSet.Productos);

            if (Id_Producto.Text != "")
            {
                claveAux = int.Parse(Id_Producto.Text);
                if (buscaProducto(claveAux) != 1)
                {
                    MessageBox.Show("El Id de Producto " + claveAux + " No Existe en la base de Datos, Ingrese un Id de Producto Valido");
                    Limpia_Registro_Producto();
                    Id_Producto.Focus();
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        datoT = Convert.ToInt32(row.Cells["idProductoDataGridViewTextBoxColumn1"].Value);
                        if (datoT == claveAux)
                        {
                            Id_Producto.Text = Convert.ToString(row.Cells["idProductoDataGridViewTextBoxColumn1"].Value);
                            Nombre_Producto.Text = Convert.ToString(row.Cells["nombreProductoDataGridViewTextBoxColumn"].Value);
                            Precio.Text = Convert.ToString(row.Cells["precioProductoDataGridViewTextBoxColumn"].Value);
                        }
                    }
                }
            }
            else
            {
                Limpia_Registro_Producto();
                Id_Producto.Focus();
            }
        }

        private void Id_Socio_TextChanged(object sender, EventArgs e)
        {
            int datoT = 0, claveAux = 0;
            this.sociosTableAdapter.Update(this.gym_Manager1DataSet.Socios);

            if (Id_Socio.Text != "")
            {
                claveAux = int.Parse(Id_Socio.Text);
                if (buscaSocio(claveAux) != 1 )
                {
                    MessageBox.Show("El Id de Socio " + claveAux + " No Existe en la base de Datos, Ingrese un Id de Socio Valido");
                    Limpia_Registro_Socio();
                    Id_Socio.Focus();
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView4.Rows)
                    {
                        datoT = Convert.ToInt32(row.Cells["numeroSocioDataGridViewTextBoxColumn"].Value);
                        if (datoT == claveAux)
                        {
                            Id_Socio.Text = Convert.ToString(row.Cells["numeroSocioDataGridViewTextBoxColumn"].Value);
                            Nombre_Socio.Text = Convert.ToString(row.Cells["nombreDataGridViewTextBoxColumn"].Value);
                            Apellido_Paterno.Text = Convert.ToString(row.Cells["apellidoPaternoDataGridViewTextBoxColumn"].Value);
                            Apellido_Materno.Text = Convert.ToString(row.Cells["apellidoMaternoDataGridViewTextBoxColumn"].Value);
                        }
                    }
                }
            }
            else
            {
                Limpia_Registro_Socio();
                Id_Socio.Focus();
            }
        }

        private void Buscar_Socio_Click(object sender, EventArgs e)
        {
            
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valida_Registro() == true)
                {
                    existencias = obtener_Existencias(idProducto);

                    if (existencias > 0 && cantidad < existencias)
                    {
                        if (buscaProductoVenta(idProducto) != 1)
                        {
                            Id_Socio.Enabled = false;
                            cantidad = Convert.ToInt32(Cantidad.Value);
                            precio = Convert.ToDecimal(Precio.Text);
                            subtotal = (precio * cantidad);
                            this.detalle_VentaTableAdapter.Alta_Detalle_Venta(idDetalleVenta, idVenta, idProducto, cantidad, subtotal);
                            idDetalleVenta++;
                            this.detalle_VentaTableAdapter.Update(this.gym_Manager1DataSet.Detalle_Venta);
                            this.detalle_VentaTableAdapter.Fill(this.gym_Manager1DataSet.Detalle_Venta);
                            this.productosTableAdapter.Actualiza_Existencias((existencias - cantidad), idProducto);
                            this.productosTableAdapter.Update(this.gym_Manager1DataSet.Productos);
                            this.productosTableAdapter.Fill(this.gym_Manager1DataSet.Productos);
                            subtotal = Convert.ToDecimal(this.detalle_VentaTableAdapter.Calcula_Total());
                            Total.Text = "$" + subtotal.ToString();
                            total = subtotal;
                            Limpia_Registro_Producto();
                            Id_Producto.Clear();
                            Id_Producto.Focus();
                        }
                        else
                        {
                            cantidadAux = obtener_cantidadProducto(idProducto);
                            Id_Socio.Enabled = false;
                            cantidad = Convert.ToInt32(Cantidad.Value);
                            precio = Convert.ToDecimal(Precio.Text);
                            subtotal = (precio * (cantidad + cantidadAux));
                            this.detalle_VentaTableAdapter.Actualiza_Cantidad(idDetalleAux, idVenta, idProducto, cantidad + cantidadAux, subtotal, idProducto);
                            this.detalle_VentaTableAdapter.Update(this.gym_Manager1DataSet.Detalle_Venta);
                            this.detalle_VentaTableAdapter.Fill(this.gym_Manager1DataSet.Detalle_Venta);
                            this.productosTableAdapter.Actualiza_Existencias((existencias - cantidad), idProducto);
                            this.productosTableAdapter.Update(this.gym_Manager1DataSet.Productos);
                            this.productosTableAdapter.Fill(this.gym_Manager1DataSet.Productos);
                            subtotal = Convert.ToDecimal(this.detalle_VentaTableAdapter.Calcula_Total());
                            Total.Text = "$" + subtotal.ToString();
                            total = subtotal;
                            Limpia_Registro_Producto();
                            Id_Producto.Clear();
                            Id_Producto.Focus();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Existencias Insuficientes para realizar la Venta");
                        Limpia_Registro_Producto();
                        Id_Producto.Focus();
                    }
                }
                else
                {
                    Id_Producto.Focus();
                }
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error de concurrencia:\n" + ex.Message);
            }
        }

        private int obtener_Existencias(int idProd)
        {
            int existencias = 0,datoT;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                datoT = Convert.ToInt32(row.Cells["idProductoDataGridViewTextBoxColumn1"].Value);
                if (datoT == idProd)
                {
                    existencias = Convert.ToInt32(row.Cells["existenciasDataGridViewTextBoxColumn"].Value);
                }
            }
            return existencias;
        }

        private int obtener_cantidadProducto(int idProd)
        {
            int cantidad = 0, datoT;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                datoT = Convert.ToInt32(row.Cells["idProductoDataGridViewTextBoxColumn"].Value);
                if (datoT == idProd)
                {
                    cantidad = Convert.ToInt32(row.Cells["cantidadDataGridViewTextBoxColumn"].Value);
                }
            }
            return cantidad;
        }

        private bool Valida_Registro()
        {
            bool band;

            if (Id_Socio.Text != "" && Convert.ToInt32(Id_Socio.Text) > 0 && buscaSocio(Convert.ToInt32(Id_Socio.Text))==1 )
            {
                idSocio = Convert.ToInt32(Id_Socio.Text);
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor Valido Para 'Id de Socio' Para Continuar");
                Id_Socio.Focus();
                band = false;
                return band;
            }

            if (Id_Producto.Text != "" && Convert.ToInt32(Id_Producto.Text) > 0 && buscaProducto(Convert.ToInt32(Id_Producto.Text)) == 1)
            {
                idProducto = Convert.ToInt32(Id_Producto.Text);
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor Valido Para 'Id de Producto' Para Continuar");
                Id_Producto.Focus();
                band = false;
                return band;
            }

            return band;
        }

        private void Limpia_Registro_Producto()
        {
            Nombre_Producto.Clear();
            Precio.Clear();
            Cantidad.Value = 1;
        }

        private void Limpia_Registro_Socio()
        {
            Nombre_Socio.Clear();
            Apellido_Paterno.Clear();
            Apellido_Materno.Clear();
        }

        private void Id_Socio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Id_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}