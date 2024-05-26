using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace lab2
{
    internal class Class1
    {
        class Sum
        {
            //Суммы несвободных членов
            public static double standart_sum(double[] x, int n, int pow)
            {
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += Math.Pow(x[i], pow);
                }
                return sum;
            }

            //Суммы свободных членов
            public static double multiply_sum(double[] x, double[] f_x, int n, int pow)
            {
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += (f_x[i] * Math.Pow(x[i], pow));
                }
                return sum;
            }
        }
        class Matr
        //свободный член фикс
        {
            public static double[,] make_matrix(double[] x, double[] f_x, int n, int p)
            {
                double[,] matrix = new double[p + 1, p + 2];

                //Степень несвободных/свободных членов
                int pow = 0, pow_fx = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    pow_fx = i;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        pow = j + i;
                        //Если достигнут свободный член, то используется другая сумма
                        if (j == p + 1)
                        {
                            matrix[i, j] = Sum.multiply_sum(x, f_x, n, pow_fx);
                        }
                        else
                            matrix[i, j] = Sum.standart_sum(x, n, pow);
                    }
                }
                return matrix;

            }

            public static void GaussWithHighestElem(double[,] matr)
            {
                double[,] matrix = matr;
                int n = 5;

                for (int i = 0; i < n; i++)
                {
                    int maxRow = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (Math.Abs(matrix[j, i]) > Math.Abs(matrix[maxRow, i]))
                        {
                            maxRow = j;
                        }
                    }

                    for (int j = i + 1; j < n; j++)
                    {
                        double factor = matrix[j, i] / matrix[i, i];
                        for (int k = i; k <= n; k++)
                        {
                            matrix[j, k] -= factor * matrix[i, k];
                        }
                    }
                }

                double[] solution = new double[n];
                for (int i = n - 1; i >= 0; i--)
                {
                    solution[i] = matrix[i, n];
                    for (int j = i + 1; j < n; j++)
                    {
                        solution[i] -= matrix[i, j] * solution[j];
                    }
                    solution[i] /= matrix[i, i];
                }

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("x{0} = {1}", i + 1, solution[i]);
                }

            }
        }
        class ShowMatr
        {
            public static void ShowMatrix(double[,] matr)
            {
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        Console.Write(Math.Round(matr[i, j], 1) + "\t|");
                    }
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------");
                }
            }
        }

        class MainClass
        {
            static void Main()
            {
                double[] i = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                double[] x = new double[] { 0.248, 0.584, 0.921, 1.257, 1.593, 1.930, 2.266, 2.603, 2.939 };
                double[] f_x = new double[] { 0.716, -1.760, -1.108, 0.190, 0.673, -0.114, -1.605, -2.226, 0.614 };
                int n = 9;
                int p = 4;

                double[,] matr = Matr.make_matrix(x, f_x, n, p);

                ShowMatr.ShowMatrix(matr);
                Matr.GaussWithHighestElem(matr);

            }
        }
    }
}
