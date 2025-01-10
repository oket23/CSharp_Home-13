using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_13
{
    public partial class task1Form : Form
    {
        private mainMenu menu;
        public task1Form(mainMenu mainMenu)
        {
            menu = mainMenu;
            InitializeComponent();
        }

        private void task1Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            menu.Show();
            Hide();
        }



        private void generateButton_Click(object sender, EventArgs e)
        {
            GenerateNumbesr();
            

        }

        private void GenerateNumbesr()
        {
            string primePath = Path.Combine("Task_1", "PrimeNumbers.txt");
            string fibsPath = Path.Combine("Task_1", "FibonacciNumbers.txt");

            Directory.CreateDirectory("Task_1");

            allNumbersRtb.Clear();
            primeNumbersRtb.Clear();
            fibonacciNumbersRtb.Clear();
            statsRtb.Clear();

            List<int> numbers = new List<int>(100);
            List<int> primes = new List<int>(100);
            List<int> fibs = new List<int>(100);

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(new Random().Next(1, 1001));
                allNumbersRtb.Text += numbers[i].ToString() + " ";
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (IsPrime(numbers[i]))
                {
                    primes.Add(numbers[i]);

                }
                if (IsFibonacci(numbers[i]))
                {
                    fibs.Add(numbers[i]);
                }
            }

            for (int i = 0; i < primes.Count; i++)
            {
                primeNumbersRtb.Text += primes[i].ToString() + " ";
            }
            for (int i = 0; i < fibs.Count; i++)
            {
                fibonacciNumbersRtb.Text += fibs[i].ToString() + " ";
            }

            statsRtb.Text = $"Total numbers: {numbers.Count}\nPrime numbers generated: {primes.Count}\nFibonacci numbers generated: {fibs.Count}\nFiles save in bin\\Debug\\net8.0-windows\\Task_1\\";

            using (var fr = new FileStream(primePath, FileMode.Create, FileAccess.Write))
            {
                using(var sw = new StreamWriter(fr))
                {
                    foreach(int i in primes)
                    {
                        sw.Write(i.ToString() + " ");
                    }
                }
            }
            using (var fr = new FileStream(fibsPath, FileMode.Create, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fr))
                {
                    foreach (int i in fibs)
                    {
                        sw.Write(i.ToString() + " ");
                    }
                }
            }

        }
        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        private bool IsFibonacci(int number)
        {
            if (number < 0) return false;

            return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4);
        }
        private bool IsPerfectSquare(int number)
        {
            int sqrt = (int)Math.Sqrt(number);
            return sqrt * sqrt == number;
        }

    }
}
