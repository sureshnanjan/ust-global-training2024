using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    internal interface Ihomepage_ContextMenu
    {
        // Title Con;text Menu
        public void Gettitle();
        // for getting description
        public void Getdescription();
        // when right cickon the text box
        public void Click_on_text_box(string title);

        // Getting an alert when I right click on the box

        public void Getting_an_alert();




    }
}
