using EF05.SetUpEFCoreModel;

namespace DeletItem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter {ID} : ");
            int id = int.Parse(Console.ReadLine());

            using (var context =new AppDBContext())
            {
                var wallet = context.Wallets.Single(x => x.Id == id);
               context.Remove(wallet);
               context.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}