namespace DVLD_PresentationLayer.Users
{
    partial class frmUserDitels
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
            this.gpbLoginInformation = new System.Windows.Forms.GroupBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lebleIsActive = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lebleUsername = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.labellblUserID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlPresonCard1 = new DVLD_PresentationLayer.ctrlPresonCard();
            this.gpbLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLoginInformation
            // 
            this.gpbLoginInformation.Controls.Add(this.lblIsActive);
            this.gpbLoginInformation.Controls.Add(this.lebleIsActive);
            this.gpbLoginInformation.Controls.Add(this.lblUserName);
            this.gpbLoginInformation.Controls.Add(this.lebleUsername);
            this.gpbLoginInformation.Controls.Add(this.lblUserID);
            this.gpbLoginInformation.Controls.Add(this.labellblUserID);
            this.gpbLoginInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbLoginInformation.Location = new System.Drawing.Point(12, 293);
            this.gpbLoginInformation.Name = "gpbLoginInformation";
            this.gpbLoginInformation.Size = new System.Drawing.Size(740, 84);
            this.gpbLoginInformation.TabIndex = 1;
            this.gpbLoginInformation.TabStop = false;
            this.gpbLoginInformation.Text = "Login Information";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(541, 30);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(54, 18);
            this.lblIsActive.TabIndex = 168;
            this.lblIsActive.Text = "[????]";
            // 
            // lebleIsActive
            // 
            this.lebleIsActive.AutoSize = true;
            this.lebleIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lebleIsActive.Location = new System.Drawing.Point(459, 30);
            this.lebleIsActive.Name = "lebleIsActive";
            this.lebleIsActive.Size = new System.Drawing.Size(76, 18);
            this.lebleIsActive.TabIndex = 167;
            this.lebleIsActive.Text = "IsActive :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(348, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(54, 18);
            this.lblUserName.TabIndex = 166;
            this.lblUserName.Text = "[????]";
            // 
            // lebleUsername
            // 
            this.lebleUsername.AutoSize = true;
            this.lebleUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lebleUsername.Location = new System.Drawing.Point(252, 30);
            this.lebleUsername.Name = "lebleUsername";
            this.lebleUsername.Size = new System.Drawing.Size(90, 18);
            this.lebleUsername.TabIndex = 165;
            this.lebleUsername.Text = "Username:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(171, 30);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(54, 18);
            this.lblUserID.TabIndex = 164;
            this.lblUserID.Text = "[????]";
            // 
            // labellblUserID
            // 
            this.labellblUserID.AutoSize = true;
            this.labellblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labellblUserID.Location = new System.Drawing.Point(90, 30);
            this.labellblUserID.Name = "labellblUserID";
            this.labellblUserID.Size = new System.Drawing.Size(75, 18);
            this.labellblUserID.TabIndex = 162;
            this.labellblUserID.Text = "User ID :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(651, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlPresonCard1
            // 
            this.ctrlPresonCard1.Location = new System.Drawing.Point(12, 12);
            this.ctrlPresonCard1.Name = "ctrlPresonCard1";
            this.ctrlPresonCard1.Size = new System.Drawing.Size(752, 275);
            this.ctrlPresonCard1.TabIndex = 0;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gpbLoginInformation);
            this.Controls.Add(this.ctrlPresonCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserInfo";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.gpbLoginInformation.ResumeLayout(false);
            this.gpbLoginInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPresonCard ctrlPresonCard1;
        private System.Windows.Forms.GroupBox gpbLoginInformation;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lebleIsActive;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lebleUsername;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label labellblUserID;
        private System.Windows.Forms.Button btnClose;
    }
}