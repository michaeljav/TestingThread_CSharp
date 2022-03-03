using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadApp
{
    //https://www.youtube.com/watch?v=XplEHgqBQhE&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=111&ab_channel=pildorasinformaticas
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria CuentaFamilia = new CuentaBancaria(2000);


            Thread[] hilosPersonas = new Thread[15];

            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(CuentaFamilia.VamosRetirarEfectivo);
                t.Name = i.ToString();
                hilosPersonas[i] = t;
            }
            foreach (Thread t in hilosPersonas) t.Start();

           // Console.ReadLine();

        }

        class CuentaBancaria
        {
            private Object bloquearSaldoPositivo = new object();
            double Saldo { set; get; }
            public CuentaBancaria(double Saldo)
            {
                this.Saldo = Saldo;
            }

            public double RetirarEfectivo(double cantidad)
            {
                if ((Saldo - cantidad) < 0)
                {
                    Console.WriteLine($"I'm sorry ${Saldo} peso in the account left  Hilo: {Thread.CurrentThread.Name}");
                    return Saldo;
                }

                lock (bloquearSaldoPositivo) { 
                    if (Saldo >= cantidad)
                    {
                        Console.WriteLine("Retirado {0} y queda {1} en la cuenta. {2}", cantidad, (Saldo -cantidad), Thread.CurrentThread.Name);
                        Saldo -= cantidad;
                    }

                return Saldo;

                }

            }

            public void VamosRetirarEfectivo()
            {
                Console.WriteLine("Esta sacando dinero el hilo: {0}", Thread.CurrentThread.Name);
                for (int i = 0; i < 4; i++)
                {
                    RetirarEfectivo(500);
                }
               
            }
        }
    }
}
