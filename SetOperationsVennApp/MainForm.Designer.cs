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
            this.lblSetA = new System.Windows.Forms.Label();
            this.lblSetB = new System.Windows.Forms.Label();
            this.txtSetA = new System.Windows.Forms.TextBox();
            this.txtSetB = new System.Windows.Forms.TextBox();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnIntersection = new System.Windows.Forms.Button();
            this.btnDifference = new System.Windows.Forms.Button();
            this.btnReverseDifference = new System.Windows.Forms.Button();
            this.btnSymmetricDifference = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.panelVenn = new System.Windows.Forms.Panel();
            this.lstOperationHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSetA
            // 
            this.lblSetA.AutoSize = true;
            this.lblSetA.Location = new System.Drawing.Point(20, 20);
            this.lblSetA.Name = "lblSetA";
            this.lblSetA.Size = new System.Drawing.Size(42, 16);
            this.lblSetA.TabIndex = 0;
            this.lblSetA.Text = "Set A:";
            // 
            // lblSetB
            // 
            this.lblSetB.AutoSize = true;
            this.lblSetB.Location = new System.Drawing.Point(20, 60);
            this.lblSetB.Name = "lblSetB";
            this.lblSetB.Size = new System.Drawing.Size(42, 16);
            this.lblSetB.TabIndex = 1;
            this.lblSetB.Text = "Set B:";
            // 
            // txtSetA
            // 
            this.txtSetA.Location = new System.Drawing.Point(80, 17);
            this.txtSetA.Name = "txtSetA";
            this.txtSetA.Size = new System.Drawing.Size(100, 22);
            this.txtSetA.TabIndex = 2;
            // 
            // txtSetB
            // 
            this.txtSetB.Location = new System.Drawing.Point(80, 57);
            this.txtSetB.Name = "txtSetB";
            this.txtSetB.Size = new System.Drawing.Size(100, 22);
            this.txtSetB.TabIndex = 3;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(200, 15);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(75, 23);
            this.btnUnion.TabIndex = 4;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnIntersection
            // 
            this.btnIntersection.Location = new System.Drawing.Point(200, 55);
            this.btnIntersection.Name = "btnIntersection";
            this.btnIntersection.Size = new System.Drawing.Size(75, 23);
            this.btnIntersection.TabIndex = 5;
            this.btnIntersection.Text = "Intersection";
            this.btnIntersection.UseVisualStyleBackColor = true;
            this.btnIntersection.Click += new System.EventHandler(this.btnIntersection_Click);
            // 
            // btnDifference
            // 
            this.btnDifference.Location = new System.Drawing.Point(200, 95);
            this.btnDifference.Name = "btnDifference";
            this.btnDifference.Size = new System.Drawing.Size(75, 23);
            this.btnDifference.TabIndex = 6;
            this.btnDifference.Text = "A - B";
            this.btnDifference.UseVisualStyleBackColor = true;
            this.btnDifference.Click += new System.EventHandler(this.btnDifference_Click);
            // 
            // btnReverseDifference
            // 
            this.btnReverseDifference.Location = new System.Drawing.Point(200, 135);
            this.btnReverseDifference.Name = "btnReverseDifference";
            this.btnReverseDifference.Size = new System.Drawing.Size(75, 23);
            this.btnReverseDifference.TabIndex = 7;
            this.btnReverseDifference.Text = "B - A";
            this.btnReverseDifference.UseVisualStyleBackColor = true;
            this.btnReverseDifference.Click += new System.EventHandler(this.btnReverseDifference_Click);
            // 
            // btnSymmetricDifference
            // 
            this.btnSymmetricDifference.Location = new System.Drawing.Point(200, 175);
            this.btnSymmetricDifference.Name = "btnSymmetricDifference";
            this.btnSymmetricDifference.Size = new System.Drawing.Size(75, 23);
            this.btnSymmetricDifference.TabIndex = 8;
            this.btnSymmetricDifference.Text = "Symmetric Diff";
            this.btnSymmetricDifference.UseVisualStyleBackColor = true;
            this.btnSymmetricDifference.Click += new System.EventHandler(this.btnSymmetricDifference_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(200, 215);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Geri Al";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(20, 300);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 16);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "Result:";
            // 
            // panelVenn
            // 
            this.panelVenn.Location = new System.Drawing.Point(20, 320);
            this.panelVenn.Name = "panelVenn";
            this.panelVenn.Size = new System.Drawing.Size(300, 150);
            this.panelVenn.TabIndex = 12;
            // 
            // lstOperationHistory
            // 
            this.lstOperationHistory.FormattingEnabled = true;
            this.lstOperationHistory.ItemHeight = 16;
            this.lstOperationHistory.Location = new System.Drawing.Point(326, 20);
            this.lstOperationHistory.Name = "lstOperationHistory";
            this.lstOperationHistory.Size = new System.Drawing.Size(200, 276);
            this.lstOperationHistory.TabIndex = 13;
            // 
            // KumeForm
            // 
            this.ClientSize = new System.Drawing.Size(550, 480);
            this.Controls.Add(this.lstOperationHistory);
            this.Controls.Add(this.panelVenn);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSymmetricDifference);
            this.Controls.Add(this.btnReverseDifference);
            this.Controls.Add(this.btnDifference);
            this.Controls.Add(this.btnIntersection);
            this.Controls.Add(this.btnUnion);
            this.Controls.Add(this.txtSetB);
            this.Controls.Add(this.txtSetA);
            this.Controls.Add(this.lblSetB);
            this.Controls.Add(this.lblSetA);
            this.Name = "KumeForm";
            this.Text = "Küme İşlemleri ve Venn Diyagramı";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
