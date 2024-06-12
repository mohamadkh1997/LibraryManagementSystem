using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Trim inputs and check for mandatory fields
            if (string.IsNullOrWhiteSpace(fname.Text) || string.IsNullOrWhiteSpace(lname.Text) || string.IsNullOrWhiteSpace(email.Text))
            {
                MessageBox.Show("First name, last name, and email are required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Additional validations can go here (e.g., email format validation)
            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed to insert data into the database
            InsertMemberData();
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void InsertMemberData()
        {
            var parameters = new Dictionary<string, object>
    {
        {"@FirstName", fname.Text},
        {"@LastName", lname.Text},
        {"@PhoneNumber", phnumber.Text},
        {"@Email", email.Text},
        {"@Address", address.Text},
        {"@DateOfBirth", datbirth.Value},
        {"@MembershipDate", DateTime.Now}
    };

            string query = "INSERT INTO Members (FirstName, LastName, PhoneNumber, Email, Address, DateOfBirth, MembershipDate, IsActive) VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Address, @DateOfBirth, @MembershipDate, 0)";

            if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
            {
              
                MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add new member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
