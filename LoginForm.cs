using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_Tic_Management_System.Controllers;
using Unicom_Tic_Management_System.Data;

namespace Unicom_Tic_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            {
                string username = txUsername.Text;
                string password = txPassword.Text;

                // Get the user by username (you can modify this logic if you want to fetch the user differently)
                User user = UserController.GetAllUsers().Find(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    // User found, check their role
                    string role = user.Role.ToLower();

                    // Show different welcome messages based on the role
                    switch (role)
                    {
                        case "admin":
                            MessageBox.Show("Welcome Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "staff":
                            MessageBox.Show("Welcome Staff!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "student":
                            MessageBox.Show("Welcome Student!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "teacher":
                            MessageBox.Show("Welcome Teacher!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        default:
                            MessageBox.Show("Invalid role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    // User not found or incorrect credentials
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ControlForn controlForn = new ControlForn();
            controlForn.Show();
            this.Hide();
        }

        private void txUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
