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
    public partial class Addshelf : Form
    {
        public Addshelf()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string Location = location.Text.Trim();
            string Description = this.description.Text.Trim();

            if (string.IsNullOrEmpty(Location))
            {
                MessageBox.Show("Please enter a shelf location.");
                return;
            }
            else
            {


                if ( Description.Length > 255)
                {
                    MessageBox.Show("Description cannot be more than 255 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Set focus to the description text box
                    return;
                }
                else
                {
                    Shelf shelf = new Shelf();
                    shelf.Location = Location;
                    shelf.Description = Description;
                    ShelfManage manager = new ShelfManage();
                    if (manager.AddShelf(shelf))
                    {
                        MessageBox.Show("Shelf added successfully.");
                        this.Close();  // Close the form if needed
                    }
                    else
                    {
                        MessageBox.Show("Failed to add shelf.");
                    }
                }







            }

        }

        private void Addshelf_Load(object sender, EventArgs e)
        {

        }
    }
}
