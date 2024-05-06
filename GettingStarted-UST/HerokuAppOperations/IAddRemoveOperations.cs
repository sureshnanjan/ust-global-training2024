namespace HerokuAppOperations
{
    public interface IAddRemoveOperations: IHerokuAppOperations
    {
        // AddElemnts
        // GetAddedElements
        // GetHeading


        /// <summary>
        /// This method verifies the elements added to page
        /// </summary>
        public void AddElements();

        /// <summary>
        /// This method verifies the title of the page
        /// </summary>
        public string getPageTitle();

        /// <summary>
        /// This method verifies the deletion of element in page
        /// </summary>
        public void deleteElements();


    }
}