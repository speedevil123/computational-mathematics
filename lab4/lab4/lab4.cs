using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace lab4
{
    class Program
    {
        static double f(double x)
        {
            return Math.Pow(Math.E, 0.5 * Math.Log(1 + x * x));
        }

        static void fx()
        {
            double count = 0;
            for (int i = 1; i < 12; i++)
            {                
                double x = Math.PI * Math.Sqrt(count);
                double fx = Math.Asin(Math.Pow(Math.Cos(x), 2));
                Console.WriteLine($"f([{Program.exchange(count)}]) = {fx,5}");
                count += 0.1;
            }
        }

        static double[] f(double x0, double xn, int n, double step = 1, double h0 = -1)
        {
            double h = (h0 == -1 ? 1.0 / n : h0);
            double[] R = new double[n + 1];
            for (double i = 1, ti = (i - step) * h; ti <= xn; i++, ti = (i - step) * h)
                R[(int)(i - 1)] = f(ti);

            return R;
        }

        static double eps(double fx, double Nx)
        {
            return Math.Abs(fx - Nx);
        }

        static string exchange(double number)
        {
            return number.ToString("F1", System.Globalization.CultureInfo.InvariantCulture);
        }

        static double N(double t, int n, bool flag)
        {
            double[][] args = new double[n + 1][];
            args[0] = f(0.0, 1.0, n);
            double N = args[0][0];
            for (int i = 1; i < n + 1; i++)
            {
                args[i] = new double[n + 1 - i];
                double count = 0;
                for (int j = 0; j < n + 1 - i; j++)
                {
                    args[i][j] = (args[i - 1][j + 1] - args[i - 1][j]) / (0.1 * i);
                    if(flag)
                    {
                        if (i == 1)
                            Console.WriteLine($"f([{Program.exchange(count)} , {Program.exchange(count + 0.1)}]) = {args[i][j]}");
                        if (i == 2)
                        {
                            Console.WriteLine($"f([{Program.exchange(count)} , {Program.exchange(count + 0.1)} , " +
                                $"{Program.exchange(count + 0.2)}]) = {args[i][j]}");
                        }
                        if (i == 3)
                        {
                            Console.WriteLine($"f([{Program.exchange(count)} , {Program.exchange(count + 0.1)} , {Program.exchange(count + 0.2)} , " +
                                $"{Program.exchange(count + 0.3)}]) = {args[i][j]}");
                        }
                        //fff
                        if (i == 4)
                        {
                            Console.WriteLine($"f([{Program.exchange(count)} , {Program.exchange(count + 0.1)} , {Program.exchange(count + 0.2)} , " +
                                $"{Program.exchange(count + 0.3)} , {Program.exchange(count + 0.4)}]) = {args[i][j]}");
                        }
                        if (i == 5)
                        {
                            Console.WriteLine($"f([{Program.exchange(count)} , {Program.exchange(count + 0.1)} , {Program.exchange(count + 0.2)} , " +
                                $"{Program.exchange(count + 0.3)} , {Program.exchange(count + 0.4)} , {Program.exchange(count + 0.5)}]) = {args[i][j]}");
                        }
                        if (i == 6)
                        {
                            Console.WriteLine($"f([{Program.exchange(count)} , {Program.exchange(count + 0.1)} , {Program.exchange(count + 0.2)} , " +
                                $"{Program.exchange(count + 0.3)} , {Program.exchange(count + 0.4)} , {Program.exchange(count + 0.5)} , " +
                                $"{Program.exchange(count + 0.6)}]) = {args[i][j]}");
                        }
                        if (i == 7)
                        {
                            Console.WriteLine($"f([{Program.exchange(count)} , {Program.exchange(count + 0.1)} , {Program.exchange(count + 0.2)} , " +
                                $"{Program.exchange(count + 0.3)} , {Program.exchange(count + 0.4)} , {Program.exchange(count + 0.5)} , " +
                                $"{Program.exchange(count + 0.6)} , {Program.exchange(count + 0.7)}]) = {args[i][j]}");
                        }
                        if (i == 8)
                        {
                            Console.WriteLine($"f([{Program.exchange(count)} , {Program.exchange(count + 0.1)} , {Program.exchange(count + 0.2)} , " +
                                $"{Program.exchange(count + 0.3)} , {Program.exchange(count + 0.4)} , {Program.exchange(count + 0.5)} , " +
                                $"{Program.exchange(count + 0.6)} , {Program.exchange(count + 0.7)} , {Program.exchange(count + 0.8)}]) = {args[i][j]}");
                        }
                        if (i == 9)
                        {
                            Console.WriteLine($"f([{Program.exchange(count)} , {Program.exchange(count + 0.1)} , {Program.exchange(count + 0.2)} , " +
                                $"{Program.exchange(count + 0.3)} , {Program.exchange(count + 0.4)} , {Program.exchange(count + 0.5)} , " +
                                $"{Program.exchange(count + 0.6)} , {Program.exchange(count + 0.7)} , {Program.exchange(count + 0.8)} , " +
                                $"{Program.exchange(count + 0.9)}]) = {args[i][j]}");
                        }
                        if (i == 10)
                        {
                            Console.WriteLine($"f([{Program.exchange(count)} , {Program.exchange(count + 0.1)} , {Program.exchange(count + 0.2)} , " +
                                $"{Program.exchange(count + 0.3)} , {Program.exchange(count + 0.4)} , {Program.exchange(count + 0.5)} , " +
                                $"{Program.exchange(count + 0.6)} , {Program.exchange(count + 0.7)} , {Program.exchange(count + 0.8)} , " +
                                $"{Program.exchange(count + 0.9)} , {Program.exchange(count + 1.0)}]) = {args[i][j]}");
                        }

                        count += 0.1;
                        if (j == n - i)
                            Console.WriteLine();
                    }
                }

                double mn = 1.0;
                for (int k = 0; k < i; k++)
                    mn *= (t - 0.1 * (k));
                N += mn * args[i][0];
            }

            return N;
        }

        static double[] eps(int n, double x0 = 0.0, double xn = 1.0, double step = 1.0)
        {
            double h = 1.0 / n;
            double[] R = new double[n];
            double[] t = new double[n + 1];

            for (double i = 1, ti = (i - step) * h; ti <= xn; i++, ti = (i - step) * h)
                t[(int)(i - 1)] = ti;

            for (int i = 0; i < n; i++)
            {
                double fti, Nti;
                if (i == 0)
                {
                    fti = f(t[i]);
                    Nti = N(t[i], n, true);
                }
                else
                {
                    fti = f(t[i]);
                    Nti = N(t[i], n, false);
                }

                Console.WriteLine($"t[{i}] = {t[i]}, f(t[{i}]) = {fti}, N(t[{i}]) = {Nti}");
                R[i] = eps(fti, Nti);
            }

            return R;
        }
        static void check()
        {
            double[] f1 = { 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0 };
            double[] f2 = { 0.05, 0.15, 0.25, 0.35, 0.45, 0.55, 0.65, 0.75, 0.85, 0.95 };
            double[] f1x = new double[f2.Count()];
            double[] f2x = new double[f2.Count()];
            double[] eps = new double[f2.Count()];

            for (int i = 0; i < f1.Count() - 1; i++)
            {
                f1x[i] = (f(f1[i]) + f(f1[i + 1])) / 2;
                f2x[i] = f(f2[i]);
                eps[i] = f2x[i] - f1x[i];
                eps[i] = Abs(eps[i]);
            }
            foreach(double epsil in eps)
            { 
                Console.WriteLine(Abs(epsil));
            }
            Console.WriteLine("max = " + Abs(eps.Max()));

            Console.WriteLine("SR = " + Abs(eps.Average()));
            

            

        }

        static void Main(string[] args)
        {

            int n = 10;
            fx();
            Console.WriteLine();
            double[] R = eps(n, 0.0, 1.0, 0.5);
            double maxeps = double.MinValue, sreps = 0;
            Console.WriteLine();
            foreach (double r in R)
            {
                sreps += Math.Pow(r, 2.0) / n;
                if (maxeps < r) maxeps = r;
                Console.WriteLine($"E = {r}");
            }


            Console.WriteLine($"\nEmax = {maxeps}");
            Console.WriteLine($"Eср = {Math.Sqrt(sreps)}");
            check();
        }
    }
}

