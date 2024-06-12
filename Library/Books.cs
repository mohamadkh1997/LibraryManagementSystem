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
using System.Xml.Linq;

namespace Library
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            panel2.MinimumSize = new Size(1200, panel1.MinimumSize.Height);
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Shelflist.Dock = DockStyle.Fill;
            Booklist.Dock = DockStyle.Fill;

            Shelflist.AllowUserToAddRows = false;







            //Shelflist.Columns.Add("ShelfID", "Shelf ID");


            // Adding Detail button column

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Booklist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookshearch_Click(object sender, EventArgs e)
        {
            string bookname = name.Text; // Assuming txtName is your TextBox for book name
            string bookauthor = author.Text; // TextBox for author
            int? publishingyear = string.IsNullOrWhiteSpace(year.Text) ? (int?)null : int.Parse(year.Text); // Numeric input for year
            string bookgenre = genre.Text; // TextBox for genre
            int? bookshelf = string.IsNullOrWhiteSpace(shelf.Text) ? (int?)null : int.Parse(shelf.Text); // Numeric input for shelf

            BookManagment manager = new BookManagment();
            List<Book> foundBooks = manager.SearchBooks(bookname, bookauthor, publishingyear, bookgenre, bookshelf);

            // Assuming you have a DataGridView to display results
            Booklist.DataSource = foundBooks;

            DataGridViewButtonColumn btnDetailColumn = new DataGridViewButtonColumn();
            btnDetailColumn.HeaderText = "Detail";
            btnDetailColumn.Name = "Detail";
            btnDetailColumn.Text = "View Details";
            btnDetailColumn.UseColumnTextForButtonValue = true;  // This means the button will display "View Details"
            Booklist.Columns.Add(btnDetailColumn);

            // Create and setup the Remove button column
            DataGridViewButtonColumn btnRemoveColumn = new DataGridViewButtonColumn();
            btnRemoveColumn.HeaderText = "Remove";
            btnRemoveColumn.Name = "Remove";
            btnRemoveColumn.Text = "Remove";
            btnRemoveColumn.UseColumnTextForButtonValue = true;  // This means the button will display "Remove"
            Booklist.Columns.Add(btnRemoveColumn);
        }










  


        private void Shelflist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addshelf addshelf = new Addshelf();
            addshelf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string location = textBox8.Text.Trim();
            ShelfManage shelfManage = new ShelfManage();
            using (SqlDataReader reader = shelfManage.searchshelf(location))
            {
                if (reader.HasRows)
                {
                    Shelflist.Rows.Clear();
                    Shelflist.Columns.Clear();

                    // Adding columns manually if not already configured
                    Shelflist.Columns.Add("Shelf Id", "Shelf Id");
                    Shelflist.Columns.Add("Location", "Location");
                    Shelflist.Columns.Add("Description", "Description");
                    Shelflist.Columns.Add("Created At", "CreatedTime");

                    DataGridViewButtonColumn Detail = new DataGridViewButtonColumn();
                    Detail.HeaderText = "Details";
                    Detail.Text = "View Details";
                    Detail.Name = "DetailsButton";
                    Detail.UseColumnTextForButtonValue = true;
                    Shelflist.Columns.Add(Detail);



                    DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
                    Delete.HeaderText = "Delete";
                    Delete.Text = "Delete";
                    Delete.Name = "DeleteButton";
                    Delete.UseColumnTextForButtonValue = true;
                    Shelflist.Columns.Add(Delete);

                    while (reader.Read())
                    {
                        int index = Shelflist.Rows.Add(); // Add a new row and get the index
                        Shelflist.Rows[index].Cells["Shelf Id"].Value = reader["Id"];
                        Shelflist.Rows[index].Cells["Location"].Value = reader["Location"];
                        Shelflist.Rows[index].Cells["Description"].Value = reader["Description"];
                        Shelflist.Rows[index].Cells["Created At"].Value = reader["CreatedTime"].ToString(); // Ensuring ToString in case of formatting issues
                    }
                }
                else
                {
                    MessageBox.Show("No shelves found.");
                }
            }
        }



        private void Shelflist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == Shelflist.Columns["Delete"].Index)
            {
                // Confirm deletion
                if (MessageBox.Show("Are you sure you want to delete this shelf?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int shelfId = Convert.ToInt32(Shelflist.Rows[e.RowIndex].Cells["Shelf Id"].Value);
                    ShelfManage Shelfmanage = new ShelfManage();
                    if (Shelfmanage.DeleteShelf(shelfId))
                    {
                        // Refresh the DataGridView to show changes
                        RefreshShelfList();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the shelf.");
                    }
                }
            }
        }


        private void RefreshShelfList()
        {
            string location = textBox8.Text.Trim();  // Re-use the existing search criteria to refresh the list
            ShelfManage shelfManage = new ShelfManage();
            SqlDataReader reader = shelfManage.searchshelf(location);
            Shelflist.Rows.Clear();

            while (reader.Read())
            {
                int index = Shelflist.Rows.Add();
                Shelflist.Rows[index].Cells["Shelf Id"].Value = reader["Id"];
                Shelflist.Rows[index].Cells["Location"].Value = reader["Location"];
                Shelflist.Rows[index].Cells["Description"].Value = reader["Description"];
                Shelflist.Rows[index].Cells["Created At"].Value = reader["CreatedTime"];
            }
            reader.Close();  // Don't forget to close the reader
        }

    }
}
