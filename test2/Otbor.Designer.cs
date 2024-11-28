namespace puirchr
{
    partial class Otbor
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
            test1button = new Button();
            test2button = new Button();
            test3button = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(189, 41);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(404, 88);
            label1.TabIndex = 15;
            label1.Text = "Выберите тест";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // test1button
            // 
            test1button.Anchor = AnchorStyles.None;
            test1button.AutoSize = true;
            test1button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            test1button.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            test1button.Location = new Point(14, 158);
            test1button.Margin = new Padding(5);
            test1button.MinimumSize = new Size(250, 100);
            test1button.Name = "test1button";
            test1button.Size = new Size(250, 100);
            test1button.TabIndex = 16;
            test1button.Text = "Тест 1";
            test1button.UseVisualStyleBackColor = true;
            test1button.Click += test1button_Click;
            // 
            // test2button
            // 
            test2button.Anchor = AnchorStyles.None;
            test2button.AutoSize = true;
            test2button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            test2button.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            test2button.Location = new Point(274, 158);
            test2button.Margin = new Padding(5);
            test2button.MinimumSize = new Size(250, 100);
            test2button.Name = "test2button";
            test2button.Size = new Size(250, 100);
            test2button.TabIndex = 17;
            test2button.Text = "Тест 2";
            test2button.UseVisualStyleBackColor = true;
            test2button.Click += test2button_Click;
            // 
            // test3button
            // 
            test3button.Anchor = AnchorStyles.None;
            test3button.AutoSize = true;
            test3button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            test3button.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            test3button.Location = new Point(534, 158);
            test3button.Margin = new Padding(5);
            test3button.MinimumSize = new Size(250, 100);
            test3button.Name = "test3button";
            test3button.Size = new Size(250, 100);
            test3button.TabIndex = 18;
            test3button.Text = "Тест 3";
            test3button.UseVisualStyleBackColor = true;
            test3button.Click += test3button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(274, 18);
            label2.Name = "label2";
            label2.Size = new Size(217, 35);
            label2.TabIndex = 19;
            label2.Text = "Отбор персонала";
            // 
            // Otbor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(test3button);
            Controls.Add(test2button);
            Controls.Add(test1button);
            Controls.Add(label1);
            Name = "Otbor";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button test1button;
        private Button test2button;
        private Button test3button;
        private Label label2;
    }
}