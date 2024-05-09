using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IShiftingContent
    {
        /// <summary>
        /// Method to fetch title of the page
        /// </summary>
        /// <returns></returns>
        public void titleOfShiftingContentPage();

        /// <summary>
        /// To check that portfolio menu item disappears after the second "click here" link is clicked
        /// </summary>
        /// <returns></returns>
        public void CheckLinksOfMenuLink();

        /// <summary>
        /// Method to check title of Shifting Content: List page
        /// </summary>
        
        public void ClickListlink_CheckTitleOfPage();

        /// <summary>
        /// Method to click on Shifting Content link available on home page
        /// </summary>
        public void clickShiftingContentLink();

       
        /// <summary>
        /// Method to check content of Shifting Content: List page
        /// </summary>
        public void contentOnShiftingContentList();
        
        /// <summary>
        /// Method to go to home page after clicking "Home" menu on Shifting Content: Menu Element page
        /// </summary>
        public void clickHome();
        
        /// <summary>
        /// Get all the Menu Options in the Page
        /// </summary>
        public void clickImagelink_ClickhereToShiftImage();

 
    }



}
