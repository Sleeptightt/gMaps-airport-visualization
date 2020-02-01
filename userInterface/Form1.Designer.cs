namespace userInterface
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
            this.gMap1 = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gMap1
            // 
            this.gMap1.Bearing = 0F;
            this.gMap1.CanDragMap = true;
            this.gMap1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap1.GrayScaleMode = false;
            this.gMap1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap1.LevelsKeepInMemory = 5;
            this.gMap1.Location = new System.Drawing.Point(13, 13);
            this.gMap1.MarkersEnabled = true;
            this.gMap1.MaxZoom = 2;
            this.gMap1.MinZoom = 2;
            this.gMap1.MouseWheelZoomEnabled = true;
            this.gMap1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap1.Name = "gMap1";
            this.gMap1.NegativeMode = false;
            this.gMap1.PolygonsEnabled = true;
            this.gMap1.RetryLoadTile = 0;
            this.gMap1.RoutesEnabled = true;
            this.gMap1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap1.ShowTileGridLines = false;
            this.gMap1.Size = new System.Drawing.Size(555, 425);
            this.gMap1.TabIndex = 0;
            this.gMap1.Zoom = 0D;
            this.gMap1.Load += new System.EventHandler(this.gMap1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AIRPORT INFORMATION";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 374);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gMap1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

