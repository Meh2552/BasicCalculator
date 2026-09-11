namespace CalculatorApplication
{
    partial class FrmCalculator
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
            lbStudentNo = new Label();
            txtBoxInput1 = new TextBox();
            panel1 = new Panel();
            lbHeader = new Label();
            btnEqual = new Button();
            txtBoxInput2 = new TextBox();
            label1 = new Label();
            cbOperator = new ComboBox();
            lblDisplayTotal = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbStudentNo
            // 
            lbStudentNo.AutoSize = true;
            lbStudentNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStudentNo.ForeColor = Color.White;
            lbStudentNo.Location = new Point(52, 121);
            lbStudentNo.Name = "lbStudentNo";
            lbStudentNo.Size = new Size(142, 21);
            lbStudentNo.TabIndex = 0;
            lbStudentNo.Text = "Enter First Number";
            lbStudentNo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput1.Location = new Point(209, 118);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(190, 29);
            txtBoxInput1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lbHeader);
            panel1.Location = new Point(1, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 92);
            panel1.TabIndex = 16;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.White;
            lbHeader.Location = new Point(30, 23);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(187, 47);
            lbHeader.TabIndex = 17;
            lbHeader.Text = "Calculator";
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(145, 311);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(130, 47);
            btnEqual.TabIndex = 17;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput2.Location = new Point(209, 196);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(190, 29);
            txtBoxInput2.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 199);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 18;
            label1.Text = "Enter Second Number";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(264, 158);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(82, 27);
            cbOperator.TabIndex = 20;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayTotal.ForeColor = Color.White;
            lblDisplayTotal.Location = new Point(209, 249);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(0, 21);
            lblDisplayTotal.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(132, 249);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 22;
            label3.Text = "Answer";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(435, 391);
            Controls.Add(label3);
            Controls.Add(lblDisplayTotal);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(label1);
            Controls.Add(btnEqual);
            Controls.Add(panel1);
            Controls.Add(txtBoxInput1);
            Controls.Add(lbStudentNo);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStudentNo;
        private TextBox txtBoxInput1;
        private Panel panel1;
        private Label lbHeader;
        private Button btnEqual;
        private TextBox txtBoxInput2;
        private Label label1;
        private ComboBox cbOperator;
        private Label lblDisplayTotal;
        private Label label3;
    }
}
