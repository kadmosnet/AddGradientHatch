namespace AddGradientHatch
{
    partial class Form1
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
            DXFReaderNET.DxfDocument dxfDocument2 = new DXFReaderNET.DxfDocument();
            DXFReaderNET.AciColor aciColor2 = new DXFReaderNET.AciColor();
            DXFReaderNET.Objects.RasterVariables rasterVariables2 = new DXFReaderNET.Objects.RasterVariables();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dxfReaderNETControl1 = new DXFReaderNET.DXFReaderNETControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dxfReaderNETControl1
            // 
            this.dxfReaderNETControl1.AutoSize = true;
            this.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None;
            dxfDocument2.ActiveLayout = "Model";
            dxfDocument2.Comments = null;
            aciColor2.Index = ((short)(256));
            aciColor2.IsByBlock = false;
            aciColor2.IsByLayer = true;
            aciColor2.UseTrueColor = false;
            dxfDocument2.CurrentColor = aciColor2;
            dxfDocument2.CurrentElevation = 0D;
            dxfDocument2.CurrentLayer = "0";
            dxfDocument2.CurrentLineTypeName = "ByLayer";
            dxfDocument2.CurrentLineTypeScale = 1D;
            dxfDocument2.CurrentTextSize = 2.5D;
            dxfDocument2.CurrentTextStyle = "STANDARD";
            dxfDocument2.CurrentThickness = 0D;
            dxfDocument2.DateCreated = new System.DateTime(2020, 1, 29, 9, 59, 45, 111);
            dxfDocument2.DateLastEdited = new System.DateTime(2020, 1, 29, 9, 59, 45, 111);
            dxfDocument2.Handle = "0";
            dxfDocument2.IsBinary = false;
            dxfDocument2.Modified = false;
            dxfDocument2.Name = null;
            dxfDocument2.Owner = null;
            rasterVariables2.DisplayFrame = true;
            rasterVariables2.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High;
            rasterVariables2.Handle = "2D";
            rasterVariables2.Owner = null;
            rasterVariables2.Units = DXFReaderNET.ImageUnits.Unitless;
            dxfDocument2.RasterVariables = rasterVariables2;
            dxfDocument2.ThumbnailImage = null;
            dxfDocument2.TotalEditTime = new System.DateTime(2020, 1, 29, 0, 0, 0, 0);
            dxfDocument2.TotalEditTimeDays = 0;
            dxfDocument2.UserTimer = new System.DateTime(2020, 1, 29, 0, 0, 0, 0);
            dxfDocument2.UserTimerDays = 0;
            this.dxfReaderNETControl1.DXF = dxfDocument2;
            this.dxfReaderNETControl1.FileName = null;
            this.dxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta;
            this.dxfReaderNETControl1.Location = new System.Drawing.Point(12, 12);
            this.dxfReaderNETControl1.Name = "dxfReaderNETControl1";
            this.dxfReaderNETControl1.ShowGridRuler = false;
            this.dxfReaderNETControl1.Size = new System.Drawing.Size(814, 619);
            this.dxfReaderNETControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add gradient hatches";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 643);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dxfReaderNETControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DXFReader.NET Component - AddGradientHatch Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DXFReaderNET.DXFReaderNETControl dxfReaderNETControl1;
        private System.Windows.Forms.Button button1;
    }
}

