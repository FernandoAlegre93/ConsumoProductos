using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3_TP3
{
    class Program
    {
        static void Main(string[] args)
        {

            string Producto =  "x";
            int contx = 0, conty = 0, contam=0, contnin= 0,i;
            double porcx, porcy,porn,poram;

            for (i=1;i<=5;i++)
               {  Console.WriteLine("¿Que producto consume usted, X,Y, ambos o ninguno?");
               Producto = Convert.ToString(Console.ReadLine());
                
           switch (Producto)
           {
               case "x":
                   contx= contx +1;
                   break;
               case "y":
                   conty=conty+1;
                   break;
               case "ambos":
                   contam=contam +1;
                   break;
              
               default:
                  
                       contnin= contnin+1;
                       break;
           
           }
            }
                porcx= (contx*100)/20;
                porcy= (conty*100)/20;
                poram= (contam*100)/20;
                porn= (contnin*100)/20;

                Console.WriteLine("El porcentaje de los que consumen X es: {0}%",porcx);
                Console.WriteLine("El porcentaje de los que consumen Y es: {0}%",porcy);
                Console.WriteLine("El porcentaje de los que consumen ambos es: {0}%",poram);
                Console.WriteLine("El porcentaje de los que no consumen ningun producto es: {0}%",porn);
                Console.ReadKey();




        }
    }
}

        