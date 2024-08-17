using EF05.SetUpEFCoreModel;
using Microsoft.Extensions.Configuration;

namespace RetriveData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new AppDBContext())
            {
                foreach(var wallet in context.Wallets)
                {
                    Console.WriteLine(wallet);
                }
            }
            Console.ReadKey();
        }
    }
}