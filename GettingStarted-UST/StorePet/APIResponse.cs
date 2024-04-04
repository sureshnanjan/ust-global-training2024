namespace StorePet
{
    /// <summary>
    /// Declaring the fields in APIResponse section
    /// </summary>
    internal class APIResponse
    {
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