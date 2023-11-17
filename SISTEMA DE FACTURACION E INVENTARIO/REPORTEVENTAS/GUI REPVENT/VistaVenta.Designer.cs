
namespace REPORTEVENTAS.GUI
{
    partial class VistaVenta
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
            this.crvVistaVenta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVistaVenta
            // 
            this.crvVistaVenta.ActiveViewIndex = -1;
            this.crvVistaVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVistaVenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVistaVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVistaVenta.Location = new System.Drawing.Point(0, 0);
            this.crvVistaVenta.Name = "crvVistaVenta";
            this.crvVistaVenta.Size = new System.Drawing.Size(800, 450);
            this.crvVistaVenta.TabIndex = 0;
            this.crvVistaVenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VistaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvVistaVenta);
            this.Name = "VistaVenta";
            this.Text = "VistaVenta";
            this.Load += new System.EventHandler(this.VistaVenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVistaVenta;
        //private ReporteVentaFactura ReporteVentaFactura1;
    }
}