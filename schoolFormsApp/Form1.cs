using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using schoolLibrary;

namespace schoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPushToTest_Click(object sender, EventArgs e)
        {
            var testSchool = new school();
            testSchool.name = txtName.Text;
            testSchool.address = txtAddress.Text;
            testSchool.city = txtCity.Text;
            testSchool.state = txtState.Text;
            testSchool.zip = txtZip.Text;
            testSchool.phoneNumber = txtPhoneNumber.Text;
            try 
            {
                testSchool.twitterAddress = txtTwitterAddress.Text;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(testSchool.ToString());

           

        }
    }
}
