using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puirchr
{
    public partial class ManagmentTest3 : Form
    {
        int n = 0;
        int[] answer;
        public ManagmentTest3()
        {
            InitializeComponent();
            answer = new int[21];
        }

        // функция изменения цвета кнопок по выбору ответа
        void colorchange(int n)
        {
            // Сбрасываем цвета всех кнопок перед проверкой
            yesButton.BackColor = Control.DefaultBackColor;
            noButton.BackColor = Control.DefaultBackColor;
            dontKnowButton.BackColor = Control.DefaultBackColor;

            // В зависимости от выбранного ответа подсвечиваем соответствующую кнопку

            switch (answer[n])
            {
                case 1:
                    yesButton.BackColor = Color.Gray;  // Подсвечиваем кнопку 1
                    break;
                case 2:
                    noButton.BackColor = Color.Gray;  // Подсвечиваем кнопку 2
                    break;
                case 3:
                    dontKnowButton.BackColor = Color.Gray;  // Подсвечиваем кнопку 3
                    break;
                default:
                    // Ничего не делать, если нет ответа
                    break;
            }
        }

        void showQuestion(int n)
        {
            // Показываем необходимые элементы
            backButton.Visible = true;
            questionTextBox.Visible = true;
            yesButton.Visible = true;
            noButton.Visible = true;
            dontKnowButton.Visible = true;
            resultTextBox.Visible = false;
            backToMenuButton.Visible = false;

            // Меняем текст в зависимости от номера вопроса
            if (n < 20)
            {
                switch (n)
                {
                    case 0:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Достаточно ли у Вас профессиональных знаний в избранной Вами области деятельности? ";
                        break;
                    case 1:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Способны ли Вы распределить работу среди подчиненных, оставив себе наиболее важную? ";
                        break;
                    case 2:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Сможете ли Вы решить многообразные проблемы управления (формирование портфеля заказов, прогнозирование финансового состояния и рентабельности отдельных изделий, применение рациональной системы оплаты труда и т.п.)?";
                        break;
                    case 3:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Доверяете ли Вы себе полностью или будете прибегать к помощи специалистов по отдельным вопросам? ";
                        break;
                    case 4:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Будете ли Вы контролировать выполнение поручений? ";
                        break;
                    case 5:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Будете ли Вы доверять Вашим подчиненным выбор метода выполнения работы? ";
                        break;
                    case 6:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Считаете ли Вы расходование средств на повышение квалификации выгодным вложением средств? ";
                        break;
                    case 7:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Имеете ли Вы достаточно ясное представление о своей деятельности на ближайший год или два? ";
                        break;
                    case 8:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Если Вам придется делить доход с вашим товарищем и партнером, уверены ли Вы, что сохраните с ним дружеские отношения? ";
                        break;
                    case 9:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Дадите ли Вы твердое обещание, если у Вас нет уверенности в том, что сумеете его выполнить? ";
                        break;
                    case 10:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Дадите ли Вы21312312 твердое обещание, если у Вас нет уверенности в том, что сумеете его выполнить? ";
                        break;
                    case 11:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Достаточно ли у Вас профессиональных знаний в избранной Вами области деятельности? ";
                        break;
                    case 12:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Способны ли Вы распределить работу среди подчиненных, оставив себе наиболее важную? ";
                        break;
                    case 13:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Сможете ли Вы решить многообразные проблемы управления (формирование портфеля заказов, прогнозирование финансового состояния и рентабельности отдельных изделий, применение рациональной системы оплаты труда и т.п.)?";
                        break;
                    case 14:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Доверяете ли Вы себе полностью или будете прибегать к помощи специалистов по отдельным вопросам? ";
                        break;
                    case 15:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Будете ли Вы контролировать выполнение поручений? ";
                        break;
                    case 16:
                        questionTextBox.Text = $"Вопрос {n + 1} из 10. Будете ли Вы доверять Вашим подчиненным выбор метода выполнения работы? ";
                        break;
                    case 17:
                        questionTextBox.Text = $"Вопрос {n + 1} из 20. Считаете ли Вы расходование средств на повышение квалификации выгодным вложением средств? ";
                        break;
                    case 18:
                        questionTextBox.Text = $"Вопрос {n + 1} из 20. Имеете ли Вы достаточно ясное представление о своей деятельности на ближайший год или два? ";
                        break;
                    case 19:
                        questionTextBox.Text = $"Вопрос {n + 1} из 20. Если Вам придется делить доход с вашим товарищем и партнером, уверены ли Вы, что сохраните с ним дружеские отношения? ";
                        break;
                }
            }
            else
            {
                // Если это последний вопрос, изменяем видимость кнопок
                questionTextBox.Visible = false;
                yesButton.Visible = false;
                noButton.Visible = false;
                dontKnowButton.Visible = false;
                endButton.Visible = true;
            }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            answer[n] = 1; // сохраняем вариант ответа
            if (n < 21) n++;
            showQuestion(n);
            colorchange(n);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            answer[n] = 2;
            if (n < 21) n++;
            showQuestion(n);
            colorchange(n);
        }

        private void dontKnowButton_Click(object sender, EventArgs e)
        {
            answer[n] = 3;
            if (n < 21) n++;
            showQuestion(n);
            colorchange(n);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (n == 0) // если на первом вопросе нажать "назад", то откроется меню теста
            {
                delegateMenu delegatemenu = new delegateMenu();
                delegatemenu.Show();
                Close();
            };
            if (n == 20)
            {
                questionTextBox.Visible = true;
                yesButton.Visible = true;
                noButton.Visible = true;
                dontKnowButton.Visible = true;
                endButton.Visible = false;
            }
            if (n > 0) n--;
            showQuestion(n);
            colorchange(n);
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            // подсчет баллов за ответы
            int correct = 0;
            if (answer[0] == 1) correct += 8;
            if (answer[0] == 2) correct += 0;
            if (answer[0] == 3) correct += 4;

            if (answer[1] == 1) correct += 4;
            if (answer[1] == 2) correct += 0;
            if (answer[1] == 3) correct += 2;

            if (answer[2] == 1) correct += 8;
            if (answer[2] == 2) correct += 0;
            if (answer[2] == 3) correct += 4;

            if (answer[3] == 1) correct += 0;
            if (answer[3] == 2) correct += 8;
            if (answer[3] == 3) correct += 6;

            if (answer[4] == 1) correct += 4;
            if (answer[4] == 2) correct += 0;
            if (answer[4] == 3) correct += 2;

            if (answer[5] == 1) correct += 4;
            if (answer[5] == 2) correct += 0;
            if (answer[5] == 3) correct += 2;

            if (answer[6] == 1) correct += 4;
            if (answer[6] == 2) correct += 0;
            if (answer[6] == 3) correct += 2;

            if (answer[7] == 1) correct += 8;
            if (answer[7] == 2) correct += 0;
            if (answer[7] == 3) correct += 4;

            if (answer[8] == 1) correct += 2;
            if (answer[8] == 2) correct += 0;
            if (answer[8] == 3) correct += 4;

            if (answer[9] == 1) correct += 0;
            if (answer[9] == 2) correct += 4;
            if (answer[0] == 2) correct += 2;

            if (answer[10] == 1) correct += 8;
            if (answer[10] == 2) correct += 0;
            if (answer[10] == 3) correct += 4;

            if (answer[11] == 1) correct += 8;
            if (answer[11] == 2) correct += 0;
            if (answer[11] == 3) correct += 4;

            if (answer[12] == 1) correct += 8;
            if (answer[12] == 2) correct += 0;
            if (answer[12] == 3) correct += 4;

            if (answer[13] == 1) correct += 4;
            if (answer[13] == 2) correct += 0;
            if (answer[13] == 3) correct += 2;

            if (answer[14] == 1) correct += 4;
            if (answer[14] == 2) correct += 0;
            if (answer[14] == 3) correct += 2;

            if (answer[15] == 1) correct += 4;
            if (answer[15] == 2) correct += 0;
            if (answer[15] == 3) correct += 2;

            if (answer[16] == 1) correct += 4;
            if (answer[16] == 2) correct += 0;
            if (answer[16] == 3) correct += 2;

            if (answer[17] == 1) correct += 8;
            if (answer[17] == 2) correct += 0;
            if (answer[17] == 3) correct += 4;

            if (answer[18] == 1) correct += 8;
            if (answer[18] == 2) correct += 0;
            if (answer[18] == 3) correct += 4;

            if (answer[19] == 1) correct += 8;
            if (answer[19] == 2) correct += 0;
            if (answer[19] == 3) correct += 4;

            if (answer[20] == 1) correct += 4;
            if (answer[20] == 2) correct += 0;
            if (answer[20] == 3) correct += 2;

            // вывод на экран результата
            endButton.Visible = false;
            backButton.Visible = false;
            backToMenuButton.Visible = true;
            if (correct >= 0 && correct < 40)
            {
                resultTextBox.Text = $"Вы набрали {correct} баллов. От 0 до 39 - лучше приниматься за работу с соответствующими помощниками.";
                resultTextBox.Visible = true;
            }
            else if (correct >= 40 && correct < 80)
            {
                resultTextBox.Text = $"Вы набрали {correct} баллов. От 40 до 79 - еще раз подумайте, достаточно ли у Вас развиты навыки делегирования.";
                resultTextBox.Visible = true;
            }
            else if (correct >= 80 && correct < 124)
            {
                resultTextBox.Text = $"Вы набрали {correct} баллов. От 80 до 124 - смело беритесь за работу.";
                resultTextBox.Visible = true;
            }
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            delegateMenu delegatemenu = new delegateMenu();
            delegatemenu.Show();
            Close();
        }
    }
}
