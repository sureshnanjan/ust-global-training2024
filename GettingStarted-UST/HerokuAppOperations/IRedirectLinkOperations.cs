using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IRedirectLinkOperations
    {
        /// <summary>
        /// This method fetched the current Url opened in the browser.
        /// </summary>
        /// <returns></returns>
        string GetURL();

        /// <summary>
        /// This method verify the title of the page.
        /// </summary>
        string GetTitle();

        /// <summary>
        /// This method helps to verify the main content.
        /// </summary>
        string GetMainContent();

        /// <summary>
        /// This method helps to trigger redirect link
        /// </summary>
        public string ClickOnRedirectLink();

        /// <summary>
        /// This method helps to get the result of triggering redirect link
        /// </summary>
        public string GetResultOfRedirect();

        /// <summary>
        /// This method helps to click on status code 200
        /// </summary>
        public string ClickOn200();

        /// <summary>
        /// This method helps to get the result of clicking status code 200
        /// </summary>
        public string GetResultOfClicking200();

        /// <summary>
        /// This method helps to click on status code 301
        /// </summary>
        public void ClickOn301();

        /// <summary>
        /// This method helps to get the result of clicking status code 301
        /// </summary>
        public void GetResultOfClicking301();

        /// <summary>
        /// This method helps to click on status code 404
        /// </summary>
        public void ClickOn404();

        /// <summary>
        /// This method helps to get the result of clicking status code 404
        /// </summary>
        public void GetResultOfClicking404();

        /// <summary>
        /// This method helps to click on status code 500
        /// </summary>
        public void ClickOn500();

        /// <summary>
        /// This method helps to get the result of clicking status code 500
        /// </summary>
        public void GetResultOfClicking500();



    }
}