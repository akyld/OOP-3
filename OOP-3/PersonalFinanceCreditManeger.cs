using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class PersonalFinanceCreditManeger : ICreditManeger
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı!");
        }

        public void Sorgula()
        {
            throw new NotImplementedException();
        }
    }
}
