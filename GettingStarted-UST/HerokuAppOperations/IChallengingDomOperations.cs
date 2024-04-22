namespace HerokuAppOperations
{
    /// <summary>
    /// 
    /// </summary>
    public interface IChallengingDomOperations: IHerokuAppOperations
    {
        /// <summary>
        /// This method fetched the current Url opened in the browser.
        /// </summary>
        /// <returns></returns>
        string getURL();
        string getTitle();

        string getMainContent();

        void doOperation1();

        string getOperation1Label();

        void doOperation2();

        string getOperation2Label();
        void doOperation3();

        string getOperation3Label();

        string getResult();

        string[] getTableHeadings();

        void editRow(int rownum);

        void deleteRow(int rownum);

        string[] getRowData(int rownum);
    }
}
