namespace PetStore
{
    /// <summary>
    /// Contains user details like id,username,firstName, LastName, Email, Password, Phone number and User Status.
    /// </summary>
    
    internal class User
    {
        /// <summary>
        /// Properties of User
        /// </summary>
        public long id;
        public string username;
        public string firstName;
        public string lastName;
        public string email;
        public string password;
        public string phone;
        public int userStatus;
    }
}