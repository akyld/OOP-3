using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class ApplicationManeger
    {
        public void Application(ICreditManeger creditManeger , List<ILoggerService> loggerServices)
        {
            //Başvuran Bilgilerini değerlendirme

            creditManeger.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

    
        public void CreditInformation(List<ICreditManeger> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    
    
    
    
    }
}
