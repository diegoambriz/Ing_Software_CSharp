namespace Gym_Manager_Ingenieria_de_Software_B
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Descripcion2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Existencias2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Precio_Producto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Costo_Producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre_Producto = new System.Windows.Forms.TextBox();
            this.No_Socio_Label = new System.Windows.Forms.Label();
            this.Numero_de_Producto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Buscar_Producto = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.Numero_Producto_Buscar = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(2, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1260, 55);
            this.label12.TabIndex = 36;
            this.label12.Text = "Productos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Descripcion2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Existencias2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Precio_Producto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Costo_Producto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Nombre_Producto);
            this.groupBox1.Controls.Add(this.No_Socio_Label);
            this.groupBox1.Controls.Add(this.Numero_de_Producto);
            this.groupBox1.Location = new System.Drawing.Point(10, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 582);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(18, 214);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(50, 22);
            this.Limpiar.TabIndex = 80;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(64, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(243, 13);
            this.label18.TabIndex = 79;
            this.label18.Text = "Todos los campos marcados con* son obligatorios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(15, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Descripción";
            // 
            // Descripcion2
            // 
            this.Descripcion2.Location = new System.Drawing.Point(108, 186);
            this.Descripcion2.MaxLength = 30;
            this.Descripcion2.Name = "Descripcion2";
            this.Descripcion2.Size = new System.Drawing.Size(199, 20);
            this.Descripcion2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(15, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Existencias*";
            // 
            // Existencias2
            // 
            this.Existencias2.Location = new System.Drawing.Point(108, 151);
            this.Existencias2.MaxLength = 5;
            this.Existencias2.Name = "Existencias2";
            this.Existencias2.Size = new System.Drawing.Size(199, 20);
            this.Existencias2.TabIndex = 5;
            this.Existencias2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Existencias2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Precio Producto*";
            // 
            // Precio_Producto
            // 
            this.Precio_Producto.Location = new System.Drawing.Point(108, 117);
            this.Precio_Producto.MaxLength = 10;
            this.Precio_Producto.Name = "Precio_Producto";
            this.Precio_Producto.Size = new System.Drawing.Size(199, 20);
            this.Precio_Producto.TabIndex = 4;
            this.Precio_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_Producto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Costo Producto*";
            // 
            // Costo_Producto
            // 
            this.Costo_Producto.Location = new System.Drawing.Point(108, 83);
            this.Costo_Producto.MaxLength = 10;
            this.Costo_Producto.Name = "Costo_Producto";
            this.Costo_Producto.Size = new System.Drawing.Size(199, 20);
            this.Costo_Producto.TabIndex = 3;
            this.Costo_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Costo_Producto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre Producto*";
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.Location = new System.Drawing.Point(108, 49);
            this.Nombre_Producto.MaxLength = 30;
            this.Nombre_Producto.Name = "Nombre_Producto";
            this.Nombre_Producto.Size = new System.Drawing.Size(199, 20);
            this.Nombre_Producto.TabIndex = 2;
            // 
            // No_Socio_Label
            // 
            this.No_Socio_Label.AutoSize = true;
            this.No_Socio_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.No_Socio_Label.Location = new System.Drawing.Point(15, 18);
            this.No_Socio_Label.Name = "No_Socio_Label";
            this.No_Socio_Label.Size = new System.Drawing.Size(69, 13);
            this.No_Socio_Label.TabIndex = 39;
            this.No_Socio_Label.Text = "Id. Producto*";
            // 
            // Numero_de_Producto
            // 
            this.Numero_de_Producto.Location = new System.Drawing.Point(108, 15);
            this.Numero_de_Producto.MaxLength = 5;
            this.Numero_de_Producto.Name = "Numero_de_Producto";
            this.Numero_de_Producto.Size = new System.Drawing.Size(199, 20);
            this.Numero_de_Producto.TabIndex = 1;
            this.Numero_de_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_de_Producto_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Buscar_Producto);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.Numero_Producto_Buscar);
            this.groupBox3.Location = new System.Drawing.Point(344, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 39);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // Buscar_Producto
            // 
            this.Buscar_Producto.BackColor = System.Drawing.Color.SteelBlue;
            this.Buscar_Producto.Location = new System.Drawing.Point(197, 11);
            this.Buscar_Producto.Name = "Buscar_Producto";
            this.Buscar_Producto.Size = new System.Drawing.Size(109, 20);
            this.Buscar_Producto.TabIndex = 11;
            this.Buscar_Producto.Text = "Buscar";
            this.Buscar_Producto.UseVisualStyleBackColor = false;
            this.Buscar_Producto.Click += new System.EventHandler(this.Buscar_Producto_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(14, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 73;
            this.label16.Text = "Id. Producto";
            // 
            // Numero_Producto_Buscar
            // 
            this.Numero_Producto_Buscar.Location = new System.Drawing.Point(107, 11);
            this.Numero_Producto_Buscar.MaxLength = 5;
            this.Numero_Producto_Buscar.Name = "Numero_Producto_Buscar";
            this.Numero_Producto_Buscar.Size = new System.Drawing.Size(84, 20);
            this.Numero_Producto_Buscar.TabIndex = 10;
            this.Numero_Producto_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_Producto_Buscar_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(344, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(908, 537);
            this.groupBox4.TabIndex = 78;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Productos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(902, 518);
            this.dataGridView1.TabIndex = 76;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Eliminar);
            this.groupBox2.Controls.Add(this.Modificar);
            this.groupBox2.Controls.Add(this.Guardar);
            this.groupBox2.Location = new System.Drawing.Point(10, 662);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 64);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opción";
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.DarkRed;
            this.Eliminar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Eliminar.Location = new System.Drawing.Point(115, 20);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(91, 30);
            this.Eliminar.TabIndex = 8;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.Color.DarkRed;
            this.Modificar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Modificar.Location = new System.Drawing.Point(224, 20);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(91, 30);
            this.Modificar.TabIndex = 9;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.ForestGreen;
            this.Guardar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Guardar.Location = new System.Drawing.Point(2, 20);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(91, 30);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.DarkRed;
            this.Regresar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Regresar.Location = new System.Drawing.Point(1144, 678);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(112, 30);
            this.Regresar.TabIndex = 80;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Name = "Productos";
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Productos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Buscar_Producto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Numero_Producto_Buscar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label No_Socio_Label;
        private System.Windows.Forms.TextBox Numero_de_Producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Existencias2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Precio_Producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Costo_Producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre_Producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Descripcion2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Limpiar;
    }
}