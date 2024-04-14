using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestHerokuApp
{
    /// <summary>
    /// Data calss to hold all the 44 page data
    /// </summary>
    public class MyDataClass
    {
        /// <summary>
        /// Test case to get links one by one 
        /// </summary>
        public static IEnumerable TestCases
        {   
            get
            {
               /*
                yield return new TestCaseData("A / B Testing", "A/B Test Control");
                yield return new TestCaseData("Broken Images", "Broken Images");
                yield return new TestCaseData("Challenging DOM", "Challenging DOM");
                yield return new TestCaseData("Dropdown", "Dropdown");
                yield return new TestCaseData("Drag and Drop", "Drag and Drop");
                yield return new TestCaseData("Exit Intent", "Exit Intent");
               */


                
                yield return new TestCaseData("A/B Testing", "XXX");
                yield return new TestCaseData("Add/Remove Elements", "XXX");
                yield return new TestCaseData("Basic Auth", "XXX");
                yield return new TestCaseData("Broken Images", "XXX");
                yield return new TestCaseData("Challenging DOM", "XXX");
                yield return new TestCaseData("Checkboxes", "XXX");
                yield return new TestCaseData("Context Menu", "XXX");
                yield return new TestCaseData("Digest Authentication", "XXX");
                yield return new TestCaseData("Disappearing Elements", "XXX");
                yield return new TestCaseData("Drag and Drop", "XXX");
                yield return new TestCaseData("Dropdown", "XXX");
                yield return new TestCaseData("Dynamic Content", "XXX");
                yield return new TestCaseData("Dynamic Controls", "XXX");
                yield return new TestCaseData("Dynamic Loading", "XXX");
                yield return new TestCaseData("Entry Ad", "XXX");
                yield return new TestCaseData("Exit Intent", "XXX");
                yield return new TestCaseData("File Download", "XXX");
                yield return new TestCaseData("File Upload", "XXX");
                yield return new TestCaseData("Floating Menu", "XXX");
                yield return new TestCaseData("Forgot Password", "XXX");
                yield return new TestCaseData("Form Authentication", "XXX");
                yield return new TestCaseData("Frames", "XXX");
                yield return new TestCaseData("Geolocation", "XXX");
                yield return new TestCaseData("Horizontal Slider", "XXX");
                yield return new TestCaseData("Hovers", "XXX");
                yield return new TestCaseData("Infinite Scroll", "XXX");
                yield return new TestCaseData("Inputs", "XXX");
                yield return new TestCaseData("JQuery UI Menus", "XXX");
                yield return new TestCaseData("JavaScript Alerts", "XXX");
                yield return new TestCaseData("JavaScript onload event error", "XXX");
                yield return new TestCaseData("Key Presses", "XXX");
                yield return new TestCaseData("Large & Deep DOM", "XXX");
                yield return new TestCaseData("Multiple Windows", "XXX");
                yield return new TestCaseData("Nested Frames", "XXX");
                yield return new TestCaseData("Notification Messages", "XXX");
                yield return new TestCaseData("Redirect Link", "XXX");
                yield return new TestCaseData("Secure File Download", "XXX");
                yield return new TestCaseData("Shadow DOM", "XXX");
                yield return new TestCaseData("Shifting Content", "XXX");
                yield return new TestCaseData("Slow Resources", "XXX");
                yield return new TestCaseData("Sortable Data Tables", "XXX");
                yield return new TestCaseData("Status Codes", "XXX");
                yield return new TestCaseData("Typos", "XXX");
                yield return new TestCaseData("WYSIWYG Editor", "XXX");

            }
        }
    }
}
