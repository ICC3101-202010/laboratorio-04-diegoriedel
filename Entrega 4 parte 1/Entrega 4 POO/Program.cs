using System;

namespace Entrega_4_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int que_hacer = 0;
            int mem_recepcion = 0;
            int mem_almacenamiento = 0;
            int mem_ensa = 0;
            int mem_cal = 0;
            int mem_emp = 0;

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
                    Ensamblaje en = new Ensamblaje();
                    en.Encendido();
                    Calidad cal = new Calidad();
                    cal.Encendido();
                    Empaque em = new Empaque();
                    em.Encendido();
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
                        mem_ensa = mem_ensa + 1;
                        Console.WriteLine("Capacidad de Ensamblaje: " + mem_ensa + "/5");
                        mem_cal = mem_cal + 1;
                        Console.WriteLine("Capacidad de verificacion de calidad: " + mem_cal + "/4");
                        mem_emp = mem_emp + 1;
                        Console.WriteLine("Capacidad de empaque: " + mem_emp + "/9");


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
                        if (mem_ensa == 5)
                        {
                            Ensamblaje en = new Ensamblaje();
                            en.Reiniciar(mem_ensa);
                            mem_ensa = 0;
                        }
                        if (mem_cal == 4)
                        {
                            Calidad cal = new Calidad();
                            cal.Reiniciar(mem_cal);
                            mem_cal = 0;
                        }
                        if (mem_emp == 9)
                        {
                            Empaque em = new Empaque();
                            em.Reiniciar(mem_emp);
                            mem_emp = 0;
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
                    Console.WriteLine("Todas las maquinas apagadas");

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
