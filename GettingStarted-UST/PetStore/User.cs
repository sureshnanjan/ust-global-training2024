using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    /// <summary>
    /// Represents a user of the pet store.
    /// </summary>
    internal class User
    {
        private long id;
        private string? username;
        private string? firstName;
        private string? lastName;
        private string? email;
        private string? password;
        private string? phone;
        private int userStatus;

        /// <summary>
        /// Gets or sets the Id of the user.
        /// </summary>
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// Gets or sets the first name of the user.
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// Gets or sets the last name of the user.
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /// <summary>
        /// Gets or sets the email address of the user.
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Gets or sets the password of the user.
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Gets or sets the phone number of the user.
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        /// <summary>
        /// Gets or sets the status of the user.
        /// </summary>
        public int UserStatus
        {
            get { return userStatus; }
            set { userStatus = value; }
        }
    
}
}
