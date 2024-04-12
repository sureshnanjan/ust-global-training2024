namespace PetStore
{
    /// <summary>
    /// Contians Pet details like id, name, photourl, Category and Tag details 
    /// </summary>

    public partial class Pet
    {
        /// <summary>
        /// Properties of pet
        /// </summary>
        private long id = 10;
        private string name;
        private string photourls;
        Category category = new Category();
        Tag tags = new Tag();
        

    }
}
