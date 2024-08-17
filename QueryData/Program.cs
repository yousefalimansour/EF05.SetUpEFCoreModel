using EF05.SetUpEFCoreModel;

namespace QueryData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Balance : ");
            decimal balance = decimal.Parse(Console.ReadLine());
            using (var context = new AppDBContext())
            {
                var wallet = context.Wallets.Where(x => x.Balance <= balance);
                foreach (var item in wallet)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}