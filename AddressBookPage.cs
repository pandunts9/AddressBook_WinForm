using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Removes all values from fields
        /// </summary>
        private void ClearFields()
        {
            name_tb.Text = String.Empty;
            lastName_tb.Text = String.Empty;
            email_tb.Text = String.Empty;
            phisycalAddress_tb.Text = String.Empty;
            phone_tb.Text = String.Empty;
        }
        /// <summary>
        /// Returnes true if all fields are completed
        /// </summary>
        /// <returns>Returns boolean value</returns>
        private bool IsCompleted()
        {
            if (name_tb.Text.Length > 0 && lastName_tb.Text.Length > 0 && email_tb.Text.Length > 0 &&
                phisycalAddress_tb.Text.Length > 0 && phone_tb.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        private List<Contact> Contacts = new List<Contact>();
        Contact contact = new Contact();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }
        private void phone_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[0-9]"))
            {
                e.Handled = true;
            }
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact() { };
            contact.FirstName = name_tb.Text;
            contact.LastName = lastName_tb.Text;
            contact.Email = email_tb.Text;
            contact.PhysicalAddress = phisycalAddress_tb.Text;
            if ((phone_tb.Text.Length > 0))
            {
                contact.PhoneNumber = Convert.ToInt32(phone_tb.Text);
            }
            if (IsCompleted())
            {
                Contacts.Add(contact);
                contacts_list.Items.Add(contact.FullName);
                warning_label_2.Visible = false;
            }
            else
            {
                warning_label_2.Visible = true;
            }

            ClearFields();

        }
        private void delete_bt_Click(object sender, EventArgs e)
        {
            contacts_list.SelectedItems[0].SubItems[0].Text = String.Empty;
        }

        private void clear_bt_Click(object sender, EventArgs e)
        {
            ClearFields();
            warning_label_2.Visible = false;
        }

        
        private void edit_bt_Click(object sender, EventArgs e)
        {
            
            foreach (Contact item in Contacts)
            {
                if (item.FullName == contacts_list.SelectedItems[0].SubItems[0].Text)
                {
                    name_tb.Text = item.FirstName;
                    lastName_tb.Text = item.LastName;
                    email_tb.Text = item.Email;
                    phisycalAddress_tb.Text = item.PhysicalAddress;
                    phone_tb.Text = item.PhoneNumber.ToString();
                }
            }
           
        }

    }
}
