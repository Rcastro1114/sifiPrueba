
namespace General.GUI
{
    partial class VisorVenta
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
            this.crvVisorVentas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Factura1 = new General.Factura();
            this.SuspendLayout();
            // 
            // crvVisorVentas
            // 
            this.crvVisorVentas.ActiveViewIndex = -1;
            this.crvVisorVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisorVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisorVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVisorVentas.Location = new System.Drawing.Point(0, 0);
            this.crvVisorVentas.Name = "crvVisorVentas";
            this.crvVisorVentas.ReportSource = this.Factura1;
            this.crvVisorVentas.Size = new System.Drawing.Size(800, 450);
            this.crvVisorVentas.TabIndex = 0;
            this.crvVisorVentas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvVisorVentas);
            this.Name = "VisorVenta";
            this.Text = "VisorVenta";
            this.Load += new System.EventHandler(this.VisorVenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisorVentas;
        private Factura Factura1;
    }
}