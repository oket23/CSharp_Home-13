namespace Home_13
{
    partial class task1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            backToMenuButton = new Button();
            generateButton = new Button();
            allNumbersLb = new Label();
            allNumbersRtb = new RichTextBox();
            primeNumbersLb = new Label();
            primeNumbersRtb = new RichTextBox();
            FibonacciNumbersLb = new Label();
            fibonacciNumbersRtb = new RichTextBox();
            statsLb = new Label();
            statsRtb = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(384, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Taks 1";
            // 
            // backToMenuButton
            // 
            backToMenuButton.FlatStyle = FlatStyle.Flat;
            backToMenuButton.Location = new Point(12, 453);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(95, 39);
            backToMenuButton.TabIndex = 1;
            backToMenuButton.Text = "Back to menu";
            backToMenuButton.UseVisualStyleBackColor = true;
            backToMenuButton.Click += backToMenuButton_Click;
            // 
            // generateButton
            // 
            generateButton.FlatStyle = FlatStyle.Flat;
            generateButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            generateButton.Location = new Point(733, 453);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(97, 39);
            generateButton.TabIndex = 2;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // allNumbersLb
            // 
            allNumbersLb.AutoSize = true;
            allNumbersLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            allNumbersLb.Location = new Point(12, 63);
            allNumbersLb.Name = "allNumbersLb";
            allNumbersLb.Size = new Size(147, 32);
            allNumbersLb.TabIndex = 3;
            allNumbersLb.Text = "All numbers:";
            // 
            // allNumbersRtb
            // 
            allNumbersRtb.BackColor = Color.White;
            allNumbersRtb.BorderStyle = BorderStyle.FixedSingle;
            allNumbersRtb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            allNumbersRtb.Location = new Point(15, 101);
            allNumbersRtb.Margin = new Padding(6);
            allNumbersRtb.Name = "allNumbersRtb";
            allNumbersRtb.ReadOnly = true;
            allNumbersRtb.Size = new Size(391, 141);
            allNumbersRtb.TabIndex = 4;
            allNumbersRtb.Text = "";
            allNumbersRtb.TextChanged += allNumbersRtb_TextChanged;
            // 
            // primeNumbersLb
            // 
            primeNumbersLb.AutoSize = true;
            primeNumbersLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            primeNumbersLb.Location = new Point(436, 63);
            primeNumbersLb.Name = "primeNumbersLb";
            primeNumbersLb.Size = new Size(181, 32);
            primeNumbersLb.TabIndex = 3;
            primeNumbersLb.Text = "Prime numbers:";
            // 
            // primeNumbersRtb
            // 
            primeNumbersRtb.BackColor = Color.White;
            primeNumbersRtb.BorderStyle = BorderStyle.FixedSingle;
            primeNumbersRtb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            primeNumbersRtb.Location = new Point(436, 101);
            primeNumbersRtb.Margin = new Padding(6);
            primeNumbersRtb.Name = "primeNumbersRtb";
            primeNumbersRtb.ReadOnly = true;
            primeNumbersRtb.Size = new Size(391, 141);
            primeNumbersRtb.TabIndex = 4;
            primeNumbersRtb.Text = "";
            primeNumbersRtb.TextChanged += allNumbersRtb_TextChanged;
            // 
            // FibonacciNumbersLb
            // 
            FibonacciNumbersLb.AutoSize = true;
            FibonacciNumbersLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FibonacciNumbersLb.Location = new Point(428, 248);
            FibonacciNumbersLb.Name = "FibonacciNumbersLb";
            FibonacciNumbersLb.Size = new Size(220, 32);
            FibonacciNumbersLb.TabIndex = 3;
            FibonacciNumbersLb.Text = "Fibonacci numbers:";
            // 
            // fibonacciNumbersRtb
            // 
            fibonacciNumbersRtb.BackColor = Color.White;
            fibonacciNumbersRtb.BorderStyle = BorderStyle.FixedSingle;
            fibonacciNumbersRtb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fibonacciNumbersRtb.Location = new Point(436, 286);
            fibonacciNumbersRtb.Margin = new Padding(6);
            fibonacciNumbersRtb.Name = "fibonacciNumbersRtb";
            fibonacciNumbersRtb.ReadOnly = true;
            fibonacciNumbersRtb.Size = new Size(391, 141);
            fibonacciNumbersRtb.TabIndex = 4;
            fibonacciNumbersRtb.Text = "";
            fibonacciNumbersRtb.TextChanged += allNumbersRtb_TextChanged;
            // 
            // statsLb
            // 
            statsLb.AutoSize = true;
            statsLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statsLb.Location = new Point(8, 248);
            statsLb.Name = "statsLb";
            statsLb.Size = new Size(69, 32);
            statsLb.TabIndex = 3;
            statsLb.Text = "Stats:";
            // 
            // statsRtb
            // 
            statsRtb.BackColor = Color.White;
            statsRtb.BorderStyle = BorderStyle.FixedSingle;
            statsRtb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statsRtb.Location = new Point(15, 286);
            statsRtb.Margin = new Padding(6);
            statsRtb.Name = "statsRtb";
            statsRtb.ReadOnly = true;
            statsRtb.Size = new Size(391, 141);
            statsRtb.TabIndex = 4;
            statsRtb.Text = "";
            statsRtb.TextChanged += allNumbersRtb_TextChanged;
            // 
            // task1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 504);
            Controls.Add(statsRtb);
            Controls.Add(fibonacciNumbersRtb);
            Controls.Add(primeNumbersRtb);
            Controls.Add(allNumbersRtb);
            Controls.Add(statsLb);
            Controls.Add(FibonacciNumbersLb);
            Controls.Add(primeNumbersLb);
            Controls.Add(allNumbersLb);
            Controls.Add(generateButton);
            Controls.Add(backToMenuButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "task1Form";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Taks 1";
            FormClosed += task1Form_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button backToMenuButton;
        private Button generateButton;
        private Label allNumbersLb;
        private RichTextBox allNumbersRtb;
        private Label primeNumbersLb;
        private RichTextBox primeNumbersRtb;
        private Label FibonacciNumbersLb;
        private RichTextBox fibonacciNumbersRtb;
        private Label statsLb;
        private RichTextBox statsRtb;
    }
}