using HelloWorld.Extensions;
using HelloWorld.Models;
using HelloWorld.Services;
using System;
using Wisej.Web;

namespace HelloWorld.Views
{
    public partial class NewOrganization : Form
    {
        private readonly DataAccess<Organization> _dalOrganization;
        public NewOrganization(DataAccess<Organization> dalOrganization)
        {
            InitializeComponent();
            _dalOrganization = dalOrganization;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                txtbxCity.Text.IsRequired();
                txtbxCountry.Text.IsRequired();
                txtbxName.Text.IsRequired();
                txtbxStreet.Text.IsRequired();
                txtbxZIP.Text.IsRequired();
                txtbxZIP.Text.IsDigits();
                await _dalOrganization.NewItems(new Organization {
                    City=txtbxCity.Text,
                    Country=txtbxCountry.Text,
                    Name= txtbxName.Text,
                    Street = txtbxStreet.Text,
                    Zip = int.Parse(txtbxZIP.Text),
                });
                AlertBox.Show("Saved successfull", 
                    icon: MessageBoxIcon.Information,
                    showCloseButton: true,
                    onclose:()=> {
                    this.Hide();
                });
            }
            catch (Exception ex)
            {
                AlertBox.Show(ex.Message, icon: MessageBoxIcon.Error, showCloseButton: true);
            }
            finally{
                button1.Enabled = true;
            }
        }
    }
}
