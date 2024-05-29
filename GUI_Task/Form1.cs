using System.Text;
using System.Text.RegularExpressions;

namespace Ivan_Angelov_Working
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new() { Filter = "Text Documents|*.txt" };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.textBoxContent.Text = string.Empty;
                using StreamReader sr = new(ofd.FileName);
                string line = sr.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    this.textBoxContent.Text += line;
                    line = sr.ReadLine();
                }
            }
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            int spaces = 0, latinLetters = 0, cyrillicLetters = 0, digits = 0;
            int words = this.textBoxContent.Text.Split().Length;
            int symbols = this.textBoxContent.Text.Length;
            Regex regexLatinLetters = new(@"[A-Za-z]");
            Regex regexCyrillicLetters = new(@"[А-Яа-я]");
            foreach (char c in this.textBoxContent.Text)
            {
                if (c == ' ') spaces++;
                else if (regexLatinLetters.IsMatch(textBoxContent.Text))
                {
                    latinLetters++;
                }
                else if (regexCyrillicLetters.IsMatch(textBoxContent.Text))
                {
                    cyrillicLetters++;
                }
                else digits++;
            }

            StringBuilder sb = new();
            sb.AppendLine("Статистика за текста:");
            sb.AppendLine($"Целият текст има {symbols} символа.");
            sb.AppendLine($"Целият текст има {cyrillicLetters} символа на кирилица.");
            sb.AppendLine($"Целият текст има {latinLetters} символа на латинеца.");
            sb.AppendLine($"Целият текст има {spaces} интервали.");
            sb.AppendLine($"Целият текст има {words} думи.");
            sb.AppendLine($"Целият текст има {digits} цифри.");

            this.textBoxData.Text += sb.ToString();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new() { Filter = "Text Documents|*.txt" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new(sfd.FileName);
                sw.WriteLine(this.textBoxData.Text);
            }
        }

        private void textBoxContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}