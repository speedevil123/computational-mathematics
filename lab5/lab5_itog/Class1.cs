using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

public class Program
{
    public static void Main(string[] args)
    {
        double F_exact = 0.160603;
        Console.WriteLine("Точное значение интеграла: {0}", F_exact);
        Console.WriteLine();

        double a = 0;
        double b = 1;
        double e = 0.001;

        // Формула трапеций
        Console.WriteLine("Формула трапеций:");
        int N = 2;
        int k = 0;
        double s = 0;
        double F0 = 0;
        List<double> F_list = new List<double>();
        while (true)
        {
            double tay = (b - a) / N;
            for (int i = 0; i <= N; i++)
            {
                double t = a + (k * tay);
                double f = Math.Pow(t,2) * Math.Exp(-t);
                if (i != 0 && i != N)
                {
                    s += 2 * f;
                }
                else
                {
                    s += f;
                }
                k++;
            }
            double F = (tay / 2) * s;
            Console.WriteLine("N = {0}: {1}", N, F);
            F_list.Add(F);
            N += 1;
            if (Math.Abs(F0 - F) < e)
            {
                break;
            }
            F0 = F;
            s = 0;
            k = 0;
        }

        Console.WriteLine("Погрешности:");
        for (int i = 0; i < F_list.Count - 1; i++)
        {
                Console.WriteLine("e{1} = {2}", i + 2, i + 1, Math.Abs(F_list[i+1] - F_list[i]));

        }
        Console.WriteLine();
        Console.WriteLine();

        // Формула Симпсона
        Console.WriteLine("Формула Симпсона:");
        N = 2;
        k = 0;
        s = 0;
        F0 = 0;
        F_list = new List<double>();
        while (true)
        {
            double tay = (b - a) / N;
            for (int i = 0; i <= N; i++)
            {
                double t = a + (k * tay);
                double f = Math.Pow(t, 2) * Math.Exp(-t);
                if (i != 0 && i != N)
                {
                    if (i % 2 != 0)
                    {
                        s += 4 * f;
                    }
                    else
                    {
                        s += 2 * f;
                    }
                }
                else
                {
                    s += f;
                }
                k++;
            }
            double F = (tay / 3) * s;
            Console.WriteLine("N = {0}: {1}", N, F);
            F_list.Add(F);
            N += 2;
            if (Math.Abs(F0 - F) < e)
            {
                break;
            }
            F0 = F;
            s = 0;
            k = 0;
        }

        Console.WriteLine("Погрешности:");
        for (int i = 0; i < F_list.Count - 1; i++)
        {
            Console.WriteLine("e{1} = {2}", i * 2 + 2, i + 1, Math.Abs(F_list[i+1] - F_list[i]));
        }
        Console.WriteLine();
    }
}

