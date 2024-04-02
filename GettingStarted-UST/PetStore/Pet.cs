namespace PetStore
{
    public abstract class Pet
    {
        public long id = 10;
        public string name;
        public string photourls;
        Category category = new Category();
        Tag tags = new Tag();
        public enum Status
        {
            available,
            pending,
            sold
        };
        Order order = new Order(2);
        User user = new User();
        Apiresponse apiresp = new Apiresponse();

    }
}
