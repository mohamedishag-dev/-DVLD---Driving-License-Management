namespace DVLD_PresentationLayer.Tests
{
    partial class frmLocalDrivingLicenseApplication
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
            this.tbctrlAddUser = new System.Windows.Forms.TabControl();
            this.tabpPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonWithFilter1 = new DVLD_PresentationLayer.ctrlPersonWithFilter();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabpLoginInfo = new System.Windows.Forms.TabPage();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblDL_ApplicationID = new System.Windows.Forms.Label();
            this.labelDLApplication = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLecenseClass = new System.Windows.Forms.ComboBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblFess = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbctrlAddUser.SuspendLayout();
            this.tabpPersonInfo.SuspendLayout();
            this.tabpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbctrlAddUser
            // 
            this.tbctrlAddUser.Controls.Add(this.tabpPersonInfo);
            this.tbctrlAddUser.Controls.Add(this.tabpLoginInfo);
            this.tbctrlAddUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbctrlAddUser.Location = new System.Drawing.Point(29, 63);
            this.tbctrlAddUser.Name = "tbctrlAddUser";
            this.tbctrlAddUser.SelectedIndex = 0;
            this.tbctrlAddUser.Size = new System.Drawing.Size(769, 409);
            this.tbctrlAddUser.TabIndex = 1;
            this.tbctrlAddUser.TabStop = false;
            // 
            // tabpPersonInfo
            // 
            this.tabpPersonInfo.Controls.Add(this.ctrlPersonWithFilter1);
            this.tabpPersonInfo.Controls.Add(this.btnNext);
            this.tabpPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tabpPersonInfo.Name = "tabpPersonInfo";
            this.tabpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabpPersonInfo.Size = new System.Drawing.Size(761, 383);
            this.tabpPersonInfo.TabIndex = 0;
            this.tabpPersonInfo.Text = "Person Info";
            this.tabpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonWithFilter1
            // 
            this.ctrlPersonWithFilter1.FilterEnabled = true;
            this.ctrlPersonWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonWithFilter1.Name = "ctrlPersonWithFilter1";
            this.ctrlPersonWithFilter1.ShowAddPerson = true;
            this.ctrlPersonWithFilter1.Size = new System.Drawing.Size(746, 327);
            this.ctrlPersonWithFilter1.TabIndex = 0;
            this.ctrlPersonWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonWithFilter1_OnPersonSelected);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(641, 336);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 34);
            this.btnNext.TabIndex = 158;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // tabpLoginInfo
            // 
            this.tabpLoginInfo.Controls.Add(this.pictureBox5);
            this.tabpLoginInfo.Controls.Add(this.lblApplicationDate);
            this.tabpLoginInfo.Controls.Add(this.lblFess);
            this.tabpLoginInfo.Controls.Add(this.lblCreatedBy);
            this.tabpLoginInfo.Controls.Add(this.cbLecenseClass);
            this.tabpLoginInfo.Controls.Add(this.label4);
            this.tabpLoginInfo.Controls.Add(this.label3);
            this.tabpLoginInfo.Controls.Add(this.label2);
            this.tabpLoginInfo.Controls.Add(this.label1);
            this.tabpLoginInfo.Controls.Add(this.btnPrev);
            this.tabpLoginInfo.Controls.Add(this.lblDL_ApplicationID);
            this.tabpLoginInfo.Controls.Add(this.labelDLApplication);
            this.tabpLoginInfo.Controls.Add(this.pictureBox4);
            this.tabpLoginInfo.Controls.Add(this.pictureBox3);
            this.tabpLoginInfo.Controls.Add(this.pictureBox2);
            this.tabpLoginInfo.Controls.Add(this.pictureBox1);
            this.tabpLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tabpLoginInfo.Name = "tabpLoginInfo";
            this.tabpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabpLoginInfo.Size = new System.Drawing.Size(761, 383);
            this.tabpLoginInfo.TabIndex = 1;
            this.tabpLoginInfo.Text = "Login Info";
            this.tabpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(641, 336);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(99, 34);
            this.btnPrev.TabIndex = 159;
            this.btnPrev.Text = "Prev";
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // lblDL_ApplicationID
            // 
            this.lblDL_ApplicationID.AutoSize = true;
            this.lblDL_ApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDL_ApplicationID.Location = new System.Drawing.Point(261, 68);
            this.lblDL_ApplicationID.Name = "lblDL_ApplicationID";
            this.lblDL_ApplicationID.Size = new System.Drawing.Size(45, 18);
            this.lblDL_ApplicationID.TabIndex = 155;
            this.lblDL_ApplicationID.Text = "[???]";
            // 
            // labelDLApplication
            // 
            this.labelDLApplication.AutoSize = true;
            this.labelDLApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDLApplication.Location = new System.Drawing.Point(71, 66);
            this.labelDLApplication.Name = "labelDLApplication";
            this.labelDLApplication.Size = new System.Drawing.Size(147, 18);
            this.labelDLApplication.TabIndex = 154;
            this.labelDLApplication.Text = "D.L.Application ID:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(699, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(607, 478);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 34);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1027, 56);
            this.lblTitle.TabIndex = 152;
            this.lblTitle.Text = "New Local Driving License Application ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(83, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 166;
            this.label1.Text = "Application Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(81, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 167;
            this.label2.Text = "Application Fess:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(122, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 168;
            this.label3.Text = "Created By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(94, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 169;
            this.label4.Text = "Lecense Class:";
            // 
            // cbLecenseClass
            // 
            this.cbLecenseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbLecenseClass.FormattingEnabled = true;
            this.cbLecenseClass.Location = new System.Drawing.Point(261, 139);
            this.cbLecenseClass.Name = "cbLecenseClass";
            this.cbLecenseClass.Size = new System.Drawing.Size(263, 28);
            this.cbLecenseClass.TabIndex = 170;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.Location = new System.Drawing.Point(261, 222);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(35, 18);
            this.lblCreatedBy.TabIndex = 171;
            this.lblCreatedBy.Text = "???";
            // 
            // lblFess
            // 
            this.lblFess.AutoSize = true;
            this.lblFess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFess.Location = new System.Drawing.Point(261, 184);
            this.lblFess.Name = "lblFess";
            this.lblFess.Size = new System.Drawing.Size(26, 18);
            this.lblFess.TabIndex = 172;
            this.lblFess.Text = "15";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblApplicationDate.Location = new System.Drawing.Point(261, 106);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(35, 18);
            this.lblApplicationDate.TabIndex = 173;
            this.lblApplicationDate.Text = "???";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Image = global::DVLD_PresentationLayer.Properties.Resources.money_321;
            this.pictureBox5.Location = new System.Drawing.Point(224, 184);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 174;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = global::DVLD_PresentationLayer.Properties.Resources.User_32__2;
            this.pictureBox4.Location = new System.Drawing.Point(224, 222);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 165;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::DVLD_PresentationLayer.Properties.Resources.Number_321;
            this.pictureBox3.Location = new System.Drawing.Point(224, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 164;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::DVLD_PresentationLayer.Properties.Resources.Renew_Driving_License_321;
            this.pictureBox2.Location = new System.Drawing.Point(224, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 163;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DVLD_PresentationLayer.Properties.Resources.Calendar_32;
            this.pictureBox1.Location = new System.Drawing.Point(224, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 162;
            this.pictureBox1.TabStop = false;
            // 
            // frmLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 524);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbctrlAddUser);
            this.Name = "frmLocalDrivingLicenseApplication";
            this.Text = "frmLocalDrivingLicenseApplication";
            this.tbctrlAddUser.ResumeLayout(false);
            this.tabpPersonInfo.ResumeLayout(false);
            this.tabpLoginInfo.ResumeLayout(false);
            this.tabpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrlAddUser;
        private System.Windows.Forms.TabPage tabpPersonInfo;
        private ctrlPersonWithFilter ctrlPersonWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tabpLoginInfo;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblDL_ApplicationID;
        private System.Windows.Forms.Label labelDLApplication;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbLecenseClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblFess;
        private System.Windows.Forms.Label lblCreatedBy;
    }
}