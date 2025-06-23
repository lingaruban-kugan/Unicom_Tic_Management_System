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
    public partial class UserForm : Form
    {
        private UserController usercontroller = new UserController();
        int selectedUserId = -1;
        public UserForm()
        {
            InitializeComponent();
            LoadRoles();
            LoadUsers();
        }
        private void LoadRoles()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new string[] { "Admin", "Student", "Staff", "Teacher" });
        }
        private void LoadUsers()
        {
            var users = UserController.GetAllUsers();
            dgvUser.DataSource = users;
        }
        private void ClearForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
            selectedUserId = -1;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void UserFormgvSelectionChanged(object sender, EventArgs e)
        {
            //if (e.RowIndex >= 0 && dgvUsers.Rows.Count > e.RowIndex)
            //{
            //    DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

            //    if (row.DataBoundItem is ValueTuple<int, string, string> userTuple)
            //    {
            //        selectedUserId = userTuple.Item1;
            //        txtUsername.Text = userTuple.Item2;
            //        cmbRole.Text = userTuple.Item3;

            //        // ⚠ Password is not shown for security – adjust only if needed
            //        txtPassword.Text = "";
            //    }
            //}
            //if (dgvUser.SelectedRows.Count > 0)
            //{
            //    var row = dgvUser.SelectedRows[0];
            //    var userView = row.DataBoundItem as User;

            //    if (userView != null)
            //    {
            //        selectedUserId = userView.UserID;

            //        var user = usercontroller.GetUserById(selectedUserId);
            //        if (user != null)
            //        {
            //            txtUsername.Text = user.Username;
            //            txtPassword.Text = user.Password;
            //            cmbRole.Text = user.Role;
            //        }
            //    }
            //}
            //else
            //{
            //    ClearForm();
                
            //}

        }
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string username = txtUsername.Text.Trim();
            //string password = txtPassword.Text.Trim();
            //string role = cmbRole.Text.Trim();

            //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            //{
            //    MessageBox.Show("Please fill all fields.");
            //    return;
            //}

            //UserController.AddUser(username, password, role);
            //MessageBox.Show("User added successfully.");
            //LoadUsers();
            //ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string username = txtUsername.Text.Trim();
            //string password = txtPassword.Text.Trim();
            //string role = cmbRole.Text.Trim();

            //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            //{
            //    MessageBox.Show("Please select a user and fill all fields.");
            //    return;
            //}

            //UserController.UpdateUser(username, password, role);
            //MessageBox.Show("User updated successfully.");
            //LoadUsers();
            //ClearForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string username = txtUsername.Text.Trim();

            //if (string.IsNullOrEmpty(username))
            //{
            //    MessageBox.Show("Please select a user to delete.");
            //    return;
            //}

            //UserController.DeleteUser(username);
            //MessageBox.Show("User deleted successfully.");
            //LoadUsers();
            //ClearForm();
        }

        private void UserForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void viewuser() 
        {
            List<User> users = UserController.GetAllUsers();
            dgvUser.DataSource = users;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            UserController.AddUser(username, password, role);
            MessageBox.Show("User added successfully.");
            LoadUsers();
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a user and fill all fields.");
                return;
            }

            UserController.UpdateUser(username, password, role,selectedUserId);
            MessageBox.Show("User updated successfully.");
            LoadUsers();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            UserController.DeleteUser(username);
            MessageBox.Show("User deleted successfully.");
            LoadUsers();
            ClearForm();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsergvSelectionChanged(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                var row = dgvUser.SelectedRows[0];
                var userView = row.DataBoundItem as User;

                if (userView != null)
                {
                    selectedUserId = userView.UserID;

                    var user = usercontroller.GetUserById(selectedUserId);
                    if (user != null)
                    {
                        txtUsername.Text = user.Username;
                        txtPassword.Text = user.Password;
                        cmbRole.Text = user.Role;
                    }
                }
            }
            else
            {
                ClearForm();

            }
        }
    }
}
