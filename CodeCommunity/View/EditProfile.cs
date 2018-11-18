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
    public partial class EditProfile : Form
    {
        Linq.dbStructureDataContext db = new Linq.dbStructureDataContext();
        public EditProfile()
        {
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            var getProfileInfo = from cc_users in db.cc_users
                                 where cc_users.UserName == Properties.Settings.Default.Username
                                 select cc_users;

            foreach(var member in getProfileInfo)
            {
                lblUsername.Text = member.UserName;
                txtFirstName.Text = member.FirstName;
                txtLastName.Text = member.LastName;
                txtEmail.Text = member.Email;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var getProfileInfo = from cc_users in db.cc_users
                                 where cc_users.UserName == Properties.Settings.Default.Username
                                 select cc_users;

            foreach (var profile in getProfileInfo)
            {
                lblUsername.Text = profile.UserName;
                profile.FirstName = txtFirstName.Text;
                profile.LastName = txtLastName.Text;
                profile.Email = txtEmail.Text;
            }
            db.SubmitChanges();
            MessageBox.Show("Updated");
        }
    }
}
