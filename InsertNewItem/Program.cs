using EF05.SetUpEFCoreModel;

namespace InsertNewItem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name; decimal balance;
            try
            {
                Console.Write("Enter Name : ");
                 name = Console.ReadLine();
                Console.Write("Enter Balance : ");
                balance = decimal.Parse(Console.ReadLine());
            }catch (Exception ex) 
            { 
                throw new Exception(" Enter right inputs please "); 
            }
            var new_wallet = new Wallet()
            {
                Holder = name,
                Balance = balance,
            };
            using(var context = new AppDBContext())
            {
                context.Wallets.Add(new_wallet);
                context.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}