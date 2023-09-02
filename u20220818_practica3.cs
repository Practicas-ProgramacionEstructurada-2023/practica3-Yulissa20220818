using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
             //DECLARACION DE VARIABLES
            string? Marca_Zapato;
            string? Color_Zapato;
            int Cantidad;
            double Precio_Zapato;

            //Captura de datos
            Console.WriteLine("\n--------Captura de Variables--------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese la marca de zapatos a comprar:");
            Marca_Zapato = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nIngrese el color de zapatos:");
            Color_Zapato = Convert.ToString(Console.ReadLine());
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nIngrese la cantidad de pares de zapatos a comprar:");
            Cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese el precio del par de zapatos a comprar:");
            Precio_Zapato = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("-------- Fin Captura de Variables --------\n");

            //capturando el total a pagar
            double Total = Cantidad * Precio_Zapato;

            //Imprimiendo resultados 
             Console.WriteLine("\n-------Imprimiendo Resultados--------");
             Console.ForegroundColor = ConsoleColor.Blue;
             Console.WriteLine("La marca de zapatos a comprar es: " + Marca_Zapato);
             Console.WriteLine("\nEl color de zapatos a comprar es: " + Color_Zapato);
             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("\nLa cantidad de pares de zapatos a comprar es: " + Cantidad);
             Console.WriteLine("\nEl precio por par de zapatos a comprar es: " + Precio_Zapato);
             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.BackgroundColor = ConsoleColor.Yellow;
             Console.WriteLine("\nEl total a pagar es: " +  Total);
             Console.ResetColor();
             Console.WriteLine("\n--------Fin Imprimir Resultados--------\n");



         }
    } 

}
