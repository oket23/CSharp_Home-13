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
    public partial class task4Form : Form
    {
        private mainMenu _menu;
        private string _path;
        public task4Form(mainMenu mainMenu)
        {
            _menu = mainMenu;
            InitializeComponent();
        }

        private void task4Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            _menu.Show();
            Hide();
        }

        private void reverseBtn_Click(object sender, EventArgs e)
        {
            reversRtb.Clear();
            statsRtb.Clear();

            string text = new string(userRtb.Text.Reverse().ToArray());
            string copyPath = "";

            reversRtb.Text = text;

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select folder to create file";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                copyPath = Path.Combine(folderBrowserDialog.SelectedPath,"CopyFile.txt");
                using (var fs = new FileStream(copyPath, FileMode.Create, FileAccess.Write))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(reversRtb.Text);
                    }
                }
                MessageBox.Show("Сopy of file has been created successfully");
                statsRtb.Text = $"Сopy of the file was created in {copyPath}";
            }
        }

        private void userSelectBtn_Click(object sender, EventArgs e)
        {
            userRtb.Clear();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _path = openFileDialog.FileName;
                using (var fs = new FileStream(_path, FileMode.Open, FileAccess.Read))
                {
                    using (var sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            userRtb.Text += sr.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
