using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadApp
{
    //   TASK waitAll, waitANy, wait
    //https://www.youtube.com/watch?v=x0gO4FoLJgg&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=114&ab_channel=pildorasinformaticas
    //Curso C#. TASK III. Vídeo 115
    //

    class Program
    {
        
        static async  Task Main(string[] args)
        {

            RealizarTodasTareas();

            Console.ReadLine();
        }


        static void RealizarTodasTareas()
        {
          var task = Task.Run(() =>
            {
              EjecutarTarea();
            });
            task.Wait();
         var task2 = Task.Run(() =>
            {
              EjecutarTarea2();
            });

           
         var task3 = Task.Run(() =>
            {
              EjecutarTarea3();
            });
          
          
         
        }
        static void EjecutarTarea()
        {

            for (int i = 0; i < 5; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine($"Esta vuelta de bucle corresponde tarea 1");
            }
                    
        }

        static void EjecutarTarea2()
        {

            for (int i = 0; i < 5; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(500);

                Console.WriteLine($"Esta vuelta de bucle corresponde  tarea 2");
            }

        }

        static void EjecutarTarea3()
        {

            for (int i = 0; i < 5; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(500);

                Console.WriteLine($"Esta vuelta de bucle corresponde  tarea 3");
            }

        }





    }
}
