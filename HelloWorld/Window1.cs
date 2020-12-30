
using System;
using System.Drawing;
using Wisej.Web;
using System.Linq;
using HelloWorld.Models;
using System.Collections.Generic;
using HelloWorld.Views;

namespace HelloWorld
{
	public partial class Window1 : Form
	{
		private readonly DataContext _context;
		public Window1(DataContext context)
		{
			InitializeComponent();
			_context = context;
		}
		
		private void Window1_Load(object sender, EventArgs e)
		{
			LoadData();
			//this.comboBox1.Items.AddRange(Enum.GetNames(typeof(ContentAlignment)));
		}

        public void LoadData()
        {
			var data = new List<object>();
			foreach(var d in _context.Staffs.ToList())
            {
				var organization = _context.Organizations.FirstOrDefault(o => o.Id == d.OrganizationId);
				data.Add(new
				{
					Id = d.Id,
					Name = d.Name,
					Lastname = d.Lastname,
					Email = d.Email,
					Phone = d.PhoneNumber,
					Title = d.Title,
					Country = d.Country,
					City = d.City,
					Street = d.Street,
					Organisation = organization?.Name,
				});
            }
			dgStaff.DataSource = data;
		}

		private void button1_Click(object sender, EventArgs e)
		{
            // parse the selected alignment and default to TopCenter
            // if the selection in the combo is not a valid ContentAlignment.
            ContentAlignment alignment = ContentAlignment.TopCenter;

            AlertBox.Show("Hello World!", alignment: alignment);
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.ApplicationExit)
				return;

			var result = MessageBox.Show(
				@"Are you sure you want to close this window?
				<br/><br/>
				This is the only window, closing it will close the app!",
				"Application Question",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == Wisej.Web.DialogResult.No)
				e.Cancel = true;
			else
				Application.Exit();

			base.OnFormClosing(e);
		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
			var newStaffWindow = new NewStaff(_context, new Services.DataAccess<Staff>(_context));
            newStaffWindow.SaveSuccess += NewStaffWindow_SaveSuccess;
			await newStaffWindow.ShowDialogAsync();
        }

        private void NewStaffWindow_SaveSuccess(object sender, EventArgs e)
        {
			LoadData();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
			var newOrganizationWindow = new NewOrganization(new Services.DataAccess<Organization>(_context));
			await newOrganizationWindow.ShowDialogAsync();
        }

    }
}
