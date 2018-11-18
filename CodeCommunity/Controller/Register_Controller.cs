using CodeCommunity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCommunity.Controller
{
    /// <summary>
    /// class to handle the New User Registration form
    /// </summary>
    public static class Register_Controller
    {
        /// <summary>
        /// reset the user form
        /// </summary>
        /// <param name="items"></param>
        public static void Reset_Form(Control[] items)
        {
            foreach (var item in items)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is NumericUpDown)
                {
                    item.Text = "0";
                }

            }
        }

        //add the user info to the database
        public static void Register_User(User user)
        {

        }
    }
}
