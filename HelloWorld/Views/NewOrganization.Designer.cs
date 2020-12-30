
namespace HelloWorld.Views
{
    partial class NewOrganization
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
            this.txtbxName = new Wisej.Web.TextBox();
            this.txtbxStreet = new Wisej.Web.TextBox();
            this.txtbxZIP = new Wisej.Web.TextBox();
            this.txtbxCity = new Wisej.Web.TextBox();
            this.txtbxCountry = new Wisej.Web.TextBox();
            this.button1 = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtbxCountry);
            this.groupBox1.Controls.Add(this.txtbxCity);
            this.groupBox1.Controls.Add(this.txtbxZIP);
            this.groupBox1.Controls.Add(this.txtbxStreet);
            this.groupBox1.Controls.Add(this.txtbxName);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "Identity";
            // 
            // txtbxName
            // 
            this.txtbxName.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxName.Location = new System.Drawing.Point(5, 33);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(359, 22);
            this.txtbxName.TabIndex = 0;
            this.txtbxName.Watermark = "Name";
            // 
            // txtbxStreet
            // 
            this.txtbxStreet.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxStreet.Location = new System.Drawing.Point(5, 92);
            this.txtbxStreet.Name = "txtbxStreet";
            this.txtbxStreet.Size = new System.Drawing.Size(359, 22);
            this.txtbxStreet.TabIndex = 1;
            this.txtbxStreet.Watermark = "Street";
            // 
            // txtbxZIP
            // 
            this.txtbxZIP.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxZIP.Location = new System.Drawing.Point(6, 158);
            this.txtbxZIP.Name = "txtbxZIP";
            this.txtbxZIP.Size = new System.Drawing.Size(359, 22);
            this.txtbxZIP.TabIndex = 2;
            this.txtbxZIP.Watermark = "ZIP";
            // 
            // txtbxCity
            // 
            this.txtbxCity.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxCity.Location = new System.Drawing.Point(5, 222);
            this.txtbxCity.Name = "txtbxCity";
            this.txtbxCity.Size = new System.Drawing.Size(359, 22);
            this.txtbxCity.TabIndex = 3;
            this.txtbxCity.Watermark = "City";
            // 
            // txtbxCountry
            // 
            this.txtbxCountry.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxCountry.Location = new System.Drawing.Point(5, 289);
            this.txtbxCountry.Name = "txtbxCountry";
            this.txtbxCountry.Size = new System.Drawing.Size(359, 22);
            this.txtbxCountry.TabIndex = 4;
            this.txtbxCountry.Watermark = "Country";
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(274, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewOrganization";
            this.Text = "New organization";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.GroupBox groupBox1;
        private Wisej.Web.TextBox txtbxCountry;
        private Wisej.Web.TextBox txtbxCity;
        private Wisej.Web.TextBox txtbxZIP;
        private Wisej.Web.TextBox txtbxStreet;
        private Wisej.Web.TextBox txtbxName;
        private Wisej.Web.Button button1;
    }
}