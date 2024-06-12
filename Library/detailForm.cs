using Microsoft.Data.SqlClient;
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
    public partial class detailForm : Form
    {
        private int memberId;
        public detailForm(int id)
        {
            InitializeComponent();
            this.memberId = id;
        }
        private void detailForm_Load(object sender, EventArgs e)
        {

            LoadMemberDetails();
        }




        private void LoadMemberDetails()
        {
            string query = "SELECT FirstName, LastName, PhoneNumber, Email, DateOfBirth, Address, IsActive FROM Members WHERE Id = @MemberID";
            var parameters = new Dictionary<string, object>
    {
        {"@MemberID", memberId}
    };

            try
            {
                using (SqlDataReader reader = DatabaseHelper.ExecuteQuery(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        // Assuming you have TextBoxes or Labels to show these details
                        fname.Text = reader["FirstName"].ToString();
                        lname.Text = reader["LastName"].ToString();
                        phnumber.Text = reader["PhoneNumber"].ToString();
                        email.Text = reader["Email"].ToString();
                        address.Text = reader["Address"].ToString();
                        isactive.Items.Clear(); // Clear existing items if necessary
                        isactive.Items.Add("True");  // Add "True" as an item
                        isactive.Items.Add("False");
                        datbirth.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                    }
                    else
                    {
                        MessageBox.Show("No member found with the specified ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving member details: " + ex.Message);
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int isActive = isactive.SelectedItem != null && isactive.SelectedItem.ToString() == "True" ? 1 : 0;

            // Prepare the update query and parameters
            string query = @"UPDATE Members SET 
                     FirstName = @FirstName, 
                     LastName = @LastName, 
                     PhoneNumber = @PhoneNumber, 
                     Email = @Email, 
                     DateOfBirth = @DateOfBirth,
                     Address = @Address,
                     IsActive = @IsActive 
                     WHERE Id = @MemberID";

            var parameters = new Dictionary<string, object>
    {
        {"@MemberID", memberId},
        {"@FirstName", fname.Text.Trim()},
        {"@LastName", lname.Text.Trim()},
        {"@PhoneNumber", phnumber.Text.Trim()},
        {"@Email", email.Text.Trim()},
        {"@Address", address.Text},
        {"@DateOfBirth", datbirth.Value},
        {"@IsActive", isActive}
    };

            // Execute the update
            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Member details updated successfully.");
                this.Close();  // Optionally close the details form upon successful update
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update member details: " + ex.Message);
            }




        }
    }
}
