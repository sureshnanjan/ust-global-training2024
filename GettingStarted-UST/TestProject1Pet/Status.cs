namespace PetStoreProject
{
    /// <summary>
    /// Status Field - Values declaration
    /// </summary>
    public partial class Pet
    {
        /// <summary>
        /// Capturing order related details like id, petId,quantity,shipDate and complete
        /// </summary>
        public enum Status
        {
            available,
            pending,
            sold
        };
    }
}