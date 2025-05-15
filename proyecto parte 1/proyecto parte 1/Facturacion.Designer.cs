namespace proyecto_parte_1
{
    partial class Facturacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbCategoria = new System.Windows.Forms.ComboBox();
            this.CBProductos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvFacturacion = new System.Windows.Forms.DataGridView();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.CbPrecios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Productos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CbCategoria
            // 
            this.CbCategoria.FormattingEnabled = true;
            this.CbCategoria.Items.AddRange(new object[] {
            ""});
            this.CbCategoria.Location = new System.Drawing.Point(299, 140);
            this.CbCategoria.Name = "CbCategoria";
            this.CbCategoria.Size = new System.Drawing.Size(121, 28);
            this.CbCategoria.TabIndex = 2;
            // 
            // CBProductos
            // 
            this.CBProductos.FormattingEnabled = true;
            this.CBProductos.Location = new System.Drawing.Point(508, 138);
            this.CBProductos.Name = "CBProductos";
            this.CBProductos.Size = new System.Drawing.Size(121, 28);
            this.CBProductos.TabIndex = 3;
            this.CBProductos.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "FACTURACION";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(676, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad";
            // 
            // DgvFacturacion
            // 
            this.DgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n,
            this.Column1,
            this.CCodigo,
            this.CProducto,
            this.Ccantidad,
            this.CPrecio,
            this.CSubtotal,
            this.CIVA,
            this.Ctotal});
            this.DgvFacturacion.Location = new System.Drawing.Point(12, 259);
            this.DgvFacturacion.Name = "DgvFacturacion";
            this.DgvFacturacion.RowHeadersWidth = 62;
            this.DgvFacturacion.RowTemplate.Height = 28;
            this.DgvFacturacion.Size = new System.Drawing.Size(1115, 150);
            this.DgvFacturacion.TabIndex = 7;
            this.DgvFacturacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // n
            // 
            this.n.HeaderText = "N";
            this.n.MinimumWidth = 8;
            this.n.Name = "n";
            this.n.Visible = false;
            this.n.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 150;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "Codigo";
            this.CCodigo.MinimumWidth = 8;
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.Width = 150;
            // 
            // CProducto
            // 
            this.CProducto.HeaderText = "Producto";
            this.CProducto.MinimumWidth = 8;
            this.CProducto.Name = "CProducto";
            this.CProducto.Width = 150;
            // 
            // Ccantidad
            // 
            this.Ccantidad.HeaderText = "Cantidad";
            this.Ccantidad.MinimumWidth = 8;
            this.Ccantidad.Name = "Ccantidad";
            this.Ccantidad.Width = 150;
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.MinimumWidth = 8;
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.Width = 150;
            // 
            // CSubtotal
            // 
            this.CSubtotal.HeaderText = "Subtotal";
            this.CSubtotal.MinimumWidth = 8;
            this.CSubtotal.Name = "CSubtotal";
            this.CSubtotal.Width = 150;
            // 
            // CIVA
            // 
            this.CIVA.HeaderText = "IVA";
            this.CIVA.MinimumWidth = 8;
            this.CIVA.Name = "CIVA";
            this.CIVA.Width = 150;
            // 
            // Ctotal
            // 
            this.Ctotal.HeaderText = "Total a Pagar";
            this.Ctotal.MinimumWidth = 8;
            this.Ctotal.Name = "Ctotal";
            this.Ctotal.Width = 150;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(58, 140);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(129, 44);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // CbPrecios
            // 
            this.CbPrecios.FormattingEnabled = true;
            this.CbPrecios.Location = new System.Drawing.Point(299, 209);
            this.CbPrecios.Name = "CbPrecios";
            this.CbPrecios.Size = new System.Drawing.Size(121, 28);
            this.CbPrecios.TabIndex = 10;
            this.CbPrecios.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(892, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbPrecios);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.DgvFacturacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBProductos);
            this.Controls.Add(this.CbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Facturacion";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbCategoria;
        private System.Windows.Forms.ComboBox CBProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctotal;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox CbPrecios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}