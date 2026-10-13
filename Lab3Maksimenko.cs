using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Lab3_Maksimenko
{
    public partial class Lab3Maksimenko : Form
    {
        private string filePath;

        public Lab3Maksimenko()
        {
            InitializeComponent();

            Text = "Lab3 Maksimenko";
            Width = 1200;
            Height = 750;

            filePath = Path.Combine(Application.StartupPath, "text.txt");

            panel1.BackColor = Color.White;
            panel1.Paint += Panel1_Paint;

            btnCreate.Click += BtnCreate_Click;
            btnDraw.Click += BtnDraw_Click;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string[] lines =
            {
                "Первая строка лабораторной работы",
                "Вторая строка лабораторной работы",
                "Третья строка лабораторной работы",
                "Четвертая строка лабораторной работы",
                "Пятая строка лабораторной работы",
                "Шестая строка лабораторной работы",
                "Седьмая строка лабораторной работы",
                "Восьмая строка лабораторной работы",
                "Девятая строка лабораторной работы",
                "Десятая строка лабораторной работы"
            };

            File.WriteAllLines(filePath, lines);

            MessageBox.Show(
                "Файл text.txt создан.\nКоличество строк: 10",
                "Лабораторная работа №3",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            panel1.Invalidate();
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                BtnCreate_Click(sender, e);
            }

            panel1.Invalidate();
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (!File.Exists(filePath))
                return;

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length < 10)
                return;

            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            float panelWidth = panel1.ClientSize.Width;
            float panelHeight = panel1.ClientSize.Height;

            using (Font font1 = new Font(
                "Consolas",
                36,
                FontStyle.Bold,
                GraphicsUnit.Point))
            {
                StringFormat format1 = new StringFormat();

                format1.Alignment = StringAlignment.Center;
                format1.LineAlignment = StringAlignment.Center;

                float group1X = 20;
                float group1Y = 20;
                float group1Width = 550;
                float group1Height = panelHeight - 40;

                float columnWidth = group1Width / 6;

                for (int i = 0; i < 6; i++)
                {
                    GraphicsState state = g.Save();
                    float centerX =
                        group1X + columnWidth * i + columnWidth / 2;

                    float centerY =
                        group1Y + group1Height / 2;
                    g.TranslateTransform(centerX, centerY);

                    g.RotateTransform(-90);

                    RectangleF textRect = new RectangleF(
                        -group1Height / 2,
                        -columnWidth / 2,
                        group1Height,
                        columnWidth);

                    g.DrawString(
                        lines[i],
                        font1,
                        Brushes.Black,
                        textRect,
                        format1);

                    g.Restore(state);
                }
            }

            using (Font font2 = new Font(
                "Calibri",
                24,
                FontStyle.Strikeout,
                GraphicsUnit.Point))
            {
                StringFormat format2 = new StringFormat();

                format2.Alignment = StringAlignment.Far;
                format2.LineAlignment = StringAlignment.Near;

                float group2X = 650;
                float group2Y = 60;
                float group2Width = panelWidth - 700;
                float group2Height = 250;

                float lineHeight = 65;

                for (int i = 0; i < 3; i++)
                {
                    RectangleF textRect = new RectangleF(
                        group2X,
                        group2Y + i * lineHeight,
                        group2Width,
                        lineHeight);

                    g.DrawString(
                        lines[i + 6],
                        font2,
                        Brushes.Black,
                        textRect,
                        format2);
                }
            }

            using (Font font3 = new Font(
                "Corbel",
                24,
                FontStyle.Underline,
                GraphicsUnit.Point))
            {
                StringFormat format3 = new StringFormat();

                format3.Alignment = StringAlignment.Near;
                format3.LineAlignment = StringAlignment.Far;

                float group3X = 650;
                float group3Y = 400;
                float group3Width = panelWidth - 700;
                float group3Height = 180;

                RectangleF textRect = new RectangleF(
                    group3X,
                    group3Y,
                    group3Width,
                    group3Height);

                g.DrawString(
                    lines[9],
                    font3,
                    Brushes.Black,
                    textRect,
                    format3);
            }

            using (Pen pen = new Pen(Color.Gray, 1))
            {
                g.DrawRectangle(
                    pen,
                    5,
                    5,
                    panelWidth - 10,
                    panelHeight - 10);
            }
        }
    }
}
