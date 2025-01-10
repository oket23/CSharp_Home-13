using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Home_13
{
    public partial class task5Form : Form
    {
        mainMenu menu;
        public task5Form(mainMenu mainMenu)
        {
            menu = mainMenu;
            InitializeComponent();
        }

        private void task5Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            menu.Show();
            Hide();
        }

        private void generateNumBtn_Click(object sender, EventArgs e)
        {
            generateNumRtb.Clear();

            int addCounter = 0;
            int negativeCounter = 0;
            int twoDigitCounter = 0;
            int fiveDigitCouter = 0;

            int[] numbers = new int[100000];
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();
            StringBuilder addNumbers = new StringBuilder();
            StringBuilder negativeNumbers = new StringBuilder();
            StringBuilder twoDigitNumbers = new StringBuilder();
            StringBuilder fiveDigitNumbers = new StringBuilder();

            string path = Path.Combine("Task_5", "task5Text.txt");
            string addPath = Path.Combine("Task_5", "addNumbers.txt");
            string negativePath = Path.Combine("Task_5", "negativeNumbers.txt");
            string twoDigitPath = Path.Combine("Task_5", "twoDigitNumbers.txt");
            string fiveDigitPath = Path.Combine("Task_5", "fiveDigitNumbers.txt");
            Directory.CreateDirectory("Task_5");
            FileInfo fileInfo = new FileInfo(path);

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-100000, 100000);
                sb.Append(numbers[i]).Append(" ");
                if (numbers[i] > 0)
                {
                    addCounter++;
                    addNumbers.Append(numbers[i]).Append(" ");
                }
                else if (numbers[i] < 0)
                {
                    negativeCounter++;
                    negativeNumbers.Append(numbers[i]).Append(" ");
                }
                if (CountDigit(numbers[i]) == 2)
                {
                    twoDigitCounter++;
                    twoDigitNumbers.Append(numbers[i]).Append(" ");
                }
                if (CountDigit(numbers[i]) == 5)
                {
                    fiveDigitCouter++;
                    fiveDigitNumbers.Append(numbers[i]).Append(" ");
                }

                
            }

            using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(sb.ToString());
                }
            }

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    generateNumRtb.Text = sr.ReadToEnd();
                }
            }

            using (var fs = new FileStream(addPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(addNumbers.ToString());
                }
            }
            using (var fs = new FileStream(negativePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(negativeNumbers.ToString());
                }
            }
            using (var fs = new FileStream(twoDigitPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(twoDigitNumbers.ToString());
                }
            }
            using (var fs = new FileStream(fiveDigitPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(fiveDigitNumbers.ToString());
                }
            }

            statsRtb.Text = $"Add numbers: {addCounter}" +
                $"\nNegative numbers: {negativeCounter}" +
                $"\nTwo digit numbers: {twoDigitCounter}" +
                $"\nFive digit numbers: {fiveDigitCouter}" +
                $"\nAll files with numbers saved in {fileInfo.Directory}";
        }

        private int CountDigit(int number)
        {
            return (number == 0) ? 1 : (int)Math.Log10(Math.Abs(number)) + 1;
        }
    }
}
