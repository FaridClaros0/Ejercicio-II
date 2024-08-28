using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_II
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] medidas =
            {
                {1, 0.11, 0.09, 0.11, 0.000147, 0.000013, 0.0000092 },//pie cuadrado
                {7.56, 1,0.702, 0.840, 0.001, 0.00010, 0.000070  },//vara cuadrada
                {10.763, 1.423, 1, 1.1958, 0.001, 0.000143, 0.0001 },//metro cuadrado
                {9, 1.190, 0.836, 1, 0.001329, 0.000119, 9.33 },//yarda cuadrada
                {6768.34, 894.98, 628.8, 752.038, 1, 0.089, 0.062},//tareas
                {75228.53, 9947.53, 6988.96, 8358.72, 11.114, 1, 0.698 },//manzana
                {107639.104, 14233.21, 10000, 11959.900, 15.903, 1.430, 1 },//hectarea
            };

            //nombre de las medidas
            string[] area = { "Pie cuadrado", "Vara cuadrada", "Metro cuadrado", "Yarda cuadrada", "Tareas", "Manzana", "Hectarea" };

            Console.WriteLine("Convertidor de area:\n\n");
            Console.WriteLine("Seleccione la medida de origen (0-9):");
            for (int i = 0; i < area.Length; i++)
            {
                Console.WriteLine($"{i}. {area[i]}");
            }
            int origen = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la medida de destino (0-9):");
            for (int i = 0; i < area.Length; i++)
            {
                Console.WriteLine($"{i}.{area[i]}");
            }
            int destino = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad a convertir: ");
            double cantidad = double.Parse(Console.ReadLine());

            double resultado = cantidad * medidas[origen, destino];
            Console.WriteLine($"El area convertida es :{resultado} {area[destino]}");

            Console.ReadLine();

        }
    }
}
