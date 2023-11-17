
namespace General.GUI_VENDEDOR
{
    partial class ProductosVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosVendedor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Label();
            this.dtgv_Productos_Vendedor = new System.Windows.Forms.DataGridView();
            this.idProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Productos_Vendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(21, 2);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(178, 20);
            this.textBuscar.TabIndex = 8;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // buscar
            // 
            this.buscar.AutoSize = true;
            this.buscar.BackColor = System.Drawing.SystemColors.Control;
            this.buscar.Location = new System.Drawing.Point(208, 6);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(39, 13);
            this.buscar.TabIndex = 9;
            this.buscar.Text = "buscar";
            // 
            // dtgv_Productos_Vendedor
            // 
            this.dtgv_Productos_Vendedor.AllowUserToAddRows = false;
            this.dtgv_Productos_Vendedor.AllowUserToDeleteRows = false;
            this.dtgv_Productos_Vendedor.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_Productos_Vendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Productos_Vendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductos,
            this.Productos,
            this.PrecioUnitario,
            this.Marca,
            this.Stock});
            this.dtgv_Productos_Vendedor.Location = new System.Drawing.Point(12, 40);
            this.dtgv_Productos_Vendedor.Name = "dtgv_Productos_Vendedor";
            this.dtgv_Productos_Vendedor.ReadOnly = true;
            this.dtgv_Productos_Vendedor.Size = new System.Drawing.Size(776, 398);
            this.dtgv_Productos_Vendedor.TabIndex = 2;
            // 
            // idProductos
            // 
            this.idProductos.DataPropertyName = "idProductos";
            this.idProductos.HeaderText = "ID Productos";
            this.idProductos.Name = "idProductos";
            this.idProductos.ReadOnly = true;
            // 
            // Productos
            // 
            this.Productos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Productos.DataPropertyName = "Productos";
            this.Productos.HeaderText = "Productos";
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // ProductosVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgv_Productos_Vendedor);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductosVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductosVendedor";
            this.Load += new System.EventHandler(this.ProductosVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Productos_Vendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label buscar;
        private System.Windows.Forms.DataGridView dtgv_Productos_Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}