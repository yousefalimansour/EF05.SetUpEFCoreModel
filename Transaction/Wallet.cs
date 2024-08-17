using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF05.SetUpEFCoreModel
{
    public class Wallet
    {
        public int Id { get; set; }
        public string Holder { get; set; } = null!;
        public decimal Balance { get; set; }
        public override string ToString()
        {
            return $"[{Holder}] => {{{Id} , {Balance}}}"; 
        }
    }
}
