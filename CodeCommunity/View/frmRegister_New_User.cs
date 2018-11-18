using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeCommunity.Controller;

namespace CodeCommunity.View
{
    public partial class frmRegister_New_User : Form
    {
        Linq.dbStructureDataContext db = new Linq.dbStructureDataContext();
        private const int SaltSize = 16;
        public frmRegister_New_User()
        {
            InitializeComponent();
            profileImage.Image = Properties.Resources._default;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //create an array of all the textbox on the form so we can loop thru them and clear the text
            Control[] form = new Control[] { txtEmail, txtFirst_Name, txtLast_Name, txtPassword, txtusername, numUpDown_Age };

            //call the method from the controller to clear the text property
            //this is the beauty of using controllers, keeps the code behind to a minimum.
            Register_Controller.Reset_Form(form);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
            //generate hash with salt
            string hash = PasswordHashHelper.Hash(txtPassword.Text, salt, 1000);

            var checkUser = from cc_users in db.cc_users
                            where cc_users.UserName == txtusername.Text
                            select cc_users.UserName;


            if (checkUser.Count() == 1)
            {
                MessageBox.Show("Username already exists");
            }
            else
            {
                var createUser = new Linq.cc_user()
                {
                    UserName = txtusername.Text,
                    Password = hash,
                    Created = DateTime.Now.ToLongDateString(),
                    Salt = Convert.ToBase64String(salt),
                    Email = txtEmail.Text,
                    FirstName = txtFirst_Name.Text,
                    LastName = txtLast_Name.Text,
                    ProfileImage = txtProfileImage.Text

                };
                db.cc_users.InsertOnSubmit(createUser);
                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("User created");
                    Properties.Settings.Default.Username = txtusername.Text;
                    Properties.Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnChoose_Profile_Img_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            txtProfileImage.Text = ofd.FileName;
            profileImage.ImageLocation = ofd.FileName;
        }
    }
}
