
namespace General.GUI
{
    partial class DireccionesGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DireccionesGestion));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistrosClt = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgvDirecciones = new System.Windows.Forms.DataGridView();
            this.txt_idDirecciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbboMunicipios = new System.Windows.Forms.ComboBox();
            this.txt_Cacerio = new System.Windows.Forms.TextBox();
            this.txt_Canton = new System.Windows.Forms.TextBox();
            this.txt_Residencia = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDirecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistrosClt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1025, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRegistrosClt
            // 
            this.lblRegistrosClt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosClt.Name = "lblRegistrosClt";
            this.lblRegistrosClt.Size = new System.Drawing.Size(168, 20);
            this.lblRegistrosClt.Text = "0 Registros Encontrados";
            // 
            // dtgvDirecciones
            // 
            this.dtgvDirecciones.AllowUserToAddRows = false;
            this.dtgvDirecciones.AllowUserToDeleteRows = false;
            this.dtgvDirecciones.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDirecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDirecciones.Location = new System.Drawing.Point(0, 25);
            this.dtgvDirecciones.Name = "dtgvDirecciones";
            this.dtgvDirecciones.ReadOnly = true;
            this.dtgvDirecciones.Size = new System.Drawing.Size(636, 364);
            this.dtgvDirecciones.TabIndex = 3;
            // 
            // txt_idDirecciones
            // 
            this.txt_idDirecciones.Location = new System.Drawing.Point(729, 49);
            this.txt_idDirecciones.Name = "txt_idDirecciones";
            this.txt_idDirecciones.ReadOnly = true;
            this.txt_idDirecciones.Size = new System.Drawing.Size(100, 20);
            this.txt_idDirecciones.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "idDirecciones";
            // 
            // cbboMunicipios
            // 
            this.cbboMunicipios.FormattingEnabled = true;
            this.cbboMunicipios.Location = new System.Drawing.Point(729, 279);
            this.cbboMunicipios.Name = "cbboMunicipios";
            this.cbboMunicipios.Size = new System.Drawing.Size(270, 21);
            this.cbboMunicipios.TabIndex = 20;
            // 
            // txt_Cacerio
            // 
            this.txt_Cacerio.Location = new System.Drawing.Point(729, 217);
            this.txt_Cacerio.Name = "txt_Cacerio";
            this.txt_Cacerio.Size = new System.Drawing.Size(270, 20);
            this.txt_Cacerio.TabIndex = 19;
            // 
            // txt_Canton
            // 
            this.txt_Canton.Location = new System.Drawing.Point(729, 155);
            this.txt_Canton.Name = "txt_Canton";
            this.txt_Canton.Size = new System.Drawing.Size(270, 20);
            this.txt_Canton.TabIndex = 18;
            // 
            // txt_Residencia
            // 
            this.txt_Residencia.Location = new System.Drawing.Point(729, 96);
            this.txt_Residencia.Name = "txt_Residencia";
            this.txt_Residencia.Size = new System.Drawing.Size(270, 20);
            this.txt_Residencia.TabIndex = 17;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(661, 351);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 16;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Municipio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cacerio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantón";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Residencia";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1025, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(924, 351);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 21;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // DireccionesGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 414);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.cbboMunicipios);
            this.Controls.Add(this.txt_Cacerio);
            this.Controls.Add(this.txt_Canton);
            this.Controls.Add(this.txt_Residencia);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_idDirecciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDirecciones);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DireccionesGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DireccionesGestion";
            this.Load += new System.EventHandler(this.DireccionesGestion_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDirecciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dtgvDirecciones;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistrosClt;
        private System.Windows.Forms.TextBox txt_idDirecciones;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbboMunicipios;
        private System.Windows.Forms.TextBox txt_Cacerio;
        private System.Windows.Forms.TextBox txt_Canton;
        private System.Windows.Forms.TextBox txt_Residencia;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btn_Actualizar;
    }
}