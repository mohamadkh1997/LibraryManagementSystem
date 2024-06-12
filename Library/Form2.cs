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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pass.PasswordChar = '*';
            repass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user.Text.Trim()))
            {
                errorProvider1.SetError(user, "Username is required");
            }
            else
            {
                if (String.IsNullOrEmpty(pass.Text.Trim()))
                {
                    errorProvider2.SetError(pass, "Password is required");
                }
                else
                {
                   if(pass.Text.Length < 8)
                    {
                        errorProvider4.SetError(pass, "password must be 8 characters or more");
                        errorProvider5.SetError(pass, "Re-type password must be 8 characters or more");
                    }
                    else
                    {

                        if (String.IsNullOrEmpty(repass.Text.Trim()))
                        {
                            errorProvider3.SetError(repass, "Re-type password is required");
                        }
                        else
                        {
                            string username = user.Text;
                            string password = pass.Text;
                            string confirmPassword = repass.Text;

                            // Check if the passwords are the same
                            if (password == confirmPassword)
                            {
                                MessageBox.Show("Password is valid and matched!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UserManage userManager = new UserManage();

                                if (userManager.UsernameExists(username))
                                {
                                    MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    User newUser = new User { Username = username, Password = password, CreatedDate = DateTime.Now, Role = 1 };
                                    if (userManager.AddUser(newUser))
                                    {
                                        MessageBox.Show("User registered successfully.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to register user.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }


                            }
                            else
                            {
                                MessageBox.Show("Passwords do not match. Please re-enter the passwords.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                // Optionally, clear the password fields
                                pass.Clear();
                                repass.Clear();
                                user.Clear();
                            }
                        }



                    }
                }


            }




        }

    }
}
