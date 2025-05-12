using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            txtSetC.Text = "";
            lblResult.Text = "Result:";
            operationHistory.Clear();
            undoHistory.Clear();
            lstOperationHistory.Items.Clear();
            panelVenn.Invalidate();
        }


        private void DrawVennDiagram(HashSet<string> A, HashSet<string> B, SortedSet<string> highlight, string mode)
        {
            // Yeni verileri static değişkenlere aktar
            this.vennA = A;
            this.vennB = B;
            this.vennResult = highlight;
            this.vennMode = mode;

            // Önceki Paint olaylarını temizle
            panelVenn.Paint -= PanelVenn_Paint2Kume;

            // Yeni Paint olayını ekle
            panelVenn.Paint += PanelVenn_Paint2Kume;
            panelVenn.Invalidate(); // yeniden çiz
        }

        // Çizim için gereken değişkenler (sınıf seviyesinde tanımla)
        private HashSet<string> vennA, vennB;
        private SortedSet<string> vennResult;
        private string vennMode;

        // 2 kümeli sabit çizim metodu
        private void PanelVenn_Paint2Kume(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            Rectangle rectA = new Rectangle(100, 150, 600, 600);
            Rectangle rectB = new Rectangle(350, 150, 600, 600);

            g.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Blue)), rectA);
            g.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Red)), rectB);

            g.DrawString("A", new Font("Arial", 18), Brushes.Black, 350, 100);
            g.DrawString("B", new Font("Arial", 18), Brushes.Black, 650, 100);

            string content = string.Join(", ", vennResult);
            Font font = new Font("Arial", 18);

            HashSet<string> onlyA = new HashSet<string>(vennA);
            onlyA.ExceptWith(vennB);

            HashSet<string> onlyB = new HashSet<string>(vennB);
            onlyB.ExceptWith(vennA);

            HashSet<string> intersection = new HashSet<string>(vennA);
            intersection.IntersectWith(vennB);

            if (vennMode == "intersection")
                g.DrawString(content, font, Brushes.Black, 450, 430);
            else if (vennMode == "union")
            {
                string onlyAContent = string.Join(", ", onlyA);
                string onlyBContent = string.Join(", ", onlyB);
                string intersectionContent = string.Join(", ", intersection);

                // Draw A - B (left)
                g.DrawString(onlyAContent, font, Brushes.Black, 110, 430);

                // Draw B - A (right)
                g.DrawString(onlyBContent, font, Brushes.Black, 720, 430);

                // Draw A ∩ B (center)
                g.DrawString(intersectionContent, font, Brushes.Black, 450, 430);
            }

            else if (vennMode == "difference")
                g.DrawString(content, font, Brushes.Black, 110, 430);
            else if (vennMode == "reverse_difference")
                g.DrawString(content, font, Brushes.Black, 720, 430);
            else if (vennMode == "symmetric_difference")
            {
                string onlyAContent = string.Join(", ", onlyA);
                string onlyBContent = string.Join(", ", onlyB);

                g.DrawString(onlyAContent, font, Brushes.Black, 110, 430); // A - B (Left circle)
                g.DrawString(onlyBContent, font, Brushes.Black, 720, 430); // B - A (Right circle)
            }

        }

        private void DrawVennDiagram3(HashSet<string> A, HashSet<string> B, HashSet<string> C, SortedSet<string> _, string mode)
        {
            panelVenn.Invalidate();
            panelVenn.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.Clear(Color.White);

                int shiftX = -250; // sola kaydırma miktarı

                Rectangle rectA = new Rectangle(340 + shiftX, 30, 600, 600);
                Rectangle rectB = new Rectangle(600 + shiftX, 30, 600, 600);
                Rectangle rectC = new Rectangle(480 + shiftX, 210, 600, 600);

                g.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Blue)), rectA);
                g.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Red)), rectB);
                g.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Green)), rectC);

                g.DrawString("A", new Font("Arial", 18), Brushes.Blue, 400 + shiftX, 60);
                g.DrawString("B", new Font("Arial", 18), Brushes.Red, 1100 + shiftX, 60);
                g.DrawString("C", new Font("Arial", 18), Brushes.Green, 750 + shiftX, 820);

                Font font = new Font("Arial", 14);

                var abc = A.Intersect(B).Intersect(C).ToList();
                var ab = A.Intersect(B).Except(C).ToList();
                var ac = A.Intersect(C).Except(B).ToList();
                var bc = B.Intersect(C).Except(A).ToList();
                var onlyA = A.Except(B).Except(C).ToList();
                var onlyB = B.Except(A).Except(C).ToList();
                var onlyC = C.Except(A).Except(B).ToList();

                // Yazılar sola kaydırılmış
                if (mode == "intersection3")
                {
                    g.DrawString("A∩B∩C: " + string.Join(",", abc), font, Brushes.Black, 660 + shiftX, 360);
                }
                else
                {
                    g.DrawString("A∩B∩C: " + string.Join(",", abc), font, Brushes.Black, 660 + shiftX, 360);
                    g.DrawString("A∩B: " + string.Join(",", ab), font, Brushes.Black, 670 + shiftX, 170);
                    g.DrawString("A∩C: " + string.Join(",", ac), font, Brushes.Black, 470 + shiftX, 430);
                    g.DrawString("B∩C: " + string.Join(",", bc), font, Brushes.Black, 895 + shiftX, 440);
                    g.DrawString("A∖(B∪C): " + string.Join(",", onlyA), font, Brushes.Black, 355 + shiftX, 240);
                    g.DrawString("B∖(A∪C): " + string.Join(",", onlyB), font, Brushes.Black, 980 + shiftX, 210);
                    g.DrawString("C∖(A∪B): " + string.Join(",", onlyC), font, Brushes.Black, 690 + shiftX, 710);
                }

            };


        }






        private void UpdateOperationHistoryList()
        {
            lstOperationHistory.Items.Clear();
            lstOperationHistory.Items.AddRange(operationHistory.ToArray());
        }

        private void btnUnionABC_Click(object sender, EventArgs e)
        {
            string errorA = "", errorB = "", errorC = "";
            if (!ValidateInput(txtSetA.Text, out errorA) ||
                !ValidateInput(txtSetB.Text, out errorB) ||
                !ValidateInput(txtSetC.Text, out errorC))
            {
                lblResult.Text = $"Hatalı giriş: {errorA} {errorB} {errorC}".Trim();
                return;
            }


            var A = ParseInputHashSet(txtSetA.Text);
            var B = ParseInputHashSet(txtSetB.Text);
            var C = ParseInputHashSet(txtSetC.Text);

            var result = new HashSet<string>(A);
            result.UnionWith(B);
            result.UnionWith(C);

            var sorted = new SortedSet<string>(result);
            lblResult.Text = "A ∪ B ∪ C: " + string.Join(", ", sorted);
            operationHistory.Push("A ∪ B ∪ C: " + string.Join(", ", sorted));
            undoHistory.Push("A ∪ B ∪ C: " + string.Join(", ", sorted));
            UpdateOperationHistoryList();

            DrawVennDiagram3(A, B, C, sorted, "union3");
        }


        private void btnİntersectionABC_Click(object sender, EventArgs e)
        {
            string errorA = "", errorB = "", errorC = "";
            if (!ValidateInput(txtSetA.Text, out errorA) ||
                !ValidateInput(txtSetB.Text, out errorB) ||
                !ValidateInput(txtSetC.Text, out errorC))
            {
                lblResult.Text = $"Hatalı giriş: {errorA} {errorB} {errorC}".Trim();
                return;
            }


            var A = ParseInputHashSet(txtSetA.Text);
            var B = ParseInputHashSet(txtSetB.Text);
            var C = ParseInputHashSet(txtSetC.Text);

            var result = new HashSet<string>(A);
            result.IntersectWith(B);
            result.IntersectWith(C);

            var sorted = new SortedSet<string>(result);
            lblResult.Text = "A ∩ B ∩ C: " + string.Join(", ", sorted);
            operationHistory.Push("A ∩ B ∩ C: " + string.Join(", ", sorted));
            undoHistory.Push("A ∩ B ∩ C: " + string.Join(", ", sorted));
            UpdateOperationHistoryList();

            DrawVennDiagram3(A, B, C, sorted, "intersection3");
        }
        private void btnIntersectionABC_Click(object sender, EventArgs e)
        {
            // Henüz yazılmamış olabilir ama en azından tanımlanmış olması gerekiyor.
        }

        private void KumeForm_Load(object sender, EventArgs e)
        {

        }

        private void lblSetA_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEvaluateExpression_Click(object sender, EventArgs e)
        {
            var A = ParseInputHashSet(txtSetA.Text);
            var B = ParseInputHashSet(txtSetB.Text);
            var C = ParseInputHashSet(txtSetC.Text);

            string expression = txtExpression.Text.Trim();
            try
            {
                var result = EvaluateSetExpression(expression, A, B, C);
                lblResult.Text = "Sonuç: " + string.Join(", ", result);

                // Operation geçmişine ekle
                operationHistory.Push("İfade: " + expression + " → " + string.Join(", ", result));
                undoHistory.Push("İfade: " + expression + " → " + string.Join(", ", result));
                UpdateOperationHistoryList();

                DrawVennDiagram3(A, B, C, new SortedSet<string>(result), "evaluate");
            }
            catch (Exception ex)
            {
                lblResult.Text = "Hata:: " + ex.Message;
            }
        }


        private HashSet<string> EvaluateSetExpression(string expr, HashSet<string> A, HashSet<string> B, HashSet<string> C)
        {
            expr = expr.Replace(" ", "")
                       .Replace("∪", "|")
                       .Replace("∩", "&")
                       .Replace("∖", "-")
                       .Replace("∆", "^");

            Dictionary<char, HashSet<string>> sets = new()
            {
                ['A'] = A,
                ['B'] = B,
                ['C'] = C
            };

            Stack<HashSet<string>> values = new();
            Stack<char> ops = new();

            // Başlangıç karakter kontrolü
            if (expr.Length == 0 || !(char.IsLetter(expr[0]) || expr[0] == '('))
                throw new Exception("İfade geçersiz şekilde başlıyor.");

            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];

                if (c == '(')
                {
                    ops.Push(c);
                }
                else if (c == ')')
                {
                    if (!ops.Contains('('))
                        throw new Exception("Kapanmamış parantez var.");

                    while (ops.Peek() != '(')
                        ApplyTopOperator(values, ops);

                    ops.Pop(); // '('
                }
                else if ("ABC".Contains(c))
                {
                    values.Push(new HashSet<string>(sets[c]));
                }
                else if ("|&-^".Contains(c))
                {
                    // Son karakter işlemse hata ver
                    if (i == expr.Length - 1)
                        throw new Exception("İfade eksik operatörle bitiyor.");

                    while (ops.Count > 0 && Precedence(ops.Peek()) >= Precedence(c))
                        ApplyTopOperator(values, ops);
                    ops.Push(c);
                }
                else
                {
                    throw new Exception("Geçersiz karakter: " + c);
                }
            }

            while (ops.Count > 0)
                ApplyTopOperator(values, ops);

            if (values.Count != 1)
                throw new Exception("İfade hatalı veya eksik, lütfen kontrol edin.");

            return values.Pop();
        }



        private int Precedence(char op)
        {
            return op switch
            {
                '-' => 3,
                '&' => 2,
                '^' => 2,  // simetrik fark
                '|' => 1,
                _ => 0
            };
        }

        private void ApplyTopOperator(Stack<HashSet<string>> values, Stack<char> ops)
        {
            if (values.Count < 2)
                throw new Exception("İfade hatalı veya eksik. Lütfen yazım kurallarını kontrol edin.");

            var right = values.Pop();
            var left = values.Pop();
            var op = ops.Pop();

            HashSet<string> result = new(left);

            switch (op)
            {
                case '|': result.UnionWith(right); break;
                case '&': result.IntersectWith(right); break;
                case '-': result.ExceptWith(right); break;
                case '^': result.SymmetricExceptWith(right); break;
            }

            values.Push(result);
        }



        private void btnOpUnion_Click(object sender, EventArgs e) => txtExpression.Text += " ∪ ";

        private void btnOpIntersect_Click_1(object sender, EventArgs e)
        {
            txtExpression.Text += " ∩ ";
        }

        private void btnOpDiff_Click(object sender, EventArgs e)
        {
            txtExpression.Text += " ∖ ";
        }

        private void btnOpSymDiff_Click(object sender, EventArgs e)
        {
            txtExpression.Text += " ∆ ";
        }

        private void btnParOpen_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "(";
        }

        private void btnParClose_Click(object sender, EventArgs e)
        {
            txtExpression.Text += ")";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "A";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "B";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "C";
        }

        private void lblSetB_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstOperationHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelVenn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
