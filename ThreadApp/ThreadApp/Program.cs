using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //sync (join) and lock (lock) threads

            Thread t = new Thread(secondMeth);
            t.Name = "SecondThread";
            t.Start();
            t.Join();

            Thread t2 = new Thread(secondMeth);
            t2.Name = "ThirdThread";
            t2.Start();
            t2.Join();

            Console.WriteLine("Main Method " + Environment.ProcessorCount);
            Console.WriteLine("Hi michael "+Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);
            Console.WriteLine("Hi michael " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);
            Console.WriteLine("Hi michael " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);
            Console.WriteLine("Hi michael " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);
            Console.WriteLine("Hi michael " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);           
            Console.ReadLine();

        }

        static void secondMeth()
        {
            Console.WriteLine("Second Method " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Hi michael " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);
            Console.WriteLine("Hi michael " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);
            Console.WriteLine("Hi michael " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);
            Console.WriteLine("Hi michael " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);
            Console.WriteLine("Hi michael " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);
            
        }
    }
}
