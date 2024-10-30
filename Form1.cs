using System.Runtime.CompilerServices;
using Bunifu.UI.WinForms;
using Bunifu.Licensing;

namespace puirchr
{
    public partial class Form1 : Form
    {
        int n = 0;
        int[] answer; // массив с выбранными вариантами ответов
        public Form1()
        {
            InitializeComponent();
            answer = new int[21];
            textBox1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button1.Visible = false;
            
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
        void ResetButtonColors()
        {
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



        // Тест 1
        void showQuestion(int n)
        {
            

            ResetButtonColors();
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
            if (n < 20)
            {
                textBox1.Text = $"Вопрос {n + 1} из 10";
                if (n == 0){
                    textBox1.Text = $"Вопрос {n + 1} из 10. Достаточно ли у Вас профессиональных знаний в избранной Вами области деятельности? ";
                }
                if (n == 1)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 10. Способны ли Вы распределить работу среди подчиненных, оставив себе наиболее важную? ";
                }
                if (n == 2)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 10. Сможете ли Вы решить многообразные проблемы управления (формирование портфеля заказов, прогнозирование финансового состояния и рентабельности отдельных изделий, применение рациональной системы оплаты труда и т.п.)?";
                }
                if (n == 3)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 10. Доверяете ли Вы себе полностью или будете прибегать к помощи специалистов по отдельным вопросам? ";
                }
                if (n == 4)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 10. Будете ли Вы контролировать выполнение поручений? ";
                }
                if (n == 5)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 10. Будете ли Вы доверять Вашим подчиненным выбор метода выполнения работы? ";
                }
                if (n == 6)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 10. Считаете ли Вы расходование средств на повышение квалификации выгодным вложением средств? ";
                }
                if (n == 7)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 10. Имеете ли Вы достаточно ясное представление о своей деятельности на ближайший год или два? ";
                }
                if (n == 8)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 10. Если Вам придется делить доход с вашим товарищем и партнером, уверены ли Вы, что сохраните с ним дружеские отношения? ";
                }
                if (n == 9)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 10. Дадите ли Вы твердое обещание, если у Вас нет уверенности в том, что сумеете его выполнить? ";
                }
                if (n == 10)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 10. Дадите ли Вы21312312 твердое обещание, если у Вас нет уверенности в том, что сумеете его выполнить? ";
                }

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

        // Тест 2
        void showQuestion2(int n)
        {

            answer = new int[21];
            ResetButtonColors();
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
            if (n < 21)
            {
                textBox1.Text = $"Вопрос {n + 1} 11111";
                if (n == 0)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 21. Достаточно л67676767и у Вас профессиональных знаний в избранной Вами области деятельности? ";
                }
                if (n == 1)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 21. Способны ли Вы распределить работу среди подчиненных, оставив себе наиболее важную? ";
                }
                if (n == 2)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 21. Сможете ли Вы решить многообразные проблемы управления (формирование портфеля заказов, прогнозирование финансового состояния и рентабельности отдельных изделий, применение рациональной системы оплаты труда и т.п.)?";
                }
                if (n == 3)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 21. Доверяете ли Вы себе полностью или будете прибегать к помощи специалистов по отдельным вопросам? ";
                }
                if (n == 4)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 21. Будете ли Вы контролировать выполнение поручений? ";
                }
                if (n == 5)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 21. Будете ли Вы доверять Вашим подчиненным выбор метода выполнения работы? ";
                }
                if (n == 6)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 21. Считаете ли Вы расходование средств на повышение квалификации выгодным вложением средств? ";
                }
                if (n == 7)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 21. Имеете ли Вы достаточно ясное представление о своей деятельности на ближайший год или два? ";
                }
                if (n == 8)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 21. Если Вам придется делить доход с вашим товарищем и партнером, уверены ли Вы, что сохраните с ним дружеские отношения? ";
                }
                if (n == 9)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 21. Дадите ли Вы твердое обещание, если у Вас нет уверенности в том, что сумеете его выполнить? ";
                }
                if (n == 10)
                {
                    textBox1.Text = $"Вопрос {n + 1} из 21. Дадите ли23232 Вы твердое обещание, если у Вас нет уверенности в том, что сумеете его выполнить? ";
                }
                
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

        // Тест 3
        void showQuestion3(int n)
        {
            ResetButtonColors();
            // Показываем необходимые элементы
            label1.Visible = false;
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
            if (n < 21) n++;

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
            if (n < 21) n++;
            showQuestion(n);
            if (answer[n] != 0) colorchange1(n);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            answer[n] = 2;
            if (n < 21) n++;
            showQuestion(n);
            if (answer[n] != 0) colorchange1(n);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //финал теста 1
        private void button5_Click(object sender, EventArgs e)
        {
            // подсчет баллов за ответы (ждем исследования Клима)
            int correct = 0;
            if (answer[0] == 1) correct+=8;
            if (answer[0] == 2) correct+=0;
            if (answer[0] == 3) correct+=4;

            if (answer[1] == 1) correct+=4;
            if (answer[1] == 2) correct+=0;
            if (answer[1] == 3) correct+=2;

            if (answer[2] == 1) correct+=8;
            if (answer[2] == 2) correct+=0;
            if (answer[2] == 3) correct+=4;

            if (answer[3] == 1) correct+=0;
            if (answer[3] == 2) correct+=8;
            if (answer[3] == 3) correct+=6;

            if (answer[4] == 1) correct+=4;
            if (answer[4] == 2) correct+=0;
            if (answer[4] == 3) correct+=2;

            if (answer[5] == 1) correct+=4;
            if (answer[5] == 2) correct+=0;
            if (answer[5] == 3) correct+=2;

            if (answer[6] == 1) correct+=4;
            if (answer[6] == 2) correct+=0;
            if (answer[6] == 3) correct+=2;

            if (answer[7] == 1) correct+=8;
            if (answer[7] == 2) correct+=0;
            if (answer[7] == 3) correct+=4;

            if (answer[8] == 1) correct+=2;
            if (answer[8] == 2) correct+=0;
            if (answer[8] == 3) correct+=4;

            if (answer[9] == 1) correct+=0;
            if (answer[9] == 2) correct+=4;
            if (answer[0] == 2) correct+=2;

            if (answer[10] == 1) correct+=8;
            if (answer[10] == 2) correct+=0;
            if (answer[10] == 3) correct+=4;

            if (answer[11] == 1) correct+=8;
            if (answer[11] == 2) correct+=0;
            if (answer[11] == 3) correct+=4;

            if (answer[12] == 1) correct+=8;
            if (answer[12] == 2) correct+=0;
            if (answer[12] == 3) correct+=4;

            if (answer[13] == 1) correct+=4;
            if (answer[13] == 2) correct+=0;
            if (answer[13] == 3) correct+=2;

            if (answer[14] == 1) correct+=4;
            if (answer[14] == 2) correct+=0;
            if (answer[14] == 3) correct+=2;

            if (answer[15] == 1) correct+=4;
            if (answer[15] == 2) correct+=0;
            if (answer[15] == 3) correct+=2;

            if (answer[16] == 1) correct+=4;
            if (answer[16] == 2) correct+=0;
            if (answer[16] == 3) correct+=2;

            if (answer[17] == 1) correct+=8;
            if (answer[17] == 2) correct+=0;
            if (answer[17] == 3) correct+=4;

            if (answer[18] == 1) correct+=8;
            if (answer[18] == 2) correct+=0;
            if (answer[18] == 3) correct+=4;

            if (answer[19] == 1) correct+=8;
            if (answer[19] == 2) correct+=0;
            if (answer[19] == 3) correct+=4;

            if (answer[20] == 1) correct+=4;
            if (answer[20] == 2) correct+=0;
            if (answer[20] == 3) correct+=2;

            // вывод на экран результата
            button5.Visible = false;
            button1.Visible = false;
            button6.Visible = true;
            if (correct >= 0 && correct < 40)
            {
                textBox2.Text = $"Вы набрали {correct} баллов. От 0 до 39 - лучше приниматься за работу с соответствующими помощниками.";
                textBox2.Visible = true;
            }
            else if (correct >= 40 && correct < 80)
            {
                textBox2.Text = $"Вы набрали {correct} баллов. От 40 до 79 - еще раз подумайте, достаточно ли у Вас развиты навыки делегирования.";
                textBox2.Visible = true;
            }
            else if (correct >= 80 && correct < 124)
            {
                textBox2.Text = $"Вы набрали {correct} баллов. От 80 до 124 - смело беритесь за работу.";
                textBox2.Visible = true;
            }
        }


        

        private void button6_Click(object sender, EventArgs e)
        {
            // Начинаем новый тест

            StartNewTest();
            start();
            label1.Visible = true   ;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showQuestion(n);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showQuestion2(n);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showQuestion3(n);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}













