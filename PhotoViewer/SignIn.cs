using PhotoViewer.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class SignIn : Form
    {
        SignInService signInService;

        public SignIn()
        {
            InitializeComponent();
            signInService = new SignInService();
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Application run was changed in Program.cs 
            // FormClosed events must call Application.Exit to properly exit 
            Application.Exit();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            if (FieldsNotEmpty())
            {
                string username = UsernameTB.Text;
                string password = PasswordTB.Text;
                AttemptSignIn(username, password);
            }
            else
            {
                ErrorMsg.Text = "Please enter your username and password";
            }

            ClearFields();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (FieldsNotEmpty())
            {
                string username = UsernameTB.Text;
                string password = PasswordTB.Text;
                AttemptRegister(username, password);
            }
            else
            {
                ErrorMsg.Text = "To register, enter a username and password";
            }

            ClearFields();
        }       

        private Boolean FieldsNotEmpty()
        {
            if (string.IsNullOrWhiteSpace(UsernameTB.Text) || 
                string.IsNullOrWhiteSpace(PasswordTB.Text) )
            {
                return false;
            }

            return true;
             
        }

        private void ClearFields()
        {
            UsernameTB.Clear();
            PasswordTB.Clear();
        }

        private void AttemptSignIn(string username, string password)
        {
            if (signInService.UsernameExists(username))
            {
                // sign in
                ErrorMsg.Text = "Success";
            }
            else
            {
                ErrorMsg.Text = "Error! No such user exists";
            }
        }

        private void AttemptRegister(string username, string password)
        {
            if (!signInService.UsernameExists(username))
            {
                // register
                signInService.RegisterUser(username, password);
                ErrorMsg.Text = "    Successfully registered new account";
            }
            else
            {
                ErrorMsg.Text = "    Error! A user by that name already exists";
            }
        }
    }
}
