using PhotoViewer.Security;
using System;
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
                OutcomeMsg.Text = "Please enter your username and password";
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
                OutcomeMsg.Text = "To register, enter a username and password";
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
                if (signInService.ProcessSignIn(username, password))
                {
                    // sign in                
                    // OutcomeMsg.Text = "    " + username+ " has logged in successfully";
                    Main main = new Main(username);
                    main.Show();
                    this.Dispose();
                }
                else
                {
                    OutcomeMsg.Text = "    Error! Entered password was incorrect!";
                }
            } 
            else
            {
                OutcomeMsg.Text = "Error! No such user exists";
            }
            
            
        }

        private void AttemptRegister(string username, string password)
        {
            if (signInService.ProcessRegister(username, password))
            {
                // register                
                OutcomeMsg.Text = "    Successfully registered new account";
            }
            else
            {
                OutcomeMsg.Text = "    Error! A user by that name already exists";
            }
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Application run was changed in Program.cs 
            // FormClosed events must call Application.Exit to properly exit 
            Application.Exit();
        }
    }
}
