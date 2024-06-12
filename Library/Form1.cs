using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            error.Hide();
            pass.PasswordChar = '*';
            this.Resize += new EventHandler(MyForm_Resize);
        }


        private void MyForm_Resize(object sender, EventArgs e)
        {
            CenterLabel(error);
        }


        private void CenterLabel(Label error)
        {
            // Center the label horizontally and vertically
            error.Left = (this.ClientSize.Width - error.Width) * 2 / 5;
           // error.Top = (this.ClientSize.Height - error.Height) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sign = new Form2();
            sign.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {

            string username = user.Text;
            string password = pass.Text;
            if (String.IsNullOrEmpty(user.Text.Trim()))
            {
                errorProvider1.SetError(user, "Username is required");
            }
            else
            {
                if (String.IsNullOrEmpty(pass.Text.Trim()))
                {
                    errorProvider2.SetError(pass, "Username is required");
                }
                else
                {


                    UserManage userManager = new UserManage();
                    string result = userManager.Login(username, password);

                    if (result == "Login successful.")
                    {
                        MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DashboardAdmin dashboardForm = new DashboardAdmin();
                        dashboardForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        error.Text = "Login Failed";
                        error.ForeColor = Color.Red;
                        error.Show();
                        //MessageBox.Show(result, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }










        }




        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void error_Click(object sender, EventArgs e)
        {

        }
    }
}
