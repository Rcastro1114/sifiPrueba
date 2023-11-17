
namespace ReporteProductos.GUI
{
    partial class ViewProductos
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
            this.crvVisorPoruductos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVisorPoruductos
            // 
            this.crvVisorPoruductos.ActiveViewIndex = -1;
            this.crvVisorPoruductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisorPoruductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisorPoruductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVisorPoruductos.Location = new System.Drawing.Point(0, 0);
            this.crvVisorPoruductos.Name = "crvVisorPoruductos";
            this.crvVisorPoruductos.Size = new System.Drawing.Size(800, 450);
            this.crvVisorPoruductos.TabIndex = 0;
            this.crvVisorPoruductos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ViewProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvVisorPoruductos);
            this.Name = "ViewProductos";
            this.Text = "ViewProductos";
            this.Load += new System.EventHandler(this.ViewProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisorPoruductos;
        //private RepProductos RepProductos1;
    }
}