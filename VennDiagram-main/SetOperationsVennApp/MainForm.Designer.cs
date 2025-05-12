namespace KumeIslemleriVenn
{
    partial class KumeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSetA;
        private System.Windows.Forms.Label lblSetB;
        private System.Windows.Forms.TextBox txtSetA;
        private System.Windows.Forms.TextBox txtSetB;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnIntersection;
        private System.Windows.Forms.Button btnDifference;
        private System.Windows.Forms.Button btnReverseDifference;
        private System.Windows.Forms.Button btnSymmetricDifference;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panelVenn;
        private System.Windows.Forms.ListBox lstOperationHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSetA = new System.Windows.Forms.Label();
            lblSetB = new System.Windows.Forms.Label();
            txtSetA = new System.Windows.Forms.TextBox();
            txtSetB = new System.Windows.Forms.TextBox();
            btnUnion = new System.Windows.Forms.Button();
            btnIntersection = new System.Windows.Forms.Button();
            btnDifference = new System.Windows.Forms.Button();
            btnReverseDifference = new System.Windows.Forms.Button();
            btnSymmetricDifference = new System.Windows.Forms.Button();
            btnUndo = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            lblResult = new System.Windows.Forms.Label();
            panelVenn = new System.Windows.Forms.Panel();
            lstOperationHistory = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            txtSetC = new System.Windows.Forms.TextBox();
            btnUnionABC = new System.Windows.Forms.Button();
            btnİntersectionABC = new System.Windows.Forms.Button();
            lblSetC = new System.Windows.Forms.Label();
            txtExpression = new System.Windows.Forms.TextBox();
            btnEvaluateExpression = new System.Windows.Forms.Button();
            btnOpUnion = new System.Windows.Forms.Button();
            btnOpIntersect = new System.Windows.Forms.Button();
            btnOpDiff = new System.Windows.Forms.Button();
            btnOpSymDiff = new System.Windows.Forms.Button();
            btnParOpen = new System.Windows.Forms.Button();
            btnParClose = new System.Windows.Forms.Button();
            btnA = new System.Windows.Forms.Button();
            btnB = new System.Windows.Forms.Button();
            btnC = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblSetA
            // 
            lblSetA.AutoSize = true;
            lblSetA.Location = new System.Drawing.Point(25, 15);
            lblSetA.Name = "lblSetA";
            lblSetA.Size = new System.Drawing.Size(37, 15);
            lblSetA.TabIndex = 0;
            lblSetA.Text = "Set A:";
            lblSetA.Click += lblSetA_Click;
            // 
            // lblSetB
            // 
            lblSetB.AutoSize = true;
            lblSetB.Location = new System.Drawing.Point(25, 45);
            lblSetB.Name = "lblSetB";
            lblSetB.Size = new System.Drawing.Size(36, 15);
            lblSetB.TabIndex = 1;
            lblSetB.Text = "Set B:";
            // 
            // txtSetA
            // 
            txtSetA.Location = new System.Drawing.Point(80, 12);
            txtSetA.Name = "txtSetA";
            txtSetA.PlaceholderText = "Set A (virgülle ayır)";
            txtSetA.Size = new System.Drawing.Size(339, 23);
            txtSetA.TabIndex = 0;
            // 
            // txtSetB
            // 
            txtSetB.Location = new System.Drawing.Point(80, 42);
            txtSetB.Name = "txtSetB";
            txtSetB.PlaceholderText = "Set B (virgülle ayır)";
            txtSetB.Size = new System.Drawing.Size(339, 23);
            txtSetB.TabIndex = 1;
            // 
            // btnUnion
            // 
            btnUnion.BackColor = System.Drawing.Color.SkyBlue;
            btnUnion.Location = new System.Drawing.Point(12, 142);
            btnUnion.Name = "btnUnion";
            btnUnion.Size = new System.Drawing.Size(59, 77);
            btnUnion.TabIndex = 4;
            btnUnion.Text = "Union";
            btnUnion.UseVisualStyleBackColor = false;
            btnUnion.Click += btnUnion_Click;
            // 
            // btnIntersection
            // 
            btnIntersection.BackColor = System.Drawing.Color.SkyBlue;
            btnIntersection.Location = new System.Drawing.Point(77, 142);
            btnIntersection.Name = "btnIntersection";
            btnIntersection.Size = new System.Drawing.Size(74, 77);
            btnIntersection.TabIndex = 5;
            btnIntersection.Text = "Intersection";
            btnIntersection.UseVisualStyleBackColor = false;
            btnIntersection.Click += btnIntersection_Click;
            // 
            // btnDifference
            // 
            btnDifference.BackColor = System.Drawing.Color.PeachPuff;
            btnDifference.Location = new System.Drawing.Point(157, 143);
            btnDifference.Name = "btnDifference";
            btnDifference.Size = new System.Drawing.Size(73, 76);
            btnDifference.TabIndex = 6;
            btnDifference.Text = "A - B";
            btnDifference.UseVisualStyleBackColor = false;
            btnDifference.Click += btnDifference_Click;
            // 
            // btnReverseDifference
            // 
            btnReverseDifference.BackColor = System.Drawing.Color.PeachPuff;
            btnReverseDifference.Location = new System.Drawing.Point(236, 143);
            btnReverseDifference.Name = "btnReverseDifference";
            btnReverseDifference.Size = new System.Drawing.Size(76, 77);
            btnReverseDifference.TabIndex = 7;
            btnReverseDifference.Text = "B - A";
            btnReverseDifference.UseVisualStyleBackColor = false;
            btnReverseDifference.Click += btnReverseDifference_Click;
            // 
            // btnSymmetricDifference
            // 
            btnSymmetricDifference.BackColor = System.Drawing.Color.RosyBrown;
            btnSymmetricDifference.Location = new System.Drawing.Point(324, 142);
            btnSymmetricDifference.Name = "btnSymmetricDifference";
            btnSymmetricDifference.Size = new System.Drawing.Size(95, 76);
            btnSymmetricDifference.TabIndex = 8;
            btnSymmetricDifference.Text = "Symmetric Diff";
            btnSymmetricDifference.UseVisualStyleBackColor = false;
            btnSymmetricDifference.Click += btnSymmetricDifference_Click;
            // 
            // btnUndo
            // 
            btnUndo.BackColor = System.Drawing.Color.ForestGreen;
            btnUndo.Location = new System.Drawing.Point(324, 228);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new System.Drawing.Size(75, 76);
            btnUndo.TabIndex = 9;
            btnUndo.Text = "Geri Al";
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.Red;
            btnClear.Location = new System.Drawing.Point(239, 228);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(72, 77);
            btnClear.TabIndex = 10;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = System.Drawing.Color.Firebrick;
            lblResult.Location = new System.Drawing.Point(20, 100);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(42, 15);
            lblResult.TabIndex = 11;
            lblResult.Text = "Result:";
            // 
            // panelVenn
            // 
            panelVenn.BackColor = System.Drawing.Color.Silver;
            panelVenn.Location = new System.Drawing.Point(425, 12);
            panelVenn.Name = "panelVenn";
            panelVenn.Size = new System.Drawing.Size(1252, 870);
            panelVenn.TabIndex = 12;
            // 
            // lstOperationHistory
            // 
            lstOperationHistory.FormattingEnabled = true;
            lstOperationHistory.ItemHeight = 15;
            lstOperationHistory.Location = new System.Drawing.Point(12, 336);
            lstOperationHistory.Name = "lstOperationHistory";
            lstOperationHistory.Size = new System.Drawing.Size(184, 439);
            lstOperationHistory.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 314);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 19);
            label1.TabIndex = 14;
            label1.Text = "Operations History";
            // 
            // txtSetC
            // 
            txtSetC.Location = new System.Drawing.Point(80, 71);
            txtSetC.Name = "txtSetC";
            txtSetC.PlaceholderText = "Set C (virgülle ayır)";
            txtSetC.Size = new System.Drawing.Size(339, 23);
            txtSetC.TabIndex = 2;
            // 
            // btnUnionABC
            // 
            btnUnionABC.BackColor = System.Drawing.Color.Lavender;
            btnUnionABC.Location = new System.Drawing.Point(20, 230);
            btnUnionABC.Name = "btnUnionABC";
            btnUnionABC.Size = new System.Drawing.Size(75, 37);
            btnUnionABC.TabIndex = 16;
            btnUnionABC.Text = "A ∪ B ∪ C";
            btnUnionABC.UseVisualStyleBackColor = false;
            btnUnionABC.Click += btnUnionABC_Click;
            // 
            // btnİntersectionABC
            // 
            btnİntersectionABC.BackColor = System.Drawing.Color.Lavender;
            btnİntersectionABC.Location = new System.Drawing.Point(121, 228);
            btnİntersectionABC.Name = "btnİntersectionABC";
            btnİntersectionABC.Size = new System.Drawing.Size(75, 41);
            btnİntersectionABC.TabIndex = 17;
            btnİntersectionABC.Text = "A ∩ B ∩ C";
            btnİntersectionABC.UseVisualStyleBackColor = false;
            btnİntersectionABC.Click += btnİntersectionABC_Click;
            // 
            // lblSetC
            // 
            lblSetC.AutoSize = true;
            lblSetC.Location = new System.Drawing.Point(25, 71);
            lblSetC.Name = "lblSetC";
            lblSetC.Size = new System.Drawing.Size(37, 15);
            lblSetC.TabIndex = 18;
            lblSetC.Text = "Set C:";
            lblSetC.Click += label2_Click;
            // 
            // txtExpression
            // 
            txtExpression.Location = new System.Drawing.Point(202, 336);
            txtExpression.Name = "txtExpression";
            txtExpression.PlaceholderText = "Yapmak istediğiniz işlemi girin";
            txtExpression.Size = new System.Drawing.Size(217, 23);
            txtExpression.TabIndex = 19;
            // 
            // btnEvaluateExpression
            // 
            btnEvaluateExpression.Location = new System.Drawing.Point(344, 310);
            btnEvaluateExpression.Name = "btnEvaluateExpression";
            btnEvaluateExpression.Size = new System.Drawing.Size(75, 23);
            btnEvaluateExpression.TabIndex = 20;
            btnEvaluateExpression.Text = "Hesapla";
            btnEvaluateExpression.UseVisualStyleBackColor = true;
            btnEvaluateExpression.Click += btnEvaluateExpression_Click;
            // 
            // btnOpUnion
            // 
            btnOpUnion.Location = new System.Drawing.Point(202, 394);
            btnOpUnion.Name = "btnOpUnion";
            btnOpUnion.Size = new System.Drawing.Size(52, 23);
            btnOpUnion.TabIndex = 21;
            btnOpUnion.Text = "∪";
            btnOpUnion.UseVisualStyleBackColor = true;
            btnOpUnion.Click += btnOpUnion_Click;
            // 
            // btnOpIntersect
            // 
            btnOpIntersect.Location = new System.Drawing.Point(315, 394);
            btnOpIntersect.Name = "btnOpIntersect";
            btnOpIntersect.Size = new System.Drawing.Size(56, 23);
            btnOpIntersect.TabIndex = 22;
            btnOpIntersect.Text = "∩";
            btnOpIntersect.UseVisualStyleBackColor = true;
            btnOpIntersect.Click += btnOpIntersect_Click_1;
            // 
            // btnOpDiff
            // 
            btnOpDiff.Location = new System.Drawing.Point(259, 394);
            btnOpDiff.Name = "btnOpDiff";
            btnOpDiff.Size = new System.Drawing.Size(53, 23);
            btnOpDiff.TabIndex = 23;
            btnOpDiff.Text = "∖";
            btnOpDiff.UseVisualStyleBackColor = true;
            btnOpDiff.Click += btnOpDiff_Click;
            // 
            // btnOpSymDiff
            // 
            btnOpSymDiff.Location = new System.Drawing.Point(202, 423);
            btnOpSymDiff.Name = "btnOpSymDiff";
            btnOpSymDiff.Size = new System.Drawing.Size(52, 23);
            btnOpSymDiff.TabIndex = 24;
            btnOpSymDiff.Text = "∆";
            btnOpSymDiff.UseVisualStyleBackColor = true;
            btnOpSymDiff.Click += btnOpSymDiff_Click;
            // 
            // btnParOpen
            // 
            btnParOpen.Location = new System.Drawing.Point(259, 423);
            btnParOpen.Name = "btnParOpen";
            btnParOpen.Size = new System.Drawing.Size(52, 23);
            btnParOpen.TabIndex = 25;
            btnParOpen.Text = "(";
            btnParOpen.UseVisualStyleBackColor = true;
            btnParOpen.Click += btnParOpen_Click;
            // 
            // btnParClose
            // 
            btnParClose.Location = new System.Drawing.Point(317, 423);
            btnParClose.Name = "btnParClose";
            btnParClose.Size = new System.Drawing.Size(54, 23);
            btnParClose.TabIndex = 26;
            btnParClose.Text = ")";
            btnParClose.UseVisualStyleBackColor = true;
            btnParClose.Click += btnParClose_Click;
            // 
            // btnA
            // 
            btnA.Location = new System.Drawing.Point(202, 365);
            btnA.Name = "btnA";
            btnA.Size = new System.Drawing.Size(52, 23);
            btnA.TabIndex = 27;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new System.Drawing.Point(259, 365);
            btnB.Name = "btnB";
            btnB.Size = new System.Drawing.Size(52, 23);
            btnB.TabIndex = 28;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new System.Drawing.Point(319, 365);
            btnC.Name = "btnC";
            btnC.Size = new System.Drawing.Size(52, 23);
            btnC.TabIndex = 29;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // KumeForm
            // 
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(1924, 1061);
            Controls.Add(btnUndo);
            Controls.Add(btnClear);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(btnParClose);
            Controls.Add(btnParOpen);
            Controls.Add(btnOpSymDiff);
            Controls.Add(btnOpDiff);
            Controls.Add(btnOpIntersect);
            Controls.Add(btnOpUnion);
            Controls.Add(btnEvaluateExpression);
            Controls.Add(txtExpression);
            Controls.Add(label1);
            Controls.Add(lblSetC);
            Controls.Add(btnİntersectionABC);
            Controls.Add(btnUnionABC);
            Controls.Add(txtSetC);
            Controls.Add(lstOperationHistory);
            Controls.Add(panelVenn);
            Controls.Add(lblResult);
            Controls.Add(btnSymmetricDifference);
            Controls.Add(btnReverseDifference);
            Controls.Add(btnDifference);
            Controls.Add(btnIntersection);
            Controls.Add(btnUnion);
            Controls.Add(txtSetB);
            Controls.Add(txtSetA);
            Controls.Add(lblSetB);
            Controls.Add(lblSetA);
            Name = "KumeForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Küme İşlemleri ve Venn Diyagramı";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += KumeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSetC;
        private System.Windows.Forms.Button btnUnionABC;
        private System.Windows.Forms.Button btnİntersectionABC;
        private System.Windows.Forms.Label lblSetC;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Button btnEvaluateExpression;
        private System.Windows.Forms.Button btnOpUnion;
        private System.Windows.Forms.Button btnOpIntersect;
        private System.Windows.Forms.Button btnOpDiff;
        private System.Windows.Forms.Button btnOpSymDiff;
        private System.Windows.Forms.Button btnParOpen;
        private System.Windows.Forms.Button btnParClose;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
    }
}
