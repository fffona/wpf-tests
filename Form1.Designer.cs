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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(4, 4);
            button1.Name = "button1";
            button1.Size = new Size(143, 62);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(283, 262);
            button3.Name = "button3";
            button3.Size = new Size(230, 50);
            button3.TabIndex = 2;
            button3.Text = "Да";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(284, 374);
            button2.Name = "button2";
            button2.Size = new Size(230, 50);
            button2.TabIndex = 3;
            button2.Text = "Затрудняюсь ответить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(284, 318);
            button4.Name = "button4";
            button4.Size = new Size(230, 50);
            button4.TabIndex = 4;
            button4.Text = "Нет";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "Вопрос 1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(283, 168);
            button5.Name = "button5";
            button5.Size = new Size(241, 87);
            button5.TabIndex = 6;
            button5.Text = "Завершить тест";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(309, 150);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 72);
            textBox2.TabIndex = 7;
            textBox2.Text = "Ваш результат1:\r\nбла бла бла ваш результат";
            textBox2.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(257, 372);
            button6.Name = "button6";
            button6.Size = new Size(267, 54);
            button6.TabIndex = 10;
            button6.Text = "Вернуться в меню";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
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
    }
}
