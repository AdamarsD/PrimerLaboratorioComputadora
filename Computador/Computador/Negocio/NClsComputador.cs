using Computador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computador.Negocio
{
    class NClsComputador
    {

        public String Encender(ClsComputador computador)
        {
            return " La computadora con memoria RAM de " + computador.Memoria_Ram + " Con micro procesador " + computador.Micro_procesador + " Esta encendida ";
        }

        public String Apagar(ClsComputador computador)
        {
            return " La computadora con memoria RAM de " + computador.Memoria_Ram + " Con micro procesador " + computador.Micro_procesador + " Apagando computadora ";
        }

        public String periferico(ClsComputador computador)
        {
            return " La computadora con memoria RAM de " + computador.Memoria_Ram + " Con micro procesador " + computador.Micro_procesador + " Mouse conectado ";
        }

        public String Reiniciar(ClsComputador computador)
        {
            return " La computadora con memoria RAM de " + computador.Memoria_Ram + " Con micro procesador " + computador.Micro_procesador + " Reiniciando computadora ";
        }

    }
}
