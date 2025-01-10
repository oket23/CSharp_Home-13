namespace Home_13
{
    partial class task3Form
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
            statsRtb = new RichTextBox();
            allTextRtb = new RichTextBox();
            statsLb = new Label();
            allTextLb = new Label();
            taskLb = new Label();
            userCensoredWordLb = new Label();
            replaceBtn = new Button();
            backToMenuButton = new Button();
            forbiddenSelectBtn = new Button();
            forbiddenWordRtb = new RichTextBox();
            allTextSelectBtn = new Button();
            SuspendLayout();
            // 
            // statsRtb
            // 
            statsRtb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statsRtb.Location = new Point(12, 232);
            statsRtb.Name = "statsRtb";
            statsRtb.ReadOnly = true;
            statsRtb.Size = new Size(305, 102);
            statsRtb.TabIndex = 17;
            statsRtb.Text = "";
            // 
            // allTextRtb
            // 
            allTextRtb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            allTextRtb.Location = new Point(348, 122);
            allTextRtb.Name = "allTextRtb";
            allTextRtb.ReadOnly = true;
            allTextRtb.Size = new Size(273, 252);
            allTextRtb.TabIndex = 18;
            allTextRtb.Text = "";
            // 
            // statsLb
            // 
            statsLb.AutoSize = true;
            statsLb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statsLb.Location = new Point(12, 204);
            statsLb.Name = "statsLb";
            statsLb.Size = new Size(55, 25);
            statsLb.TabIndex = 10;
            statsLb.Text = "Stats:";
            // 
            // allTextLb
            // 
            allTextLb.AutoSize = true;
            allTextLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            allTextLb.Location = new Point(348, 80);
            allTextLb.Name = "allTextLb";
            allTextLb.Size = new Size(160, 32);
            allTextLb.TabIndex = 11;
            allTextLb.Text = "Text from file:";
            // 
            // taskLb
            // 
            taskLb.AutoSize = true;
            taskLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            taskLb.Location = new Point(294, 9);
            taskLb.Name = "taskLb";
            taskLb.Size = new Size(78, 32);
            taskLb.TabIndex = 12;
            taskLb.Text = "Taks 3";
            // 
            // userCensoredWordLb
            // 
            userCensoredWordLb.AutoSize = true;
            userCensoredWordLb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userCensoredWordLb.Location = new Point(12, 86);
            userCensoredWordLb.Name = "userCensoredWordLb";
            userCensoredWordLb.Size = new Size(204, 25);
            userCensoredWordLb.TabIndex = 14;
            userCensoredWordLb.Text = "Enter forbidden words:";
            // 
            // replaceBtn
            // 
            replaceBtn.FlatStyle = FlatStyle.Flat;
            replaceBtn.Location = new Point(526, 399);
            replaceBtn.Name = "replaceBtn";
            replaceBtn.Size = new Size(95, 39);
            replaceBtn.TabIndex = 9;
            replaceBtn.Text = "Replace word";
            replaceBtn.UseVisualStyleBackColor = true;
            replaceBtn.Click += replaceBtn_Click;
            // 
            // backToMenuButton
            // 
            backToMenuButton.FlatStyle = FlatStyle.Flat;
            backToMenuButton.Location = new Point(12, 399);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(95, 39);
            backToMenuButton.TabIndex = 8;
            backToMenuButton.Text = "Back to menu";
            backToMenuButton.UseVisualStyleBackColor = true;
            backToMenuButton.Click += backToMenuButton_Click_1;
            // 
            // forbiddenSelectBtn
            // 
            forbiddenSelectBtn.FlatStyle = FlatStyle.Flat;
            forbiddenSelectBtn.Location = new Point(222, 86);
            forbiddenSelectBtn.Name = "forbiddenSelectBtn";
            forbiddenSelectBtn.Size = new Size(95, 29);
            forbiddenSelectBtn.TabIndex = 19;
            forbiddenSelectBtn.Text = "Select file";
            forbiddenSelectBtn.UseVisualStyleBackColor = true;
            forbiddenSelectBtn.Click += forbiddenSelectBtn_Click;
            // 
            // forbiddenWordRtb
            // 
            forbiddenWordRtb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            forbiddenWordRtb.Location = new Point(12, 122);
            forbiddenWordRtb.Name = "forbiddenWordRtb";
            forbiddenWordRtb.ReadOnly = true;
            forbiddenWordRtb.Size = new Size(305, 70);
            forbiddenWordRtb.TabIndex = 18;
            forbiddenWordRtb.Text = "";
            // 
            // allTextSelectBtn
            // 
            allTextSelectBtn.FlatStyle = FlatStyle.Flat;
            allTextSelectBtn.Location = new Point(526, 80);
            allTextSelectBtn.Name = "allTextSelectBtn";
            allTextSelectBtn.Size = new Size(95, 29);
            allTextSelectBtn.TabIndex = 19;
            allTextSelectBtn.Text = "Select file";
            allTextSelectBtn.UseVisualStyleBackColor = true;
            allTextSelectBtn.Click += allTextSelectBtn_Click;
            // 
            // task3Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
            Controls.Add(allTextSelectBtn);
            Controls.Add(forbiddenSelectBtn);
            Controls.Add(statsRtb);
            Controls.Add(forbiddenWordRtb);
            Controls.Add(allTextRtb);
            Controls.Add(statsLb);
            Controls.Add(allTextLb);
            Controls.Add(taskLb);
            Controls.Add(userCensoredWordLb);
            Controls.Add(replaceBtn);
            Controls.Add(backToMenuButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "task3Form";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Taks 3";
            FormClosed += task3Form_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox statsRtb;
        private RichTextBox allTextRtb;
        private Label statsLb;
        private Label allTextLb;
        private Label taskLb;
        private Label userCensoredWordLb;
        private Button replaceBtn;
        private Button backToMenuButton;
        private Button forbiddenSelectBtn;
        private RichTextBox forbiddenWordRtb;
        private Button allTextSelectBtn;
    }
}