namespace Practice
{
    public class Customer
    {
        public int id;
        public string name;

        public Customer()
        {

        }

        public Customer(int id)
        {
            this.id = id;
        }

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
