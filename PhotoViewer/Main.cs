using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// ***TODO
// ** ON INIT
// set displayname to logged in user upon init
// load galleries into gallery list box

// sign out btn closes and disposes this form and returns clean sign in form
//

namespace PhotoViewer
{
    public partial class Main : Form
    {
        private List<Gallery> galleries;

        public Main()
        {
            InitializeComponent();
            
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Dispose();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
