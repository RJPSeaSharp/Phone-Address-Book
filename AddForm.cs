using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Data.PhoneBook.ContainsKey(txtFName.Text))
            {
                Person newperson = new Person();
                newperson.Fname = txtFName.Text;
                newperson.LName = txtLName.Text;
                newperson.Address = txtAddress.Text;
                newperson.MobilePhone = int.Parse(txtMobilePhone.Text);
                newperson.WorkPhone = int.Parse(txtWorkPhone.Text);
                Data.PhoneBook.Add(txtFName.Text, newperson);
                Play();
                MessageBox.Show("Contact Added");
                PhoneBook phonebook = new PhoneBook();
                phonebook.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PhoneBook obj = new PhoneBook();
            obj.Show();
            this.Hide();
        }
        private void Play()
        {
         SystemSounds.Beep.Play();
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
