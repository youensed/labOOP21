namespace OOP_21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            правитиToolStripMenuItem = new ToolStripMenuItem();
            копіюватиToolStripMenuItem = new ToolStripMenuItem();
            вставитиToolStripMenuItem = new ToolStripMenuItem();
            вирізатиToolStripMenuItem = new ToolStripMenuItem();
            виділитиВсеToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            вставитиЗображенняToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem1 = new ToolStripMenuItem();
            колірToolStripMenuItem = new ToolStripMenuItem();
            виглядToolStripMenuItem = new ToolStripMenuItem();
            колірФонуToolStripMenuItem = new ToolStripMenuItem();
            моваToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            режимРозробникаToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            копіюватиToolStripMenuItem1 = new ToolStripMenuItem();
            вставитиToolStripMenuItem1 = new ToolStripMenuItem();
            вирізатиToolStripMenuItem1 = new ToolStripMenuItem();
            виділитиВсеToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            вставитиЗображенняToolStripMenuItem1 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.ForeColor = SystemColors.InfoText;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 426);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged_1;
            richTextBox1.MouseUp += richTextBox1_MouseUp;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правитиToolStripMenuItem, шрифтToolStripMenuItem, виглядToolStripMenuItem, моваToolStripMenuItem, режимРозробникаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { відкритиToolStripMenuItem, зберегтиЯкToolStripMenuItem, зберегтиToolStripMenuItem });
            файлToolStripMenuItem.ForeColor = SystemColors.ControlText;
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Image = (Image)resources.GetObject("відкритиToolStripMenuItem.Image");
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.Size = new Size(145, 22);
            відкритиToolStripMenuItem.Text = "Відкрити";
            відкритиToolStripMenuItem.Click += відкритиToolStripMenuItem_Click;
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            зберегтиЯкToolStripMenuItem.Image = (Image)resources.GetObject("зберегтиЯкToolStripMenuItem.Image");
            зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            зберегтиЯкToolStripMenuItem.Size = new Size(145, 22);
            зберегтиЯкToolStripMenuItem.Text = "Зберегти як..";
            зберегтиЯкToolStripMenuItem.Click += зберегтиЯкToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Image = (Image)resources.GetObject("зберегтиToolStripMenuItem.Image");
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(145, 22);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            // 
            // правитиToolStripMenuItem
            // 
            правитиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { копіюватиToolStripMenuItem, вставитиToolStripMenuItem, вирізатиToolStripMenuItem, виділитиВсеToolStripMenuItem, toolStripSeparator1, вставитиЗображенняToolStripMenuItem });
            правитиToolStripMenuItem.Name = "правитиToolStripMenuItem";
            правитиToolStripMenuItem.Size = new Size(66, 20);
            правитиToolStripMenuItem.Text = "Правити";
            // 
            // копіюватиToolStripMenuItem
            // 
            копіюватиToolStripMenuItem.Image = (Image)resources.GetObject("копіюватиToolStripMenuItem.Image");
            копіюватиToolStripMenuItem.Name = "копіюватиToolStripMenuItem";
            копіюватиToolStripMenuItem.Size = new Size(193, 22);
            копіюватиToolStripMenuItem.Text = "Копіювати";
            копіюватиToolStripMenuItem.Click += копіюватиToolStripMenuItem_Click;
            // 
            // вставитиToolStripMenuItem
            // 
            вставитиToolStripMenuItem.Image = (Image)resources.GetObject("вставитиToolStripMenuItem.Image");
            вставитиToolStripMenuItem.Name = "вставитиToolStripMenuItem";
            вставитиToolStripMenuItem.Size = new Size(193, 22);
            вставитиToolStripMenuItem.Text = "Вставити";
            вставитиToolStripMenuItem.Click += вставитиToolStripMenuItem_Click;
            // 
            // вирізатиToolStripMenuItem
            // 
            вирізатиToolStripMenuItem.Image = (Image)resources.GetObject("вирізатиToolStripMenuItem.Image");
            вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            вирізатиToolStripMenuItem.Size = new Size(193, 22);
            вирізатиToolStripMenuItem.Text = "Вирізати";
            вирізатиToolStripMenuItem.Click += вирізатиToolStripMenuItem_Click;
            // 
            // виділитиВсеToolStripMenuItem
            // 
            виділитиВсеToolStripMenuItem.Image = (Image)resources.GetObject("виділитиВсеToolStripMenuItem.Image");
            виділитиВсеToolStripMenuItem.Name = "виділитиВсеToolStripMenuItem";
            виділитиВсеToolStripMenuItem.Size = new Size(193, 22);
            виділитиВсеToolStripMenuItem.Text = "Виділити все";
            виділитиВсеToolStripMenuItem.Click += виділитиВсеToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(190, 6);
            // 
            // вставитиЗображенняToolStripMenuItem
            // 
            вставитиЗображенняToolStripMenuItem.Image = (Image)resources.GetObject("вставитиЗображенняToolStripMenuItem.Image");
            вставитиЗображенняToolStripMenuItem.Name = "вставитиЗображенняToolStripMenuItem";
            вставитиЗображенняToolStripMenuItem.Size = new Size(193, 22);
            вставитиЗображенняToolStripMenuItem.Text = "Вставити зображення";
            вставитиЗображенняToolStripMenuItem.Click += вставитиЗображенняToolStripMenuItem_Click;
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { шрифтToolStripMenuItem1, колірToolStripMenuItem });
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(48, 20);
            шрифтToolStripMenuItem.Text = "Текст";
            // 
            // шрифтToolStripMenuItem1
            // 
            шрифтToolStripMenuItem1.Image = (Image)resources.GetObject("шрифтToolStripMenuItem1.Image");
            шрифтToolStripMenuItem1.Name = "шрифтToolStripMenuItem1";
            шрифтToolStripMenuItem1.Size = new Size(113, 22);
            шрифтToolStripMenuItem1.Text = "Шрифт";
            шрифтToolStripMenuItem1.Click += шрифтToolStripMenuItem1_Click;
            // 
            // колірToolStripMenuItem
            // 
            колірToolStripMenuItem.Image = (Image)resources.GetObject("колірToolStripMenuItem.Image");
            колірToolStripMenuItem.Name = "колірToolStripMenuItem";
            колірToolStripMenuItem.Size = new Size(113, 22);
            колірToolStripMenuItem.Text = "Колір";
            колірToolStripMenuItem.Click += колірToolStripMenuItem_Click;
            // 
            // виглядToolStripMenuItem
            // 
            виглядToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { колірФонуToolStripMenuItem });
            виглядToolStripMenuItem.Name = "виглядToolStripMenuItem";
            виглядToolStripMenuItem.Size = new Size(39, 20);
            виглядToolStripMenuItem.Text = "Вид";
            // 
            // колірФонуToolStripMenuItem
            // 
            колірФонуToolStripMenuItem.Image = (Image)resources.GetObject("колірФонуToolStripMenuItem.Image");
            колірФонуToolStripMenuItem.Name = "колірФонуToolStripMenuItem";
            колірФонуToolStripMenuItem.Size = new Size(137, 22);
            колірФонуToolStripMenuItem.Text = "Колір фону";
            колірФонуToolStripMenuItem.Click += колірФонуToolStripMenuItem_Click;
            // 
            // моваToolStripMenuItem
            // 
            моваToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            моваToolStripMenuItem.Name = "моваToolStripMenuItem";
            моваToolStripMenuItem.Size = new Size(49, 20);
            моваToolStripMenuItem.Text = "Мова";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(134, 22);
            toolStripMenuItem1.Text = "English";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(134, 22);
            toolStripMenuItem2.Text = "Українська";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // режимРозробникаToolStripMenuItem
            // 
            режимРозробникаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            режимРозробникаToolStripMenuItem.Name = "режимРозробникаToolStripMenuItem";
            режимРозробникаToolStripMenuItem.Size = new Size(126, 20);
            режимРозробникаToolStripMenuItem.Text = "Режим розробника";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = (Image)resources.GetObject("toolStripMenuItem3.Image");
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(213, 22);
            toolStripMenuItem3.Text = "Підсвітка С подібних мов";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { копіюватиToolStripMenuItem1, вставитиToolStripMenuItem1, вирізатиToolStripMenuItem1, виділитиВсеToolStripMenuItem1, toolStripSeparator2, вставитиЗображенняToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(194, 120);
            // 
            // копіюватиToolStripMenuItem1
            // 
            копіюватиToolStripMenuItem1.Image = (Image)resources.GetObject("копіюватиToolStripMenuItem1.Image");
            копіюватиToolStripMenuItem1.Name = "копіюватиToolStripMenuItem1";
            копіюватиToolStripMenuItem1.Size = new Size(193, 22);
            копіюватиToolStripMenuItem1.Text = "Копіювати";
            копіюватиToolStripMenuItem1.Click += копіюватиToolStripMenuItem1_Click;
            // 
            // вставитиToolStripMenuItem1
            // 
            вставитиToolStripMenuItem1.Image = (Image)resources.GetObject("вставитиToolStripMenuItem1.Image");
            вставитиToolStripMenuItem1.Name = "вставитиToolStripMenuItem1";
            вставитиToolStripMenuItem1.Size = new Size(193, 22);
            вставитиToolStripMenuItem1.Text = "Вставити";
            вставитиToolStripMenuItem1.Click += вставитиToolStripMenuItem1_Click;
            // 
            // вирізатиToolStripMenuItem1
            // 
            вирізатиToolStripMenuItem1.Image = (Image)resources.GetObject("вирізатиToolStripMenuItem1.Image");
            вирізатиToolStripMenuItem1.Name = "вирізатиToolStripMenuItem1";
            вирізатиToolStripMenuItem1.Size = new Size(193, 22);
            вирізатиToolStripMenuItem1.Text = "Вирізати";
            вирізатиToolStripMenuItem1.Click += вирізатиToolStripMenuItem1_Click;
            // 
            // виділитиВсеToolStripMenuItem1
            // 
            виділитиВсеToolStripMenuItem1.Image = (Image)resources.GetObject("виділитиВсеToolStripMenuItem1.Image");
            виділитиВсеToolStripMenuItem1.Name = "виділитиВсеToolStripMenuItem1";
            виділитиВсеToolStripMenuItem1.Size = new Size(193, 22);
            виділитиВсеToolStripMenuItem1.Text = "Виділити все";
            виділитиВсеToolStripMenuItem1.Click += виділитиВсеToolStripMenuItem1_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(190, 6);
            // 
            // вставитиЗображенняToolStripMenuItem1
            // 
            вставитиЗображенняToolStripMenuItem1.Image = (Image)resources.GetObject("вставитиЗображенняToolStripMenuItem1.Image");
            вставитиЗображенняToolStripMenuItem1.Name = "вставитиЗображенняToolStripMenuItem1";
            вставитиЗображенняToolStripMenuItem1.Size = new Size(193, 22);
            вставитиЗображенняToolStripMenuItem1.Text = "Вставити зображення";
            вставитиЗображенняToolStripMenuItem1.Click += вставитиЗображенняToolStripMenuItem1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripSeparator3, toolStripButton4, toolStripButton5, toolStripButton6, toolStripButton7 });
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "Вирівнювання по лівому краю";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "Вирівнювання по центру";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "Вирівнювання по правому краю";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "Курсив";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 22);
            toolStripButton5.Text = "Підкреслений";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(23, 22);
            toolStripButton6.Text = "Жирний";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(23, 22);
            toolStripButton7.Text = "Стандарт";
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            ShowIcon = false;
            Text = "OOP 21";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem правитиToolStripMenuItem;
        private ToolStripMenuItem копіюватиToolStripMenuItem;
        private ToolStripMenuItem вставитиToolStripMenuItem;
        private ToolStripMenuItem вирізатиToolStripMenuItem;
        private ToolStripMenuItem виділитиВсеToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem вставитиЗображенняToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem1;
        private ToolStripMenuItem колірToolStripMenuItem;
        private ToolStripMenuItem виглядToolStripMenuItem;
        private ToolStripMenuItem колірФонуToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem копіюватиToolStripMenuItem1;
        private ToolStripMenuItem вставитиToolStripMenuItem1;
        private ToolStripMenuItem вирізатиToolStripMenuItem1;
        private ToolStripMenuItem виділитиВсеToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem вставитиЗображенняToolStripMenuItem1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private ToolStripMenuItem моваToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem режимРозробникаToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}
