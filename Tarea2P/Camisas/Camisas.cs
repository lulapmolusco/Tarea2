using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camisas
{
    internal class Camisas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO A TIENDA DE CAMISAS PACA LOCA");

            Console.WriteLine("\n Ingrese la cantidad de camisas que desea comprar: ");
            int CantidadC = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Ingrese el precio de la camisa: ");
            float PrecioC = float.Parse(Console.ReadLine());

            float CostoT = 0;

            if (CantidadC == 1)
            {
                CostoT = CantidadC * PrecioC;
            }
            else if (CantidadC >= 2 && CantidadC <= 5)
            {
                CostoT = CantidadC * PrecioC * 0.15f;
            }
            else if (CantidadC > 5)
            {
                CostoT = CantidadC * PrecioC * 0.15f;
            }

            Console.WriteLine($"\n El costo total de {CantidadC} camisas es de {CostoT}");

            Console.WriteLine("\n Su compra se realizó con éxito. Muchas gracias.");

            Console.ReadLine();
        }
    }
}
