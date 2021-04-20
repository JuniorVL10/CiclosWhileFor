using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclosWhileFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //For
            //Parte 1 Valor de la iteracion
            //Parte 2 Condicion
            //Parte 3 aumento o decremento 

            int tabla;
            //int i = 1;*

            Console.WriteLine("Ingrese el numero de la tabla a calcular");
            tabla = int.Parse(Console.ReadLine());

            //Parte 2 
           // while (i <=10)
            //{
             //   Console.WriteLine("" + tabla * i);
             //   i++; //Parte 3
            //}


            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine("" + tabla * i);
            }
            Console.ReadKey();



        }
    }
}
