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
    public partial class DashboardAdmin : Form
    {

        private Form activeChildForm = null;
        public DashboardAdmin()
        {
            InitializeComponent();

            this.Load += (sender, e) =>
            {
                Console.WriteLine("Form1 is loading");
            };


            
            this.WindowState = FormWindowState.Maximized;
            panel1.Height = 100;  // Set the desired height
            panel1.Dock = DockStyle.Top;

            panel2.Dock = DockStyle.Left;  // Dock the panel to the left side of the form

            // Set location and size
            panel2.Height = this.ClientSize.Height;
            panel2.Width = 200;// Stretch to the height of the form
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top; // Anchor to the left, bottom, and top

            this.Controls.Add(panel2);

            panel3.Dock = DockStyle.Right;

            panel3.Height = this.ClientSize.Height;
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;


        }


        private void OpenChildForm(Form childForm)
        {
            // Close the currently active child form
            if (activeChildForm != null)
            {
                activeChildForm.Close();
            }

            // Set the new child form as the active form
            activeChildForm = childForm;
            activeChildForm.TopLevel = false;
            activeChildForm.FormBorderStyle = FormBorderStyle.None;
            activeChildForm.Dock = DockStyle.Fill;

            // Clear existing controls and add new form
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(activeChildForm);


            activeChildForm.BringToFront();
            activeChildForm.Show();
        }


        private void TestDisplay()
        {
            Form testForm = new Form();
            testForm.BackColor = Color.Red; // So it's clearly visible
            testForm.TopLevel = false;
            testForm.FormBorderStyle = FormBorderStyle.None;
            testForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(testForm);
            testForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            OpenChildForm(new Members());
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Books());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Barrowing());
        }
    }
}
