namespace PetStore
{
    internal class Order
    {
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