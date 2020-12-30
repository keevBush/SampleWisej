
namespace HelloWorld.Views
{
    partial class NewStaff
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.cbxOrganization = new Wisej.Web.ComboBox();
            this.txtbxTitle = new Wisej.Web.TextBox();
            this.txtbxPhone = new Wisej.Web.TextBox();
            this.txtbxEmail = new Wisej.Web.TextBox();
            this.txtbxLastname = new Wisej.Web.TextBox();
            this.txtbxName = new Wisej.Web.TextBox();
            this.btnSave = new Wisej.Web.Button();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.txtbxStreet = new Wisej.Web.TextBox();
            this.txtbxCity = new Wisej.Web.TextBox();
            this.txtbxCountry = new Wisej.Web.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxOrganization);
            this.groupBox1.Controls.Add(this.txtbxTitle);
            this.groupBox1.Controls.Add(this.txtbxPhone);
            this.groupBox1.Controls.Add(this.txtbxEmail);
            this.groupBox1.Controls.Add(this.txtbxLastname);
            this.groupBox1.Controls.Add(this.txtbxName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "Identity";
            // 
            // cbxOrganization
            // 
            this.cbxOrganization.AllowHtml = true;
            this.cbxOrganization.Location = new System.Drawing.Point(182, 187);
            this.cbxOrganization.Name = "cbxOrganization";
            this.cbxOrganization.Size = new System.Drawing.Size(317, 22);
            this.cbxOrganization.TabIndex = 5;
            this.cbxOrganization.Watermark = "Oganization";
            this.cbxOrganization.SelectedIndexChanged += new System.EventHandler(this.cbxOrganization_SelectedIndexChanged);
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxTitle.Location = new System.Drawing.Point(182, 34);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Size = new System.Drawing.Size(317, 22);
            this.txtbxTitle.TabIndex = 0;
            this.txtbxTitle.Watermark = "Title";
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxPhone.Location = new System.Drawing.Point(343, 138);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(317, 22);
            this.txtbxPhone.TabIndex = 4;
            this.txtbxPhone.Watermark = "Phone number";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxEmail.Location = new System.Drawing.Point(6, 138);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(317, 22);
            this.txtbxEmail.TabIndex = 3;
            this.txtbxEmail.Watermark = "Email";
            // 
            // txtbxLastname
            // 
            this.txtbxLastname.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxLastname.Location = new System.Drawing.Point(343, 74);
            this.txtbxLastname.Name = "txtbxLastname";
            this.txtbxLastname.Size = new System.Drawing.Size(317, 22);
            this.txtbxLastname.TabIndex = 2;
            this.txtbxLastname.Watermark = "Lastname";
            // 
            // txtbxName
            // 
            this.txtbxName.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxName.Location = new System.Drawing.Point(6, 74);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(317, 22);
            this.txtbxName.TabIndex = 1;
            this.txtbxName.Watermark = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(573, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbxCountry);
            this.groupBox2.Controls.Add(this.txtbxStreet);
            this.groupBox2.Controls.Add(this.txtbxCity);
            this.groupBox2.Location = new System.Drawing.Point(13, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.Text = "Location";
            // 
            // txtbxStreet
            // 
            this.txtbxStreet.Location = new System.Drawing.Point(428, 32);
            this.txtbxStreet.Name = "txtbxStreet";
            this.txtbxStreet.Size = new System.Drawing.Size(232, 22);
            this.txtbxStreet.TabIndex = 2;
            this.txtbxStreet.Watermark = "Street";
            // 
            // txtbxCity
            // 
            this.txtbxCity.Location = new System.Drawing.Point(217, 32);
            this.txtbxCity.Name = "txtbxCity";
            this.txtbxCity.Size = new System.Drawing.Size(202, 22);
            this.txtbxCity.TabIndex = 0;
            this.txtbxCity.Watermark = "City";
            // 
            // txtbxCountry
            // 
            this.txtbxCountry.Location = new System.Drawing.Point(0, 32);
            this.txtbxCountry.Name = "txtbxCountry";
            this.txtbxCountry.Size = new System.Drawing.Size(202, 22);
            this.txtbxCountry.TabIndex = 3;
            this.txtbxCountry.Watermark = "Country";
            // 
            // NewStaff
            // 
            this.ClientSize = new System.Drawing.Size(704, 389);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewStaff";
            this.Text = "New staff";
            this.Load += new System.EventHandler(this.NewStaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.GroupBox groupBox1;
        private Wisej.Web.TextBox txtbxLastname;
        private Wisej.Web.TextBox txtbxName;
        private Wisej.Web.TextBox txtbxPhone;
        private Wisej.Web.TextBox txtbxEmail;
        private Wisej.Web.TextBox txtbxTitle;
        private Wisej.Web.Button btnSave;
        private Wisej.Web.ComboBox cbxOrganization;
        private Wisej.Web.GroupBox groupBox2;
        private Wisej.Web.TextBox txtbxStreet;
        private Wisej.Web.TextBox txtbxCity;
        private Wisej.Web.TextBox txtbxCountry;
    }
}