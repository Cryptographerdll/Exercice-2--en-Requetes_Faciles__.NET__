using System;
using System.Collections.Generic;
using System.Linq;

namespace Requêtes_Faciles_2__.NET_
{
    class Program
    {
        static void Main(string[] args)
        {
            // récupérer les nombres supérieurs ou égaux à 15 et inférieurs à 20 .

            List<int> Entiers = new List<int> { 12, 1, 25, 4, 3, 15, 16, 6, 8, 9, 77, 56, 12, 21, 5 };

            // Query Syntax 

            var query = from y in Entiers
                        where y >= 15 && y < 20
                        select y;

            foreach (var y in query)
            {
                Console.Write(y);
            }
        }
    }
}
