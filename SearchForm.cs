using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment_4._2
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBacktoMain_Click(object sender, EventArgs e)
        {

            PhoneBook obj = new PhoneBook();
            obj.Show();
            this.Hide();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtFname.Text;

            if (Data.PhoneBook.ContainsKey(name))
            {
                MessageBox.Show("First Name: " + Data.PhoneBook[name].Fname + "\n\nLast Name: " + Data.PhoneBook[name].LName + "\n\nAddress: " + Data.PhoneBook[name].Address + "\n\nMobile Number:  " + Data.PhoneBook[name].MobilePhone + "\n\nWork Number: " + Data.PhoneBook[name].WorkPhone);
            }
            else
            {
                Play();
                MessageBox.Show("Person is not found!");
            }
        }
        private void Play()
        {


            SystemSounds.Beep.Play();


        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void lblLName_Click(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
