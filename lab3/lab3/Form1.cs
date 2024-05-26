using System.Xml.Resolvers;
using static System.Math;
namespace lab3
{
    public partial class Form1 : Form
    {
        double eps = 0.02;
        double a = 6;
        double b = 8.6;
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = a.ToString();
            textBox5.Text = b.ToString();
            textBox6.Text = ((a + b) / 2).ToString();
        }

        public static double fafb(double x)
        {
            return 0.3 * Pow(Cos(x), 2) - Log(x) + 2;
        }

        public static double Proizv1por(double x)
        {
            return -3 * Math.Cos(x) * Math.Sin(x) / 5 - 1 / x;
        }

        public static double Proizv2por(double x)
        {
            return 1 / (x * x) - 3 * (Math.Cos(x) * Math.Cos(x) - Math.Sin(x) * Math.Sin(x)) / 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == string.Empty)
            {
                MessageBox.Show("Задайте точность (eps)");
                return;
            }
            eps = Double.Parse(textBox10.Text);
            double x0 = (a + b) / 2;
            textBox2.Text = Math.Round((fafb(a) * fafb(b)), 3) + " < " + 0;
            textBox4.Text = Math.Round(Proizv1por(3), 1) + " ≠ " + 0 + ", " + Math.Round(Proizv2por(3), 1) + " ≠ " + 0;
            textBox1.Text = Math.Round((fafb(x0) * Proizv2por(x0)), 3) + " > " + 0;

            double xk = 0, xkp1 = 0;
            int count = 0;
            do
            {
                if (count == 0)
                {
                    xk = x0;
                    xkp1 = x0 - fafb(x0) / Proizv1por(x0);
                    count++;
                    continue;
                }
                xk = xkp1;
                xkp1 = xk - fafb(xk) / Proizv1por(xk);
                count++;
            } while (Math.Abs(xkp1 - xk) > eps);
            textBox7.Text = count.ToString();
            textBox8.Text = Math.Round(xk, 4).ToString();
            textBox9.Text = Math.Round(fafb(xk), 4).ToString();



        }
    }
}