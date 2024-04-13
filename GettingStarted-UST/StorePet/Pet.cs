using System.Formats.Asn1;
using System.Reflection.Metadata;
using StorePet;

namespace StorePet
{
    /// <summary>
    /// Contians Pet details like id, name, photourl, Category and Tag details 
    /// </summary>
    
    [TestClass]
    internal partial class Pet
    {
        /// <summary>
        /// Properties of Pet
        /// </summary>
        private int id = 10;
        private string name;
        private string photourls;
        Category category = new Category();
        Tag tags = new Tag();
        Order order = new Order(0);
        User user = new User();
        APIResponse apiresp = new APIResponse();
    }
}