using System.Formats.Asn1;
using System.Reflection.Metadata;

namespace PetStoreProject
{
    /// <summary>
    /// Capturing order related details like id, petId,quantity,shipDate and complete
    /// </summary>
    internal partial class Pet
    {
        private long id = 10;
        private string name;
        private string photourls;
        Category category = new Category();
        Tag tags = new Tag();
        Order order = new Order(0);
        User user = new User();
        APIResponse apiresp = new APIResponse();

    }
}