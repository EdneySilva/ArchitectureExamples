namespace Facade
{
    class Client
    {
        public Client(string name)
        {
            this.Name = name;
        }

        public string Name { get; protected set; }
    }
}