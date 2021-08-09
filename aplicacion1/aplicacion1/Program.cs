using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace aplicacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            string archivo;
            char op = 's';
            int OP = 1;
            while(op=='s')
            {
                Console.Clear();
                Console.WriteLine("Que decea hacer: \n 1.Nombre del archivo \n 2.Salir");
                o = int.Parse(Console.ReadLine());

                if(OP==1)
                {
                    Console.Clear();
                    StreamWrite ar;
                    archivo = Console.ReadLine();
                    Console.WriteLine("Ingrese nombre del archivo: ");
                    ar = File.AppendText(Console.ReadLine()+".txt");
                    ar = File.CreateText(@"C: \Users\Raul Santos Ramirez\Desktop\Trabajos de Lourdes\Programacion\zCuarta Unidad");
                    ar.Close();
                }
                if (OP == 2)
                {
                    Console.WriteLine("Usted a salido");

                }

                Console.Clear();
                Console.WriteLine("Desea Continuar ['s/n']");
                op = char.Parse(Console.ReadLine());

            }

            Console.ReadKey();
        }
    }
}
