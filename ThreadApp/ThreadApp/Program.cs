using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadApp
{
    //   TASK son recomendados. 
    //https://www.youtube.com/watch?v=v3yd_Ctl6PQ&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=113&ab_channel=pildorasinformaticas
    //Curso C#. TASK I. Vídeo 113
    // las task son capaces de gestionar el numero de thread que se utilizan en cada momento. 
    //the tasks are able to manage the number of threads that are used at any given time.
    //Una task es algo futuro o una promesa 
    //Thread es la herramienta para conseguir realizar esa promesa.
    class Program
    {
        
        static async  Task Main(string[] args)
        {

            Task task = new Task(EjecutarTarea);
            task.Start();

            Task task2 = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    var miThread = Thread.CurrentThread.ManagedThreadId;

                    Thread.Sleep(1000);

                    Console.WriteLine($"Tarea  corresponde al Thread : " + miThread + " EJecutandose desde el main");

                }

            });
            task2.Start();
            await task;
            Console.WriteLine("Finished main");

            Console.ReadLine();
        }

        static void EjecutarTarea( )
        {

            for (int i = 0; i < 100; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine($"Esta vuelta de bucle corresponde al Thread : " +miThread);
            }
         

           

           
        }



      
    }
}
