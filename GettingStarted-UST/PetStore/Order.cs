namespace PetStore
{
    /// <summary>
    /// Capturing order related details like id, petId,quantity,shipDate and complete
    /// </summary>

    internal partial class Order
    {
        /// <summary>
        /// Properties of Order
        /// </summary>
        private long id;
        private long petId;
        private int quantity;
        private DateTime shipDate;
        private Boolean complete;
       
    }
}