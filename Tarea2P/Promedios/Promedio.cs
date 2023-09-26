using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedios
{
    internal class Promedio
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADOR DE PROMEDIOS FINALES");

            Console.WriteLine("Digite el numero de carnet del estudiante: ");
            int CarnetE = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Ingrese el nombre del estudante: ");
            string NombreE = Console.ReadLine();

            // quizzes 
            
            Console.WriteLine("\n Digite la calificacion del primer quiz: ");
            double Quiz1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite la calificacion del segundo quiz: ");
            double Quiz2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite la calificacion del tercer quiz: ");
            double Quiz3 = double.Parse(Console.ReadLine());

            //tareas
            
            Console.WriteLine("\n Digite la calificacion de la primera tarea: ");
            double Tarea1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite la calificacion de la segunda tarea: ");
            double Tarea2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite la calificacion de la tercera tarea: ");
            double Tarea3 = double.Parse(Console.ReadLine());

            // examenes
            
            Console.WriteLine("\n Digite la calificacion del primer examen: ");
            double Examen1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite la calificacion del segundo examen: ");
            double Examen2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite la calificacion del tercer examen: ");
            double Examen3 = double.Parse(Console.ReadLine());

            // porcentajes

            double PorcentajeQ = ((Quiz1 + Quiz2 + Quiz3) / 3) * 0.25d;
            double PorcentajeT = ((Tarea1 + Tarea2 + Tarea3) / 3) * 0.30d;
            double PorcentajeE = ((Examen1 + Examen2 + Examen3) / 3) * 0.45d;

            // promedio 

            double PromedioF = PorcentajeQ + PorcentajeT + PorcentajeE;

            // condicion

            string Condicion;

            if (PromedioF >= 70)
            {
                Condicion = "Aprobado"; 
            }
            else if (PromedioF >= 50)
            {
                Condicion = "Aplazado";
            }
            else
            {
                Condicion = "Reprobado";
            }

            // resultados

            Console.WriteLine("\n Los datos del estudiante son los siguientes:");

            Console.WriteLine($"Carnet: {CarnetE}");
            Console.WriteLine($"Nombre: {NombreE}");
            Console.WriteLine($"Porcentaje de quizzes: {PorcentajeQ}%");
            Console.WriteLine($"Porcentaje de tareas: {PorcentajeT}%");
            Console.WriteLine($"Porcentaje de examenes: {PorcentajeE}%");
            Console.WriteLine($"Promedio final: {PromedioF}");
            Console.WriteLine($"Condicion del estudiante: {Condicion}");

            Console.ReadLine();
        }
    }
}
