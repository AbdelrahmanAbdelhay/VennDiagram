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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblSetA
            // 
            lblSetA.AutoSize = true;
            lblSetA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSetA.Location = new System.Drawing.Point(28, 12);
            lblSetA.Name = "lblSetA";
            lblSetA.Size = new System.Drawing.Size(47, 20);
            lblSetA.TabIndex = 0;
            lblSetA.Text = "Set A:";
            lblSetA.Click += lblSetA_Click;
            // 
            // lblSetB
            // 
            lblSetB.AutoSize = true;
            lblSetB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSetB.Location = new System.Drawing.Point(28, 53);
            lblSetB.Name = "lblSetB";
            lblSetB.Size = new System.Drawing.Size(46, 20);
            lblSetB.TabIndex = 1;
            lblSetB.Text = "Set B:";
            lblSetB.Click += lblSetB_Click;
            // 
            // txtSetA
            // 
            txtSetA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSetA.Location = new System.Drawing.Point(80, 12);
            txtSetA.Name = "txtSetA";
            txtSetA.PlaceholderText = "Set A (comma seperated)";
            txtSetA.Size = new System.Drawing.Size(524, 27);
            txtSetA.TabIndex = 0;
            // 
            // txtSetB
            // 
            txtSetB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSetB.Location = new System.Drawing.Point(80, 50);
            txtSetB.Name = "txtSetB";
            txtSetB.PlaceholderText = "Set B (comma seperated)";
            txtSetB.Size = new System.Drawing.Size(524, 27);
            txtSetB.TabIndex = 1;
            // 
            // btnUnion
            // 
            btnUnion.BackColor = System.Drawing.Color.SkyBlue;
            btnUnion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUnion.Location = new System.Drawing.Point(24, 183);
            btnUnion.Name = "btnUnion";
            btnUnion.Size = new System.Drawing.Size(99, 60);
            btnUnion.TabIndex = 4;
            btnUnion.Text = "Union";
            btnUnion.UseVisualStyleBackColor = false;
            btnUnion.Click += btnUnion_Click;
            // 
            // btnIntersection
            // 
            btnIntersection.BackColor = System.Drawing.Color.SkyBlue;
            btnIntersection.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnIntersection.Location = new System.Drawing.Point(130, 183);
            btnIntersection.Name = "btnIntersection";
            btnIntersection.Size = new System.Drawing.Size(108, 60);
            btnIntersection.TabIndex = 5;
            btnIntersection.Text = "Intersection";
            btnIntersection.UseVisualStyleBackColor = false;
            btnIntersection.Click += btnIntersection_Click;
            // 
            // btnDifference
            // 
            btnDifference.BackColor = System.Drawing.Color.PeachPuff;
            btnDifference.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDifference.Location = new System.Drawing.Point(255, 183);
            btnDifference.Name = "btnDifference";
            btnDifference.Size = new System.Drawing.Size(101, 60);
            btnDifference.TabIndex = 6;
            btnDifference.Text = "A - B";
            btnDifference.UseVisualStyleBackColor = false;
            btnDifference.Click += btnDifference_Click;
            // 
            // btnReverseDifference
            // 
            btnReverseDifference.BackColor = System.Drawing.Color.PeachPuff;
            btnReverseDifference.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnReverseDifference.Location = new System.Drawing.Point(372, 183);
            btnReverseDifference.Name = "btnReverseDifference";
            btnReverseDifference.Size = new System.Drawing.Size(98, 60);
            btnReverseDifference.TabIndex = 7;
            btnReverseDifference.Text = "B - A";
            btnReverseDifference.UseVisualStyleBackColor = false;
            btnReverseDifference.Click += btnReverseDifference_Click;
            // 
            // btnSymmetricDifference
            // 
            btnSymmetricDifference.BackColor = System.Drawing.Color.RosyBrown;
            btnSymmetricDifference.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSymmetricDifference.Location = new System.Drawing.Point(488, 183);
            btnSymmetricDifference.Name = "btnSymmetricDifference";
            btnSymmetricDifference.Size = new System.Drawing.Size(114, 60);
            btnSymmetricDifference.TabIndex = 8;
            btnSymmetricDifference.Text = "Symmetric Diff";
            btnSymmetricDifference.UseVisualStyleBackColor = false;
            btnSymmetricDifference.Click += btnSymmetricDifference_Click;
            // 
            // btnUndo
            // 
            btnUndo.BackColor = System.Drawing.Color.ForestGreen;
            btnUndo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUndo.Location = new System.Drawing.Point(478, 612);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new System.Drawing.Size(143, 154);
            btnUndo.TabIndex = 9;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.Red;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClear.Location = new System.Drawing.Point(478, 772);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(143, 153);
            btnClear.TabIndex = 10;
            btnClear.Text = "Delete";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblResult.ForeColor = System.Drawing.Color.Firebrick;
            lblResult.Location = new System.Drawing.Point(25, 128);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(57, 20);
            lblResult.TabIndex = 11;
            lblResult.Text = "Result:";
            // 
            // panelVenn
            // 
            panelVenn.BackColor = System.Drawing.Color.Silver;
            panelVenn.Location = new System.Drawing.Point(633, 12);
            panelVenn.Name = "panelVenn";
            panelVenn.Size = new System.Drawing.Size(1044, 911);
            panelVenn.TabIndex = 12;
            panelVenn.Paint += panelVenn_Paint;
            // 
            // lstOperationHistory
            // 
            lstOperationHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstOperationHistory.FormattingEnabled = true;
            lstOperationHistory.ItemHeight = 25;
            lstOperationHistory.Location = new System.Drawing.Point(12, 615);
            lstOperationHistory.Name = "lstOperationHistory";
            lstOperationHistory.Size = new System.Drawing.Size(466, 304);
            lstOperationHistory.TabIndex = 13;
            lstOperationHistory.SelectedIndexChanged += lstOperationHistory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 585);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(154, 21);
            label1.TabIndex = 14;
            label1.Text = "Operations History";
            // 
            // txtSetC
            // 
            txtSetC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSetC.Location = new System.Drawing.Point(80, 92);
            txtSetC.Name = "txtSetC";
            txtSetC.PlaceholderText = "Set C (comma seperated)";
            txtSetC.Size = new System.Drawing.Size(524, 27);
            txtSetC.TabIndex = 2;
            // 
            // btnUnionABC
            // 
            btnUnionABC.BackColor = System.Drawing.Color.Lavender;
            btnUnionABC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUnionABC.Location = new System.Drawing.Point(126, 258);
            btnUnionABC.Name = "btnUnionABC";
            btnUnionABC.Size = new System.Drawing.Size(161, 48);
            btnUnionABC.TabIndex = 16;
            btnUnionABC.Text = "A ∪ B ∪ C";
            btnUnionABC.UseVisualStyleBackColor = false;
            btnUnionABC.Click += btnUnionABC_Click;
            // 
            // btnİntersectionABC
            // 
            btnİntersectionABC.BackColor = System.Drawing.Color.Lavender;
            btnİntersectionABC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnİntersectionABC.Location = new System.Drawing.Point(293, 258);
            btnİntersectionABC.Name = "btnİntersectionABC";
            btnİntersectionABC.Size = new System.Drawing.Size(169, 48);
            btnİntersectionABC.TabIndex = 17;
            btnİntersectionABC.Text = "A ∩ B ∩ C";
            btnİntersectionABC.UseVisualStyleBackColor = false;
            btnİntersectionABC.Click += btnİntersectionABC_Click;
            // 
            // lblSetC
            // 
            lblSetC.AutoSize = true;
            lblSetC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSetC.Location = new System.Drawing.Point(28, 95);
            lblSetC.Name = "lblSetC";
            lblSetC.Size = new System.Drawing.Size(46, 20);
            lblSetC.TabIndex = 18;
            lblSetC.Text = "Set C:";
            lblSetC.Click += label2_Click;
            // 
            // txtExpression
            // 
            txtExpression.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtExpression.Location = new System.Drawing.Point(91, 359);
            txtExpression.Name = "txtExpression";
            txtExpression.PlaceholderText = "Enter the operation you want to calculate";
            txtExpression.Size = new System.Drawing.Size(388, 29);
            txtExpression.TabIndex = 19;
            // 
            // btnEvaluateExpression
            // 
            btnEvaluateExpression.BackColor = System.Drawing.Color.RoyalBlue;
            btnEvaluateExpression.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEvaluateExpression.Location = new System.Drawing.Point(279, 399);
            btnEvaluateExpression.Name = "btnEvaluateExpression";
            btnEvaluateExpression.Size = new System.Drawing.Size(199, 175);
            btnEvaluateExpression.TabIndex = 20;
            btnEvaluateExpression.Text = "Calculate";
            btnEvaluateExpression.UseVisualStyleBackColor = false;
            btnEvaluateExpression.Click += btnEvaluateExpression_Click;
            // 
            // btnOpUnion
            // 
            btnOpUnion.BackColor = System.Drawing.Color.Silver;
            btnOpUnion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOpUnion.Location = new System.Drawing.Point(90, 459);
            btnOpUnion.Name = "btnOpUnion";
            btnOpUnion.Size = new System.Drawing.Size(57, 55);
            btnOpUnion.TabIndex = 21;
            btnOpUnion.Text = "∪";
            btnOpUnion.UseVisualStyleBackColor = false;
            btnOpUnion.Click += btnOpUnion_Click;
            // 
            // btnOpIntersect
            // 
            btnOpIntersect.BackColor = System.Drawing.Color.Silver;
            btnOpIntersect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOpIntersect.Location = new System.Drawing.Point(153, 459);
            btnOpIntersect.Name = "btnOpIntersect";
            btnOpIntersect.Size = new System.Drawing.Size(57, 55);
            btnOpIntersect.TabIndex = 22;
            btnOpIntersect.Text = "∩";
            btnOpIntersect.UseVisualStyleBackColor = false;
            btnOpIntersect.Click += btnOpIntersect_Click_1;
            // 
            // btnOpDiff
            // 
            btnOpDiff.BackColor = System.Drawing.Color.Silver;
            btnOpDiff.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOpDiff.Location = new System.Drawing.Point(152, 520);
            btnOpDiff.Name = "btnOpDiff";
            btnOpDiff.Size = new System.Drawing.Size(58, 54);
            btnOpDiff.TabIndex = 23;
            btnOpDiff.Text = "∖";
            btnOpDiff.UseVisualStyleBackColor = false;
            btnOpDiff.Click += btnOpDiff_Click;
            // 
            // btnOpSymDiff
            // 
            btnOpSymDiff.BackColor = System.Drawing.Color.Silver;
            btnOpSymDiff.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOpSymDiff.Location = new System.Drawing.Point(216, 459);
            btnOpSymDiff.Name = "btnOpSymDiff";
            btnOpSymDiff.Size = new System.Drawing.Size(57, 55);
            btnOpSymDiff.TabIndex = 24;
            btnOpSymDiff.Text = "∆";
            btnOpSymDiff.UseVisualStyleBackColor = false;
            btnOpSymDiff.Click += btnOpSymDiff_Click;
            // 
            // btnParOpen
            // 
            btnParOpen.BackColor = System.Drawing.Color.Silver;
            btnParOpen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnParOpen.Location = new System.Drawing.Point(91, 520);
            btnParOpen.Name = "btnParOpen";
            btnParOpen.Size = new System.Drawing.Size(57, 54);
            btnParOpen.TabIndex = 25;
            btnParOpen.Text = "(";
            btnParOpen.UseVisualStyleBackColor = false;
            btnParOpen.Click += btnParOpen_Click;
            // 
            // btnParClose
            // 
            btnParClose.BackColor = System.Drawing.Color.Silver;
            btnParClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnParClose.Location = new System.Drawing.Point(214, 520);
            btnParClose.Name = "btnParClose";
            btnParClose.Size = new System.Drawing.Size(59, 54);
            btnParClose.TabIndex = 26;
            btnParClose.Text = ")";
            btnParClose.UseVisualStyleBackColor = false;
            btnParClose.Click += btnParClose_Click;
            // 
            // btnA
            // 
            btnA.BackColor = System.Drawing.Color.Silver;
            btnA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnA.Location = new System.Drawing.Point(90, 399);
            btnA.Name = "btnA";
            btnA.Size = new System.Drawing.Size(57, 54);
            btnA.TabIndex = 27;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.BackColor = System.Drawing.Color.Silver;
            btnB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnB.Location = new System.Drawing.Point(153, 399);
            btnB.Name = "btnB";
            btnB.Size = new System.Drawing.Size(57, 54);
            btnB.TabIndex = 28;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.BackColor = System.Drawing.Color.Silver;
            btnC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnC.Location = new System.Drawing.Point(216, 399);
            btnC.Name = "btnC";
            btnC.Size = new System.Drawing.Size(57, 54);
            btnC.TabIndex = 29;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(114, 150);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(378, 21);
            label2.TabIndex = 30;
            label2.Text = "Common Operations between two sets (A and B)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.DarkViolet;
            label3.Location = new System.Drawing.Point(201, 321);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 25);
            label3.TabIndex = 31;
            label3.Text = "Set Calculator";
            // 
            // KumeForm
            // 
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(1701, 937);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
