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
            SuspendLayout();
            // 
            // lblSetA
            // 
            lblSetA.AutoSize = true;
            lblSetA.Location = new System.Drawing.Point(20, 20);
            lblSetA.Name = "lblSetA";
            lblSetA.Size = new System.Drawing.Size(47, 20);
            lblSetA.TabIndex = 0;
            lblSetA.Text = "Set A:";
            // 
            // lblSetB
            // 
            lblSetB.AutoSize = true;
            lblSetB.Location = new System.Drawing.Point(20, 60);
            lblSetB.Name = "lblSetB";
            lblSetB.Size = new System.Drawing.Size(46, 20);
            lblSetB.TabIndex = 1;
            lblSetB.Text = "Set B:";
            // 
            // txtSetA
            // 
            txtSetA.Location = new System.Drawing.Point(80, 17);
            txtSetA.Name = "txtSetA";
            txtSetA.Size = new System.Drawing.Size(442, 27);
            txtSetA.TabIndex = 2;
            // 
            // txtSetB
            // 
            txtSetB.Location = new System.Drawing.Point(80, 57);
            txtSetB.Name = "txtSetB";
            txtSetB.Size = new System.Drawing.Size(442, 27);
            txtSetB.TabIndex = 3;
            // 
            // btnUnion
            // 
            btnUnion.BackColor = System.Drawing.Color.SkyBlue;
            btnUnion.Location = new System.Drawing.Point(538, 12);
            btnUnion.Name = "btnUnion";
            btnUnion.Size = new System.Drawing.Size(194, 72);
            btnUnion.TabIndex = 4;
            btnUnion.Text = "Union";
            btnUnion.UseVisualStyleBackColor = false;
            btnUnion.Click += btnUnion_Click;
            // 
            // btnIntersection
            // 
            btnIntersection.BackColor = System.Drawing.Color.SkyBlue;
            btnIntersection.Location = new System.Drawing.Point(538, 100);
            btnIntersection.Name = "btnIntersection";
            btnIntersection.Size = new System.Drawing.Size(194, 74);
            btnIntersection.TabIndex = 5;
            btnIntersection.Text = "Intersection";
            btnIntersection.UseVisualStyleBackColor = false;
            btnIntersection.Click += btnIntersection_Click;
            // 
            // btnDifference
            // 
            btnDifference.BackColor = System.Drawing.Color.PeachPuff;
            btnDifference.Location = new System.Drawing.Point(546, 198);
            btnDifference.Name = "btnDifference";
            btnDifference.Size = new System.Drawing.Size(178, 66);
            btnDifference.TabIndex = 6;
            btnDifference.Text = "A - B";
            btnDifference.UseVisualStyleBackColor = false;
            btnDifference.Click += btnDifference_Click;
            // 
            // btnReverseDifference
            // 
            btnReverseDifference.BackColor = System.Drawing.Color.PeachPuff;
            btnReverseDifference.Location = new System.Drawing.Point(546, 293);
            btnReverseDifference.Name = "btnReverseDifference";
            btnReverseDifference.Size = new System.Drawing.Size(178, 66);
            btnReverseDifference.TabIndex = 7;
            btnReverseDifference.Text = "B - A";
            btnReverseDifference.UseVisualStyleBackColor = false;
            btnReverseDifference.Click += btnReverseDifference_Click;
            // 
            // btnSymmetricDifference
            // 
            btnSymmetricDifference.BackColor = System.Drawing.Color.RosyBrown;
            btnSymmetricDifference.Location = new System.Drawing.Point(546, 388);
            btnSymmetricDifference.Name = "btnSymmetricDifference";
            btnSymmetricDifference.Size = new System.Drawing.Size(178, 66);
            btnSymmetricDifference.TabIndex = 8;
            btnSymmetricDifference.Text = "Symmetric Diff";
            btnSymmetricDifference.UseVisualStyleBackColor = false;
            btnSymmetricDifference.Click += btnSymmetricDifference_Click;
            // 
            // btnUndo
            // 
            btnUndo.BackColor = System.Drawing.Color.ForestGreen;
            btnUndo.Location = new System.Drawing.Point(546, 503);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new System.Drawing.Size(178, 78);
            btnUndo.TabIndex = 9;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.Red;
            btnClear.Location = new System.Drawing.Point(546, 587);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(178, 84);
            btnClear.TabIndex = 10;
            btnClear.Text = "Delete";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = System.Drawing.Color.Firebrick;
            lblResult.Location = new System.Drawing.Point(20, 100);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(52, 20);
            lblResult.TabIndex = 11;
            lblResult.Text = "Result:";
            // 
            // panelVenn
            // 
            panelVenn.BackColor = System.Drawing.Color.Silver;
            panelVenn.Location = new System.Drawing.Point(20, 130);
            panelVenn.Name = "panelVenn";
            panelVenn.Size = new System.Drawing.Size(502, 324);
            panelVenn.TabIndex = 12;
            // 
            // lstOperationHistory
            // 
            lstOperationHistory.FormattingEnabled = true;
            lstOperationHistory.ItemHeight = 20;
            lstOperationHistory.Location = new System.Drawing.Point(20, 503);
            lstOperationHistory.Name = "lstOperationHistory";
            lstOperationHistory.Size = new System.Drawing.Size(502, 244);
            lstOperationHistory.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(20, 471);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(162, 23);
            label1.TabIndex = 14;
            label1.Text = "Operations History";
            // 
            // KumeForm
            // 
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(765, 759);
            Controls.Add(label1);
            Controls.Add(lstOperationHistory);
            Controls.Add(panelVenn);
            Controls.Add(lblResult);
            Controls.Add(btnClear);
            Controls.Add(btnUndo);
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
            Text = "Küme İşlemleri ve Venn Diyagramı";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
    }
}
