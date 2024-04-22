namespace HerokuAppOperations
{
    public interface IHerokuAppOperations
    {
        void GoToHome();

        void CloseBrowser();

        string GetRepoDetails();

        string GetFooterDetails();
        string GetStatus(string locator);
        void closeBrowser();
        string getFooterDetails();
        string getRepoDetails();
        string getStatus(string locator);
        void goToHome();
        bool GetStatus();
        
    }
}
