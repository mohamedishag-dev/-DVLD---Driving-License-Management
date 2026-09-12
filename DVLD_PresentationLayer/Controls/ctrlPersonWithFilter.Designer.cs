namespace DVLD_PresentationLayer
{
    partial class ctrlPersonWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnAddPreson = new System.Windows.Forms.Button();
            this.lblFelter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.ctrlPresonCard1 = new DVLD_PresentationLayer.ctrlPresonCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnSearchPerson);
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.btnAddPreson);
            this.gbFilter.Controls.Add(this.lblFelter);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(737, 60);
            this.gbFilter.TabIndex = 0;
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
            this.btnSearchPerson.TabIndex = 1;
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
            "NationalNo",
            "PersonID"});
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
            this.btnAddPreson.TabIndex = 2;
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
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilter.Location = new System.Drawing.Point(271, 19);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(175, 26);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFiltering_TextChanged);
            // 
            // ctrlPresonCard1
            // 
            this.ctrlPresonCard1.Location = new System.Drawing.Point(0, 69);
            this.ctrlPresonCard1.Name = "ctrlPresonCard1";
            this.ctrlPresonCard1.Size = new System.Drawing.Size(737, 255);
            this.ctrlPresonCard1.TabIndex = 1;
            // 
            // ctrlPersonWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlPresonCard1);
            this.Name = "ctrlPersonWithFilter";
            this.Size = new System.Drawing.Size(746, 327);
            this.Load += new System.EventHandler(this.ctrlFindPerson_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPresonCard ctrlPresonCard1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnAddPreson;
        private System.Windows.Forms.Label lblFelter;
        private System.Windows.Forms.TextBox txtFilter;
    }
}
