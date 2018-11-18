using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using CodeCommunity.Controller;
using System.Windows.Forms;

namespace CodeCommunity.Model
{
    public class Users
    {
        private const int SaltSize = 16;
        
        public static void CreateUser()
        {
            Linq.dbStructureDataContext db = new Linq.dbStructureDataContext();
            Form1 frm = new Form1();
            //create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
            //generate hash with salt
            string hash = PasswordHashHelper.Hash(frm.txtNewPass.Text, salt, 1000);

            var checkUser = from cc_users in db.cc_users
                            where cc_users.UserName == frm.txtNewUser.Text
                            select cc_users.UserName;


            if (checkUser.Count() == 1)
            {
                MessageBox.Show("Username already exists");
            }
            else
            {
                var createUser = new Linq.cc_user()
                {
                    UserName = frm.txtNewUser.Text,
                    Password = hash,
                    Created = DateTime.Now.ToLongDateString(),
                    Salt = Convert.ToBase64String(salt)

                };
                db.cc_users.InsertOnSubmit(createUser);
                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("User created");
                    Properties.Settings.Default.Username = frm.txtNewUser.Text;
                    Properties.Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void Login()
        {
            Linq.dbStructureDataContext db = new Linq.dbStructureDataContext();
            Form1 frm = new Form1();
            //create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
            //generate hash with salt
            string hash = PasswordHashHelper.Hash(frm.txtNewPass.Text, salt, 1000);

            var checkLogin = from cc_users in db.cc_users
                             where cc_users.UserName == frm.txtLoginUser.Text
                             select new
                             {
                                 username = cc_users.UserName,
                                 password = cc_users.Password,
                                 salt = cc_users.Salt
                             };

            foreach (var user in checkLogin)
            {
                //var saltByte = new byte[user.salt.Length];
                if (PasswordHashHelper.Verify(frm.txtLoginPass.Text, user.password))
                {
                    //MessageBox.Show("Passwords Match");
                    Properties.Settings.Default.Username = frm.txtLoginUser.Text;
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

        public static void Logout()
        {
            Properties.Settings.Default.Username = "";
            Application.Restart();
        }
    }
}
