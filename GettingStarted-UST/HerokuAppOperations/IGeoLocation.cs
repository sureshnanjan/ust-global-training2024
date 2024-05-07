namespace HerokuAppOperations
{
    public interface IGeoLocation

    {
        /// <summary>
        /// This method verifies the title of the page
        /// </summary>
        string getTitle();

        /// <summary>
        /// This method is to verify the header above the button displayed 
        /// </summary>
        string getTheHeaderShownforThebutton();

        /// <summary>
        /// This method is to verify the text shown in the button
        /// </summary>
        string getButtonText();

        /// <summary>
        /// This method is to click on where am i button
        /// </summary>
        void clickTheButton();

        /// <summary>
        /// This method is to verify if the geo location displayed in the page
        /// </summary>
        List<string> verifyGeoLocation();

        /// <summary>
        /// This method is to click on the hyperlink
        /// </summary>
        void clickOnVerifyInGoogleLink();

        /// <summary>
        /// This method verifies if the google map page displayed or not
        /// </summary>
        bool verifyIfGoogleMapPage();

        
    }
}