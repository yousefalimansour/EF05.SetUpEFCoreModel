using Microsoft.Extensions.Configuration;

namespace EF05.SetUpEFCoreModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
             var configration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var constr = configration.GetSection("constr").Value;
            Console.WriteLine(constr);
            Console.ReadKey();
        }
    }
}