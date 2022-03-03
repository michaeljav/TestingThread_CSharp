using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadApp
{
    //https://www.youtube.com/watch?v=2YCIAYk63ns&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=111&ab_channel=pildorasinformaticas
    //usando  el TaskCompletionSouce para  que una tarea comienze siempre y cuando las anteriores hayan terminado su trabajo.    Curso C#. Threads IV. Tareas completadas. Vídeo 111
    //TaskCompletionSouce es como una condicion. El siguiente  hilo se ejecutara siempre y cuando los anteriores hilos hayan termiando su tarea.
    //cuando se esta manjeando socket (minetras el socket no se haya cerrado no realice otro) o conexciones de base de datos (mientras este la conexion con la base de datos no realice otra tarea) 
    class Program
    {
        static void Main(string[] args)
        {

            var tareaTerminada = new TaskCompletionSource<bool>();

            var hilo1 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 1");
                    Thread.Sleep(1000);
                }

                tareaTerminada.TrySetResult(true);
            });

            var hilo2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 2");
                    Thread.Sleep(1000);
                }

            });

            var hilo3 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 2");
                    Thread.Sleep(1000);
                }
                tareaTerminada.TrySetResult(true);

            });

            hilo1.Start();
            hilo2.Start();
            var resultado = tareaTerminada.Task.Result;
           
            hilo3.Start();

        }

      
    }
}
