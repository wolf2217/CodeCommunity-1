using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCommunity.Model
{
    public class User
    {
        /// <summary>
        /// class to hold the user info
        /// </summary>
        /// <remarks>
        /// here we can get or set the user info. then store this info into the database
        /// </remarks>
        /// <return>
        /// model classes don't return anything, they are used to set or get info
        /// </return>
        public int ID { get; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password_Hash { get; set; }
        public string Salt { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Profile_Img_Path { get; set; }
        public int Age { get; set; }
        public DateTime Date_Created { get; set; }

        public User(string userName, string email, string password_Hash, string salt, 
            string first_Name, string last_Name, string profile_Img_Path, int age, DateTime date_Created)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password_Hash = password_Hash ?? throw new ArgumentNullException(nameof(password_Hash));
            Salt = salt ?? throw new ArgumentNullException(nameof(salt));
            First_Name = first_Name ?? throw new ArgumentNullException(nameof(first_Name));
            Last_Name = last_Name ?? throw new ArgumentNullException(nameof(last_Name));
            Profile_Img_Path = profile_Img_Path ?? throw new ArgumentNullException(nameof(profile_Img_Path));
            Age = age;
            Date_Created = date_Created;
        }

        
    }
}
