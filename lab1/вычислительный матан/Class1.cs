using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вычислительный_матан
{
    internal class Class1
    {
        class MatrixTries
        {
            public static void GaussWithHighestElem(double[,] matr)
            {
                double[,] matrix = matr;
                double[] koefs = { matrix[0, 0], matrix[0, 1], matrix[0, 2], matrix[0, 3], matrix[0, 4] };
                int n = 4;

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

                for (int i = 0; i < 4; i++)
                {
                    koefs[i] *= solution[i];
                }

                double sum = 0; ;
                for (int i = 0; i < 4; i++)
                {
                    sum += koefs[i];
                }
                if (sum == koefs.Last())
                {
                    Console.WriteLine("Свободный член: " + sum + " = Свободный член вычисл." + koefs.Last());
                    Console.WriteLine("Проверка прошла успешно!");
                }
                else
                    Console.WriteLine("Проверка провалена." + " " + sum + " != " + koefs.Last());

            }
            public static void SimpleIteration(double[,] matr)
            {
                double[] koefs = { matr[0, 0], matr[0, 1], matr[0, 2], matr[0, 3], matr[0, 4] };
                double[,] C = new double[matr.GetLength(0), matr.GetLength(1) - 1];
                double[,] F = new double[matr.GetLength(0), 1];

                const int F_col = 0;
                const double eps = 0.0001;


                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    for (int j = 0; j < matr.GetLength(1) - 1; j++)
                    {
                        if (i == j)
                            C[i, j] = 0;
                        else
                            C[i, j] = -matr[i, j] / matr[i, i];
                    }
                    F[i, F_col] = matr[i, matr.GetLength(1) - 1] / matr[i, i];
                }

                double[,] X_prev = new double[4, 1];
                double[,] X_next = new double[4, 1];

                for (int i = 0; i < X_prev.GetLength(0); i++)
                {
                    for (int j = 0; j < X_prev.GetLength(1); j++)
                    {
                        X_prev[i, j] = 0;
                    }
                }

                do
                {
                    double[,] temp = X_next;
                    X_next = MatrixMethods.Summa(MatrixMethods.Multiplication(C, X_next), F);
                    X_prev = temp;
  


                } while (MatrixMethods.Raznica(X_next,X_prev) > eps);

                double[] solution = { X_next[0, 0], X_next[1, 0], X_next[2, 0], X_next[3, 0] };
                for(int i = 0; i < 4; i++)
                {
                    Console.WriteLine("x{0} = {1}", i + 1, solution[i]);
                }
                for (int i = 0; i < 4; i++)
                {
                    koefs[i] *= solution[i];
                }

                double sum = 0; ;
                for (int i = 0; i < 4; i++)
                {
                    sum += koefs[i];
                }

                if ((sum - koefs.Last()) < eps)
                {
                    Console.WriteLine("Свободный член: " + sum + " = Свободный член вычисл." + koefs.Last());
                    Console.WriteLine("Проверка прошла успешно!");
                }
                else
                    Console.WriteLine("Проверка провалена." + " " + sum + " != " + koefs.Last());
            }
        }
        class MatrixMethods
        {
            
            public static double Raznica(double[,] matr1, double[,] matr2)
            {
                double max = 0;
                double[,] matr1_copy = new double[matr1.GetLength(0), matr1.GetLength(1)];
                Array.Copy(matr1, matr1_copy, matr1.Length);

                double[,] matr2_copy = new double[matr1.GetLength(0), matr1.GetLength(1)];
                Array.Copy(matr2, matr2_copy, matr2.Length);

                for (int i = 0; i < matr1_copy.GetLength(0); i++)
                {
                    for (int j = 0; j < matr1_copy.GetLength(1); j++)
                    {
                     
                        matr1_copy[i, j] -= matr2_copy[i, j];
                    }
                }

                for(int i = 0; i < matr1_copy.GetLength(0); i++)
                {
                    for(int j = 0; j < matr1_copy.GetLength(1); j++)
                    {
                        if (Math.Abs(matr1_copy[i,j]) > max)
                            max = Math.Abs(matr1_copy[i,j]);
                    }
                }
                return max;
                
            }
            public static double[,] Multiplication(double[,] matr1, double[,] matr2)
            {
                double[,] multmatr = new double[matr1.GetLength(0), matr2.GetLength(1)];

                for (int i = 0; i <matr1.GetLength(0) ; i++)
                {
                    for(int j = 0; j < matr2.GetLength(1); j++)
                    {
                        multmatr[i, j] = 0;
                        for(int k = 0; k < matr1.GetLength(1); k++)
                        {
                            multmatr[i, j] += matr1[i, k] * matr2[k, j];
                        }
                    }
                }
                return multmatr;
            }

            public static double[,] Summa(double[,] matr1, double[,] matr2)
            {
                for(int i = 0; i < matr1.GetLength(0); i++)
                {
                    for (int j = 0; j < matr2.GetLength(1); j++)
                    {
                        matr1[i, j] += matr2[i, j];
                    }
                }
                return matr1;
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
                        Console.Write(Math.Round(matr[i, j], 3) + "\t|");
                    }
                    Console.WriteLine();
                }
            }
        }

        class MainClass
        {
            static void Main()
            {

                double[,] matrix = {
                    {2.998, 0.209, 0.315, 0.281, 0.108},
                    {0.163, 3.237, 0.226, 0.307, 0.426},
                    {0.416, 0.175, 3.239, 0.159, 0.310},
                    {0.287, 0.196, 0.325, 4.062, 0.084}
                };

                Console.WriteLine("Исходная матрица:");
                ShowMatr.ShowMatrix(matrix);

                Console.WriteLine("\nРешение СЛАУ методом Гаусса с выбором главного элемента");
                MatrixTries.GaussWithHighestElem(matrix);
                Console.WriteLine();

                Console.WriteLine("Решение СЛАУ методом простой итерации");
                MatrixTries.SimpleIteration(matrix);

            }
        }
    }
}
