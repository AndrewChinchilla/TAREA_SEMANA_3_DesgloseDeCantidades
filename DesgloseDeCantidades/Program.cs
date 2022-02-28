using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesgloseDeCantidades
{
    internal class Program
    {
        private static string linea;

        static void Main(string[] args)
        {

            //ANDREW HENRY STIVE CHINCHILLA CHINCHILLA
            //0905 - 21 - 11296
            //SECCIÓN "B"
            //TAREA SEMANA 3


            //Versión 1 - Switch

            int Cant, Cant200, Cant100, Cant50, Cant20, Cant10, Cant5, Cant1, OpcInicial; 
            Cant200 = Cant100 = Cant50 = Cant20 = Cant10 = Cant5 = Cant1=0;
            String Linea;
            float Mone50, Mone25, Mone10, Mone5, Mone1, Cant2;
            Mone50 = Mone25 = Mone10 = Mone5 = Mone1 = 0.00f;
            Console.WriteLine("\n");
            Console.WriteLine("\n\t\tBIENVENIDO USUARIO");
            Console.WriteLine("\n\tMENU DE OPCIONES DISPONIBLE: ");
            Console.WriteLine("\n\t[ 1 ] -> DESGLOSE DE CANTIDADES <-");
            Console.WriteLine("\t[ 2 ] -> SALIR");
            Console.WriteLine("\n");
            Console.Write("\n\tEyyy!... POR FAVOR INDIQUE LA OPCIÓN QUE DESEA EJECUTAR: ->> ");
            OpcInicial = int.Parse(Console.ReadLine());
            Console.WriteLine();




            switch (OpcInicial) 

            {
                case 1:
                    Console.WriteLine("\n");
                    Console.WriteLine("\t* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
                    Console.WriteLine("\n\tSALUDOS USUARIO! HA ELEGIDO DESGLOSE DE CANTIDADES");
                    Console.WriteLine("\n\t-->> PARA CONTINUAR POR FAVOR INGRESE SU CANTIDAD :");
                    Console.Write("\n\t--> CANTIDAD: $");
                    Linea = Console.ReadLine();
                    Cant2 = float.Parse(Linea);
                    Cant=(int)Cant2;
                    Cant2 = Cant2 - Cant;
                    Console.WriteLine("\n\tESPERE UN MOMENTO, OPERACIÓN EN PROCESO... ...");
                    Console.WriteLine("\n");
                  
                    Console.WriteLine($"¡PROCESO LISTO!  -> RESULTADOS: CANTIDAD DE: ->> Q {Cant}");
                    Console.WriteLine(".......");

                    if ((Cant >= 200))
                    {
                        Cant200 = (Cant / 200);
                        Cant = Cant - (Cant200 * 200);
                    }
                    if ((Cant >= 100))
                    {
                        Cant100 = (Cant / 100);
                        Cant = Cant - (Cant100 * 100);
                    }
                    if ((Cant >= 50))
                    {
                        Cant50 = (Cant / 50);
                        Cant = Cant - (Cant50 * 50);
                    }
                    if ((Cant >= 20))
                    {
                        Cant20 = (Cant / 20);
                        Cant = Cant - (Cant20 * 20);
                    }
                    if ((Cant >= 10))
                    {
                        Cant10 = (Cant / 10);
                        Cant = Cant - (Cant10 * 10);
                    }
                    if ((Cant5 >= 5))
                    {
                        Cant5 = (Cant / 5);
                        Cant = Cant - (Cant5 * 5);
                    }
                    if ((Cant1>=1))
                    {
                        Cant1 = (Cant / 1);
                        Cant = Cant - (Cant1 * 1);
                    }
                    if ((Cant2>=0.50))
                    {
                        Mone50 = 1;
                            Cant2 = (Cant2 - 0.50f);
                    }
                    if ((Cant2 >= 0.25))
                    {
                        Mone25 = 1;
                        Cant2 = (Cant2 - 0.25f);
                    }
                    if ((Cant2 >= 0.10))
                    {
                        Mone10 = (Cant2 - (Cant2 % 0.10f)) / 0.10f;
                        Cant2 = (Cant2 % 0.10f);
                        Mone10 = (float)Math.Round(Mone10, 2);
                    }
                    if ((Cant2>=0.05))
                    {
                        Mone5 = (Cant2 - (Cant2 % 0.05f)) / 0.05f;
                        Cant2 = Cant2 - (Mone5 % 0.05f);
                        Mone5=(float)Math.Round(Mone5, 2);
                    }
                    if((Cant2>=0.01))
                    {
                        Mone1 = (Cant2 / 0.01f);
                        Mone1=(float)Math.Round(Mone1, 2);
                    }

                    Console.WriteLine("\n\t* * * * * * * * * * * * * * * * * * * * * * *");
                    Console.WriteLine("\n\tDESGLOSE DE UNIDADES:");
                    Console.WriteLine($"\tBILLETES DE 200:-> {Cant200}");
                    Console.WriteLine($"\tBILLETES DE 100:-> {Cant100}");
                    Console.WriteLine($"\tBILLETES DE 50:-> {Cant50}");
                    Console.WriteLine($"\tBILLETES DE 20:-> {Cant20}");
                    Console.WriteLine($"\tBILLETES DE 10:-> {Cant10}");
                    Console.WriteLine($"\tBILLETES DE 5:-> {Cant5}");
                    Console.WriteLine($"\tBILLETES DE 1:-> {Cant1}");
                    Console.WriteLine("\n");
                    Console.WriteLine($"\tMONEDAS DE 50 CENTAVOS:-> {Mone50}");
                    Console.WriteLine($"\tMONEDAS DE 25 CENTAVOS:-> {Mone25}");
                    Console.WriteLine($"\tMONEDAS DE 10 CENTAVOS:-> {Mone10}");
                    Console.WriteLine($"\tMONEDAS DE 05 CENTAVOS:-> {Mone5}");
                    Console.WriteLine($"\tMONEDAS DE 01 CENTAVOS:-> {Mone1}");

                    Console.WriteLine("\n");
                    Console.WriteLine("\tPROCESO TERMINADO GRACIAS");
                    Console.WriteLine("\t* * * * * * * * * * * * * * * * * * * * * *");

                    Console.ReadKey();
                    break;

                case 2:
                    
                    Console.WriteLine("\n\tHASTA PRONTO...");
                    Console.ReadKey();

                    break;
            }

            
           
           

        }
    }
}
