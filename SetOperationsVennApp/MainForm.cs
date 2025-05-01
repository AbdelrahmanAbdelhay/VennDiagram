using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SetOperationsVennApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private HashSet<string> ParseInput(string input)
        {
            return new HashSet<string>(
                input.Split(',').Select(s => s.Trim()).Where(s => !string.IsNullOrEmpty(s))
            );
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            var A = ParseInput(txtSetA.Text);
            var B = ParseInput(txtSetB.Text);
            var union = new HashSet<string>(A);
            union.UnionWith(B);
            lblResult.Text = "Union: " + string.Join(", ", union);
            DrawVennDiagram(A, B, union, "union");
        }

        private void btnIntersection_Click(object sender, EventArgs e)
        {
            var A = ParseInput(txtSetA.Text);
            var B = ParseInput(txtSetB.Text);
            var intersect = new HashSet<string>(A);
            intersect.IntersectWith(B);
            lblResult.Text = "Intersection: " + string.Join(", ", intersect);
            DrawVennDiagram(A, B, intersect, "intersection");
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            var A = ParseInput(txtSetA.Text);
            var B = ParseInput(txtSetB.Text);
            var difference = new HashSet<string>(A);
            difference.ExceptWith(B);
            lblResult.Text = "A - B: " + string.Join(", ", difference);
            DrawVennDiagram(A, B, difference, "difference");
        }

        private void DrawVennDiagram(HashSet<string> A, HashSet<string> B, HashSet<string> highlight, string mode)
        {
            panelVenn.Invalidate();
            panelVenn.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.Clear(Color.White);

                Rectangle rectA = new Rectangle(30, 30, 100, 100);
                Rectangle rectB = new Rectangle(80, 30, 100, 100);

                g.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Blue)), rectA);
                g.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Red)), rectB);

                g.DrawString("A", new Font("Arial", 10), Brushes.Black, 60, 130);
                g.DrawString("B", new Font("Arial", 10), Brushes.Black, 140, 130);

                string content = string.Join(", ", highlight);
                Font font = new Font("Arial", 9);
                if (mode == "intersection")
                    g.DrawString(content, font, Brushes.Black, 90, 80);
                else if (mode == "union")
                    g.DrawString(content, font, Brushes.Black, 60, 10);
                else if (mode == "difference")
                    g.DrawString(content, font, Brushes.Black, 40, 80);
            };
        }

        private List<string> onlyA = new List<string>();
        private List<string> onlyB = new List<string>();
        private List<string> both = new List<string>();

        private void panelVenn_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle leftCircle = new Rectangle(100, 50, 180, 180);
            Rectangle rightCircle = new Rectangle(200, 50, 180, 180);

            using (Brush brush = new SolidBrush(Color.FromArgb(100, Color.Blue)))
                g.FillEllipse(brush, leftCircle);
            using (Brush brush = new SolidBrush(Color.FromArgb(100, Color.Red)))
                g.FillEllipse(brush, rightCircle);

            using (Pen pen = new Pen(Color.Blue, 2))
                g.DrawEllipse(pen, leftCircle);
            using (Pen pen = new Pen(Color.Red, 2))
                g.DrawEllipse(pen, rightCircle);

            g.DrawString("Set A", this.Font, Brushes.Blue, 110, 30);
            g.DrawString("Set B", this.Font, Brushes.Red, 290, 30);

            // Draw results
            g.DrawString("Only A:\n" + string.Join(", ", onlyA), this.Font, Brushes.Black, new RectangleF(50, 110, 100, 150));
            g.DrawString("Only B:\n" + string.Join(", ", onlyB), this.Font, Brushes.Black, new RectangleF(330, 110, 100, 150));
            g.DrawString("Both:\n" + string.Join(", ", both), this.Font, Brushes.Black, new RectangleF(190, 120, 100, 150));
        }
    }
}