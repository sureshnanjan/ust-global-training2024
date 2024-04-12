using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestHerokuApp
{
    internal class MyDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
              yield return new TestCaseData("Add / Remove Elements","XXXX");
              yield return new TestCaseData("Basic Auth(user and pass: admin)","XXXX");
              yield return new TestCaseData("Broken Images","XXXX");
              yield return new TestCaseData("Challenging DOM","XXXX");
              yield return new TestCaseData("Checkboxes","XXXX");
              yield return new TestCaseData("Context Menu","XXXX");
              yield return new TestCaseData("Digest Authentication(user and pass: admin)","XXXX");
              yield return new TestCaseData("Disappearing Elements","XXXX");
              yield return new TestCaseData("Drag and Drop","XXXX");
              yield return new TestCaseData("Dropdown","XXXX");
              yield return new TestCaseData("Dynamic Content","XXXX");
              yield return new TestCaseData("Dynamic Controls","XXXX");
              yield return new TestCaseData("Dynamic Loading","XXXX");
              yield return new TestCaseData("Entry Ad","XXXX");
              yield return new TestCaseData("Exit Intent","XXXX");
              yield return new TestCaseData("File Download","XXXX");
              yield return new TestCaseData("File Upload","XXXX");
              yield return new TestCaseData("Floating Menu","XXXX");
              yield return new TestCaseData("Forgot Password","XXXX");
              yield return new TestCaseData("Form Authentication","XXXX");
              yield return new TestCaseData("Frames","XXXX");
              yield return new TestCaseData("Geolocation","XXXX");
              yield return new TestCaseData("Horizontal Slider","XXXX");
              yield return new TestCaseData("Hovers","XXXX");
              yield return new TestCaseData("Infinite Scroll","XXXX");
              yield return new TestCaseData("Inputs","XXXX");
              yield return new TestCaseData("JQuery UI Menus","XXXX");
              yield return new TestCaseData("JavaScript Alerts","XXXX");
              yield return new TestCaseData("JavaScript onload event error","XXXX");
              yield return new TestCaseData("Key Presses","XXXX");
              yield return new TestCaseData("Large & Deep DOM","XXXX");
              yield return new TestCaseData("Multiple Windows","XXXX");
              yield return new TestCaseData("Nested Frames","XXXX");
              yield return new TestCaseData("Notification Messages","XXXX");
              yield return new TestCaseData("Redirect Link","XXXX");
              yield return new TestCaseData("Secure File Download","XXXX");
              yield return new TestCaseData("Shadow DOM","XXXX");
              yield return new TestCaseData("Shifting Content","XXXX");
              yield return new TestCaseData("Slow Resources","XXXX");
              yield return new TestCaseData("Sortable Data Tables","XXXX");
              yield return new TestCaseData("Status Codes","XXXX");
              yield return new TestCaseData("Typos","XXXX");
              yield return new TestCaseData("WYSIWYG Editor", "XXXX");

    }
        }
    }
}
