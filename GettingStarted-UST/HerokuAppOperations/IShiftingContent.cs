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
        /// Method to click on Shifting Content link available on home page
        /// </summary>
        public void clickShiftingContentLink();

        
        /// <summary>
        /// Get all the Menu Options in the Page
        /// </summary>
        /// <returns>List of Menu options</returns>
        //List<string> getMenuElements();
        
        /// <summary>
        /// Method to shift image in left/right directions
        /// </summary>
      //  public void clickToShiftImagesLeft();

        /// <summary>
        /// Method to click link and get blank image
        /// </summary>
      //  public void clickLinkForBlankImage();
       
        /// <summary>
        /// Method to check the visibility of all the menu
        /// </summary>
       // bool getMenuItemVisibilityStatus(string item);
        
        /// <summary>
        /// Method to check content of Shifting Content link page
        /// </summary>
        public void contentOnShiftingContentList();
        /// <summary>
        /// Method to go to home page from Shifting Content: Menu Element page
        /// </summary>
        public void clickHome();

    }



}
