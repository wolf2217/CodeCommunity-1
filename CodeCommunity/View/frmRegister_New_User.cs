using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeCommunity.Controller;

namespace CodeCommunity.View
{
    public partial class frmRegister_New_User : Form
    {

        public frmRegister_New_User()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources._default;
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

        }

        private void btnChoose_Profile_Img_Click(object sender, EventArgs e)
        {

        }
    }
}
