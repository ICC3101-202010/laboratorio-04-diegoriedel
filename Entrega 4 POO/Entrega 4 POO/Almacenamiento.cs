﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_4_POO
{
    public class Almacenamiento : Maquina
    {


        public override void Encendido()
        {
            Console.WriteLine("Almacenamiento esta funcionando...");

        }
        public override void Reiniciar(int memoria)
        {
            memoria = 0;
            Console.WriteLine("Memoria llena de almacenamiento");
            Console.WriteLine("Reiniciando...");
            Console.WriteLine("Memoria reiniciada");
        }

        public override void Apagar()
        {
            Console.WriteLine("Apagando equipo");
        }
    }
}
