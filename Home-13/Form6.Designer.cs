﻿namespace Home_13
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
            label1 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 121);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 8;
            label1.Text = "Taks 5 comming...";
            // 
            // task5Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backToMenuButton);
            Controls.Add(label1);
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
        private Label label1;
    }
}