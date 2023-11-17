
namespace General.GUI
{
    partial class ventas
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_buscar_emp = new System.Windows.Forms.Button();
            this.txt_apellidos_emp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Nombres_emp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_idEmpleados = new System.Windows.Forms.TextBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NoFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_venta = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btn_buscar_emp);
            this.groupBox3.Controls.Add(this.txt_apellidos_emp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_Nombres_emp);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_idEmpleados);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 142);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información sobre el empleado";
            // 
            // btn_buscar_emp
            // 
            this.btn_buscar_emp.Location = new System.Drawing.Point(126, 47);
            this.btn_buscar_emp.Name = "btn_buscar_emp";
            this.btn_buscar_emp.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_emp.TabIndex = 10;
            this.btn_buscar_emp.Text = "Buscar";
            this.btn_buscar_emp.UseVisualStyleBackColor = true;
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
            this.txt_idEmpleados.Size = new System.Drawing.Size(100, 22);
            this.txt_idEmpleados.TabIndex = 5;
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
            this.groupBox2.Location = new System.Drawing.Point(450, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 142);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información sobre el cliente";
            // 
            // btn_buscar_cli
            // 
            this.btn_buscar_cli.Location = new System.Drawing.Point(123, 47);
            this.btn_buscar_cli.Name = "btn_buscar_cli";
            this.btn_buscar_cli.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_cli.TabIndex = 11;
            this.btn_buscar_cli.Text = "Buscar";
            this.btn_buscar_cli.UseVisualStyleBackColor = true;
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
            this.txt_idClientes.Size = new System.Drawing.Size(100, 22);
            this.txt_idClientes.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_NoFactura);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Fecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(539, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 85);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la venta";
            // 
            // txt_NoFactura
            // 
            this.txt_NoFactura.Location = new System.Drawing.Point(231, 53);
            this.txt_NoFactura.Name = "txt_NoFactura";
            this.txt_NoFactura.ReadOnly = true;
            this.txt_NoFactura.Size = new System.Drawing.Size(112, 21);
            this.txt_NoFactura.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "N° de Factura";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(9, 53);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.ReadOnly = true;
            this.txt_Fecha.Size = new System.Drawing.Size(100, 21);
            this.txt_Fecha.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Punto de Venta";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 432);
            this.label1.TabIndex = 14;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_venta
            // 
            this.btn_venta.Location = new System.Drawing.Point(495, 279);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(127, 23);
            this.btn_venta.TabIndex = 17;
            this.btn_venta.Text = "Agregar Venta";
            this.btn_venta.UseVisualStyleBackColor = true;
            // 
            // ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.btn_venta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ventas";
            this.Text = "ventas";
            this.Load += new System.EventHandler(this.ventas_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_buscar_emp;
        public System.Windows.Forms.TextBox txt_apellidos_emp;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_Nombres_emp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_idEmpleados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_buscar_cli;
        private System.Windows.Forms.ComboBox cmbo_Formadepago;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_Apellidos_cli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Nombres_cli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_idClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NoFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_venta;
    }
}