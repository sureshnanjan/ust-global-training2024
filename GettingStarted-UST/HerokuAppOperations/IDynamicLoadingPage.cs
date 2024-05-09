using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IDynamicLoadingPage
    {
        ///<summary>
        ///Get the Title of the Page 
        ////<summary>
        /// /// <returns>Title</returns>
        string getTitle();

        /// <summary>
        /// Get the content of DynamicLoading Page
        /// </summary>
        ///  /// <returns>Content</returns>
        string getDescription();

        /// <summary>
        /// Get the count of Example Links on DynamicLoading Page
        /// </summary>
        /// <returns>Count</returns>
        int getExamplesCount();


        /// <summary>
        /// Visit the Example Links on DynamicLoading Page
        /// </summary>
        void goToExampleLinks(string exampleName);

        /// <summary>
        /// get the subtitle -Example 1 Element on the page that is hidden
        /// </summary>
        /// <returns>SubTitle of Example1 Page</returns>
        string getSubTitleExample1();

        /// <summary>
        /// get the subtitle - Example 2 Element rendered after the fact
        /// </summary>
        /// <returns>SubTitle of Example2 Page</returns>
        string getSubTitleExample2();

        /// <summary>
        /// This method is used to Enable Start
        /// </summary>
        /// <returns></returns> 
        public void enableStart();

        /// <summary>
        /// This method validates the start message
        /// </summary>
        /// <returns>Hello World!</returns> 
        public string getStartMessage();

        public void openDynamicLoadingPage();

       // public void closeBrowser();


    }
}