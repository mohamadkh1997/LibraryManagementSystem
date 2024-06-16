using Microsoft.IdentityModel.Tokens;
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
    public partial class ModifyShelf : Form
    {

        private int ShelfId;
        public ModifyShelf(Shelf shelf)
        {
            InitializeComponent();
            ShelfId = shelf.ShelfID;
            location.Text = shelf.Location;
            description.Text = shelf.Description;
            title.Text = "Editing the shelf:" + shelf.Location;
        }




        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(location.Text.Trim()))
            {
                MessageBox.Show("Please enter a shelf location.");
                return;
            }
            else
            {
                Shelf newshelf = new Shelf();
                newshelf.ShelfID = ShelfId;
                newshelf.Location = location.Text.Trim();
                newshelf.Description = description.Text.Trim();
                ShelfManage myshelf = new ShelfManage();
                bool updateSuccess = myshelf.UpdateShelf(newshelf);

                if (updateSuccess)
                {
                    MessageBox.Show("Shelf updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); //close the form after updating 
                }
                else
                {
                    MessageBox.Show("Failed to update the shelf. Please check your input and try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ModifyShelf_Load(object sender, EventArgs e)
        {

        }
    }
}
