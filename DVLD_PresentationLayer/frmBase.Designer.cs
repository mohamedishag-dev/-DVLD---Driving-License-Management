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
            this.dgvAllPeople = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(275, 137);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(510, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tital";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBase
            // 
            this.pbBase.Image = global::DVLD_PresentationLayer.Properties.Resources.Male_512;
            this.pbBase.Location = new System.Drawing.Point(445, 31);
            this.pbBase.Name = "pbBase";
            this.pbBase.Size = new System.Drawing.Size(153, 85);
            this.pbBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBase.TabIndex = 0;
            this.pbBase.TabStop = false;
            // 
            // dgvAllPeople
            // 
            this.dgvAllPeople.AllowUserToAddRows = false;
            this.dgvAllPeople.AllowUserToDeleteRows = false;
            this.dgvAllPeople.AllowUserToOrderColumns = true;
            this.dgvAllPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAllPeople.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPeople.Location = new System.Drawing.Point(35, 215);
            this.dgvAllPeople.Name = "dgvAllPeople";
            this.dgvAllPeople.Size = new System.Drawing.Size(1037, 282);
            this.dgvAllPeople.TabIndex = 3;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 509);
            this.Controls.Add(this.dgvAllPeople);
            this.Controls.Add(this.pbBase);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBase";
            this.Load += new System.EventHandler(this.frmBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBase;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvAllPeople;
    }
}