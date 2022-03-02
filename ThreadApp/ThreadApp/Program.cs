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

            
            Thread t = new Thread(secondMeth);
            t.Name = "SecondThread";
            t.Start();

            Thread t2 = new Thread(secondMeth);
            t2.Name = "ThirdThread";
            t2.Start();

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
            Console.ReadLine();
        }
    }
}
