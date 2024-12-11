namespace puirchr
{
    partial class delegateTest1
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
            label2.Location = new Point(83, 14);
            label2.Name = "label2";
            label2.Size = new Size(480, 28);
            label2.TabIndex = 17;
            label2.Text = "Делегирование полномочий и принятие решений";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(308, 40);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 18;
            label3.Text = "Тест 1";
            // 
            // backButton
            // 
            backButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backButton.Location = new Point(-1, 0);
            backButton.Margin = new Padding(4);
            backButton.MinimumSize = new Size(88, 49);
            backButton.Name = "backButton";
            backButton.Size = new Size(88, 49);
            backButton.TabIndex = 19;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // questionTextBox
            // 
            questionTextBox.Anchor = AnchorStyles.None;
            questionTextBox.BorderStyle = BorderStyle.None;
            questionTextBox.Location = new Point(105, 94);
            questionTextBox.Margin = new Padding(4);
            questionTextBox.Multiline = true;
            questionTextBox.Name = "questionTextBox";
            questionTextBox.ReadOnly = true;
            questionTextBox.Size = new Size(466, 64);
            questionTextBox.TabIndex = 20;
            questionTextBox.Text = "Вопрос 1 из 21. Достаточно ли у Вас профессиональных знаний в избранной Вами области деятельности?";
            questionTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // noButton
            // 
            noButton.Anchor = AnchorStyles.None;
            noButton.Location = new Point(221, 226);
            noButton.Margin = new Padding(4);
            noButton.Name = "noButton";
            noButton.Size = new Size(247, 40);
            noButton.TabIndex = 23;
            noButton.Text = "Нет";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += noButton_Click;
            // 
            // dontKnowButton
            // 
            dontKnowButton.Location = new Point(221, 280);
            dontKnowButton.Margin = new Padding(4);
            dontKnowButton.Name = "dontKnowButton";
            dontKnowButton.Size = new Size(247, 40);
            dontKnowButton.TabIndex = 22;
            dontKnowButton.Text = "Затрудняюсь ответить";
            dontKnowButton.UseVisualStyleBackColor = true;
            dontKnowButton.Click += dontKnowButton_Click;
            // 
            // yesButton
            // 
            yesButton.Anchor = AnchorStyles.None;
            yesButton.Location = new Point(220, 174);
            yesButton.Margin = new Padding(4);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(247, 40);
            yesButton.TabIndex = 21;
            yesButton.Text = "Да";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += yesButton_Click;
            // 
            // endButton
            // 
            endButton.Location = new Point(258, 145);
            endButton.Margin = new Padding(3, 2, 3, 2);
            endButton.Name = "endButton";
            endButton.Size = new Size(185, 49);
            endButton.TabIndex = 24;
            endButton.Text = "Завершить тест";
            endButton.UseVisualStyleBackColor = true;
            endButton.Visible = false;
            endButton.Click += endButton_Click;
            // 
            // backToMenuButton
            // 
            backToMenuButton.Anchor = AnchorStyles.None;
            backToMenuButton.Location = new Point(144, 269);
            backToMenuButton.Margin = new Padding(4);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(409, 63);
            backToMenuButton.TabIndex = 25;
            backToMenuButton.Text = "Вернуться в меню";
            backToMenuButton.UseVisualStyleBackColor = true;
            backToMenuButton.Visible = false;
            backToMenuButton.Click += backToMenuButton_Click_1;
            // 
            // resultTextBox
            // 
            resultTextBox.Anchor = AnchorStyles.None;
            resultTextBox.BackColor = SystemColors.Menu;
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Location = new Point(212, 128);
            resultTextBox.Margin = new Padding(4);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(276, 82);
            resultTextBox.TabIndex = 26;
            resultTextBox.Text = "Ваш результат1:\r\nбла бла бла ваш результат";
            resultTextBox.Visible = false;
            // 
            // delegateTest1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "delegateTest1";
            Text = "delegateTest1";
            Load += delegateTest1_Load;
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