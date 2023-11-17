namespace General.GUI
{
    partial class PuntoDeVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuntoDeVenta));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_buscar_cli = new System.Windows.Forms.Button();
            this.cmbo_Formadepago = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_Apellidos_cli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Nombres_cli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_idClientes = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_apellidos_emp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Nombres_emp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_idEmpleados = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar_Prod = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_precio_pro = new System.Windows.Forms.TextBox();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_idproductos = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_paga = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_cambio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgtv_ventas = new System.Windows.Forms.DataGridView();
            this.idProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(891, 534);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(787, 13);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.ReadOnly = true;
            this.txt_Fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_Fecha.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(732, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_buscar_cli);
            this.groupBox2.Controls.Add(this.cmbo_Formadepago);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txt_Apellidos_cli);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_Nombres_cli);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_idClientes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 142);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información sobre el cliente";
            // 
            // btn_buscar_cli
            // 
            this.btn_buscar_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.btn_buscar_cli.ForeColor = System.Drawing.Color.White;
            this.btn_buscar_cli.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_cli.Image")));
            this.btn_buscar_cli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar_cli.Location = new System.Drawing.Point(123, 49);
            this.btn_buscar_cli.Name = "btn_buscar_cli";
            this.btn_buscar_cli.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_buscar_cli.Size = new System.Drawing.Size(85, 23);
            this.btn_buscar_cli.TabIndex = 11;
            this.btn_buscar_cli.Text = "Buscar";
            this.btn_buscar_cli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar_cli.UseVisualStyleBackColor = false;
            this.btn_buscar_cli.Click += new System.EventHandler(this.btn_buscar_cli_Click);
            // 
            // cmbo_Formadepago
            // 
            this.cmbo_Formadepago.FormattingEnabled = true;
            this.cmbo_Formadepago.Location = new System.Drawing.Point(254, 48);
            this.cmbo_Formadepago.Name = "cmbo_Formadepago";
            this.cmbo_Formadepago.Size = new System.Drawing.Size(178, 24);
            this.cmbo_Formadepago.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(251, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 18);
            this.label20.TabIndex = 10;
            this.label20.Text = "Forma de Pago";
            // 
            // txt_Apellidos_cli
            // 
            this.txt_Apellidos_cli.Location = new System.Drawing.Point(254, 109);
            this.txt_Apellidos_cli.Name = "txt_Apellidos_cli";
            this.txt_Apellidos_cli.ReadOnly = true;
            this.txt_Apellidos_cli.Size = new System.Drawing.Size(178, 22);
            this.txt_Apellidos_cli.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Apellido";
            // 
            // txt_Nombres_cli
            // 
            this.txt_Nombres_cli.Location = new System.Drawing.Point(9, 109);
            this.txt_Nombres_cli.Name = "txt_Nombres_cli";
            this.txt_Nombres_cli.ReadOnly = true;
            this.txt_Nombres_cli.Size = new System.Drawing.Size(178, 22);
            this.txt_Nombres_cli.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "ID del Cliente";
            // 
            // txt_idClientes
            // 
            this.txt_idClientes.Location = new System.Drawing.Point(9, 48);
            this.txt_idClientes.Name = "txt_idClientes";
            this.txt_idClientes.ReadOnly = true;
            this.txt_idClientes.Size = new System.Drawing.Size(100, 22);
            this.txt_idClientes.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txt_apellidos_emp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_Nombres_emp);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_idEmpleados);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(469, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 142);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información sobre el empleado";
            // 
            // txt_apellidos_emp
            // 
            this.txt_apellidos_emp.Location = new System.Drawing.Point(226, 107);
            this.txt_apellidos_emp.Name = "txt_apellidos_emp";
            this.txt_apellidos_emp.ReadOnly = true;
            this.txt_apellidos_emp.Size = new System.Drawing.Size(178, 22);
            this.txt_apellidos_emp.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(223, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Apellido";
            // 
            // txt_Nombres_emp
            // 
            this.txt_Nombres_emp.Location = new System.Drawing.Point(9, 107);
            this.txt_Nombres_emp.Name = "txt_Nombres_emp";
            this.txt_Nombres_emp.ReadOnly = true;
            this.txt_Nombres_emp.Size = new System.Drawing.Size(178, 22);
            this.txt_Nombres_emp.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "ID del empleado";
            // 
            // txt_idEmpleados
            // 
            this.txt_idEmpleados.Location = new System.Drawing.Point(9, 48);
            this.txt_idEmpleados.Name = "txt_idEmpleados";
            this.txt_idEmpleados.ReadOnly = true;
            this.txt_idEmpleados.Size = new System.Drawing.Size(100, 22);
            this.txt_idEmpleados.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btn_Buscar_Prod);
            this.groupBox4.Controls.Add(this.btn_Agregar);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txt_Cantidad);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txt_stock);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txt_precio_pro);
            this.groupBox4.Controls.Add(this.txt_producto);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txt_idproductos);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(20, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(807, 133);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Información sobre el producto";
            // 
            // btn_Buscar_Prod
            // 
            this.btn_Buscar_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.btn_Buscar_Prod.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar_Prod.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar_Prod.Image")));
            this.btn_Buscar_Prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar_Prod.Location = new System.Drawing.Point(126, 47);
            this.btn_Buscar_Prod.Name = "btn_Buscar_Prod";
            this.btn_Buscar_Prod.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_Buscar_Prod.Size = new System.Drawing.Size(81, 23);
            this.btn_Buscar_Prod.TabIndex = 11;
            this.btn_Buscar_Prod.Text = "Buscar";
            this.btn_Buscar_Prod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar_Prod.UseVisualStyleBackColor = false;
            this.btn_Buscar_Prod.Click += new System.EventHandler(this.btn_Buscar_Prod_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(707, 46);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_Agregar.Size = new System.Drawing.Size(41, 32);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(560, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 18);
            this.label15.TabIndex = 16;
            this.label15.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(563, 98);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 22);
            this.txt_Cantidad.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(385, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 18);
            this.label14.TabIndex = 14;
            this.label14.Text = "Stock";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(388, 98);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.ReadOnly = true;
            this.txt_stock.Size = new System.Drawing.Size(100, 22);
            this.txt_stock.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(203, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Precio";
            // 
            // txt_precio_pro
            // 
            this.txt_precio_pro.Location = new System.Drawing.Point(206, 98);
            this.txt_precio_pro.Name = "txt_precio_pro";
            this.txt_precio_pro.Size = new System.Drawing.Size(100, 22);
            this.txt_precio_pro.TabIndex = 13;
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(274, 48);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.ReadOnly = true;
            this.txt_producto.Size = new System.Drawing.Size(421, 22);
            this.txt_producto.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "ID del producto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(271, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Producto";
            // 
            // txt_idproductos
            // 
            this.txt_idproductos.Location = new System.Drawing.Point(9, 48);
            this.txt_idproductos.Name = "txt_idproductos";
            this.txt_idproductos.ReadOnly = true;
            this.txt_idproductos.Size = new System.Drawing.Size(100, 22);
            this.txt_idproductos.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(686, 461);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 18);
            this.label16.TabIndex = 18;
            this.label16.Text = "Total Venta";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(689, 482);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(100, 20);
            this.txt_Total.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(686, 333);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 18);
            this.label17.TabIndex = 20;
            this.label17.Text = "Registro de pago";
            // 
            // txt_paga
            // 
            this.txt_paga.Location = new System.Drawing.Point(689, 354);
            this.txt_paga.Name = "txt_paga";
            this.txt_paga.Size = new System.Drawing.Size(100, 20);
            this.txt_paga.TabIndex = 21;
            this.txt_paga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_paga_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(692, 386);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 18);
            this.label19.TabIndex = 24;
            this.label19.Text = "Cambio";
            // 
            // txt_cambio
            // 
            this.txt_cambio.Location = new System.Drawing.Point(784, 387);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.ReadOnly = true;
            this.txt_cambio.Size = new System.Drawing.Size(100, 20);
            this.txt_cambio.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(798, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 46);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generar Venta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgtv_ventas
            // 
            this.dgtv_ventas.AllowUserToAddRows = false;
            this.dgtv_ventas.BackgroundColor = System.Drawing.Color.White;
            this.dgtv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtv_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductos,
            this.Productos,
            this.Cantidad,
            this.PrecioVenta,
            this.SubTotal,
            this.eliminar});
            this.dgtv_ventas.Location = new System.Drawing.Point(20, 322);
            this.dgtv_ventas.Name = "dgtv_ventas";
            this.dgtv_ventas.ReadOnly = true;
            this.dgtv_ventas.Size = new System.Drawing.Size(660, 206);
            this.dgtv_ventas.TabIndex = 27;
            this.dgtv_ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtv_ventas_CellContentClick);
            this.dgtv_ventas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgtv_ventas_CellPainting);
            // 
            // idProductos
            // 
            this.idProductos.HeaderText = "idProductos";
            this.idProductos.Name = "idProductos";
            this.idProductos.ReadOnly = true;
            this.idProductos.Width = 83;
            // 
            // Productos
            // 
            this.Productos.HeaderText = "Productos";
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            // 
            // PuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(910, 552);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgtv_ventas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_cambio);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_paga);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PuntoDeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PuntoDeVenta";
            this.Load += new System.EventHandler(this.PuntoDeVenta_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Nombres_cli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbo_Formadepago;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_Apellidos_cli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_precio_pro;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_idproductos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_paga;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_cambio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_buscar_cli;
        public System.Windows.Forms.TextBox txt_apellidos_emp;
        public System.Windows.Forms.TextBox txt_Nombres_emp;
        public System.Windows.Forms.TextBox txt_idEmpleados;
        private System.Windows.Forms.Button btn_Buscar_Prod;
        private System.Windows.Forms.DataGridView dgtv_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        public System.Windows.Forms.TextBox txt_idClientes;
        private System.Windows.Forms.Button btn_Agregar;
    }
}