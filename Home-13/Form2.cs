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
            allNumbersRtb.Clear();
            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(1, 1001);
                allNumbersRtb.Text += numbers[i].ToString() + " ";
            }


        }

        private void allNumbersRtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
