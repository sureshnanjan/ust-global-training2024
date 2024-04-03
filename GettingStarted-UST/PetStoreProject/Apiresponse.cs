namespace PetStoreProject
{
    /// <summary>
    /// Declaring the fields in APIresponse section
    /// </summary>
    internal class Apiresponse
    {
        private int code;
        private string message;
        private string type;

        public int Code { get; set; }
        public  string Message { get; set; }
        public string Type { get; set; }
        public Apiresponse()
        {
        }
    }
}