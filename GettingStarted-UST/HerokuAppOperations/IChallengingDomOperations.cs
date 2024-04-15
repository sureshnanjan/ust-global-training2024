using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface with operations that can be done on ChallengingDom homepage
    /// </summary>
    public interface IChallengingDomOperations
    {
        string GetURL();

        string GetTitle();

        string GetMainContent();

        string GetOperation1Label();

        void DoOperation1();

        string GetOperation2Label();

        void DoOperation2();

        string GetOperation3Label();

        void DoOperation3();

        string GetResult();

        string[] GetTableHeadings();

        void EditRow(int rownum);

        void DeleteRow(int rownum);

        string[] GetRowData(int rownum);
    }
}
