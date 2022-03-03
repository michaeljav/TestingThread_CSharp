using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadApp
{
    // WITHOUT  ThreadPool 
    //https://www.youtube.com/watch?v=2qeDlKUsGLA&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=112&ab_channel=pildorasinformaticas
    //Curso C#. Threads V. ThreadPool. Vídeo 112
    //Al utilizar  threadpool  le creamos dentro  3 thread  y tenemos 5 tareas a realizar el  threadpool 
    //se encarga  de que cuando un thread termina de realizar su tarea el automaticamente reutiliza ese thread para comanzar a realizar la tarea siguiente.
    //y podrimos reutilizar esos thread cuando terminen con otras tareas. siempre un threadpool va a consumir menos recurso.  Nota: al utilizar solo thread, se le asignaba un thread a cada tarea.

    class Program
    {
        public static int v;
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 500; i++)
            {
                v = i;
                Thread t = new Thread(EjecutarTarea);
                t.Start();
            }

            Console.WriteLine();
        }

        static void EjecutarTarea()
        {
            Console.WriteLine($"Thread n: {Thread.CurrentThread.ManagedThreadId} ha comenzado su tarea  HiloCount: {v}");

            Thread.Sleep(1000);

            Console.WriteLine($"Thread n: {Thread.CurrentThread.ManagedThreadId} ha terminado su tarea HiloCount: {v} ");
        }



      
    }
}
