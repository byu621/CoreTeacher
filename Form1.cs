using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using ToolGood.Words.Pinyin;
using System.Linq;

namespace CoreTeacher
{
    public partial class Form1 : Form
    {
        private List<List<string>> hskLevels = new();
        private List<List<string>> hskLevelsNew = new();
        private List<string> allHskCharacters = new();
        private List<string> currentSet = new();
        private int fromIndex = 0;
        private int toIndex = int.MaxValue;   
        private int hskLevel = 1;
        private int iterator = 0;
        private bool pinyinRevealed = true;

        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 2; i++)
            {
                List<string> words = File.ReadAllLines($"HSK/hsk{i}unknown.txt").ToList();
                hskLevels.Add(words);
                allHskCharacters.AddRange(words);
            }

            for (int i = 1; i <= 1; i++)
            {
                hskLevelsNew.Add(File.ReadAllLines($"HSK/hsknew{i}unknown.txt").ToList());
            }

            Sync();

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("SimSun.ttf");
            character1.Font = new Font(pfc.Families[0], 72, FontStyle.Bold);
            character2.Font = new Font(pfc.Families[0], 72, FontStyle.Bold);
        }

        private void Sync()
        {
            currentSet.Clear();
            iterator = 0;
            iteratorLabel.Text = iterator.ToString();
            character1.Text = "";
            character2.Text = "";
            pinyin1.Text = "";
            pinyin2.Text = "";

            List<string> words = File.ReadAllLines($"HSK/hsk{hskBox.Text}unknown.txt").ToList();
            for (int i = fromIndex; i <= toIndex && i < words.Count; i++)
            {
                if (noHSKBox.Checked)
                {
                    bool newWord = false;
                    foreach (var c in words[i])
                    {
                        if (!allHskCharacters.Exists(h => h.Contains(c)))
                        {
                            newWord = true;
                            break;
                        }
                    }

                    if (!newWord)
                    {
                        continue;
                    }
                }

                if (normCheckBox.Checked)
                {
                    currentSet.Add(words[i]);
                }

                if (SplitCheckBox.Checked && words[i].Length > 1)
                {
                    foreach (var c in words[i])
                    {
                        if (!currentSet.Contains(c.ToString()))
                        {
                            currentSet.Add(c.ToString());
                        }
                    }
                }
            }

            if (sentenceCheckBox.Checked)
            {
                currentSet.Clear();
                currentSet.AddRange(File.ReadAllLines($"HSK/hsk{hskLevel}sentences.txt").ToList());
            }

            pinyinRevealed = true;
            poolLabel.Text = currentSet.Count.ToString();
            Randomise();
        }

        private void Action()
        {
            if (pinyinRevealed)
            {
                character1.Text = CalculateNextWord();
                pinyin1.Text = "";

                if (iterator != 0)
                {
                    character2.Text = CalculateNextWord();
                    pinyin2.Text = "";
                } else
                {
                    character2.Text = "N/A";
                    pinyin2.Text = "";
                }
            } else
            {
                pinyin1.Text = WordsHelper.GetPinyin(character1.Text, true);
                pinyin2.Text = WordsHelper.GetPinyin(character2.Text, true);
            }

            pinyinRevealed = !pinyinRevealed;
        }

        private void Randomise()
        {
            Random rand = new Random();
            currentSet = currentSet.OrderBy(_ => rand.Next()).ToList();
        }

        private string CalculateNextWord()
        {
            string nextWord = currentSet[iterator];
            iterator = (iterator + 1) % currentSet.Count;
            if (iterator == 0)
            {
                Randomise();
            }

            iteratorLabel.Text = iterator.ToString();
            return nextWord;
        }

        private void hskBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(hskBox.Text.Trim(), out hskLevel);
        }

        private void fromBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(fromBox.Text.Trim(), out fromIndex);
        }

        private void toBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(toBox.Text.Trim(), out toIndex);
        }

        private void syncButton_Click(object sender, EventArgs e)
        {
            Sync();
        }

        private void BaseForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Action();
                e.Handled = true;
            }
        }

        private void purpleButton1_Click(object sender, EventArgs e)
        {
            OpenPurple(character1.Text);
        }

        private void purpleButton2_Click(object sender, EventArgs e)
        {
            OpenPurple(character2.Text);
        }

        private void OpenPurple(string characterText)
        {
            string url = $"https://www.purpleculture.net/dictionary_details/?word={characterText}";
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psInfo);
        }

        private void copyButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(character1.Text);
        }

        private void copyButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(character2.Text);
        }

        private void seenButton1_Click(object sender, EventArgs e)
        {
            SeenButton(character1.Text);
        }

        private void seenButton2_Click(object sender, EventArgs e)
        {
            SeenButton(character2.Text);
        }

        private void SeenButton(string character)
        {
            var bigMessageBox = new BigMessageBox();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hskLevels.Count; i++)
            {
                sb.Append($"HSK{i + 1}: ");

                foreach (string s in hskLevels[i])
                {
                    if (s.Contains(character))
                    {
                        sb.Append($",{s}");
                    }
                }

                sb.Append('\n');
            }

            bigMessageBox.content = sb.ToString();
            bigMessageBox.ShowDialog();
        }
    }
}