using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computador.Entidades
{
    class ClsComputador
    {
        // Partes internas de una computadora 

        private String placa_madre;
        private String micro_procesador;
        private int memoria_Ram;
        private int disco_duro;
        private String targeta_de_video;
        private String fuente_de_poder;
        private String lector_optico;

        // partes externas de una computadora

        private String marca;
        private String color;
        private String teclado;
        private String mouse;
        private String pantalla;

        public string Placa_madre { get => placa_madre; set => placa_madre = value; }
        public string Micro_procesador { get => micro_procesador; set => micro_procesador = value; }
        public int Memoria_Ram { get => memoria_Ram; set => memoria_Ram = value; }
        public int Disco_duro { get => disco_duro; set => disco_duro = value; }
        public string Targeta_de_video { get => targeta_de_video; set => targeta_de_video = value; }
        public string Fuente_de_poder { get => fuente_de_poder; set => fuente_de_poder = value; }
        public string Lector_optico { get => lector_optico; set => lector_optico = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public string Teclado { get => teclado; set => teclado = value; }
        public string Mouse { get => mouse; set => mouse = value; }
        public string Pantalla { get => pantalla; set => pantalla = value; }
    }
}
