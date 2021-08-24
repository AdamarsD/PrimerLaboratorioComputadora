using Computador.Entidades;
using Computador.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computador
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsComputador clscomputador = new ClsComputador();

            NClsComputador nclscomputador = new NClsComputador();

            clscomputador.Memoria_Ram = 16;
            clscomputador.Micro_procesador = " Intel Core i7 dual core @ 3.4EZH ";

            Console.WriteLine(nclscomputador.Encender(clscomputador));
            Console.ReadLine();
        }
    }
}
