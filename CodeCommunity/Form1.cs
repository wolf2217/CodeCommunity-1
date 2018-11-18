using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCommunity
{
    public partial class Form1 : Form
    {
        Linq.dbStructureDataContext db = new Linq.dbStructureDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            var checkUser = from cc_users in db.cc_users
                            where cc_users.UserName == txtNewUser.Text
                            select new //here we select new and below we create variables to hold the fields we want
                            {
                                username = cc_users.UserName
                            };

            foreach (var user in checkUser)
            {
                if(user.username == txtNewUser.Text)
                {
                    MessageBox.Show("Username already exists");
                }
                else
                {
                    var createUser = new Linq.cc_user()
                    {
                        UserName = txtNewUser.Text,
                        Password = txtNewPass.Text,
                        Created = DateTime.Now.ToLongDateString()
                    };
                    db.cc_users.InsertOnSubmit(createUser);
                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("User created");
                        Properties.Settings.Default.Username = txtNewUser.Text;
                        Properties.Settings.Default.Save();
                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var checkLogin = from cc_users in db.cc_users
                             where cc_users.UserName == txtLoginUser.Text && cc_users.Password == txtLoginPass.Text
                             select cc_users;
            foreach(var user in checkLogin)
            {
                if(txtLoginUser.Text == user.UserName && txtLoginPass.Text == user.Password)
                {
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
