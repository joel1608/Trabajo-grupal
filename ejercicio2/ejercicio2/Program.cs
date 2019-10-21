using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio2.clases;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Nota n = new Nota();
            Console.WriteLine("Ingrese su nombre:");
            n.Nombre = Console.ReadLine();
            try
            {
                Console.WriteLine("Ingrese nota de actuacion del primer parcial");
                n.ActuacionP1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nota de producción del primer parcial");
                n.ProduccionP1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nota de trabajo autonomo del primer parcial");
                n.TrabajoAutonomoP1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nota de exámen del primer parcial");
                n.ExamenFinalP1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nota de actuacion del segundo parcial");
                n.ActuacionP2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nota de producción del segundo parcial");
                n.ProduccionP2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nota de trabajo autonomo del segundo parcial");
                n.TrabajoAutonomoP2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nota de exámen del segundo parcial");
                n.ExamenFinalP2 = float.Parse(Console.ReadLine());


                if (n.PrimerParcial + n.PSegundoParcial < 14)
                {
                    if (n.PrimerParcial + n.PSegundoParcial >= 8)
                    {

                        Console.WriteLine("Usted esta en recuperación\n");
                        Console.WriteLine("Ingrese nota de recuperación");
                        n.NotaRecuperacion = float.Parse(Console.ReadLine());

                        if (n.NotaRecuperacion >= n.Recuperacion)
                        {
                            Console.WriteLine("APROBADO!");
                        }

                        else
                        {
                            Console.WriteLine("REPROBADO");
                        }


                    }

                    else
                    {
                        Console.WriteLine("REPROBADO");
                    }


                }
                else
                {
                    Console.WriteLine("APROBADO!");
                }
            }
            catch (Exception mensaje)
            {
                Console.WriteLine(mensaje.Message);

            }

            Console.ReadKey();

        }
    }
}
