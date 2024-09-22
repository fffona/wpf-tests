namespace puirchr
{
    public partial class Form1 : Form
    {
        int n = 0;
        int[] answer; // массив с выбранными вариантами ответов
        public Form1()
        {
            InitializeComponent();
            answer = new int[11];
        }
        
        // в следующей функции меняется цвет кнопки в зависимости от выбранного пользователем ответа.
        // эта функция используется только при возврате на предыдущий вопрос
        void colorchange1(int n)
        {
            switch (answer[n])
            {
                case 1:
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Control.DefaultBackColor;
                    button2.BackColor = Control.DefaultBackColor;
                    break;
                case 2:
                    button3.BackColor = Control.DefaultBackColor;
                    button4.BackColor = Color.Yellow;
                    button2.BackColor = Control.DefaultBackColor;
                    break;
                case 3:
                    button3.BackColor = Control.DefaultBackColor;
                    button4.BackColor = Control.DefaultBackColor;
                    button2.BackColor = Color.Yellow;
                    break;
            }
        }

        void show1(int n)
        {
            switch (n)
            {
                case 0:
                    textBox1.Text = "Вопрос 1";
                    break;
                case 1:
                    textBox1.Text = "Вопрос 2";
                    break;
                case 2:
                    textBox1.Text = "Вопрос 3";
                    break;
                case 3:
                    textBox1.Text = "Вопрос 4";
                    break;
                case 4:
                    textBox1.Text = "Вопрос 5";
                    break;
                case 5:
                    textBox1.Text = "Вопрос 6";
                    break;
                case 6:
                    textBox1.Text = "Вопрос 7";
                    break;
                case 7:
                    textBox1.Text = "Вопрос 8";
                    break;
                case 8:
                    textBox1.Text = "Вопрос 9";
                    break;
                case 9:
                    textBox1.Text = "Вопрос 10";
                    textBox1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = false;
                    break;
                case 10:
                    textBox1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = true;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            answer[n] = 3;
            n++;
            if (n > 10) n = 10;


            // тут проверяется, отвечал ли уже пользователь на текущий вопрос.
            // например, если пользователь дважды вернулся назад, в обоих этих вопросах должен
            // подсвечиваться выбранный вариант ответа
            if (answer[n] != 0)
            {
                colorchange1(n);
            }
            else
            {
                button3.BackColor = Control.DefaultBackColor;
                button4.BackColor = Control.DefaultBackColor;
                button2.BackColor = Control.DefaultBackColor;
            }
            show1(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n--;
            if (n < 0) n = 0;
            show1(n);
            colorchange1(n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            answer[n] = 1;
            n++;
            if (n > 10) n = 10;
            if (answer[n] != 0)
            {
                colorchange1(n);
            }
            else
            {
                button3.BackColor = Control.DefaultBackColor;
                button4.BackColor = Control.DefaultBackColor;
                button2.BackColor = Control.DefaultBackColor;
            }
            show1(n);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            answer[n] = 2;
            n++;
            if (n > 10) n = 10;
            if (answer[n] != 0)
            {
                colorchange1(n);
            }
            else
            {
                button3.BackColor = Control.DefaultBackColor;
                button4.BackColor = Control.DefaultBackColor;
                button2.BackColor = Control.DefaultBackColor;
            }
            show1(n);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // подсчет баллов за ответы (ждем исследования Клима)
            int correct = 0;
            if (answer[0] == 1) correct++;
            if (answer[1] == 1) correct++;
            if (answer[2] == 1) correct++;
            if (answer[3] == 1) correct++;
            if (answer[4] == 1) correct++;
            if (answer[5] == 1) correct++;
            if (answer[6] == 1) correct++;
            if (answer[7] == 1) correct++;
            if (answer[8] == 1) correct++;
            if (answer[9] == 1) correct++;

            // вывод на экран результата
            button5.Visible = false;
            button1.Visible = false;
            button6.Visible = true;
            if (correct >= 0 && correct < 3)
            {
                textBox2.Text = "Ваш результат 1";
                textBox2.Visible = true;
            }
            else if (correct >= 3 && correct < 6)
            {
                textBox2.Text = "Ваш результат 2";
                textBox2.Visible = true;
            }
            else if (correct >= 6 && correct < 15)
            {
                textBox2.Text = "Ваш результат 3";
                textBox2.Visible = true;
            }
        }
    }
}
