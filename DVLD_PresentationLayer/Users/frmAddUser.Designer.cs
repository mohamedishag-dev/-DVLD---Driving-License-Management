namespace DVLD_PresentationLayer
{
    partial class frmAddUser
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
            this.components = new System.ComponentModel.Container();
            this.lblMode = new System.Windows.Forms.Label();
            this.tbctrlAddUser = new System.Windows.Forms.TabControl();
            this.tabpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnAddPreson = new System.Windows.Forms.Button();
            this.lblFelter = new System.Windows.Forms.Label();
            this.txtFiltering = new System.Windows.Forms.TextBox();
            this.tabpLoginInfo = new System.Windows.Forms.TabPage();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.checkbIsActive = new System.Windows.Forms.CheckBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPresonCard1 = new DVLD_PresentationLayer.ctrlPresonCard();
            this.tbctrlAddUser.SuspendLayout();
            this.tabpPersonInfo.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.tabpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Red;
            this.lblMode.Location = new System.Drawing.Point(308, 32);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(169, 29);
            this.lblMode.TabIndex = 151;
            this.lblMode.Text = "Add New User";
            // 
            // tbctrlAddUser
            // 
            this.tbctrlAddUser.Controls.Add(this.tabpPersonInfo);
            this.tbctrlAddUser.Controls.Add(this.tabpLoginInfo);
            this.tbctrlAddUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbctrlAddUser.Location = new System.Drawing.Point(12, 83);
            this.tbctrlAddUser.Name = "tbctrlAddUser";
            this.tbctrlAddUser.SelectedIndex = 0;
            this.tbctrlAddUser.Size = new System.Drawing.Size(773, 413);
            this.tbctrlAddUser.TabIndex = 155;
            this.tbctrlAddUser.TabStop = false;
            // 
            // tabpPersonInfo
            // 
            this.tabpPersonInfo.Controls.Add(this.btnNext);
            this.tabpPersonInfo.Controls.Add(this.gbFilter);
            this.tabpPersonInfo.Controls.Add(this.ctrlPresonCard1);
            this.tabpPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tabpPersonInfo.Name = "tabpPersonInfo";
            this.tabpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabpPersonInfo.Size = new System.Drawing.Size(765, 387);
            this.tabpPersonInfo.TabIndex = 0;
            this.tabpPersonInfo.Text = "Person Info";
            this.tabpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(644, 347);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 34);
            this.btnNext.TabIndex = 158;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnSearchPerson);
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.btnAddPreson);
            this.gbFilter.Controls.Add(this.lblFelter);
            this.gbFilter.Controls.Add(this.txtFiltering);
            this.gbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFilter.Location = new System.Drawing.Point(6, 17);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(737, 60);
            this.gbFilter.TabIndex = 156;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.SearchPerson;
            this.btnSearchPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPerson.Location = new System.Drawing.Point(452, 19);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(43, 34);
            this.btnSearchPerson.TabIndex = 24;
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "NationalNo"});
            this.cbFilter.Location = new System.Drawing.Point(98, 19);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(167, 28);
            this.cbFilter.TabIndex = 20;
            this.cbFilter.SelectionChangeCommitted += new System.EventHandler(this.cbFilter_SelectionChangeCommitted);
            // 
            // btnAddPreson
            // 
            this.btnAddPreson.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.Add_Person_401;
            this.btnAddPreson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPreson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPreson.Location = new System.Drawing.Point(501, 19);
            this.btnAddPreson.Name = "btnAddPreson";
            this.btnAddPreson.Size = new System.Drawing.Size(43, 34);
            this.btnAddPreson.TabIndex = 23;
            this.btnAddPreson.UseVisualStyleBackColor = true;
            this.btnAddPreson.Click += new System.EventHandler(this.btnAddPreson_Click);
            // 
            // lblFelter
            // 
            this.lblFelter.AutoSize = true;
            this.lblFelter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFelter.Location = new System.Drawing.Point(11, 22);
            this.lblFelter.Name = "lblFelter";
            this.lblFelter.Size = new System.Drawing.Size(72, 20);
            this.lblFelter.TabIndex = 21;
            this.lblFelter.Text = "Felter By";
            // 
            // txtFiltering
            // 
            this.txtFiltering.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFiltering.Location = new System.Drawing.Point(271, 19);
            this.txtFiltering.Name = "txtFiltering";
            this.txtFiltering.Size = new System.Drawing.Size(175, 26);
            this.txtFiltering.TabIndex = 22;
            // 
            // tabpLoginInfo
            // 
            this.tabpLoginInfo.Controls.Add(this.btnPrev);
            this.tabpLoginInfo.Controls.Add(this.txtPassword);
            this.tabpLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tabpLoginInfo.Controls.Add(this.txtUserName);
            this.tabpLoginInfo.Controls.Add(this.checkbIsActive);
            this.tabpLoginInfo.Controls.Add(this.labelUserName);
            this.tabpLoginInfo.Controls.Add(this.labelPassword);
            this.tabpLoginInfo.Controls.Add(this.labelConfirmPassword);
            this.tabpLoginInfo.Controls.Add(this.lblUserID);
            this.tabpLoginInfo.Controls.Add(this.labelUserID);
            this.tabpLoginInfo.Controls.Add(this.pictureBox4);
            this.tabpLoginInfo.Controls.Add(this.pictureBox3);
            this.tabpLoginInfo.Controls.Add(this.pictureBox2);
            this.tabpLoginInfo.Controls.Add(this.pictureBox1);
            this.tabpLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tabpLoginInfo.Name = "tabpLoginInfo";
            this.tabpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabpLoginInfo.Size = new System.Drawing.Size(765, 387);
            this.tabpLoginInfo.TabIndex = 1;
            this.tabpLoginInfo.Text = "Login Info";
            this.tabpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(644, 347);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(99, 34);
            this.btnPrev.TabIndex = 159;
            this.btnPrev.Text = "Prev";
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(227, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(175, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(227, 150);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(175, 26);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUserName.Location = new System.Drawing.Point(227, 82);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(175, 26);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // checkbIsActive
            // 
            this.checkbIsActive.AutoSize = true;
            this.checkbIsActive.Checked = true;
            this.checkbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkbIsActive.Location = new System.Drawing.Point(227, 191);
            this.checkbIsActive.Name = "checkbIsActive";
            this.checkbIsActive.Size = new System.Drawing.Size(85, 22);
            this.checkbIsActive.TabIndex = 3;
            this.checkbIsActive.Text = "IsActive";
            this.checkbIsActive.UseVisualStyleBackColor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelUserName.Location = new System.Drawing.Point(91, 84);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(93, 18);
            this.labelUserName.TabIndex = 160;
            this.labelUserName.Text = "UserName:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelPassword.Location = new System.Drawing.Point(96, 119);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(88, 18);
            this.labelPassword.TabIndex = 158;
            this.labelPassword.Text = "Password:";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelConfirmPassword.Location = new System.Drawing.Point(31, 152);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(153, 18);
            this.labelConfirmPassword.TabIndex = 156;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(227, 49);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(35, 18);
            this.lblUserID.TabIndex = 155;
            this.lblUserID.Text = "???";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(114, 49);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(70, 18);
            this.labelUserID.TabIndex = 154;
            this.labelUserID.Text = "User ID:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = global::DVLD_PresentationLayer.Properties.Resources.Password_32;
            this.pictureBox4.Location = new System.Drawing.Point(190, 150);
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
            this.pictureBox3.Location = new System.Drawing.Point(190, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 164;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::DVLD_PresentationLayer.Properties.Resources.Password_32;
            this.pictureBox2.Location = new System.Drawing.Point(190, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 163;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DVLD_PresentationLayer.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(190, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 162;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(603, 498);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(695, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPresonCard1
            // 
            this.ctrlPresonCard1.Location = new System.Drawing.Point(6, 83);
            this.ctrlPresonCard1.Name = "ctrlPresonCard1";
            this.ctrlPresonCard1.Size = new System.Drawing.Size(747, 275);
            this.ctrlPresonCard1.TabIndex = 0;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 537);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbctrlAddUser);
            this.Controls.Add(this.lblMode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load_1);
            this.tbctrlAddUser.ResumeLayout(false);
            this.tabpPersonInfo.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.tabpLoginInfo.ResumeLayout(false);
            this.tabpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TabPage tabpPersonInfo;
        private ctrlPresonCard ctrlPresonCard1;
        private System.Windows.Forms.TabPage tabpLoginInfo;
        private System.Windows.Forms.TabControl tbctrlAddUser;
        private System.Windows.Forms.TextBox txtFiltering;
        private System.Windows.Forms.Label lblFelter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.Button btnAddPreson;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox checkbIsActive;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}