using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_4_POO
{
    public class Reception : Maquina
    {
        public Reception()
        {
        }

        public override void Encendido()
        {
            Console.WriteLine("Recepcion esta funcionando...");

        }
        public override void Reiniciar(int memoria)
        {
            memoria = 0;
            Console.WriteLine("");
            Console.WriteLine("Memoria llena de recepcion");
            Console.WriteLine("Reiniciando...");
            Console.WriteLine("Memoria reiniciada");
        }

        public override void Apagar()
        {
            Console.WriteLine("Apagando equipo");
        }
    }
}
