namespace DVLD_PresentationLayer
{
    partial class frmBase
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbBase = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBase)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(295, 109);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(510, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Tital";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBase
            // 
            this.pbBase.Image = global::DVLD_PresentationLayer.Properties.Resources.Male_512;
            this.pbBase.Location = new System.Drawing.Point(465, 3);
            this.pbBase.Name = "pbBase";
            this.pbBase.Size = new System.Drawing.Size(153, 85);
            this.pbBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBase.TabIndex = 2;
            this.pbBase.TabStop = false;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 488);
            this.Controls.Add(this.pbBase);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmBase";
            this.Text = "frmBase";
            ((System.ComponentModel.ISupportInitialize)(this.pbBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBase;
        private System.Windows.Forms.Label lblTitle;
    }
}