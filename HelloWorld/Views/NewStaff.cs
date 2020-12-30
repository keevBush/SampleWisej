using HelloWorld.Extensions;
using HelloWorld.Models;
using HelloWorld.Services;
using System;
using System.Data.Entity;
using System.Linq;
using Wisej.Web;

namespace HelloWorld.Views
{
    public partial class NewStaff : Wisej.Web.Form
    {
        public event EventHandler SaveSuccess;
        public Organization SelectedOrganization { get; set; }
        private readonly DataContext _context;
        private readonly DataAccess<Staff> _dalStaff;
        public NewStaff(DataContext context,DataAccess<Staff> dal)
        {
            InitializeComponent();
            _context = context;
            _dalStaff = dal;
        }

        private async void NewStaff_Load(object sender, EventArgs e)
        {
            cbxOrganization.DataSource = await _context.Organizations.ToListAsync();
            cbxOrganization.DisplayMember = "Name";
            cbxOrganization.ValueMember = "Id";
        }

        private void cbxOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedOrganization = (Organization)((ComboBox)sender).SelectedItem;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = false;

                txtbxTitle.Text.IsRequired("Title");

                txtbxName.Text.IsRequired("Name");
                txtbxLastname.Text.IsRequired("Lastname");
                txtbxPhone.Text.IsRequired("Phone number");
                txtbxEmail.Text.IsRequired("Email");

                txtbxCountry.Text.IsRequired("Country");
                txtbxStreet.Text.IsRequired("Street");
                txtbxCity.Text.IsRequired("City");

                txtbxEmail.Text.IsEmail("Email");
                txtbxPhone.Text.IsDigits("Phone number");


                var newStaff = new Staff
                {
                    Email = txtbxEmail.Text,
                    Lastname = txtbxLastname.Text,
                    Name = txtbxName.Text,
                    Organization = SelectedOrganization,
                    PhoneNumber = txtbxPhone.Text,
                    Street = txtbxStreet.Text,
                    Title = txtbxTitle.Text,
                    City = txtbxCity.Text,
                    Country = txtbxCountry.Text
                };
                var data = await _dalStaff.NewItems(newStaff);
                SaveSuccess.Invoke(this, new DataEvent {
                    Organization = SelectedOrganization,
                    Staff = data.ToList().FirstOrDefault()
                });
                AlertBox.Show("Saved successfull",
                   icon: MessageBoxIcon.Information,
                   showCloseButton: true,
                   onclose: () => {
                       this.Hide();
                   });
            }
            catch(Exception ex)
            {
                AlertBox.Show(ex.Message, icon: MessageBoxIcon.Error, showCloseButton: true);
            }
            finally
            {
                btnSave.Enabled = true;

            }

        }

    }
}
