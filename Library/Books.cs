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
            //    panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //    panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            //  panel2.MinimumSize = new Size(1200, panel1.MinimumSize.Height);
            //   panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            //   Shelflist.Dock = DockStyle.Fill;
            //   Booklist.Dock = DockStyle.Fill;

            Shelflist.AllowUserToAddRows = false;






            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            panel2.MinimumSize = new Size(1200, panel1.MinimumSize.Height);
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Shelflist.Dock = DockStyle.Fill;
            Booklist.Dock = DockStyle.Fill;



            Shelflist.CellClick += new DataGridViewCellEventHandler(Shelflist_CellClick);

            //Shelflist.Columns.Add("ShelfID", "Shelf ID");


            // Adding Detail button column

        }




        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void Shelflist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is part of the "DeleteButton" column
            if (e.RowIndex >= 0 && e.ColumnIndex == Shelflist.Columns["DeleteButton"].Index)
            {
                // Confirm the deletion
                if (MessageBox.Show("Are you sure you want to delete this shelf?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int shelfId = Convert.ToInt32(Shelflist.Rows[e.RowIndex].Cells["Shelf Id"].Value);
                    ShelfManage shelfManage = new ShelfManage();
                    if (shelfManage.DeleteShelf(shelfId))
                    {
                        // Successfully deleted the shelf
                        MessageBox.Show("Shelf deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Shelflist.Rows.RemoveAt(e.RowIndex); // Remove the row from DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the shelf.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == Shelflist.Columns["DetailsButton"].Index)
            {
                int shelfId = Convert.ToInt32(Shelflist.Rows[e.RowIndex].Cells["Shelf Id"].Value);
                ShelfManage Shelf = new ShelfManage();
                Shelf shelf = Shelf.GetShelfById(shelfId);
                if (shelf != null)
                {
                    ModifyShelf shelfmodifyform = new ModifyShelf(shelf);
                    shelfmodifyform.ShowDialog();


                }



            }


        }





        private void button2_Click_1(object sender, EventArgs e)
        {
            string location = textBox8.Text.Trim();

            ShelfManage shelfManage = new ShelfManage();
            using (SqlDataReader reader = shelfManage.searchshelf(location))
            {
                Shelflist.Rows.Clear();
                Shelflist.Columns.Clear();


                Shelflist.Columns.Add("Shelf Id", "Shelf Id");
                Shelflist.Columns.Add("Location", "Location");
                Shelflist.Columns.Add("Description", "Description");

                DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
                btnDeleteColumn.HeaderText = "Delete";
                btnDeleteColumn.Name = "DeleteButton";
                btnDeleteColumn.Text = "Delete";
                btnDeleteColumn.UseColumnTextForButtonValue = true;
                Shelflist.Columns.Add(btnDeleteColumn);



                DataGridViewButtonColumn btnDetailsColumn = new DataGridViewButtonColumn();
                btnDetailsColumn.HeaderText = "Details";
                btnDetailsColumn.Name = "DetailsButton";
                btnDetailsColumn.Text = "Show Details";
                btnDetailsColumn.UseColumnTextForButtonValue = true;
                Shelflist.Columns.Add(btnDetailsColumn);

                while (reader.Read())
                {
                    int index = Shelflist.Rows.Add();
                    Shelflist.Rows[index].Cells["Shelf Id"].Value = reader["Id"].ToString();
                    Shelflist.Rows[index].Cells["Location"].Value = reader["Location"].ToString();
                    Shelflist.Rows[index].Cells["Description"].Value = reader["Description"].ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addshelf shelfplus = new Addshelf();
            shelfplus.Show();
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }
    }
}
