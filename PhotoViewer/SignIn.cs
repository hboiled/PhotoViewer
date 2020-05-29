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
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Application run was changed in Program.cs 
            // FormClosed events must call Application.Exit to properly exit 
            Application.Exit();
        }
    }
}
