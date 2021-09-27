using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            
            IKrediManager tasitKrediManager = new TasitKrediManager();
          
            IKrediManager konutKrediManager = new KonutKrediManager();

            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerServices();
            ILoggerService fileLoggerService = new FileLoggerServices();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,  smsLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
             


        }
    }
}
