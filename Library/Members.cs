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
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();

            searchPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Memberpanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Memberlist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            Memberlist.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            DateBirth.Value = DateTime.Today.AddYears(-18);
        }

        private void Members_Load(object sender, EventArgs e)
        {

        }

        private void Memberlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Members WHERE ";
            var parameters = new Dictionary<string, object>();

            List<string> conditions = new List<string>();

            if (!string.IsNullOrEmpty(Fname.Text))
            {
                conditions.Add("FirstName LIKE @FirstName");
                parameters.Add("@FirstName", $"%{Fname.Text}%");
            }
            if (!string.IsNullOrEmpty(Lname.Text))
            {
                conditions.Add("LastName LIKE @LastName");
                parameters.Add("@LastName", $"%{Lname.Text}%");
            }
            if (!string.IsNullOrEmpty(Phnumber.Text))
            {
                conditions.Add("PhoneNumber LIKE @PhoneNumber");
                parameters.Add("@PhoneNumber", $"%{Phnumber.Text}%");
            }
            if (!string.IsNullOrEmpty(Email.Text))
            {
                conditions.Add("Email LIKE @Email");
                parameters.Add("@Email", $"%{Email.Text}%");
            }
            if (DateBirth.Value != null && DateBirth.Value != DateBirth.MinDate)
            {
                // Use greater or equal to include all members born on or after the specified date
                conditions.Add("DateOfBirth >= @DateOfBirth");
                parameters.Add("@DateOfBirth", DateBirth.Value.Date);
            }

            if (conditions.Count == 0)
            {
                query = "SELECT * FROM Members"; // Select all if no conditions
            }
            else
            {
                query += string.Join(" AND ", conditions);
            }


            using (SqlDataReader reader = DatabaseHelper.ExecuteQuery(query, parameters))
            {

                Memberlist.Rows.Clear();
                Memberlist.Columns.Clear();

                // Adding columns manually if not already configured
                Memberlist.Columns.Add("MemberID", "Member ID");
                Memberlist.Columns.Add("FirstName", "First Name");
                Memberlist.Columns.Add("LastName", "Last Name");
                Memberlist.Columns.Add("PhoneNumber", "Phone Number");
                Memberlist.Columns.Add("Email", "Email");
                Memberlist.Columns.Add("Address", "Address");
                Memberlist.Columns.Add("DateOfBirth", "Date of Birth");
                Memberlist.Columns.Add("MembershipDate", "MembershipDate");
                Memberlist.Columns.Add("IsActive", "Is Active");

                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Details";
                btnColumn.Text = "View Details";
                btnColumn.Name = "DetailsButton";
                btnColumn.UseColumnTextForButtonValue = true;
                Memberlist.Columns.Add(btnColumn);


                while (reader.Read())
                {
                    int index = Memberlist.Rows.Add(); // Add a new row and get the index
                    Memberlist.Rows[index].Cells["MemberID"].Value = reader["Id"];
                    Memberlist.Rows[index].Cells["FirstName"].Value = reader["FirstName"];
                    Memberlist.Rows[index].Cells["LastName"].Value = reader["LastName"];
                    Memberlist.Rows[index].Cells["PhoneNumber"].Value = reader["PhoneNumber"];
                    Memberlist.Rows[index].Cells["Email"].Value = reader["Email"];
                    Memberlist.Rows[index].Cells["Address"].Value = reader["Address"];
                    Memberlist.Rows[index].Cells["DateOfBirth"].Value = reader["DateOfBirth"].ToString();
                    Memberlist.Rows[index].Cells["MembershipDate"].Value = reader["MembershipDate"].ToString();
                    Memberlist.Rows[index].Cells["IsActive"].Value = reader["IsActive"];

                }


              //  table.Load(reader);
            }
          //  Memberlist.DataSource = table; 
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on your button column
            if (e.RowIndex >= 0 && e.ColumnIndex == Memberlist.Columns["DetailsButton"].Index)
            {
                int memberId = Convert.ToInt32(Memberlist.Rows[e.RowIndex].Cells["MemberID"].Value);

                // Open the details form for the selected member
                detailForm detailsForm = new detailForm(memberId);
                detailsForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addbook addbook = new Addbook();
            addbook.Show();
        }
    }
}
