using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace OOP_21
{
    public partial class Form1 : Form
    {
        // змінні для переміни режиму
        private bool langCMode, ukr, eng; 

        public Form1()
        {
            InitializeComponent();
            langCMode = false;
            ukr = false;
            eng = false;
        }
        //
        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string name = openFileDialog1.FileName;
            string text = File.ReadAllText(name);
            richTextBox1.Text = text;
        }

        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Текстовий файл(*.txt)|*.txt|RTF файл(*.rtf)|*.rtf|Текстовий документ(*.docx)|*.docx";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string name = saveFileDialog1.FileName;
            File.WriteAllText(name, richTextBox1.Text);
        }

        private void копіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вставитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void вирізатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void виділитиВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void вставитиЗображенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;

                Image img = Image.FromFile(imagePath);
                Clipboard.SetImage(img);
                richTextBox1.Paste();
            }
        }

        private void шрифтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void колірToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void колірФонуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void копіюватиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вставитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void вирізатиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void виділитиВсеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void вставитиЗображенняToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;

                Image img = Image.FromFile(imagePath);
                Clipboard.SetImage(img);
                richTextBox1.Paste();
            }
        }
        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Italic);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Underline);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Bold);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Regular);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            eng = true;

            файлToolStripMenuItem.Text = "File";
            відкритиToolStripMenuItem.Text = "Open";
            зберегтиЯкToolStripMenuItem.Text = "Save as...";
            зберегтиToolStripMenuItem.Text = "Save";

            правитиToolStripMenuItem.Text = "Edit";
            копіюватиToolStripMenuItem.Text = "Copy";
            вставитиToolStripMenuItem.Text = "Paste";
            вирізатиToolStripMenuItem.Text = "Cut";
            виділитиВсеToolStripMenuItem.Text = "Select All";
            вставитиЗображенняToolStripMenuItem.Text = "Paste Image";

            шрифтToolStripMenuItem.Text = "Text";
            шрифтToolStripMenuItem1.Text = "Type";
            колірToolStripMenuItem.Text = "Color";

            виглядToolStripMenuItem.Text = "View";
            колірФонуToolStripMenuItem.Text = "Background Color";

            моваToolStripMenuItem.Text = "Language";
            toolStripMenuItem2.Text = "Ukrainian";

            toolStripButton1.Text = "Left";
            toolStripButton2.Text = "Center";
            toolStripButton3.Text = "Right";
            toolStripButton4.Text = "Italic";
            toolStripButton5.Text = "Underline";
            toolStripButton6.Text = "Bold";
            toolStripButton7.Text = "Default";

            режимРозробникаToolStripMenuItem.Text = "Developer mode";
            toolStripMenuItem3.Text = "C style";

            копіюватиToolStripMenuItem1.Text = "Copy";
            вставитиToolStripMenuItem1.Text = "Paste";
            вирізатиToolStripMenuItem1.Text = "Cut";
            виділитиВсеToolStripMenuItem1.Text = "Select All";
            вставитиЗображенняToolStripMenuItem1.Text = "Paste Image";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ukr = true;

            файлToolStripMenuItem.Text = "Файл";
            відкритиToolStripMenuItem.Text = "Відкрити";
            зберегтиЯкToolStripMenuItem.Text = "Зберегти як...";
            зберегтиToolStripMenuItem.Text = "Зберегти";

            правитиToolStripMenuItem.Text = "Правити";
            копіюватиToolStripMenuItem.Text = "Копіювати";
            вставитиToolStripMenuItem.Text = "Вставити";
            вирізатиToolStripMenuItem.Text = "Вирізати";
            виділитиВсеToolStripMenuItem.Text = "Виділити все";
            вставитиЗображенняToolStripMenuItem.Text = "Вставити зображення";

            шрифтToolStripMenuItem.Text = "Текст";
            шрифтToolStripMenuItem1.Text = "Щрифт";
            колірToolStripMenuItem.Text = "Колір";

            виглядToolStripMenuItem.Text = "Вигляд";
            колірФонуToolStripMenuItem.Text = "Колір фону";

            моваToolStripMenuItem.Text = "Мова";
            toolStripMenuItem2.Text = "Українська";

            toolStripButton1.Text = "Вирівнювання по лівому краю";
            toolStripButton2.Text = "Вирівнювання по центру";
            toolStripButton3.Text = "Вирівнювання по правому краю";
            toolStripButton4.Text = "Курсив";
            toolStripButton5.Text = "Підкреслений";
            toolStripButton6.Text = "Жирний";
            toolStripButton7.Text = "Стандарт";

            режимРозробникаToolStripMenuItem.Text = "Режим розробника";
            toolStripMenuItem3.Text = "Підсвітка С подібних мов";

            копіюватиToolStripMenuItem1.Text = "Копіювати";
            вставитиToolStripMenuItem1.Text = "Вставити";
            вирізатиToolStripMenuItem1.Text = "Вирізати";
            виділитиВсеToolStripMenuItem1.Text = "Виділити все";
            вставитиЗображенняToolStripMenuItem1.Text = "Вставити зображення";
        }

        private void HighlightSyntax()
        {
            string keywordsPattern = @"\b(if|else|for|while|do|break|continue|return)\b";
            string typePattern = @"\b(void|byte|short|int|long|longlong|float|double|decimal|char|string|using|true|false|static|public|private|class|interface|delegate|struct)\b";

            Color keyColors;
            Color typeColors;
            if (langCMode)
            {
                keyColors = Color.Fuchsia;
                typeColors = Color.Blue;
            }
            else
            {
                keyColors = Color.Black;
                typeColors = Color.Black;
            }
            HighlightMatches(keywordsPattern, keyColors);
            HighlightMatches(typePattern, typeColors);

            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectionColor = Color.Black;
        }

        private void HighlightMatches(string pattern, Color colors)
        {
            MatchCollection temp = Regex.Matches(richTextBox1.Text, pattern);
            foreach (Match match in temp)
            {
                richTextBox1.Select(match.Index, match.Length);
                richTextBox1.SelectionColor = colors;
            }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            HighlightSyntax();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            if (langCMode)
            {
                langCMode = false;
                if (eng && !ukr)
                {
                    MessageBox.Show("Developer mode is off", "Switch Mode!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Режим розробника вимкнено", "Зміна режиму!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                langCMode = true;
                if (eng && !ukr)
                {
                    MessageBox.Show("Developer mode is on", "Switch Mode!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Режим розробника увімкнено", "Зміна режиму!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
