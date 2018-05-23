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
    public partial class Socios : Form
    {
        int numeroSocio, numeroExterior, codigoPostal, telefonoFijo,numSocioAux;
        string tipoSocio, nombre, aPaterno, aMaterno, genero, calle, numeroInterior, colonia, email, fechaPago, fNacimiento, telefonoCelular;

        public Socios()
        {
            InitializeComponent();
            numeroSocio = 0;
            numeroExterior = 0;
            codigoPostal = 0;
            telefonoFijo = 0;
            telefonoCelular = "";
            numeroInterior = "";
            tipoSocio = "";
            fechaPago = "";
            nombre = "";
            aPaterno = "";
            aMaterno = "";
            genero = "";
            fNacimiento = "";
            calle = "";
            colonia = "";
            email = "";
            Fecha_de_Vencimiento.MaxDate = DateTime.Now;
            Fecha_de_Vencimiento.Value = DateTime.Now;
        }

        private void Socios_Load(object sender, EventArgs e)
        {
           // this.sociosTableAdapter.Update(this.gym_Manager1DataSet.Socios);
            //this.sociosTableAdapter.Fill(this.gym_Manager1DataSet.Socios);
            Eliminar.Enabled = false;
            Modificar.Enabled = false;
            Numero_de_Socio.Focus();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {                
                if(validaRegistro() == true)
                { 
                    if (buscaClave(numeroSocio) != 1)
                    {
                      //  this.sociosTableAdapter.Alta_Socio(numeroSocio, tipoSocio, fechaPago, nombre, aPaterno, aMaterno, genero, fNacimiento, calle, numeroExterior, numeroInterior, colonia, codigoPostal, telefonoFijo, telefonoCelular, email);
                        MessageBox.Show("Registro Guardado Exitosamente");
                        //this.sociosTableAdapter.Fill(this.gym_Manager1DataSet.Socios);
                        //this.sociosTableAdapter.Update(this.gym_Manager1DataSet.Socios);
                        Limpia_Registro();
                        Numero_de_Socio.Focus();
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
            if (Numero_de_Socio.Text != "")
            {
                try
                {
                    //this.sociosTableAdapter.Baja_Socio(Convert.ToInt32(Numero_de_Socio.Text));
                    MessageBox.Show("Registro Eliminado Exitosamente");
                    //this.sociosTableAdapter.Fill(this.gym_Manager1DataSet.Socios);
                    //this.sociosTableAdapter.Update(this.gym_Manager1DataSet.Socios);
                    Limpia_Registro();
                    Eliminar.Enabled = false;
                    Modificar.Enabled = false;
                    Numero_de_Socio.Focus();
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
                MessageBox.Show("Ingrese un ID de Socio Valido");
                Numero_de_Socio.Focus();
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if(Numero_de_Socio.Text != "")
            {
                if (validaRegistro() == true)
                {
                    try
                    {
                        //this.sociosTableAdapter.Modifica_Socio(numeroSocio, tipoSocio, fechaPago, nombre, aPaterno, aMaterno, genero, fNacimiento, calle, numeroExterior, numeroInterior, colonia, codigoPostal, telefonoFijo, telefonoCelular, email, numSocioAux);
                        MessageBox.Show("Registro Actualizado Exitosamente");
                        //this.sociosTableAdapter.Update(this.gym_Manager1DataSet.Socios);
                        //this.sociosTableAdapter.Fill(this.gym_Manager1DataSet.Socios);
                        Limpia_Registro();
                        Eliminar.Enabled = false;
                        Modificar.Enabled = false;
                        Numero_de_Socio.Focus();
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
                MessageBox.Show("Ingrese un ID de Socio Valido");
                Numero_de_Socio.Focus();
            }
            
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Limpia_Registro();
            Eliminar.Enabled = false;
            Modificar.Enabled = false;
        }

        private void Buscar_Socio_Click(object sender, EventArgs e)
        {
            int datoT = 0, claveAux = 0;
           // this.sociosTableAdapter.Update(this.gym_Manager1DataSet.Socios);

            if (Numero_Socio_Buscar.Text != "")
            {
                claveAux = int.Parse(Numero_Socio_Buscar.Text);
                if (buscaSocio(claveAux) != 1)
                {
                    MessageBox.Show("El IdSocio " + claveAux + " No Existe en la base de Datos, Ingrese un IdSocio Valido");
                    Limpia_Registro();
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        datoT = Convert.ToInt32(row.Cells["numeroSocioDataGridViewTextBoxColumn"].Value);
                        if (datoT == claveAux)
                        {
                            Numero_de_Socio.Text = Convert.ToString(row.Cells["numeroSocioDataGridViewTextBoxColumn"].Value);
                            Tipo_Usuario.Text = Convert.ToString(row.Cells["tipodeSocioDataGridViewTextBoxColumn"].Value);
                            Fecha_de_Vencimiento.Text = Convert.ToString(row.Cells["fechadePagoDataGridViewTextBoxColumn"].Value);
                            Nombre_Socio.Text = Convert.ToString(row.Cells["nombreDataGridViewTextBoxColumn"].Value);
                            Apellido_Paterno.Text = Convert.ToString(row.Cells["apellidoPaternoDataGridViewTextBoxColumn"].Value);
                            Apellido_Materno.Text = Convert.ToString(row.Cells["apellidoMaternoDataGridViewTextBoxColumn"].Value);
                            Genero2.Text = Convert.ToString(row.Cells["generoDataGridViewTextBoxColumn"].Value);
                            Fecha_de_Nacimiento.Text = Convert.ToString(row.Cells["fechadeNacimientoDataGridViewTextBoxColumn"].Value);
                            Calle1.Text = Convert.ToString(row.Cells["calleDataGridViewTextBoxColumn"].Value);
                            Numero_Exterior1.Text = Convert.ToString(row.Cells["numeroExteriorDataGridViewTextBoxColumn"].Value);
                            Numero_Interior1.Text = Convert.ToString(row.Cells["numeroInteriorDataGridViewTextBoxColumn"].Value);
                            Colonia1.Text = Convert.ToString(row.Cells["coloniaDataGridViewTextBoxColumn"].Value);
                            Codigo_Postal1.Text = Convert.ToString(row.Cells["codigoPostalDataGridViewTextBoxColumn"].Value);
                            Telefono_Fijo1.Text = Convert.ToString(row.Cells["telefonoFijoDataGridViewTextBoxColumn"].Value);
                            Telefono_Celular1.Text = Convert.ToString(row.Cells["telefonoCelularDataGridViewTextBoxColumn"].Value);
                            Correo_Electronico1.Text = Convert.ToString(row.Cells["correoElectronicoDataGridViewTextBoxColumn"].Value);
                            numSocioAux = Convert.ToInt32(Numero_Socio_Buscar.Text);
                            Numero_Socio_Buscar.Clear();
                            Eliminar.Enabled = true;
                            Modificar.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Id de Socio Valido");
                Limpia_Registro();
                //this.sociosTableAdapter.Fill(this.gym_Manager1DataSet.Socios);
                Numero_Socio_Buscar.Focus();
            }
        }

        private int buscaClave(int idSocio)
        {
            //this.sociosTableAdapter.Update(this.gym_Manager1DataSet.Socios);
            int existe = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int idSocioAux = Convert.ToInt32(row.Cells["numeroSocioDataGridViewTextBoxColumn"].Value);
                if (idSocioAux == idSocio)
                {
                    MessageBox.Show("El idSocio " + idSocio + " ya Existe en la Base de Datos, Ingrese una clave diferente");
                    Numero_de_Socio.Focus();
                    existe = 1;
                    break;
                }
            }
            return existe;
        }

        private int buscaSocio(int nSocio)
        {
            //this.sociosTableAdapter.Update(this.gym_Manager1DataSet.Socios);
            
            int idSocioAux, existe = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
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
        private void Limpia_Registro()
        {
            Numero_de_Socio.Clear();
            Tipo_Usuario.Text = "";
            Fecha_de_Vencimiento.Text = "";
            Nombre_Socio.Text = "";
            Apellido_Paterno.Text = "";
            Apellido_Materno.Text = "";
            Genero2.Text = "";
            Fecha_de_Nacimiento.Text = "";
            Calle1.Text = "";
            Numero_Exterior1.Text = "";
            Numero_Interior1.Text = "";
            Colonia1.Text = "";
            Codigo_Postal1.Text = "";
            Telefono_Fijo1.Text = "";
            Telefono_Celular1.Text = "";
            Correo_Electronico1.Text = "";
        }

        private void Numero_de_Socio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Nombre_Socio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Apellido_Paterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Apellido_Materno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Telefono_Celular1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Telefono_Fijo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Codigo_Postal1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Numero_Exterior1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Numero_Socio_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }
        private bool validaRegistro()
        {
            bool band;

            if (Numero_de_Socio.Text != "" && Convert.ToInt32(Numero_de_Socio.Text) > 0 )
            {
                numeroSocio = Convert.ToInt32(Numero_de_Socio.Text);
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un Id de Socio Valido Para continuar");
                Numero_de_Socio.Focus();
                band = false;
                return band;
            }

            if (Tipo_Usuario.Text != "" && Tipo_Usuario.Text == "Normal" || Tipo_Usuario.Text != "" && Tipo_Usuario.Text == "Estudiante")
            {
                tipoSocio = Tipo_Usuario.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Tipo de Socio' Para continuar");
                Tipo_Usuario.Focus();
                band = false;
                return band;
            }

            if (Fecha_de_Vencimiento.Text != "" && Fecha_de_Vencimiento.Value < Fecha_de_Vencimiento.MaxDate )
            {
                fechaPago = Fecha_de_Vencimiento.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Fecha de Vencimiento' Para continuar");
                Fecha_de_Vencimiento.Focus();
                band = false;
                return band;
            }

            if (Nombre_Socio.Text != "")
            {
                nombre = Nombre_Socio.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un  valor valido para 'Nombre' Para continuar");
                Nombre_Socio.Focus();
                band = false;
                return band;
            }

            if (Apellido_Paterno.Text != "")
            {
                aPaterno = Apellido_Paterno.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Apellido Paterno' Para continuar");
                Apellido_Paterno.Focus();
                band = false;
                return band;
            }

            if (Apellido_Materno.Text != "")
            {
                aMaterno = Apellido_Materno.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Apellido Materno' Para continuar");
                Apellido_Materno.Focus();
                band = false;
                return band;
            }

            if (Genero2.Text != "" && Genero2.Text == "Femenino"  || Genero2.Text != "" && Genero2.Text == "Masculino")
            {
                genero = Genero2.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Genero' Para continuar");
                Genero2.Focus();
                band = false;
                return band;
            }

            if (Fecha_de_Nacimiento.Text != "")
            {
                fNacimiento = Fecha_de_Nacimiento.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Fecha de Nacimiento' Para continuar");
                band = false;
                return band;
            }

            if (Calle1.Text != "")
            {
                calle = Calle1.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Calle' Para continuar");
                band = false;
                return band;
            }

            if (Numero_Exterior1.Text != "")
            {
                numeroExterior = Convert.ToInt32(Numero_Exterior1.Text);
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Numero_Exterior' Para continuar");
                band = false;
                return band;
            }
            if (Numero_Interior1.Text != "")
            {
                numeroInterior = Numero_Interior1.Text;
                band = true;
            }
            else
            {
                numeroInterior = null;
            }

            if (Colonia1.Text != "")
            {
                colonia = Colonia1.Text;
                band = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para 'Colonia' Para continuar");
                band = false;
                return band;
            }

            if (Codigo_Postal1.Text!= "")
            {
                codigoPostal = Convert.ToInt32(Codigo_Postal1.Text);
                band = true;
            }
            else
            {
                codigoPostal = 0;
            }

            if (Telefono_Fijo1.Text != "")
            {
                telefonoFijo = Convert.ToInt32(Telefono_Fijo1.Text);
                band = true;
            }
            else
            {
                telefonoFijo = 0;
            }

            if (Telefono_Celular1.Text != "")
            {
                telefonoCelular = Telefono_Celular1.Text;
            }
            else
            {
                telefonoCelular = null;
            }

            if (Correo_Electronico1.Text != "")
            {
                email = Correo_Electronico1.Text;
                band = true;
            }
            else
            {
                email = null;
            }
            return band;
        }
    }
}
