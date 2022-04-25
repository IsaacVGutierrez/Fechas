using System;

namespace Fechas
{
    class Program
    {
        static void Main(string[] args)
        {

            int dia;
            int mes;
            int año;
            

            Console.WriteLine("Ingrese el dia de hoy: ");
            dia = int.Parse(Console.ReadLine());

            if (dia > 31)
            {
                Console.WriteLine("Error ,Ingrese un dia correcto: ");
                dia = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Ingrese el mes: ");
            mes = int.Parse(Console.ReadLine());

            if (mes > 12)
            {
                Console.WriteLine("Error ,Ingrese un mes correcto: ");
                mes = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Ingrese el año: ");
            año = int.Parse(Console.ReadLine());

            if (año < 1000)
            {
                Console.WriteLine("Error ,Ingrese un año correcto: ");
                año = int.Parse(Console.ReadLine());
            }

          
            {
            
            }

            if (dia > 30)
            {
                int a = dia = 1;
                dia = a;
                int b = mes + 1;
                mes = b;

            }
            else
            {
                int z = dia + 1;
                dia = z;
            }


           if (mes > 12)

            {
                int c = mes = 1;
                mes = c;
                int d = año + 1;
                año = d;
            }
                      


            {
                String numero;
                
                switch (mes)
                {
                    case 1:
                        numero = "enero";
                        break;
                    case 2:
                        numero = "febrero";
                        break;
                    case 3:
                        numero = "marzo";
                        break;
                    case 4:
                        numero  = "abril";
                        break;
                    case 5:
                        numero = "mayo";
                        break;
                    case 6:
                        numero = "junio";
                        break;
                    case 7:
                        numero = "julio";
                        break;
                    case 8:
                        numero = "agosto";
                        break;
                    case 9:
                        numero = "septiembre";
                        break;
                    case 10:
                        numero = "octubre";
                        break;
                    case 11:
                        numero = "noviembre";
                        break;
                    case 12:
                       numero = "diciembre";
                        break;



                    default:
                        numero = "error";
                        break;
                }

                Console.WriteLine("El dia de mañana es: " + dia + " de " + numero + " de " + año);


            }


        }
    }
}

    

