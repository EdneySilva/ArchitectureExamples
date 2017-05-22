namespace Facade
{
    class Bank
    {
        public Bank()
        {
        }

        public bool HasSufficientSavings(Client client)
        {
            System.Console.WriteLine($"Checking savings for {client.Name}");
            return true;
        }
    }
}