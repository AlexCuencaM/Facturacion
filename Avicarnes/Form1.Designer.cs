namespace Avicarnes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGenerarFactura = new System.Windows.Forms.Button();
            this.labelNombreEmpresa = new System.Windows.Forms.Label();
            this.labelDireccionEmpresa = new System.Windows.Forms.Label();
            this.labelTelfonoDeEmpresa = new System.Windows.Forms.Label();
            this.labelIdPedido = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelIdCliente = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDireccionCliente = new System.Windows.Forms.Label();
            this.labelEstadoDePago = new System.Windows.Forms.Label();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCampoTelf = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.descripcionProducto,
            this.cantidadProducto,
            this.pesoProducto,
            this.precioProducto,
            this.subtotalProducto,
            this.descuentoProducto,
            this.totalProducto});
            this.dataGridViewProducto.Location = new System.Drawing.Point(15, 334);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.Size = new System.Drawing.Size(1240, 150);
            this.dataGridViewProducto.TabIndex = 0;
            this.dataGridViewProducto.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducto_CellEndEdit);
            // 
            // codigoProducto
            // 
            this.codigoProducto.HeaderText = "Código";
            this.codigoProducto.Name = "codigoProducto";
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.NullValue = "NA";
            this.descripcionProducto.DefaultCellStyle = dataGridViewCellStyle5;
            this.descripcionProducto.HeaderText = "Descripción";
            this.descripcionProducto.Name = "descripcionProducto";
            this.descripcionProducto.ReadOnly = true;
            this.descripcionProducto.Width = 500;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cantidad";
            this.cantidadProducto.Name = "cantidadProducto";
            // 
            // pesoProducto
            // 
            this.pesoProducto.HeaderText = "Peso";
            this.pesoProducto.Name = "pesoProducto";
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            // 
            // subtotalProducto
            // 
            dataGridViewCellStyle6.NullValue = "0";
            this.subtotalProducto.DefaultCellStyle = dataGridViewCellStyle6;
            this.subtotalProducto.HeaderText = "Subtotal";
            this.subtotalProducto.Name = "subtotalProducto";
            this.subtotalProducto.ReadOnly = true;
            // 
            // descuentoProducto
            // 
            dataGridViewCellStyle7.NullValue = "0";
            this.descuentoProducto.DefaultCellStyle = dataGridViewCellStyle7;
            this.descuentoProducto.HeaderText = "Descuento(%)";
            this.descuentoProducto.Name = "descuentoProducto";
            // 
            // totalProducto
            // 
            dataGridViewCellStyle8.NullValue = "0";
            this.totalProducto.DefaultCellStyle = dataGridViewCellStyle8;
            this.totalProducto.HeaderText = "Total";
            this.totalProducto.Name = "totalProducto";
            this.totalProducto.ReadOnly = true;
            // 
            // buttonGenerarFactura
            // 
            this.buttonGenerarFactura.Location = new System.Drawing.Point(1025, 523);
            this.buttonGenerarFactura.Name = "buttonGenerarFactura";
            this.buttonGenerarFactura.Size = new System.Drawing.Size(123, 23);
            this.buttonGenerarFactura.TabIndex = 1;
            this.buttonGenerarFactura.Text = "Generar Factura";
            this.buttonGenerarFactura.UseVisualStyleBackColor = true;
            this.buttonGenerarFactura.Click += new System.EventHandler(this.buttonGenerarFactura_Click);
            // 
            // labelNombreEmpresa
            // 
            this.labelNombreEmpresa.AutoSize = true;
            this.labelNombreEmpresa.Location = new System.Drawing.Point(456, 51);
            this.labelNombreEmpresa.Name = "labelNombreEmpresa";
            this.labelNombreEmpresa.Size = new System.Drawing.Size(116, 13);
            this.labelNombreEmpresa.TabIndex = 2;
            this.labelNombreEmpresa.Text = "Nombre de la empresa.";
            // 
            // labelDireccionEmpresa
            // 
            this.labelDireccionEmpresa.AutoSize = true;
            this.labelDireccionEmpresa.Location = new System.Drawing.Point(439, 89);
            this.labelDireccionEmpresa.Name = "labelDireccionEmpresa";
            this.labelDireccionEmpresa.Size = new System.Drawing.Size(124, 13);
            this.labelDireccionEmpresa.TabIndex = 3;
            this.labelDireccionEmpresa.Text = "Dirección de la empresa:";
            // 
            // labelTelfonoDeEmpresa
            // 
            this.labelTelfonoDeEmpresa.AutoSize = true;
            this.labelTelfonoDeEmpresa.Location = new System.Drawing.Point(336, 134);
            this.labelTelfonoDeEmpresa.Name = "labelTelfonoDeEmpresa";
            this.labelTelfonoDeEmpresa.Size = new System.Drawing.Size(126, 13);
            this.labelTelfonoDeEmpresa.TabIndex = 4;
            this.labelTelfonoDeEmpresa.Text = "Telefonos de la empresa:";
            // 
            // labelIdPedido
            // 
            this.labelIdPedido.AutoSize = true;
            this.labelIdPedido.Location = new System.Drawing.Point(12, 51);
            this.labelIdPedido.Name = "labelIdPedido";
            this.labelIdPedido.Size = new System.Drawing.Size(53, 13);
            this.labelIdPedido.TabIndex = 5;
            this.labelIdPedido.Text = "ID pedido";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(953, 51);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(40, 13);
            this.labelFecha.TabIndex = 6;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(12, 185);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(42, 13);
            this.labelCliente.TabIndex = 7;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelIdCliente
            // 
            this.labelIdCliente.AutoSize = true;
            this.labelIdCliente.Location = new System.Drawing.Point(953, 185);
            this.labelIdCliente.Name = "labelIdCliente";
            this.labelIdCliente.Size = new System.Drawing.Size(57, 13);
            this.labelIdCliente.TabIndex = 8;
            this.labelIdCliente.Text = "N° Cliente:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(12, 289);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 10;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // labelDireccionCliente
            // 
            this.labelDireccionCliente.AutoSize = true;
            this.labelDireccionCliente.Location = new System.Drawing.Point(12, 236);
            this.labelDireccionCliente.Name = "labelDireccionCliente";
            this.labelDireccionCliente.Size = new System.Drawing.Size(55, 13);
            this.labelDireccionCliente.TabIndex = 11;
            this.labelDireccionCliente.Text = "Direccion:";
            // 
            // labelEstadoDePago
            // 
            this.labelEstadoDePago.AutoSize = true;
            this.labelEstadoDePago.Location = new System.Drawing.Point(953, 236);
            this.labelEstadoDePago.Name = "labelEstadoDePago";
            this.labelEstadoDePago.Size = new System.Drawing.Size(43, 13);
            this.labelEstadoDePago.TabIndex = 12;
            this.labelEstadoDePago.Text = "Estado:";
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(1048, 182);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdCliente.TabIndex = 13;
            this.textBoxIdCliente.TextChanged += new System.EventHandler(this.textBoxIdCliente_TextChanged);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(60, 182);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(166, 20);
            this.textBoxCliente.TabIndex = 14;
            this.textBoxCliente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Avicarnes.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(725, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // labelCampoTelf
            // 
            this.labelCampoTelf.AutoSize = true;
            this.labelCampoTelf.Location = new System.Drawing.Point(70, 289);
            this.labelCampoTelf.Name = "labelCampoTelf";
            this.labelCampoTelf.Size = new System.Drawing.Size(0, 13);
            this.labelCampoTelf.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Limpiar Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCampoTelf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.textBoxIdCliente);
            this.Controls.Add(this.labelEstadoDePago);
            this.Controls.Add(this.labelDireccionCliente);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelIdCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelIdPedido);
            this.Controls.Add(this.labelTelfonoDeEmpresa);
            this.Controls.Add(this.labelDireccionEmpresa);
            this.Controls.Add(this.labelNombreEmpresa);
            this.Controls.Add(this.buttonGenerarFactura);
            this.Controls.Add(this.dataGridViewProducto);
            this.Name = "Form1";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.Button buttonGenerarFactura;
        private System.Windows.Forms.Label labelNombreEmpresa;
        private System.Windows.Forms.Label labelDireccionEmpresa;
        private System.Windows.Forms.Label labelTelfonoDeEmpresa;
        private System.Windows.Forms.Label labelIdPedido;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelIdCliente;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDireccionCliente;
        private System.Windows.Forms.Label labelEstadoDePago;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCampoTelf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProducto;
    }
}

