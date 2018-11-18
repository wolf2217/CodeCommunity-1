using CodeCommunity.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCommunity
{
    public partial class Form1 : Form
    {
        private const int SaltSize = 16;

        Linq.dbStructureDataContext db = new Linq.dbStructureDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Model.Users.CreateUser();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Model.Users.Login();
        }
    }
}
