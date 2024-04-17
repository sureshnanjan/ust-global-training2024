namespace StorePet
{
    /// <summary>>
    /// Contains API response details like code, message and type
    /// </summary>>
    
    internal class APIResponse
    {
        /// <summary>>
        /// API response properties 
        /// </summary>>
        private int code;
        private string message;
        private string type;

        public int Code { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public APIResponse()
        {
        }
    }
}