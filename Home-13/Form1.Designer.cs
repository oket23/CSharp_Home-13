namespace Home_13
{
    partial class mainMenu
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
            task1Button = new Button();
            MainMenuLb = new Label();
            task2Button = new Button();
            task3Button = new Button();
            task4Button = new Button();
            task5Button = new Button();
            SuspendLayout();
            // 
            // task1Button
            // 
            task1Button.FlatStyle = FlatStyle.Flat;
            task1Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            task1Button.Location = new Point(30, 228);
            task1Button.Name = "task1Button";
            task1Button.Size = new Size(115, 37);
            task1Button.TabIndex = 0;
            task1Button.Text = "Task 1";
            task1Button.UseVisualStyleBackColor = true;
            task1Button.Click += task1Button_Click;
            // 
            // MainMenuLb
            // 
            MainMenuLb.AutoSize = true;
            MainMenuLb.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuLb.Location = new Point(318, 50);
            MainMenuLb.Name = "MainMenuLb";
            MainMenuLb.Size = new Size(150, 65);
            MainMenuLb.TabIndex = 1;
            MainMenuLb.Text = "Menu";
            // 
            // task2Button
            // 
            task2Button.FlatStyle = FlatStyle.Flat;
            task2Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            task2Button.Location = new Point(177, 291);
            task2Button.Name = "task2Button";
            task2Button.Size = new Size(115, 37);
            task2Button.TabIndex = 0;
            task2Button.Text = "Task 2";
            task2Button.UseVisualStyleBackColor = true;
            task2Button.Click += task2Button_Click;
            // 
            // task3Button
            // 
            task3Button.FlatStyle = FlatStyle.Flat;
            task3Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            task3Button.Location = new Point(353, 291);
            task3Button.Name = "task3Button";
            task3Button.Size = new Size(115, 37);
            task3Button.TabIndex = 0;
            task3Button.Text = "Task 3";
            task3Button.UseVisualStyleBackColor = true;
            task3Button.Click += task3Button_Click;
            // 
            // task4Button
            // 
            task4Button.FlatStyle = FlatStyle.Flat;
            task4Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            task4Button.Location = new Point(519, 291);
            task4Button.Name = "task4Button";
            task4Button.Size = new Size(115, 37);
            task4Button.TabIndex = 0;
            task4Button.Text = "Task 4";
            task4Button.UseVisualStyleBackColor = true;
            task4Button.Click += task4Button_Click;
            // 
            // task5Button
            // 
            task5Button.FlatStyle = FlatStyle.Flat;
            task5Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            task5Button.Location = new Point(645, 228);
            task5Button.Name = "task5Button";
            task5Button.Size = new Size(115, 37);
            task5Button.TabIndex = 0;
            task5Button.Text = "Task 5";
            task5Button.UseVisualStyleBackColor = true;
            task5Button.Click += task5Button_Click;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainMenuLb);
            Controls.Add(task5Button);
            Controls.Add(task4Button);
            Controls.Add(task3Button);
            Controls.Add(task2Button);
            Controls.Add(task1Button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "mainMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home-13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button task1Button;
        private Label MainMenuLb;
        private Button task2Button;
        private Button task3Button;
        private Button task4Button;
        private Button task5Button;
    }
}
