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
    public partial class PhoneBook : Form
    {
        public PhoneBook()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
            DataGridInfo.DataSource = Data.PhoneBook.Values.ToList();                                 
            //DataGridInfo.Visible = false;          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Play();
            var result = MessageBox.Show("This contact will be deleted", "Warning", MessageBoxButtons.OKCancel);
            Data.PhoneBook.Remove(DataGridInfo.CurrentRow.Cells[0].Value.ToString());
            Play();
            MessageBox.Show("Contact Delected.");
            DataGridInfo.DataSource = Data.PhoneBook.Values.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Play()
        {
          SystemSounds.Beep.Play();
        }

    }
}
