using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_4_POO
{
    public class Empaque: Maquina
    {
        public override void Encendido()
        {
            Console.WriteLine("Empaque esta funcionando...");

        }
        public override void Reiniciar(int memoria)
        {
            memoria = 0;
            Console.WriteLine("");
            Console.WriteLine("Memoria llena de Empaque");
            Console.WriteLine("Reiniciando...");
            Console.WriteLine("Memoria reiniciada");
        }

        public override void Apagar()
        {
            Console.WriteLine("Apagando equipo");
        }
    }
}
