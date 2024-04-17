using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
    ///<summary>
    ///Hold the Properties and Operations of Heroku App
{
    internal interface IFloating
    {
        string getUrl();
        void setUrl(string url);
        ///<summary>
        ///</summary>
    }
}
