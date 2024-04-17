namespace StorePet
{
    /// <summary>
    /// Capturing order related details like id, petId,quantity,shipDate and complete
    /// </summary>
    
    internal class Order
    {
        /// <summary>
        /// Properties of Order
        /// </summary>
        public long id;
        public long petId;
        public int quantity;
        public DateTime shipDate;
        public Boolean complete;
        public enum status
        {
            placed,
            approved,
            delivered
        }
        public Order(int id)
        {
            this.id = id;

        }
    }
}