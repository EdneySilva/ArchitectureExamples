using System;

namespace Facade
{
    internal class Emprestimo
    {
        public Emprestimo()
        {
        }

        internal void LiberarEmprestimo()
        {
            Client client = new Client("Edney");
            Bank banck = new Bank();    
        }
    }
}