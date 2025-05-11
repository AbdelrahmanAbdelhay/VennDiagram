using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KumeIslemleriVenn
{
    public partial class KumeForm : Form
    {
        private Stack<string> operationHistory = new Stack<string>();
        private Stack<string> undoHistory = new Stack<string>();

        public KumeForm()
        {
            InitializeComponent();
        }

        private bool ValidateInput(string input, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(input))
            {
                errorMessage = "Küme boş olamaz.";
                return false;
            }
            var elements = input.Split(',').Select(s => s.Trim());
            if (elements.Any(s => string.IsNullOrEmpty(s)))
            {
                errorMessage = "Geçersiz eleman bulundu.";
                return false;
            }
            return true;
        }

        private HashSet<string> ParseInputHashSet(string input)
        {
            return new HashSet<string>(input.Split(',').Select(s => s.Trim()).Where(s => !string.IsNullOrEmpty(s)));
        }

        private SortedSet<string> ParseInputSortedSet(string input)
        {
            return new SortedSet<string>(input.Split(',').Select(s => s.Trim()).Where(s => !string.IsNullOrEmpty(s)));
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(txtSetA.Text, out string errorA))
            {
                lblResult.Text = "Küme A: " + errorA;
                return;
            }
            if (!ValidateInput(txtSetB.Text, out string errorB))
            {
                lblResult.Text = "Küme B: " + errorB;
                return;
            }
            var A = ParseInputHashSet(txtSetA.Text);
            var B = ParseInputHashSet(txtSetB.Text);
            var union = new HashSet<string>(A);
            union.UnionWith(B);
            var sortedUnion = new SortedSet<string>(union);
            lblResult.Text = "Union: " + string.Join(", ", sortedUnion);
            operationHistory.Push("Union: " + string.Join(", ", sortedUnion));
            undoHistory.Push("Union: " + string.Join(", ", sortedUnion));
            UpdateOperationHistoryList();
            DrawVennDiagram(A, B, sortedUnion, "union");
        }

        private void btnIntersection_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(txtSetA.Text, out string errorA))
            {
                lblResult.Text = "Küme A: " + errorA;
                return;
            }
            if (!ValidateInput(txtSetB.Text, out string errorB))
            {
                lblResult.Text = "Küme B: " + errorB;
                return;
            }
            var A = ParseInputHashSet(txtSetA.Text);
            var B = ParseInputHashSet(txtSetB.Text);
            var intersect = new HashSet<string>(A);
            intersect.IntersectWith(B);
            var sortedIntersect = new SortedSet<string>(intersect);
            lblResult.Text = "Intersection: " + string.Join(", ", sortedIntersect);
            operationHistory.Push("Intersection: " + string.Join(", ", sortedIntersect));
            undoHistory.Push("Intersection: " + string.Join(", ", sortedIntersect));
            UpdateOperationHistoryList();
            DrawVennDiagram(A, B, sortedIntersect, "intersection");
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(txtSetA.Text, out string errorA))
            {
                lblResult.Text = "Küme A: " + errorA;
                return;
            }
            if (!ValidateInput(txtSetB.Text, out string errorB))
            {
                lblResult.Text = "Küme B: " + errorB;
                return;
            }
            var A = ParseInputHashSet(txtSetA.Text);
            var B = ParseInputHashSet(txtSetB.Text);
            var difference = new HashSet<string>(A);
            difference.ExceptWith(B);
            var sortedDifference = new SortedSet<string>(difference);
            lblResult.Text = "A - B: " + string.Join(", ", sortedDifference);
            operationHistory.Push("A - B: " + string.Join(", ", sortedDifference));
            undoHistory.Push("A - B: " + string.Join(", ", sortedDifference));
            UpdateOperationHistoryList();
            DrawVennDiagram(A, B, sortedDifference, "difference");
        }

        private void btnReverseDifference_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(txtSetA.Text, out string errorA))
            {
                lblResult.Text = "Küme A: " + errorA;
                return;
            }
            if (!ValidateInput(txtSetB.Text, out string errorB))
            {
                lblResult.Text = "Küme B: " + errorB;
                return;
            }
            var A = ParseInputHashSet(txtSetA.Text);
            var B = ParseInputHashSet(txtSetB.Text);
            var difference = new HashSet<string>(B);
            difference.ExceptWith(A);
            var sortedDifference = new SortedSet<string>(difference);
            lblResult.Text = "B - A: " + string.Join(", ", sortedDifference);
            operationHistory.Push("B - A: " + string.Join(", ", sortedDifference));
            undoHistory.Push("B - A: " + string.Join(", ", sortedDifference));
            UpdateOperationHistoryList();
            DrawVennDiagram(B, A, sortedDifference, "reverse_difference");
        }

        private void btnSymmetricDifference_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(txtSetA.Text, out string errorA))
            {
                lblResult.Text = "Küme A: " + errorA;
                return;
            }
            if (!ValidateInput(txtSetB.Text, out string errorB))
            {
                lblResult.Text = "Küme B: " + errorB;
                return;
            }
            var A = ParseInputHashSet(txtSetA.Text);
            var B = ParseInputHashSet(txtSetB.Text);
            var symmetricDifference = new HashSet<string>(A);
            symmetricDifference.SymmetricExceptWith(B);
            var sortedSymmetricDifference = new SortedSet<string>(symmetricDifference);
            lblResult.Text = "Symmetric Difference: " + string.Join(", ", sortedSymmetricDifference);
            operationHistory.Push("Symmetric Difference: " + string.Join(", ", sortedSymmetricDifference));
            undoHistory.Push("Symmetric Difference: " + string.Join(", ", sortedSymmetricDifference));
            UpdateOperationHistoryList();
            DrawVennDiagram(A, B, sortedSymmetricDifference, "symmetric_difference");
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (undoHistory.Count > 0)
            {
                string lastOperation = undoHistory.Pop();
                lblResult.Text = "Geri Alındı: " + lastOperation;
            }
            else
            {
                lblResult.Text = "Geri alınacak işlem yok.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSetA.Text = "";
            txtSetB.Text = "";
            lblResult.Text = "Result:";
            operationHistory.Clear();
            undoHistory.Clear();
            lstOperationHistory.Items.Clear();
            panelVenn.Invalidate();
        }

        private void DrawVennDiagram(HashSet<string> A, HashSet<string> B, SortedSet<string> highlight, string mode)
        {
            panelVenn.Invalidate();
            panelVenn.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.Clear(Color.White);

                Rectangle rectA = new Rectangle(30, 50, 250, 250);
                Rectangle rectB = new Rectangle(155, 50, 250, 250);

                g.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Blue)), rectA);
                g.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Red)), rectB);

                g.DrawString("A", new Font("Arial", 10), Brushes.Black, 120, 180);
                g.DrawString("B", new Font("Arial", 10), Brushes.Black, 300, 180);

                string content = string.Join(", ", highlight);
                Font font = new Font("Arial", 9);
                if (mode == "intersection")
                    g.DrawString(content, font, Brushes.Black, 155, 170);
                else if (mode == "union")
                    g.DrawString(content, font, Brushes.Black, 100, 30);
                else if (mode == "difference")
                    g.DrawString(content, font, Brushes.Black, 40, 165);
                else if (mode == "reverse_difference")
                    g.DrawString(content, font, Brushes.Black, 285, 165);
                else if (mode == "symmetric_difference")
                    g.DrawString(content, font, Brushes.Black, 170, 300);
            };
        }

        private void UpdateOperationHistoryList()
        {
            lstOperationHistory.Items.Clear();
            lstOperationHistory.Items.AddRange(operationHistory.ToArray());
        }
    }
}
