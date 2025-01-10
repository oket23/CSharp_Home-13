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
    }
}
