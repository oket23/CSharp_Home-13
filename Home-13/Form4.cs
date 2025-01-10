namespace Home_13
{
    public partial class task3Form : Form
    {
        private mainMenu _menu;
        private string _forbiddenPath;
        private string _textnPath;
        public task3Form(mainMenu mainMenu)
        {
            _menu = mainMenu;
            InitializeComponent();
        }

        private void task3Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backToMenuButton_Click_1(object sender, EventArgs e)
        {
            _menu.Show();
            Hide();
        }

        private void allTextSelectBtn_Click(object sender, EventArgs e)
        {
            allTextRtb.Clear();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _textnPath = openFileDialog.FileName;
                using (var fs = new FileStream(_textnPath, FileMode.Open, FileAccess.Read))
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

        private void forbiddenSelectBtn_Click(object sender, EventArgs e)
        {
            forbiddenWordRtb.Clear();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _forbiddenPath = openFileDialog.FileName;
                using (var fs = new FileStream(_forbiddenPath, FileMode.Open, FileAccess.Read))
                {
                    using (var sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            forbiddenWordRtb.Text += sr.ReadLine();
                        }
                    }
                }
            }
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            statsRtb.Clear();

            int replaceCount = 0;
            string result = "";
            string punctuation = " ,!:?.;";
            string[] banWords = forbiddenWordRtb.Text.Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            string[] words = allTextRtb.Text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                string cleanWords = words[i].Trim(punctuation.ToCharArray());
                for (int j = 0; j < banWords.Length; j++)
                {
                    if (cleanWords.Equals(banWords[j], StringComparison.OrdinalIgnoreCase))
                    {
                        words[i] = words[i].Replace(cleanWords, new string('*', banWords[j].Length));
                        replaceCount++;
                        break;
                    }

                }
                result += words[i] + " ";
            }

            statsRtb.Text = $"Сensored {replaceCount} words";

            allTextRtb.Clear();

            using (var fs = new FileStream(_textnPath, FileMode.Create, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(result);
                }
            }
            using (var fs = new FileStream(_textnPath, FileMode.Open, FileAccess.Read))
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
