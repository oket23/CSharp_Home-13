namespace Home_13
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void task1Button_Click(object sender, EventArgs e)
        {
            task1Form taks1 = new task1Form(this);
            SwapForm(taks1);
        }
        private void task2Button_Click(object sender, EventArgs e)
        {
            task2Form taks2 = new task2Form(this);
            SwapForm(taks2);
        }
        private void task3Button_Click(object sender, EventArgs e)
        {
            task3Form taks3 = new task3Form(this);
            SwapForm(taks3);
        }
        private void task4Button_Click(object sender, EventArgs e)
        {
            task4Form taks4 = new task4Form(this);
            SwapForm(taks4);
        }
        private void task5Button_Click(object sender, EventArgs e)
        {
            task5Form taks5 = new task5Form(this);
            SwapForm(taks5);
        }



        private void SwapForm(Form form)
        {
            form.Show();
            Hide();
        }


    }
}
