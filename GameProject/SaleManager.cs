using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class SaleManager : ISaleService
    {
        public void Add(Sale sale)
        {
            Console.WriteLine("Satış " + sale.GamerName + " adlı kullanıcıya yapıldı");
        }
    }
}
