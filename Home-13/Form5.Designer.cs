namespace Home_13
{
    partial class task4Form
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
            userRtb = new RichTextBox();
            reversRtb = new RichTextBox();
            userSelectBtn = new Button();
            copyTextLb = new Label();
            UserTextLb = new Label();
            reverseBtn = new Button();
            statsLb = new Label();
            statsRtb = new RichTextBox();
            SuspendLayout();
            // 
            // backToMenuButton
            // 
            backToMenuButton.FlatStyle = FlatStyle.Flat;
            backToMenuButton.Location = new Point(7, 494);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(95, 39);
            backToMenuButton.TabIndex = 7;
            backToMenuButton.Text = "Back to menu";
            backToMenuButton.UseVisualStyleBackColor = true;
            backToMenuButton.Click += backToMenuButton_Click;
            // 
            // taskLb
            // 
            taskLb.AutoSize = true;
            taskLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            taskLb.Location = new Point(201, 9);
            taskLb.Name = "taskLb";
            taskLb.Size = new Size(78, 32);
            taskLb.TabIndex = 6;
            taskLb.Text = "Taks 4";
            // 
            // userRtb
            // 
            userRtb.Location = new Point(12, 98);
            userRtb.Name = "userRtb";
            userRtb.ReadOnly = true;
            userRtb.Size = new Size(204, 216);
            userRtb.TabIndex = 8;
            userRtb.Text = "";
            // 
            // reversRtb
            // 
            reversRtb.Location = new Point(263, 98);
            reversRtb.Name = "reversRtb";
            reversRtb.ReadOnly = true;
            reversRtb.Size = new Size(204, 216);
            reversRtb.TabIndex = 8;
            reversRtb.Text = "";
            // 
            // userSelectBtn
            // 
            userSelectBtn.FlatStyle = FlatStyle.Flat;
            userSelectBtn.Location = new Point(133, 66);
            userSelectBtn.Name = "userSelectBtn";
            userSelectBtn.Size = new Size(83, 26);
            userSelectBtn.TabIndex = 9;
            userSelectBtn.Text = "Select file";
            userSelectBtn.UseVisualStyleBackColor = true;
            userSelectBtn.Click += userSelectBtn_Click;
            // 
            // copyTextLb
            // 
            copyTextLb.AutoSize = true;
            copyTextLb.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            copyTextLb.Location = new Point(263, 60);
            copyTextLb.Name = "copyTextLb";
            copyTextLb.Size = new Size(119, 30);
            copyTextLb.TabIndex = 10;
            copyTextLb.Text = "Revers text:";
            // 
            // UserTextLb
            // 
            UserTextLb.AutoSize = true;
            UserTextLb.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserTextLb.Location = new Point(7, 60);
            UserTextLb.Name = "UserTextLb";
            UserTextLb.Size = new Size(100, 30);
            UserTextLb.TabIndex = 10;
            UserTextLb.Text = "Your text:";
            // 
            // reverseBtn
            // 
            reverseBtn.FlatStyle = FlatStyle.Flat;
            reverseBtn.Location = new Point(372, 494);
            reverseBtn.Name = "reverseBtn";
            reverseBtn.Size = new Size(95, 39);
            reverseBtn.TabIndex = 7;
            reverseBtn.Text = "Reverse text";
            reverseBtn.UseVisualStyleBackColor = true;
            reverseBtn.Click += reverseBtn_Click;
            // 
            // statsLb
            // 
            statsLb.AutoSize = true;
            statsLb.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statsLb.Location = new Point(12, 331);
            statsLb.Name = "statsLb";
            statsLb.Size = new Size(62, 30);
            statsLb.TabIndex = 10;
            statsLb.Text = "Stats:";
            // 
            // statsRtb
            // 
            statsRtb.Location = new Point(12, 364);
            statsRtb.Name = "statsRtb";
            statsRtb.ReadOnly = true;
            statsRtb.Size = new Size(455, 79);
            statsRtb.TabIndex = 8;
            statsRtb.Text = "";
            // 
            // task4Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 545);
            Controls.Add(statsLb);
            Controls.Add(UserTextLb);
            Controls.Add(copyTextLb);
            Controls.Add(userSelectBtn);
            Controls.Add(reversRtb);
            Controls.Add(statsRtb);
            Controls.Add(userRtb);
            Controls.Add(reverseBtn);
            Controls.Add(backToMenuButton);
            Controls.Add(taskLb);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "task4Form";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Taks 4";
            FormClosed += task4Form_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backToMenuButton;
        private Label taskLb;
        private RichTextBox userRtb;
        private RichTextBox reversRtb;
        private Button userSelectBtn;
        private Label copyTextLb;
        private Label UserTextLb;
        private Button reverseBtn;
        private Label statsLb;
        private RichTextBox statsRtb;
    }
}