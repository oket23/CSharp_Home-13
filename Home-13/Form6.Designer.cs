namespace Home_13
{
    partial class task5Form
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
            backToMenuButton = new Button();
            taskLb = new Label();
            generateNumRtb = new RichTextBox();
            generateNumLb = new Label();
            generateNumBtn = new Button();
            statsLb = new Label();
            statsRtb = new RichTextBox();
            SuspendLayout();
            // 
            // backToMenuButton
            // 
            backToMenuButton.FlatStyle = FlatStyle.Flat;
            backToMenuButton.Location = new Point(12, 399);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(95, 39);
            backToMenuButton.TabIndex = 9;
            backToMenuButton.Text = "Back to menu";
            backToMenuButton.UseVisualStyleBackColor = true;
            backToMenuButton.Click += backToMenuButton_Click;
            // 
            // taskLb
            // 
            taskLb.AutoSize = true;
            taskLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            taskLb.Location = new Point(308, 9);
            taskLb.Name = "taskLb";
            taskLb.Size = new Size(85, 32);
            taskLb.TabIndex = 8;
            taskLb.Text = "Taks 5 ";
            // 
            // generateNumRtb
            // 
            generateNumRtb.Location = new Point(12, 104);
            generateNumRtb.Name = "generateNumRtb";
            generateNumRtb.ReadOnly = true;
            generateNumRtb.Size = new Size(314, 269);
            generateNumRtb.TabIndex = 10;
            generateNumRtb.Text = "";
            // 
            // generateNumLb
            // 
            generateNumLb.AutoSize = true;
            generateNumLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            generateNumLb.Location = new Point(12, 69);
            generateNumLb.Name = "generateNumLb";
            generateNumLb.Size = new Size(231, 32);
            generateNumLb.TabIndex = 8;
            generateNumLb.Text = "Generated numbers:";
            // 
            // generateNumBtn
            // 
            generateNumBtn.FlatStyle = FlatStyle.Flat;
            generateNumBtn.Location = new Point(557, 406);
            generateNumBtn.Name = "generateNumBtn";
            generateNumBtn.Size = new Size(129, 32);
            generateNumBtn.TabIndex = 11;
            generateNumBtn.Text = "Generate numbers";
            generateNumBtn.UseVisualStyleBackColor = true;
            generateNumBtn.Click += generateNumBtn_Click;
            // 
            // statsLb
            // 
            statsLb.AutoSize = true;
            statsLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statsLb.Location = new Point(372, 69);
            statsLb.Name = "statsLb";
            statsLb.Size = new Size(69, 32);
            statsLb.TabIndex = 8;
            statsLb.Text = "Stats:";
            // 
            // statsRtb
            // 
            statsRtb.Location = new Point(372, 104);
            statsRtb.Name = "statsRtb";
            statsRtb.ReadOnly = true;
            statsRtb.Size = new Size(314, 269);
            statsRtb.TabIndex = 10;
            statsRtb.Text = "";
            // 
            // task5Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 450);
            Controls.Add(generateNumBtn);
            Controls.Add(statsRtb);
            Controls.Add(generateNumRtb);
            Controls.Add(backToMenuButton);
            Controls.Add(statsLb);
            Controls.Add(generateNumLb);
            Controls.Add(taskLb);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "task5Form";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Taks 5";
            FormClosed += task5Form_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backToMenuButton;
        private Label taskLb;
        private RichTextBox generateNumRtb;
        private Label generateNumLb;
        private Button generateNumBtn;
        private Label statsLb;
        private RichTextBox statsRtb;
    }
}