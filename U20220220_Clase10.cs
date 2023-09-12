using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            // EJERCICIO CON ESTRUCTURA SWITCH CASE

            Console.WriteLine("\n<<<<<<<<<< Menu de opciones del programa >>>>>>>>>>\n"+
            "\n1.Programa de trimestre\n"+
            "\n2.Cancelar\n");
            Console.WriteLine("Ingrese la opcion de desea ejecutar");
            int meses = Convert.ToInt32(Console.ReadLine());
            
            // USO DE SWITCH-CASE

            switch (meses)
            {
                case 1:
                Console.WriteLine("\n<<<<<<<<<< Inico del programa del primer trimestre >>>>>>>>>>\n");

                Console.WriteLine("Ingresa el digito del mes, del primer trimestre que desea ver");
                int mes = Convert.ToInt32(Console.ReadLine());

                // USO DE CONDICIONALES IF, ELSE IF, ELSE

                if (mes == 1)
                Console.WriteLine("\nEste es mes es: Enero");

                else if (mes == 2)
                Console.WriteLine("\nEste mes es: Febrero");

                else if (mes == 3)
                Console.WriteLine("\nEste mes es: Marzo");

                else if (mes == 4)
                Console.WriteLine("\nEste mes es: Abril");

                else if (mes == 5)
                Console.WriteLine("\nEste mes es: Mayo");

                else if (mes == 6)
                Console.WriteLine("\nEste mes es: Julio");

                else 
                Console.WriteLine("\nError de datos vuelva a ingresarlo\n");
                Console.WriteLine("\n<<<<<<<<<< FIN DEL PROGRAMA >>>>>>>>>>\n");

                    break;

                    case 2:
                    Console.WriteLine("\nOperacion cancelada\n");
                    Console.WriteLine("<<<<<<<<<< FIN DEL PROGRAMA >>>>>>>>>>\n");


                    break;
                default:
                    break;
            }

            // NOMBRE: JUDITH ESPERANZA DEL CID DE LA O
            // CODIGO: U20220220
        }
    }
}
