using EmployeeManagementSystem.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string fullname, Age, Section;


        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (username == "" && password == "")
            {
                MessageBox.Show("Please input username and password");
                return;
            }
            else if (username == "")
            {
                MessageBox.Show("Please input username");
                return;
            }
            else if (password == "")
            {
                MessageBox.Show("Please input password");
                return;
            }

            bool isLogin = CRUD.CRUD.RETRIEVESINGLELOGIN(username, password);

            if (isLogin)
            {
                fullname = CRUD.CRUD.dt.Rows[0]["FullName"].ToString();
                Section = CRUD.CRUD.dt.Rows[0]["Section"].ToString();
                Age = CRUD.CRUD.dt.Rows[0]["Age"].ToString();

                MessageBox.Show(
                    $"Welcome {fullname}",
                    "LOGIN SUCCESS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Hide();
                frmMotherForm main = new frmMotherForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    internal class Form1
    {
        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
