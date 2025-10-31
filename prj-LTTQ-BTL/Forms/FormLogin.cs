using prj_LTTQ_BTL.Data;
using prj_LTTQ_BTL.Forms.Manager;
//using prj_LTTQ_BTL.Forms.Student;
using prj_LTTQ_BTL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Forms
{
    public partial class FormLogin : Form
    {
        private readonly AuthService _authService;
        public FormLogin()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập username và password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string role = _authService.AuthenticateUser(username, password);

                if (role != null)
                {
                    GlobalData.role = role;
                    MessageBox.Show($"Welcome, {username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form nextForm;
                    //if (role.Equals("student", StringComparison.OrdinalIgnoreCase))
                    //{
                    //    nextForm = new StudentMenuForm();
                    //}
                    if (role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                    {
                        nextForm = new ManagerMenuForm();
                    }
                    else
                    {
                        MessageBox.Show("Role không hợp lệ.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
