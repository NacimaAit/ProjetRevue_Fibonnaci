using System;


namespace ProjetRevue_Fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserer le nombre de termes à calculer");
            int n=Convert.ToInt32(Console.ReadLine());
            /* if (n == 0)
             {
                 Console.WriteLine("Suite : 0");
             }
             else if (n == 1)
             {
                 Console.WriteLine("Suite : 0, 1");
             }
             else {
                 Console.Write("Suite : 0, 1");
                 long t0 = 0;
                 long t1 = 1;
                 for (int i = 0; i < n-2; i++)
                 {
                     long ti = t0 + t1;
                     t0 = t1;
                     t1 = ti;
                     Console.Write(", " + ti);
                 }
                 Console.WriteLine();
             }*/

            Console.WriteLine("Methode Reccursive");
            var watchRec = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
           
            for (int i = 0; i < n; i++) {
                Console.Write(fib_reccursive(i)+ ", ");

            }

            watchRec.Stop();
            var elapsedMsRec = watchRec.ElapsedMilliseconds;     

            Console.WriteLine();

            Console.WriteLine("Temps d'execution : " + elapsedMsRec);

            Console.WriteLine("Methode avec boucle");
            var watchBoucle = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < n; i++)
            {
                Console.Write(fib_boucle(i) + ", ");
            }


            watchBoucle.Stop();
            var elapsedMsBoucle = watchBoucle.ElapsedMilliseconds;

            Console.WriteLine();

            Console.WriteLine("Temps d'execution en milisecondes: " + elapsedMsBoucle);

            Console.ReadKey();
        }

        static long fib_reccursive(int n) {
            if (n == 0) {
                return 0;
            }
            if (n == 1) {
                return 1;
            }
            return (fib_reccursive(n - 1) + fib_reccursive(n - 2));
        }

        static long fib_boucle(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                long t0 = 0;
                long t1 = 1;
                long ti =0;
                for (int i = 0; i < n-1; i++)
                {
                    ti = t0 + t1;
                    t0 = t1;
                    t1 = ti;
                    
                }
                return ti;
                
            }
        }
    }
}

/*Notée {\displaystyle (F_{n})}(F_{n}), elle est définie par {\displaystyle F_{0}=0,\quad F_{1}=1}{\displaystyle F_{0}=0,\quad F_{1}=1}, 
 * et {\displaystyle F_{n}=F_{n-1}+F_{n-2}}{\displaystyle F_{n}=F_{n-1}+F_{n-2}} pour {\displaystyle n\geqslant 2}{\displaystyle n\geqslant 2}.*/