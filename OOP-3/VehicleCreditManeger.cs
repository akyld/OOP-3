using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class VehicleCreditManeger : ICreditManeger
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı!");
        }

        public void Sorgula()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı sorgulandı!");
        }
    }
}
