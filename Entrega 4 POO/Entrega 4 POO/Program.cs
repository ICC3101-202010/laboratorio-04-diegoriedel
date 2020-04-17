using System;

namespace Entrega_4_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("aa");
            Reception q = new Reception();
            q.Encendido();
            int i = 0;
            Console.WriteLine("1) Encender todas las maquinas");
            int que_hacer = Convert.ToInt32(Console.ReadLine());
            int a = 10;
            q.Reiniciar(a);
        }
    }
}
