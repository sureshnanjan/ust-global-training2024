using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// this interface contains methods to be implemented for Form Authentication page
    /// <returns></returns> 
    public interface IFormAuthenticationOperation
    {
        /// <summary>
        /// this method accepts username and password as strings and returns the boolean status for login successful
        /// </summary>
        /// <returns></returns> 
        public Boolean Login(String uName, String Password);

        /// <summary>
        /// this method returns the title as string
        /// </summary>
        /// <returns></returns> 
        public String getTitle();

        /// <summary>
        /// this method is used to logout
        /// </summary>
        /// <returns></returns> 
        public void logout();

        /// <summary>
        /// this method validates the login scussess message
        /// </summary>
        /// <returns></returns> 
        public void getSuccessMessage();

        /// <summary>
        /// this method validates the login failed message
        /// </summary>
        /// <returns></returns> 
        public string getLoginFail();

        /// <summary>
        /// this method validates the logout scussess message
        /// </summary>
        /// <returns></returns> 
        public string getLogoutMessage();


    }
}