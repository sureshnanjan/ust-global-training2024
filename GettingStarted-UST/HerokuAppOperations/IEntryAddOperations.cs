using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IEntryAddOperations
    {
        public string getTitle();
        public string getPageContentIentryAd();

        public string getWindowTitle();
        public string clickHere();
        public string getUrl();
        public string clickClose();
        public string reloadPage();

    }
}
