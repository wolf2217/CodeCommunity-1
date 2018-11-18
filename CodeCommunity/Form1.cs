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
            //create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
            //generate hash with salt
            string hash = PasswordHashHelper.Hash(txtNewPass.Text, salt, 1000);

            //MessageBox.Show(hash + "\r\n" + Convert.ToBase64String(salt));

            var checkUser = from cc_users in db.cc_users
                            where cc_users.UserName == txtNewUser.Text
                            select cc_users.UserName;
                           

            if(checkUser.Count() == 1)
            {
                MessageBox.Show("Username already exists");
            }
            else
            {
                var createUser = new Linq.cc_user()
                {
                    UserName = txtNewUser.Text,
                    Password = hash,
                    Created = DateTime.Now.ToLongDateString(),
                    Salt = Convert.ToBase64String(salt)
                    
                };
                db.cc_users.InsertOnSubmit(createUser);
                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("User created");
                    Properties.Settings.Default.Username = txtNewUser.Text;
                    Properties.Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //I changed the select new here also...now it selects the cc_users username and password
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var checkLogin = from cc_users in db.cc_users
                             where cc_users.UserName == txtLoginUser.Text
                             select new
                             {
                                 username = cc_users.UserName,
                                 password = cc_users.Password, 
                                 salt = cc_users.Salt
                             };

            foreach(var user in checkLogin)
            {
                //var saltByte = new byte[user.salt.Length];
                if (PasswordHashHelper.Verify(txtLoginPass.Text, user.password))
                {
                    MessageBox.Show("Passwords Match");
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
