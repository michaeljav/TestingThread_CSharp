using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadApp
{
    //   TASK Run
    //https://www.youtube.com/watch?v=x0gO4FoLJgg&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=114&ab_channel=pildorasinformaticas
    //Curso C#. TASK II. Vídeo 114
    //manera mas abreviada de crear hilos

    class Program
    {
        
        static async  Task Main(string[] args)
        {

            //Task task = new Task(EjecutarTarea);
            //task.Start();

            Task tarea = Task.Run(() => EjecutarTarea());
            Task tarea2 = Task.Run(() => EjecutarOtraTarea());

            //Task task2 = new Task(() =>
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        var miThread = Thread.CurrentThread.ManagedThreadId;

            //        Thread.Sleep(1000);

            //        Console.WriteLine($"Tarea  corresponde al Thread : " + miThread + " EJecutandose desde el main");

            //    }

            //});
            //task2.Start();
            //await task;
            Console.WriteLine("Finished main");

            Console.ReadLine();
        }

        static void EjecutarTarea( )
        {

            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine($"Esta vuelta de bucle corresponde al Thread : " +miThread);
            }
                    
        }

        static void EjecutarOtraTarea()
        {

            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine($"Esto es otra tareaEsta y esta vuelta de bucle corresponde al Thread : " + miThread);
            }

        }




    }
}
