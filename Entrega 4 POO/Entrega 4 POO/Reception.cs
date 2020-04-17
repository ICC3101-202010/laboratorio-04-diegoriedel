using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_4_POO
{
    public class Reception : Central
    {
        public Reception()
        {
        }

        public int memoria;

        public override void Encendido()
        {
            Console.WriteLine("Reception is working..");

        }
        public override void Reiniciar(int memoria)
        {
            memoria = 0;
            Console.WriteLine("Reiniciando...");
            Console.WriteLine("Memoria reiniciada");
            Console.WriteLine(memoria);
        }

        public override void Apagar()
        {
            throw new NotImplementedException();
        }
    }
}
