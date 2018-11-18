using CodeCommunity.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeCommunity.View;

namespace CodeCommunity.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void lblRegisterLink_Click(object sender, EventArgs e)
        {
            frmRegister_New_User new_user = new frmRegister_New_User();
            new_user.Show();
        }
    }
}
