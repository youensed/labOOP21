using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace OOP_21
{
    public partial class Form1 : Form
    {
        // ���� ��� ������� ������
        private bool langCMode, ukr, eng; 

        public Form1()
        {
            InitializeComponent();
            langCMode = false;
            ukr = false;
            eng = false;
        }
        //
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string name = openFileDialog1.FileName;
            string text = File.ReadAllText(name);
            richTextBox1.Text = text;
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "��������� ����(*.txt)|*.txt|RTF ����(*.rtf)|*.rtf|��������� ��������(*.docx)|*.docx";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string name = saveFileDialog1.FileName;
            File.WriteAllText(name, richTextBox1.Text);
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void ������������������ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void �����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void ��������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void ��������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void �������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void ����������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void ������������������ToolStripMenuItem1_Click(object sender, EventArgs e)
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

            ����ToolStripMenuItem.Text = "File";
            �������ToolStripMenuItem.Text = "Open";
            ����������ToolStripMenuItem.Text = "Save as...";
            ��������ToolStripMenuItem.Text = "Save";

            �������ToolStripMenuItem.Text = "Edit";
            ��������ToolStripMenuItem.Text = "Copy";
            ��������ToolStripMenuItem.Text = "Paste";
            �������ToolStripMenuItem.Text = "Cut";
            ����������ToolStripMenuItem.Text = "Select All";
            ������������������ToolStripMenuItem.Text = "Paste Image";

            �����ToolStripMenuItem.Text = "Text";
            �����ToolStripMenuItem1.Text = "Type";
            ����ToolStripMenuItem.Text = "Color";

            ������ToolStripMenuItem.Text = "View";
            ��������ToolStripMenuItem.Text = "Background Color";

            ����ToolStripMenuItem.Text = "Language";
            toolStripMenuItem2.Text = "Ukrainian";

            toolStripButton1.Text = "Left";
            toolStripButton2.Text = "Center";
            toolStripButton3.Text = "Right";
            toolStripButton4.Text = "Italic";
            toolStripButton5.Text = "Underline";
            toolStripButton6.Text = "Bold";
            toolStripButton7.Text = "Default";

            ���������������ToolStripMenuItem.Text = "Developer mode";
            toolStripMenuItem3.Text = "C style";

            ��������ToolStripMenuItem1.Text = "Copy";
            ��������ToolStripMenuItem1.Text = "Paste";
            �������ToolStripMenuItem1.Text = "Cut";
            ����������ToolStripMenuItem1.Text = "Select All";
            ������������������ToolStripMenuItem1.Text = "Paste Image";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ukr = true;

            ����ToolStripMenuItem.Text = "����";
            �������ToolStripMenuItem.Text = "³������";
            ����������ToolStripMenuItem.Text = "�������� ��...";
            ��������ToolStripMenuItem.Text = "��������";

            �������ToolStripMenuItem.Text = "�������";
            ��������ToolStripMenuItem.Text = "��������";
            ��������ToolStripMenuItem.Text = "��������";
            �������ToolStripMenuItem.Text = "�������";
            ����������ToolStripMenuItem.Text = "������� ���";
            ������������������ToolStripMenuItem.Text = "�������� ����������";

            �����ToolStripMenuItem.Text = "�����";
            �����ToolStripMenuItem1.Text = "�����";
            ����ToolStripMenuItem.Text = "����";

            ������ToolStripMenuItem.Text = "������";
            ��������ToolStripMenuItem.Text = "���� ����";

            ����ToolStripMenuItem.Text = "����";
            toolStripMenuItem2.Text = "���������";

            toolStripButton1.Text = "����������� �� ����� ����";
            toolStripButton2.Text = "����������� �� ������";
            toolStripButton3.Text = "����������� �� ������� ����";
            toolStripButton4.Text = "������";
            toolStripButton5.Text = "ϳ����������";
            toolStripButton6.Text = "������";
            toolStripButton7.Text = "��������";

            ���������������ToolStripMenuItem.Text = "����� ����������";
            toolStripMenuItem3.Text = "ϳ������ � ������� ���";

            ��������ToolStripMenuItem1.Text = "��������";
            ��������ToolStripMenuItem1.Text = "��������";
            �������ToolStripMenuItem1.Text = "�������";
            ����������ToolStripMenuItem1.Text = "������� ���";
            ������������������ToolStripMenuItem1.Text = "�������� ����������";
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
                    MessageBox.Show("����� ���������� ��������", "���� ������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("����� ���������� ��������", "���� ������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
