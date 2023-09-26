using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2P
{
    internal class Producto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO A NUESTRA TIENDA DE ARTICULOS");

            Console.WriteLine("\n Ingrese la cantidad de articulos que desea comprar: ");

            int CantidadA = int.Parse(Console.ReadLine());
            int PrecioA;

            if (CantidadA <= 10)
            {
                PrecioA = 20;
            }
            else
            {
                PrecioA = 15;
            }

            int CostoT = CantidadA * PrecioA;

            Console.WriteLine($"El precio por articulo es de {PrecioA}");

            Console.WriteLine($"El costo total de {CantidadA} es de {CostoT}");

            Console.WriteLine("MUCHAS GRACIAS POR COMPRAR EN NUESTRA TIENDA DE ARTICULOS!");

            Console.ReadLine();
        }
    }
}
