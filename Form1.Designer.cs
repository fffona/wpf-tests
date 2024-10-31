namespace puirchr
{
    partial class Form1
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
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            textBox2 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button10 = new Button();
            button11 = new Button();
            button8 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(7, 6);
            button1.Margin = new Padding(5);
            button1.MinimumSize = new Size(175, 65);
            button1.Name = "button1";
            button1.Size = new Size(175, 65);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(268, 309);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(402, 78);
            button3.TabIndex = 2;
            button3.Text = "Да";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(270, 487);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(402, 78);
            button2.TabIndex = 3;
            button2.Text = "Затрудняюсь ответить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(270, 396);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(402, 78);
            button4.TabIndex = 4;
            button4.Text = "Нет";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(101, 112);
            textBox1.Margin = new Padding(5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(739, 86);
            textBox1.TabIndex = 5;
            textBox1.Text = "Вопрос 1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(369, 282);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(211, 65);
            button5.TabIndex = 6;
            button5.Text = "Завершить тест";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(306, 135);
            textBox2.Margin = new Padding(5);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 109);
            textBox2.TabIndex = 7;
            textBox2.Text = "Ваш результат1:\r\nбла бла бла ваш результат";
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Location = new Point(233, 559);
            button6.Margin = new Padding(5);
            button6.Name = "button6";
            button6.Size = new Size(467, 84);
            button6.TabIndex = 10;
            button6.Text = "Вернуться в меню";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.AutoSize = true;
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            button7.Location = new Point(70, 194);
            button7.Margin = new Padding(5);
            button7.MinimumSize = new Size(250, 100);
            button7.Name = "button7";
            button7.Size = new Size(250, 100);
            button7.TabIndex = 11;
            button7.Text = "Тест 1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.AutoSize = true;
            button9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button9.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            button9.Location = new Point(590, 191);
            button9.Margin = new Padding(5);
            button9.MinimumSize = new Size(250, 100);
            button9.Name = "button9";
            button9.Size = new Size(250, 100);
            button9.TabIndex = 13;
            button9.Text = "Тест 3";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(255, 55);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(404, 88);
            label1.TabIndex = 14;
            label1.Text = "Выберите тест";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button10
            // 
            button10.Location = new Point(369, 282);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Size = new Size(211, 65);
            button10.TabIndex = 14;
            button10.Text = "Завершить тест";
            button10.UseVisualStyleBackColor = true;
            button10.Visible = false;
            // 
            // button11
            // 
            button11.Location = new Point(371, 282);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new Size(211, 65);
            button11.TabIndex = 15;
            button11.Text = "Завершить тест";
            button11.UseVisualStyleBackColor = true;
            button11.Visible = false;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.AutoSize = true;
            button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button8.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            button8.Location = new Point(330, 191);
            button8.Margin = new Padding(5);
            button8.MinimumSize = new Size(250, 100);
            button8.Name = "button8";
            button8.Size = new Size(250, 100);
            button8.TabIndex = 12;
            button8.Text = "Тест 2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 28);
            label2.Name = "label2";
            label2.Size = new Size(584, 29);
            label2.TabIndex = 16;
            label2.Text = "Делегирование полномочий и принятие решений";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 57);
            label3.Name = "label3";
            label3.Size = new Size(67, 29);
            label3.TabIndex = 17;
            label3.Text = "Тест";
            label3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 647);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private TextBox textBox1;
        private Button button5;
        private TextBox textBox2;
        private Button button6;
        private Button button7;
        private Button button9;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button10;
        private Button button11;
        private Button button8;
        private Label label2;
        private Label label3;
    }
}
