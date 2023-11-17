
namespace General.GUI
{
    partial class ComprasGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprasGestion));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idempleados = new System.Windows.Forms.TextBox();
            this.txt_idproveedores = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_proveedor = new System.Windows.Forms.Button();
            this.btn_empleado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_compra = new System.Windows.Forms.DataGridView();
            this.idProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Agregar_Prod = new System.Windows.Forms.Button();
            this.btn_eliminar_prod = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_pr = new System.Windows.Forms.Label();
            this.txt_precioCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TotalCompra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID del empleado";
            // 
            // txt_idempleados
            // 
            this.txt_idempleados.Location = new System.Drawing.Point(18, 52);
            this.txt_idempleados.Name = "txt_idempleados";
            this.txt_idempleados.Size = new System.Drawing.Size(100, 22);
            this.txt_idempleados.TabIndex = 1;
            // 
            // txt_idproveedores
            // 
            this.txt_idproveedores.Location = new System.Drawing.Point(19, 120);
            this.txt_idproveedores.Name = "txt_idproveedores";
            this.txt_idproveedores.Size = new System.Drawing.Size(100, 22);
            this.txt_idproveedores.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID del proveedor";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_proveedor);
            this.groupBox1.Controls.Add(this.btn_empleado);
            this.groupBox1.Controls.Add(this.txt_idproveedores);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_idempleados);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información sobre la compra";
            // 
            // btn_proveedor
            // 
            this.btn_proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.btn_proveedor.ForeColor = System.Drawing.Color.White;
            this.btn_proveedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_proveedor.Image")));
            this.btn_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proveedor.Location = new System.Drawing.Point(125, 118);
            this.btn_proveedor.Name = "btn_proveedor";
            this.btn_proveedor.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_proveedor.Size = new System.Drawing.Size(87, 25);
            this.btn_proveedor.TabIndex = 13;
            this.btn_proveedor.Text = "Buscar ";
            this.btn_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_proveedor.UseVisualStyleBackColor = false;
            this.btn_proveedor.Click += new System.EventHandler(this.btn_proveedor_Click);
            // 
            // btn_empleado
            // 
            this.btn_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.btn_empleado.ForeColor = System.Drawing.Color.White;
            this.btn_empleado.Image = ((System.Drawing.Image)(resources.GetObject("btn_empleado.Image")));
            this.btn_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empleado.Location = new System.Drawing.Point(125, 50);
            this.btn_empleado.Name = "btn_empleado";
            this.btn_empleado.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_empleado.Size = new System.Drawing.Size(87, 25);
            this.btn_empleado.TabIndex = 12;
            this.btn_empleado.Text = "Buscar ";
            this.btn_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_empleado.UseVisualStyleBackColor = false;
            this.btn_empleado.Click += new System.EventHandler(this.btn_empleado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Detalle de la compra";
            // 
            // dgv_compra
            // 
            this.dgv_compra.AllowUserToAddRows = false;
            this.dgv_compra.BackgroundColor = System.Drawing.Color.White;
            this.dgv_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_compra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductos,
            this.Cantidad,
            this.PrecioCompra});
            this.dgv_compra.Location = new System.Drawing.Point(12, 208);
            this.dgv_compra.MultiSelect = false;
            this.dgv_compra.Name = "dgv_compra";
            this.dgv_compra.RowHeadersVisible = false;
            this.dgv_compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_compra.Size = new System.Drawing.Size(549, 264);
            this.dgv_compra.TabIndex = 8;
            // 
            // idProductos
            // 
            this.idProductos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProductos.HeaderText = "idProductos";
            this.idProductos.Name = "idProductos";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioCompra.HeaderText = "Precio de Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            // 
            // btn_Agregar_Prod
            // 
            this.btn_Agregar_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.btn_Agregar_Prod.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar_Prod.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar_Prod.Image")));
            this.btn_Agregar_Prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar_Prod.Location = new System.Drawing.Point(16, 128);
            this.btn_Agregar_Prod.Name = "btn_Agregar_Prod";
            this.btn_Agregar_Prod.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_Agregar_Prod.Size = new System.Drawing.Size(175, 23);
            this.btn_Agregar_Prod.TabIndex = 9;
            this.btn_Agregar_Prod.Text = "Agregar Producto";
            this.btn_Agregar_Prod.UseVisualStyleBackColor = false;
            this.btn_Agregar_Prod.Click += new System.EventHandler(this.btn_Agregar_Prod_Click);
            // 
            // btn_eliminar_prod
            // 
            this.btn_eliminar_prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.btn_eliminar_prod.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_prod.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar_prod.Image")));
            this.btn_eliminar_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar_prod.Location = new System.Drawing.Point(280, 128);
            this.btn_eliminar_prod.Name = "btn_eliminar_prod";
            this.btn_eliminar_prod.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_eliminar_prod.Size = new System.Drawing.Size(176, 23);
            this.btn_eliminar_prod.TabIndex = 10;
            this.btn_eliminar_prod.Text = "Eliminar Producto";
            this.btn_eliminar_prod.UseVisualStyleBackColor = false;
            this.btn_eliminar_prod.Click += new System.EventHandler(this.btn_eliminar_prod_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(567, 411);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(648, 411);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lbl_pr);
            this.groupBox2.Controls.Add(this.txt_precioCompra);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_Cantidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.btn_Agregar_Prod);
            this.groupBox2.Controls.Add(this.btn_eliminar_prod);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(331, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 165);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información sobre el producto";
            // 
            // lbl_pr
            // 
            this.lbl_pr.AutoSize = true;
            this.lbl_pr.Location = new System.Drawing.Point(159, 36);
            this.lbl_pr.Name = "lbl_pr";
            this.lbl_pr.Size = new System.Drawing.Size(122, 16);
            this.lbl_pr.TabIndex = 18;
            this.lbl_pr.Text = "Precio de comra";
            // 
            // txt_precioCompra
            // 
            this.txt_precioCompra.Location = new System.Drawing.Point(162, 52);
            this.txt_precioCompra.Name = "txt_precioCompra";
            this.txt_precioCompra.Size = new System.Drawing.Size(100, 22);
            this.txt_precioCompra.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(325, 52);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 22);
            this.txt_Cantidad.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID del producto";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(564, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total de la Compra";
            // 
            // txt_TotalCompra
            // 
            this.txt_TotalCompra.Location = new System.Drawing.Point(567, 228);
            this.txt_TotalCompra.Name = "txt_TotalCompra";
            this.txt_TotalCompra.ReadOnly = true;
            this.txt_TotalCompra.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalCompra.TabIndex = 21;
            // 
            // ComprasGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(811, 479);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TotalCompra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_compra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComprasGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComprasGestion";
            this.Load += new System.EventHandler(this.ComprasGestion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idempleados;
        private System.Windows.Forms.TextBox txt_idproveedores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_compra;
        private System.Windows.Forms.Button btn_proveedor;
        private System.Windows.Forms.Button btn_empleado;
        private System.Windows.Forms.Button btn_Agregar_Prod;
        private System.Windows.Forms.Button btn_eliminar_prod;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.Label lbl_pr;
        private System.Windows.Forms.TextBox txt_precioCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TotalCompra;
    }
}