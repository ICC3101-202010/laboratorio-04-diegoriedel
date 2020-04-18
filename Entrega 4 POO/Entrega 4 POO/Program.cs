using System;

namespace Entrega_4_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Reception q = new Reception();
            q.Encendido();
            int a = 10;
            q.Reiniciar(a);
            int que_hacer = 0;
            int mem_recepcion = 0;
            int mem_almacenamiento = 0;
            int encendidas = 0;

            while (que_hacer!=4)
            {
                Console.WriteLine("");
                Console.WriteLine("Bienvenido a la fabrica");
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("1) Encender todas las maquinas");
                Console.WriteLine("2) Comenzar funcionamiento de las maquinas");
                Console.WriteLine("3) Apagar todas las maquinas");
                Console.WriteLine("4) Salir de la fabrica");
                que_hacer = Convert.ToInt32(Console.ReadLine());
               
                if (que_hacer > 4) 
                {
                    Console.WriteLine("Numero no valido");
                    Console.WriteLine("");
                }
                if (que_hacer == 1)
                {
                    Reception rec = new Reception();
                    rec.Encendido();
                    Almacenamiento alm = new Almacenamiento();
                    alm.Encendido();
                    encendidas = 1;

                }
                else if (que_hacer == 2)
                {
                    if (encendidas == 1)
                    {
                        mem_recepcion = mem_recepcion + 1;
                        Console.WriteLine("Capacidad de recepcion: " + mem_recepcion+"/3");
                        mem_almacenamiento = mem_almacenamiento + 1;
                        Console.WriteLine("Capacidad de almacenamiento: " + mem_almacenamiento + "/4");
                        if (mem_recepcion == 3)
                        {
                            Reception re = new Reception();
                            re.Reiniciar(mem_recepcion);
                            mem_recepcion = 0;
                        }
                        if (mem_almacenamiento == 4)
                        {
                            Almacenamiento re = new Almacenamiento();
                            re.Reiniciar(mem_almacenamiento);
                            mem_almacenamiento = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Estan apagadas las maquinas");
                    }
                }
                else if (que_hacer == 3)
                {
                    encendidas = 0;

                }
                else if (que_hacer == 4)
                {
                    Console.WriteLine("Muchas gracias por venir...");
                    Console.WriteLine("Saliendo de las fabrica");
                }
            }
        }
    }
}
