namespace HerokuAppOperations
{
    /// <summary>
    /// this interface contains methods to be implemented for Horizontal Slider page
    /// <returns></returns>  /// </summary>
    public interface IHorizontalSlider
    {

        /// <summary>
        /// this returns the title of the page
        /// </summary>
        /// <returns>Title</returns> 
        public string getTitle();

        /// <summary>
        /// this method will retrieve the current position of the slidebar and returns current position as float
        /// </summary>
        /// <returns>Position</returns> 
        public string getSlidePosition();


        /// <summary>
        /// this method performs forward and backward sliding on the bar
        /// </summary>
        public void SlidetheBar(int n);
        

        /// <summary>
        /// this method returns the text present on the screen
        /// </summary>
        /// <returns>Content</returns> 
        public string getScreenContent();
    }
}