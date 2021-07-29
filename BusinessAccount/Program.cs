using System;
using Accounts.Entities;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brow", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //account.Balance = 200; -> Nessa caso não será possível alterar o valor do Balance pois o SET do Balance esta protegido e apenas a super classe ou subclasse poderá modificar seu valor.

        }
    }
}
