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
    public partial class Proveedores : Form
    {
        int numeroProveedor, numeroExterior, codigoPostal, telefonoFijo, numProvAux;
        string nombre, calle, numeroInterior, colonia, telefonoCelular, correoElectronico;
        
        public Proveedores()
        {
            InitializeComponent();

            numeroProveedor = 0;
            numeroExterior = 0;
            codigoPostal = 0;
            telefonoFijo = 0;
            nombre = "";
            calle = "";
            numeroInterior = "";
            colonia = "";
            telefonoCelular = "";
            correoElectronico = "";
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            //this.proveedoresTableAdapter.Update(this.gym_Manager1DataSet.Proveedores);
            //this.proveedoresTableAdapter.Fill(this.gym_Manager1DataSet.Proveedores);
            Numero_de_Proveedor.Focus();
            Eliminar.Enabled = false;
            Modificar.Enabled = false;
        }
       
        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valida_Registro() == true)
                {
                    if (buscaClave(numeroProveedor) != 1)
                    {
                        //this.proveedoresTableAdapter.Alta_Proveedor(numeroProveedor, nombre, calle, numeroExterior,numeroInterior, colonia, codigoPostal, telefonoFijo, telefonoCelular, correoElectronico);
                        MessageBox.Show("Registro Guardado Exitosamente");
                        //this.proveedoresTableAdapter.Fill(this.gym_Manager1DataSet.Proveedores);
                        //this.proveedoresTableAdapter.Update(this.gym_Manager1DataSet.Proveedores);
                        Limpia_Registro();
                        Numero_de_Proveedor.Focus();
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
            if (Numero_de_Proveedor.Text != "")
            {
                try
                {
                    //this.proveedoresTableAdapter.Baja_Proveedor(Convert.ToInt32(Numero_de_Proveedor.Text));
                    MessageBox.Show("Registro Eliminado Exitosamente");
                    //this.proveedoresTableAdapter.Fill(this.gym_Manager1DataSet.Proveedores);
                    //this.proveedoresTableAdapter.Update(this.gym_Manager1DataSet.Proveedores);
                    Limpia_Registro();
                    Eliminar.Enabled = false;
                    Modificar.Enabled = false;
                    Numero_de_Proveedor.Focus();
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
                MessageBox.Show("Ingrese un ID de Proveedor Valido");
                Numero_de_Proveedor.Focus();
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if(Numero_de_Proveedor.Text != "")
            {
                if (Valida_Registro() == true)
                {
                    try
                    {
                        //this.proveedoresTableAdapter.Modifica_Proveedor(numeroProveedor, nombre, calle, numeroExterior, numeroInterior, colonia, codigoPostal, telefonoFijo, telefonoCelular, correoElectronico, numProvAux);
                        MessageBox.Show("Registro Actualizado Exitosamente");
                        //this.proveedoresTableAdapter.Update(this.gym_Manager1DataSet.Proveedores);
                        //this.proveedoresTableAdapter.Fill(this.gym_Manager1DataSet.Proveedores);
                        Limpia_Registro();
                        Eliminar.Enabled = false;
                        Modificar.Enabled = false;
                        Numero_de_Proveedor.Focus();
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
                MessageBox.Show("Ingrese un ID de Proveedor Valido");
                Numero_de_Proveedor.Focus();
            }
        }

        private void Buscar_Proveedor_Click(object sender, EventArgs e)
        {
            int datoT = 0, claveAux = 0;
            //this.proveedoresTableAdapter.Update(this.gym_Manager1DataSet.Proveedores);

            if (Numero_Proveedor_Buscar.Text != "")
            {
                claveAux = int.Parse(Numero_Proveedor_Buscar.Text);
                if (buscaProveedor(claveAux) != 1)
                {
                    MessageBox.Show("El Id de Proveedor " + claveAux + " No Existe en la base de Datos, Ingrese un Id de Proveedor Valido");
                    Limpia_Registro();
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        datoT = Convert.ToInt32(row.Cells["idProveedorDataGridViewTextBoxColumn"].Value);
                        if (datoT == claveAux)
                        {
                            Numero_de_Proveedor.Text = Convert.ToString(row.Cells["idProveedorDataGridViewTextBoxColumn"].Value);
                            Nombre_Proveedor.Text = Convert.ToString(row.Cells["nombreProveedorDataGridViewTextBoxColumn"].Value);
                            Calle.Text = Convert.ToString(row.Cells["calleDataGridViewTextBoxColumn"].Value);
                            Numero_Exterior.Text = Convert.ToString(row.Cells["numeroExteriorDataGridViewTextBoxColumn"].Value);
                            Numero_Interior.Text = Convert.ToString(row.Cells["numeroInteriorDataGridViewTextBoxColumn"].Value);
                            Colonia.Text = Convert.ToString(row.Cells["coloniaDataGridViewTextBoxColumn"].Value);
                            Codigo_Postal.Text = Convert.ToString(row.Cells["codigoPostalDataGridViewTextBoxColumn"].Value);
                            Telefono_Fijo.Text = Convert.ToString(row.Cells["telefonoFijoDataGridViewTextBoxColumn"].Value);
                            Telefono_Celular.Text = Convert.ToString(row.Cells["telefonoCelularDataGridViewTextBoxColumn"].Value);
                            Correo_Electronico.Text = Convert.ToString(row.Cells["correoElectronicoDataGridViewTextBoxColumn"].Value);
                            numProvAux = Convert.ToInt32(Numero_Proveedor_Buscar.Text);
                            Numero_Proveedor_Buscar.Clear();
                            Eliminar.Enabled = true;
                            Modificar.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Id de Proveedor Valido");
                Limpia_Registro();
                //this.proveedoresTableAdapter.Fill(this.gym_Manager1DataSet.Proveedores);
                Numero_Proveedor_Buscar.Focus();
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private int buscaClave(int idProveedor)
        {
           // this.proveedoresTableAdapter.Update(this.gym_Manager1DataSet.Proveedores);
            int existe = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int idProveedorAux = Convert.ToInt32(row.Cells["idProveedorDataGridViewTextBoxColumn"].Value);
                if (idProveedorAux == idProveedor)
                {
                    MessageBox.Show("El idProveedor " + idProveedor + " ya Existe en la Base de Datos, Ingrese una clave diferente");
                    Numero_de_Proveedor.Focus();
                    existe = 1;
                    break;
                }
            }
            return existe;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Limpia_Registro();
            Eliminar.Enabled = false;
            Modificar.Enabled = false;
        }

        private int buscaProveedor(int nProveedor)
        {
            //this.proveedoresTableAdapter.Update(this.gym_Manager1DataSet.Proveedores);

            int idProveedorAux, existe = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                idProveedorAux = Convert.ToInt32(row.Cells["idProveedorDataGridViewTextBoxColumn"].Value);
                if (idProveedorAux == nProveedor)
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

            if (Numero_de_Proveedor.Text != "" && Convert.ToInt32(Numero_de_Proveedor.Text) > 0 )
            {
                numeroProveedor = Convert.ToInt32(Numero_de_Proveedor.Text);
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Numero de Provedor' Para continuar");
                Numero_de_Proveedor.Focus();
                band = false;
                return band;
            }

            if (Nombre_Proveedor.Text != "")
            {
                nombre = Nombre_Proveedor.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Nombre de Proveedor' Para continuar");
                Nombre_Proveedor.Focus();
                band = false;
                return band;
            }

            if (Calle.Text != "")
            {
                calle = Calle.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Calle' Para continuar");
                Calle.Focus();
                band = false;
                return band;
            }

            if (Numero_Exterior.Text != "")
            {
                numeroExterior = Convert.ToInt32(Numero_Exterior.Text);
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Numero Exterior' Para continuar");
                Numero_Exterior.Focus();
                band = false;
                return band;
            }

            if (Numero_Interior.Text != "")
            {
                numeroInterior = Numero_Interior.Text;
                band = true;
            }
            else
            {
                numeroInterior = null;
            }

            if (Colonia.Text != "")
            {
                colonia = Colonia.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Colonia' Para continuar");
                Colonia.Focus();
                band = false;
                return band;
            }

            if (Codigo_Postal.Text != "")
            {
                codigoPostal = Convert.ToInt32(Codigo_Postal.Text);
                band = true;
            }
            else
            {
                codigoPostal = 0;
            }

            if (Telefono_Fijo.Text != "")
            {
                telefonoFijo = Convert.ToInt32(Telefono_Fijo.Text);
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Telefono Fijo' Para continuar");
                Telefono_Fijo.Focus();
                band = false;
                return band;
            }

            if (Telefono_Celular.Text != "")
            {
                telefonoCelular = Telefono_Celular.Text;
                band = true;
            }
            else
            {
                telefonoCelular = null;
            }

            if (Correo_Electronico.Text != "")
            {
                correoElectronico = Correo_Electronico.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Correo Electronico' Para continuar");
                Correo_Electronico.Focus();
                band = false;
                return band;
            }

            return band;
        }
        private void Limpia_Registro()
        {
            Numero_de_Proveedor.Clear();
            Nombre_Proveedor.Clear();
            Calle.Clear();
            Numero_Exterior.Clear();
            Numero_Interior.Clear();
            Colonia.Clear();
            Codigo_Postal.Clear();
            Telefono_Fijo.Clear();
            Telefono_Celular.Clear();
            Correo_Electronico.Clear();
        }

        private void Numero_de_Proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Numero_Exterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Codigo_Postal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Telefono_Fijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Telefono_Celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Numero_Proveedor_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
