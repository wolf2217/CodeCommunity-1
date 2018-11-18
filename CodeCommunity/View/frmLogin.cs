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
using System.Security.Cryptography;

namespace CodeCommunity.View
{
    public partial class frmLogin : Form
    {
        private const int SaltSize = 16;
        Linq.dbStructureDataContext db = new Linq.dbStructureDataContext();
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void lblRegisterLink_Click(object sender, EventArgs e)
        {
            frmRegister_New_User new_user = new frmRegister_New_User();
            new_user.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
            //generate hash with salt
            string hash = PasswordHashHelper.Hash(txtPassword.Text, salt, 1000);

            var checkLogin = from cc_users in db.cc_users
                             where cc_users.UserName == txtusername.Text
                             select new
                             {
                                 username = cc_users.UserName,
                                 password = cc_users.Password,
                                 salt = cc_users.Salt
                             };

            foreach (var user in checkLogin)
            {
                //var saltByte = new byte[user.salt.Length];
                if (PasswordHashHelper.Verify(txtPassword.Text, user.password))
                {
                    //MessageBox.Show("Passwords Match");
                    Properties.Settings.Default.Username = txtusername.Text;
                    Properties.Settings.Default.Save();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else

                {
                    MessageBox.Show("Login failed");
                }
            }
        }
    }
}
