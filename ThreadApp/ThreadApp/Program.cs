using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadApp
{
    //   Parallel.for
    //https://www.youtube.com/watch?v=LwxTVdyUXdM&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=119
    //Curso C#. Clase Parallel. Vídeo 116
    //Crea hilos para poder hacer la tarea mas rapido

    class Program
    {
        private static int accumulador = 0;
        static async  Task Main(string[] args)
        {

            Parallel.For(0, 100, EjecutarTarea);

            Console.ReadLine();
        }


      
        static void EjecutarTarea( int dato )
        {
            Console.WriteLine($"Acumulador vale {accumulador}. Tarea realizada por el hilo {Thread.CurrentThread.ManagedThreadId}");
            if ((accumulador % 2 ) == 0)
            {
                accumulador += dato;
                Thread.Sleep(100);
            }
            else
            {
                accumulador -= dato;
                Thread.Sleep(100);
            }

           
                    
        }

      





    }
}
