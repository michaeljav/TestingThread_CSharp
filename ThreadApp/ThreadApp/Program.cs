using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadApp
{
    //   Parallel.for
    //https://www.youtube.com/watch?v=Gl-DQxoDtZ4&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=118&ab_channel=pildorasinformaticas
    //Curso C#. Cancelación de Task. Vídeo 117
    //cacelation of task

    class Program
    {
        private static int accumulador = 0;
        static async  Task Main(string[] args)
        {
            /*tESTING THE RETURN AND BREAK*/
            /* for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("inside for");
                if (i == 0)
                {
                    //BREAK GO OUT FROM THE BLOCK AND CONTINUE THE EXECUTION
                    //RETURN GO OUT FROM THE FUNCTION.
                    break;
                }
                Console.WriteLine("after if");

            }
            Console.WriteLine("after for");
            */

            //CancellationTokenSource object points to the token that should interrupt the task
            CancellationTokenSource PointerToCancelTask = new CancellationTokenSource();

            //CancellationToken object that cancel the task or thread
            CancellationToken cancellationToken = PointerToCancelTask.Token;


            Task tarea = Task.Run(() => EjecutarTarea(cancellationToken));


            for (int i = 0; i < 100; i++)
            {
                accumulador += 30;

                Thread.Sleep(1000);

                if (accumulador > 100)
                {
                   PointerToCancelTask.Cancel();

                    break;
                }
            }

            Thread.Sleep(1000);

            Console.WriteLine("Valor del acumulador: " + accumulador);

            Console.ReadLine();
        }


      
        static void EjecutarTarea( CancellationToken tokenCancelation )
        {
            for (int i = 0; i < 100; i++)
            {
                accumulador++;
                var threadId = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine($"Ejecutando tarea el thread: {threadId}");

                Console.WriteLine(accumulador);
                //if this token received a canceletion request 
                if (tokenCancelation.IsCancellationRequested)
                {
                    accumulador = 0;
                    return;                   
                }
            }

            
           

           
                    
        }

      





    }
}
