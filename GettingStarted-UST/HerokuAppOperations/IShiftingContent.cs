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
        /// To count the number of links available on the page
        /// </summary>
        /// <returns></returns>
        public void CheckLinksOfMenuLink();
        /// <summary>
        /// Enable the functionality to click on the links
        /// </summary>

        public void ClickListlink_CheckTitleOfPage();

        /// <summary>
        /// Enable the functionality to click on the links
        /// </summary>
        public void clickShiftingContentLink();

        
        /// <summary>
        /// Get all the Menu Options in the Page
        /// </summary>
        /// <returns>List of Menu options</returns>
        //List<string> getMenuElements();
        
        /// <summary>
        /// Method to shift images towards left
        /// </summary>
        public void clickToShiftImageLeft();
        
        /// <summary>
        /// Method to shift images towards left
        /// </summary>
        public void clickToShiftImageRight();
       
        /// <summary>
        /// Method to check the visibility of all the menu
        /// </summary>
       // bool getMenuItemVisibilityStatus(string item);
        
        /// <summary>
        /// Method to check content of Shifting Content link page
        /// </summary>
        public void validateContentOnShiftingContentList();

        public void clickHome();

    }



}
