using EF05.SetUpEFCoreModel;

namespace RetriveOneItem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context= new AppDBContext())
            {
                var wallet = context.Wallets.FirstOrDefault(x => x.Id == 4);
                Console.WriteLine(wallet);
            }

            Console.ReadKey();
        }
    }
}