namespace Home_13
{
    partial class task2Form
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
            replaceBtn = new Button();
            userSearchWordLb = new Label();
            userReplaceWordLb = new Label();
            replaceTb = new TextBox();
            searchTb = new TextBox();
            statsLb = new Label();
            taskLb = new Label();
            allTextLb = new Label();
            allTextRtb = new RichTextBox();
            statsRtb = new RichTextBox();
            SuspendLayout();
            // 
            // backToMenuButton
            // 
            backToMenuButton.FlatStyle = FlatStyle.Flat;
            backToMenuButton.Location = new Point(12, 360);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(95, 39);
            backToMenuButton.TabIndex = 3;
            backToMenuButton.Text = "Back to menu";
            backToMenuButton.UseVisualStyleBackColor = true;
            backToMenuButton.Click += backToMenuButton_Click;
            // 
            // replaceBtn
            // 
            replaceBtn.FlatStyle = FlatStyle.Flat;
            replaceBtn.Location = new Point(505, 360);
            replaceBtn.Name = "replaceBtn";
            replaceBtn.Size = new Size(95, 39);
            replaceBtn.TabIndex = 4;
            replaceBtn.Text = "Replace word";
            replaceBtn.UseVisualStyleBackColor = true;
            replaceBtn.Click += replaceBtn_Click;
            // 
            // userSearchWordLb
            // 
            userSearchWordLb.AutoSize = true;
            userSearchWordLb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userSearchWordLb.Location = new Point(12, 107);
            userSearchWordLb.Name = "userSearchWordLb";
            userSearchWordLb.Size = new Size(156, 21);
            userSearchWordLb.TabIndex = 5;
            userSearchWordLb.Text = "Enter word to search:";
            // 
            // userReplaceWordLb
            // 
            userReplaceWordLb.AutoSize = true;
            userReplaceWordLb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userReplaceWordLb.Location = new Point(12, 148);
            userReplaceWordLb.Name = "userReplaceWordLb";
            userReplaceWordLb.Size = new Size(161, 21);
            userReplaceWordLb.TabIndex = 5;
            userReplaceWordLb.Text = "Enter word to replace:";
            // 
            // replaceTb
            // 
            replaceTb.Location = new Point(174, 148);
            replaceTb.Name = "replaceTb";
            replaceTb.Size = new Size(100, 23);
            replaceTb.TabIndex = 6;
            // 
            // searchTb
            // 
            searchTb.Location = new Point(174, 109);
            searchTb.Name = "searchTb";
            searchTb.Size = new Size(100, 23);
            searchTb.TabIndex = 6;
            // 
            // statsLb
            // 
            statsLb.AutoSize = true;
            statsLb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statsLb.Location = new Point(12, 195);
            statsLb.Name = "statsLb";
            statsLb.Size = new Size(55, 25);
            statsLb.TabIndex = 5;
            statsLb.Text = "Stats:";
            // 
            // taskLb
            // 
            taskLb.AutoSize = true;
            taskLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            taskLb.Location = new Point(253, 9);
            taskLb.Name = "taskLb";
            taskLb.Size = new Size(78, 32);
            taskLb.TabIndex = 5;
            taskLb.Text = "Taks 2";
            // 
            // allTextLb
            // 
            allTextLb.AutoSize = true;
            allTextLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            allTextLb.Location = new Point(303, 72);
            allTextLb.Name = "allTextLb";
            allTextLb.Size = new Size(160, 32);
            allTextLb.TabIndex = 5;
            allTextLb.Text = "Text from file:";
            // 
            // allTextRtb
            // 
            allTextRtb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            allTextRtb.Location = new Point(312, 107);
            allTextRtb.Name = "allTextRtb";
            allTextRtb.ReadOnly = true;
            allTextRtb.Size = new Size(273, 218);
            allTextRtb.TabIndex = 7;
            allTextRtb.Text = "";
            // 
            // statsRtb
            // 
            statsRtb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statsRtb.Location = new Point(12, 223);
            statsRtb.Name = "statsRtb";
            statsRtb.ReadOnly = true;
            statsRtb.Size = new Size(262, 102);
            statsRtb.TabIndex = 7;
            statsRtb.Text = "";
            // 
            // task2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(612, 411);
            Controls.Add(statsRtb);
            Controls.Add(allTextRtb);
            Controls.Add(searchTb);
            Controls.Add(replaceTb);
            Controls.Add(statsLb);
            Controls.Add(allTextLb);
            Controls.Add(taskLb);
            Controls.Add(userReplaceWordLb);
            Controls.Add(userSearchWordLb);
            Controls.Add(replaceBtn);
            Controls.Add(backToMenuButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "task2Form";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Taks 2";
            FormClosed += task2Form_FormClosed;
            Load += task2Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backToMenuButton;
        private Button replaceBtn;
        private Label userSearchWordLb;
        private Label userReplaceWordLb;
        private TextBox replaceTb;
        private TextBox searchTb;
        private Label statsLb;
        private Label taskLb;
        private Label allTextLb;
        private RichTextBox allTextRtb;
        private RichTextBox statsRtb;
    }
}