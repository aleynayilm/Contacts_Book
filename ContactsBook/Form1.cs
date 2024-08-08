using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsBook
{
    public partial class Form1 : Form
    {
        DataTable contacts = new DataTable();
        bool editing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            phoneNumTextBox.Text = "";
            emailTextBox.Text = "";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastNameTextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            phoneNumTextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailTextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[3].ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["First Name"] = firstNameTextBox.Text;
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["Last Name"] = lastNameTextBox.Text;
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["Phone Number"] = phoneNumTextBox.Text;
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["Email"] = emailTextBox.Text;
            }
            else {
            contacts.Rows.Add(firstNameTextBox.Text,lastNameTextBox.Text,phoneNumTextBox.Text,emailTextBox.Text);
            }
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            phoneNumTextBox.Text = "";
            emailTextBox.Text = "";
            editing = false;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Not a valid now"); } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("First Name");
            contacts.Columns.Add("Last Name");
            contacts.Columns.Add("Phone Number");
            contacts.Columns.Add("Email");

            contactsDataGrid.DataSource = contacts;
        }

        private void contactsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
    }
}
