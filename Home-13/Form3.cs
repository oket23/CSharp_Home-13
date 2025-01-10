namespace Home_13
{
    public partial class task2Form : Form
    {
        private mainMenu _menu;

        private string _path;
        public task2Form(mainMenu mainMenu)
        {
            _menu = mainMenu;
            InitializeComponent();
        }

        private void task2Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            _menu.Show();
            Hide();
        }

        private void task2Form_Load(object sender, EventArgs e)
        {
            allTextRtb.Clear();

            _path = Path.Combine("Task_2", "task2Text.txt");
            Directory.CreateDirectory("Task_2");

            using (var fs = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        allTextRtb.Text += sr.ReadLine() + Environment.NewLine;
                    }

                }
            }
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            statsRtb.Clear();

            int replaceCount = 0;
            string searchWord = searchTb.Text;
            string replaceWord = replaceTb.Text;
            string punctuation = " ,!:?.;";
            string result = "";

            string[] text = allTextRtb.Text.Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            for(int i =0; i < text.Length; i++)
            {
                string cleanWord = text[i].Trim(punctuation.ToCharArray());
                if (cleanWord.Equals(searchWord, StringComparison.OrdinalIgnoreCase))
                {
                    text[i] = text[i].Replace(cleanWord, replaceWord);
                    replaceCount++;
                    
                }
                result += text[i] + " ";
            }
            statsRtb.Text = $"Word \"{searchWord}\" was replaced by {replaceWord} {replaceCount} times";

            allTextRtb.Clear();

            using (var fs = new FileStream(_path, FileMode.Create, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(result);
                }
            }
            using (var fs = new FileStream(_path, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        allTextRtb.Text += sr.ReadLine();
                    }

                }
            }
        }

    }
}
