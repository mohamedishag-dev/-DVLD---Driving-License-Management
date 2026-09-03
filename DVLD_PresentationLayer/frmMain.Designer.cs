namespace DVLD_PresentationLayer
{
    partial class frmMain
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
            this.btnApplication = new System.Windows.Forms.Button();
            this.btnDirvers = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAccountSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApplication
            // 
            this.btnApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnApplication.FlatAppearance.BorderSize = 0;
            this.btnApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplication.Location = new System.Drawing.Point(2, 3);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(174, 67);
            this.btnApplication.TabIndex = 0;
            this.btnApplication.Text = "Applications";
            this.btnApplication.UseVisualStyleBackColor = false;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // btnDirvers
            // 
            this.btnDirvers.BackColor = System.Drawing.Color.Transparent;
            this.btnDirvers.FlatAppearance.BorderSize = 0;
            this.btnDirvers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirvers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirvers.Location = new System.Drawing.Point(362, 3);
            this.btnDirvers.Name = "btnDirvers";
            this.btnDirvers.Size = new System.Drawing.Size(174, 67);
            this.btnDirvers.TabIndex = 1;
            this.btnDirvers.Text = "Dirvers";
            this.btnDirvers.UseVisualStyleBackColor = false;
            this.btnDirvers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.Location = new System.Drawing.Point(182, 3);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(174, 67);
            this.btnPeople.TabIndex = 2;
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = false;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(542, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(174, 67);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnAccountSettings.FlatAppearance.BorderSize = 0;
            this.btnAccountSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSettings.Location = new System.Drawing.Point(722, 3);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Size = new System.Drawing.Size(209, 67);
            this.btnAccountSettings.TabIndex = 4;
            this.btnAccountSettings.Text = "Account Settings";
            this.btnAccountSettings.UseVisualStyleBackColor = false;
            this.btnAccountSettings.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 558);
            this.Controls.Add(this.btnAccountSettings);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnPeople);
            this.Controls.Add(this.btnDirvers);
            this.Controls.Add(this.btnApplication);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.Button btnDirvers;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnAccountSettings;
    }
}

