namespace puirchr
{
    partial class CompensationTest2
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
            label2 = new Label();
            label3 = new Label();
            backButton = new Button();
            questionTextBox = new TextBox();
            noButton = new Button();
            dontKnowButton = new Button();
            yesButton = new Button();
            endButton = new Button();
            backToMenuButton = new Button();
            resultTextBox = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(97, 19);
            label2.Name = "label2";
            label2.Size = new Size(630, 35);
            label2.TabIndex = 17;
            label2.Text = "Системы компенсации и стимулирования персонала";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(352, 54);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 18;
            label3.Text = "Тест 2";
            // 
            // backButton
            // 
            backButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backButton.Location = new Point(-1, 0);
            backButton.Margin = new Padding(5);
            backButton.MinimumSize = new Size(100, 65);
            backButton.Name = "backButton";
            backButton.Size = new Size(100, 65);
            backButton.TabIndex = 19;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // questionTextBox
            // 
            questionTextBox.Anchor = AnchorStyles.None;
            questionTextBox.BorderStyle = BorderStyle.None;
            questionTextBox.Location = new Point(120, 125);
            questionTextBox.Margin = new Padding(5);
            questionTextBox.Multiline = true;
            questionTextBox.Name = "questionTextBox";
            questionTextBox.ReadOnly = true;
            questionTextBox.Size = new Size(532, 86);
            questionTextBox.TabIndex = 20;
            questionTextBox.Text = "Вопрос 1 из 10. Достаточно ли у Вас профессиональных знаний в избранной Вами области деятельности?";
            questionTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // noButton
            // 
            noButton.Anchor = AnchorStyles.None;
            noButton.Location = new Point(253, 301);
            noButton.Margin = new Padding(5);
            noButton.Name = "noButton";
            noButton.Size = new Size(282, 54);
            noButton.TabIndex = 23;
            noButton.Text = "Нет";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += noButton_Click;
            // 
            // dontKnowButton
            // 
            dontKnowButton.Location = new Point(253, 374);
            dontKnowButton.Margin = new Padding(5);
            dontKnowButton.Name = "dontKnowButton";
            dontKnowButton.Size = new Size(282, 54);
            dontKnowButton.TabIndex = 22;
            dontKnowButton.Text = "Затрудняюсь ответить";
            dontKnowButton.UseVisualStyleBackColor = true;
            dontKnowButton.Click += dontKnowButton_Click;
            // 
            // yesButton
            // 
            yesButton.Anchor = AnchorStyles.None;
            yesButton.Location = new Point(251, 232);
            yesButton.Margin = new Padding(5);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(282, 54);
            yesButton.TabIndex = 21;
            yesButton.Text = "Да";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += yesButton_Click;
            // 
            // endButton
            // 
            endButton.Location = new Point(295, 193);
            endButton.Margin = new Padding(3, 2, 3, 2);
            endButton.Name = "endButton";
            endButton.Size = new Size(211, 65);
            endButton.TabIndex = 24;
            endButton.Text = "Завершить тест";
            endButton.UseVisualStyleBackColor = true;
            endButton.Visible = false;
            endButton.Click += endButton_Click;
            // 
            // backToMenuButton
            // 
            backToMenuButton.Anchor = AnchorStyles.None;
            backToMenuButton.Location = new Point(165, 359);
            backToMenuButton.Margin = new Padding(5);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(467, 84);
            backToMenuButton.TabIndex = 25;
            backToMenuButton.Text = "Вернуться в меню";
            backToMenuButton.UseVisualStyleBackColor = true;
            backToMenuButton.Visible = false;
            backToMenuButton.Click += backToMenuButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Anchor = AnchorStyles.None;
            resultTextBox.BackColor = SystemColors.Menu;
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Location = new Point(242, 171);
            resultTextBox.Margin = new Padding(5);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(316, 109);
            resultTextBox.TabIndex = 26;
            resultTextBox.Text = "Ваш результат1:\r\nбла бла бла ваш результат";
            resultTextBox.Visible = false;
            // 
            // CompensationTest2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultTextBox);
            Controls.Add(backToMenuButton);
            Controls.Add(endButton);
            Controls.Add(noButton);
            Controls.Add(dontKnowButton);
            Controls.Add(yesButton);
            Controls.Add(questionTextBox);
            Controls.Add(backButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "CompensationTest2";
            Text = "delegateTest1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Button backButton;
        private TextBox questionTextBox;
        private Button noButton;
        private Button dontKnowButton;
        private Button yesButton;
        private Button endButton;
        private Button backToMenuButton;
        private TextBox resultTextBox;
    }
}