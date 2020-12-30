namespace HelloWorld
{
	partial class Window1
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
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.dgStaff = new Wisej.Web.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AllowHtml = true;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(21, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "New staff";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AllowHtml = true;
            this.button2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromName("@accent");
            this.button2.CssClass = "btn btn-primary";
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(764, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "New organization";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgStaff
            // 
            this.dgStaff.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dgStaff.Location = new System.Drawing.Point(21, 90);
            this.dgStaff.Name = "dgStaff";
            this.dgStaff.Size = new System.Drawing.Size(951, 423);
            this.dgStaff.TabIndex = 2;
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 537);
            this.Controls.Add(this.dgStaff);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new Wisej.Web.Padding(9, 0, 9, 0);
            this.MinimizeBox = false;
            this.Name = "Window1";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Sample";
            this.Load += new System.EventHandler(this.Window1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private Wisej.Web.Button button1;
        private Wisej.Web.Button button2;
        private Wisej.Web.DataGridView dgStaff;
    }
}

