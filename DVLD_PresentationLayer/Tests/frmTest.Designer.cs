namespace DVLD_PresentationLayer
{
    partial class frmTest
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
            this.ctrlPersonWithFilter1 = new DVLD_PresentationLayer.ctrlPersonWithFilter();
            this.SuspendLayout();
            // 
            // ctrlPersonWithFilter1
            // 
            this.ctrlPersonWithFilter1.Location = new System.Drawing.Point(44, 22);
            this.ctrlPersonWithFilter1.Name = "ctrlPersonWithFilter1";
            this.ctrlPersonWithFilter1.Size = new System.Drawing.Size(746, 327);
            this.ctrlPersonWithFilter1.TabIndex = 0;
            this.ctrlPersonWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonWithFilter1_OnPersonSelected);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 552);
            this.Controls.Add(this.ctrlPersonWithFilter1);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBase";
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonWithFilter ctrlPersonWithFilter1;
    }
}