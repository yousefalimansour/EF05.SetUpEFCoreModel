using EF05.SetUpEFCoreModel;

namespace UpdateItems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter {ID} : ");
            int id =int.Parse(Console.ReadLine());

            Console.Write("Enter {balance} : ");
            int balance = int.Parse(Console.ReadLine());

            using (var context = new AppDBContext())
            {
                var updatewallet = context.Wallets.Single(x => x.Id == id);
                updatewallet.Balance += balance;
                context.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}