namespace GettingStarted_UST
{
    internal class PetStoreWorker
    {
        public PetStoreWorker() { }

        public void FeedAnimals() {

            List<Pet> list = new List<Pet>();
            list.Add(new Fish());
            list.Add(new Dog());
            list.Add(new Cat());
            
            Pet mypet = new Fish();
            mypet = new Dog();
            mypet = new Cat();

            foreach (Pet p in list)
            {
                p.Feed();
            }
        
        }
    }
}
