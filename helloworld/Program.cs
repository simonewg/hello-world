using helloworld.Model;
using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //value type

            int Intero;
            float NumeroConLaVirgola32;
            double NumeroConLaVirgola64;
            bool ValoreLogico;
            char car;
            decimal Decimale; //valore preciso con operazioni matematiche 

            int i = 5;
            int j = 10;

            Console.WriteLine(i);
            Console.WriteLine(j);
           
            j = i;
            
            Console.WriteLine(i);
            Console.WriteLine(j);


            //reference type

            string InsiemeDiCaratteri;
            string stringa1 = "la mia casa e bella";
            string stringa2 = stringa1;

            Console.WriteLine(stringa1);
            Console.WriteLine(stringa2);
            
          


            object oggetto;
            
             Person simone = new Person("simone", "gaudiano");
             simone.eta = 18;

            Console.WriteLine(simone.Anagrafica());


        }
    }
}
