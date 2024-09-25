using System.Runtime.CompilerServices;

namespace puirchr
{
    public partial class Form1 : Form
    {
        int n = 0;
        int[] answer; // массив с выбранными вариантами ответов
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button1.Visible = false;
            answer = new int[11];
        }

        void ResetAnswers()
        {
            // Сбрасываем массив ответов до значений по умолчанию (0)
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = 0;
            }

            // Сбрасываем цвета всех кнопок
            button3.BackColor = Control.DefaultBackColor;
            button4.BackColor = Control.DefaultBackColor;
            button2.BackColor = Control.DefaultBackColor;
        }

        private void StartNewTest()
        {
            // Сбрасываем массив ответов
            ResetAnswers();

            // Устанавливаем текущий вопрос на первый
            n = 0;

            // Обновляем интерфейс для начала нового теста
            showQuestion(n);
        }

        // в следующей функции меняется цвет кнопки в зависимости от выбранного пользователем ответа.
        // эта функция используется только при возврате на предыдущий вопрос
        void start()
        {
            textBox1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button1.Visible = false;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button5.Visible = false;
            button6.Visible = false;
        }

        void colorchange1(int n)
        {
            // Сбрасываем цвета всех кнопок перед проверкой
            button3.BackColor = Control.DefaultBackColor;
            button4.BackColor = Control.DefaultBackColor;
            button2.BackColor = Control.DefaultBackColor;

            // В зависимости от выбранного ответа подсвечиваем соответствующую кнопку
            switch (answer[n])
            {
                case 1:
                    button3.BackColor = Color.Gray;  // Подсвечиваем кнопку 1
                    break;
                case 2:
                    button4.BackColor = Color.Gray;  // Подсвечиваем кнопку 2
                    break;
                case 3:
                    button2.BackColor = Color.Gray;  // Подсвечиваем кнопку 3
                    break;
                default:
                    // Ничего не делать, если нет ответа
                    break;
            }
        }




        void showQuestion(int n)
        {
            // Показываем необходимые элементы
            textBox1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button1.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            textBox2.Visible = false;

            // Меняем текст в зависимости от номера вопроса
            if (n < 10)
            {
                textBox1.Text = $"Вопрос {n + 1}";
            }
            else
            {
                // Если это последний вопрос, изменяем видимость кнопок
                textBox1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            answer[n] = 3;  // сохраняем выбранный ответ (3-й вариант)

            // Увеличиваем индекс вопроса, если не достигли последнего вопроса
            if (n < 10) n++;

            // Проверяем, есть ли уже выбранный ответ для следующего вопроса
            if (answer[n] != 0)
            {
                colorchange1(n);  // если ответ уже был выбран, меняем цвет кнопок
            }
            else
            {
                // если ответ не выбран, сбрасываем цвет кнопок
                button3.BackColor = Control.DefaultBackColor;
                button4.BackColor = Control.DefaultBackColor;
                button2.BackColor = Control.DefaultBackColor;
            }

            // Используем функцию showQuestion для отображения следующего вопроса
            showQuestion(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n > 0) n--;
            showQuestion(n);
            colorchange1(n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            answer[n] = 1;
            if (n < 10) n++;
            showQuestion(n);
            if (answer[n] != 0) colorchange1(n);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            answer[n] = 2;
            if (n < 10) n++;
            showQuestion(n);
            if (answer[n] != 0) colorchange1(n);
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

        private void button6_Click(object sender, EventArgs e)
        {
            // Начинаем новый тест
            
            StartNewTest();
            start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showQuestion(n);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showQuestion(n);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showQuestion(n);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
