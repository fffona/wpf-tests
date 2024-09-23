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
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(5, 5);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(179, 78);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(354, 328);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(288, 62);
            button3.TabIndex = 2;
            button3.Text = "Да";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(355, 468);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(288, 62);
            button2.TabIndex = 3;
            button2.Text = "Затрудняюсь ответить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(355, 398);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(288, 62);
            button4.TabIndex = 4;
            button4.Text = "Нет";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 250);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(529, 31);
            textBox1.TabIndex = 5;
            textBox1.Text = "Вопрос 1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(341, 211);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(301, 109);
            button5.TabIndex = 6;
            button5.Text = "Завершить тест";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(382, 230);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 89);
            textBox2.TabIndex = 7;
            textBox2.Text = "Ваш результат1:\r\nбла бла бла ваш результат";
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button6
            // 
            button6.Location = new Point(321, 465);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(334, 68);
            button6.TabIndex = 10;
            button6.Text = "Вернуться в меню";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(13, 192);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(315, 147);
            button7.TabIndex = 11;
            button7.Text = "Тест 1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(341, 192);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(315, 147);
            button8.TabIndex = 12;
            button8.Text = "Тест 2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(672, 192);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(315, 147);
            button9.TabIndex = 13;
            button9.Text = "Тест 3";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
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
            Margin = new Padding(4);
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
        private Button button8;
        private Button button9;
    }
}
