using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IDisappearingElementsOperations
    {
        /// <summary>
        /// This method fetched the current Url opened in the browser.
        /// </summary>
        /// <returns> </returns>
        string GetURL();

        /// <summary>
        /// Verify the title displayed
        /// </summary>

        string GetTitle();

        /// <summary>
        /// This method helps to verify the main content.
        /// </summary>
        string GetMainContent();

        /// <summary>
        /// Click on the Home option
        /// </summary>
        /// <action> Redirect to the Home Page</action>
        public void ClickHome();

        

        /// <summary>
        /// Click on the About option
        /// </summary>
        /// <returns></returns>
        public void ClickAbout();

        /// <summary>
        /// Get result of clicking About option
        /// </summary>

        public string GetAboutPageDetails();


        /// <summary>
        /// Click on the Contact Us option
        /// </summary>
        /// <returns></returns>
        public void ClickContactUs();

        /// <summary>
        /// Get result of clicking the Contact Us option
        /// </summary>

        public string GetContactUsPageDetails();


        /// <summary>
        /// Click on the Portfolio option
        /// </summary>
        /// <returns></returns>
        /// 

        public void ClickPortfolio();

        /// <summary>
        /// Get result of clicking Portfolio option
        /// </summary>

        public string GetPortfolioPageDetails();


        /// <summary>
        /// Click on the Gallery option
        /// </summary>
        /// <returns></returns>
        public void ClickGallery();

        /// <summary>
        /// Get result of clicking Gallery option
        /// </summary>

        public string GetGalleryPageDetails();
    }
}
