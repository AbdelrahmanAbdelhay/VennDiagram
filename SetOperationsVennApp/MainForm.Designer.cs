// MainForm.Designer.cs
namespace SetOperationsVennApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSetA;
        private System.Windows.Forms.TextBox txtSetB;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnIntersection;
        private System.Windows.Forms.Button btnDifference;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panelVenn;

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
            txtSetA = new System.Windows.Forms.TextBox();
            txtSetB = new System.Windows.Forms.TextBox();
            btnUnion = new System.Windows.Forms.Button();
            btnIntersection = new System.Windows.Forms.Button();
            btnDifference = new System.Windows.Forms.Button();
            lblResult = new System.Windows.Forms.Label();
            panelVenn = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // txtSetA
            // 
            txtSetA.Location = new System.Drawing.Point(30, 25);
            txtSetA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSetA.Name = "txtSetA";
            txtSetA.PlaceholderText = "Enter Set A (comma-separated)";
            txtSetA.Size = new System.Drawing.Size(510, 27);
            txtSetA.TabIndex = 0;
            // 
            // txtSetB
            // 
            txtSetB.Location = new System.Drawing.Point(30, 75);
            txtSetB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSetB.Name = "txtSetB";
            txtSetB.PlaceholderText = "Enter Set B (comma-separated)";
            txtSetB.Size = new System.Drawing.Size(510, 27);
            txtSetB.TabIndex = 1;
            // 
            // btnUnion
            // 
            btnUnion.Location = new System.Drawing.Point(561, 25);
            btnUnion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUnion.Name = "btnUnion";
            btnUnion.Size = new System.Drawing.Size(101, 38);
            btnUnion.TabIndex = 2;
            btnUnion.Text = "Union";
            btnUnion.UseVisualStyleBackColor = true;
            btnUnion.Click += btnUnion_Click;
            // 
            // btnIntersection
            // 
            btnIntersection.Location = new System.Drawing.Point(561, 75);
            btnIntersection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnIntersection.Name = "btnIntersection";
            btnIntersection.Size = new System.Drawing.Size(101, 38);
            btnIntersection.TabIndex = 3;
            btnIntersection.Text = "Intersection";
            btnIntersection.UseVisualStyleBackColor = true;
            btnIntersection.Click += btnIntersection_Click;
            // 
            // btnDifference
            // 
            btnDifference.Location = new System.Drawing.Point(561, 125);
            btnDifference.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDifference.Name = "btnDifference";
            btnDifference.Size = new System.Drawing.Size(101, 38);
            btnDifference.TabIndex = 4;
            btnDifference.Text = "A - B";
            btnDifference.UseVisualStyleBackColor = true;
            btnDifference.Click += btnDifference_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new System.Drawing.Point(30, 125);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(0, 20);
            lblResult.TabIndex = 5;
            // 
            // panelVenn
            // 
            panelVenn.BackColor = System.Drawing.Color.Gray;
            panelVenn.Location = new System.Drawing.Point(30, 158);
            panelVenn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelVenn.Name = "panelVenn";
            panelVenn.Size = new System.Drawing.Size(510, 438);
            panelVenn.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 621);
            Controls.Add(panelVenn);
            Controls.Add(lblResult);
            Controls.Add(btnDifference);
            Controls.Add(btnIntersection);
            Controls.Add(btnUnion);
            Controls.Add(txtSetB);
            Controls.Add(txtSetA);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Set Operations with Venn Diagram";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}