using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCommunity
{
    public partial class Dashboard : Form
    {
        Linq.dbStructureDataContext db = new Linq.dbStructureDataContext();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Model.Users.Logout();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var getUsername = from cc_users in db.cc_users
                              where cc_users.UserName == Properties.Settings.Default.Username
                              select cc_users;

            foreach(var user in getUsername)
            {
                Text = user.UserName;
            }
        }
    }
}
