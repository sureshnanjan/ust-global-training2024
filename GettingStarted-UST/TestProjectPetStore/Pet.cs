using System.Formats.Asn1;
using System.Reflection.Metadata;

namespace TestProjectPetStore
{
    /// <summary>
    /// Declaration of fields in Pet section
    /// </summary>
    [TestClass]
    internal partial class Pet
    {
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