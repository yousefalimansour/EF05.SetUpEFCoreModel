using EF05.SetUpEFCoreModel;

namespace Transaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter id for sender user : ");
            int Fromid = int.Parse(Console.ReadLine());

            Console.Write("Enter id for reciver user : ");
            int Toid = int.Parse(Console.ReadLine());

            Console.Write("Enter amount to transfer");
            decimal amount = decimal.Parse(Console.ReadLine()); 
            
            using(var context=new AppDBContext())
            {
                using(var transaction= context.Database.BeginTransaction())
                {
                    var To = context.Wallets.Single(x => x.Id == Toid);

                    var From = context.Wallets.Single(x => x.Id == Fromid);

                    From.Balance -= amount;
                    context.SaveChanges();

                    To.Balance += amount;
                    context.SaveChanges();

                   
                    transaction.Commit();
                }
            }
        }
    }
}