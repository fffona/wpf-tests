using System.Runtime.CompilerServices;

namespace puirchr
{
    public partial class Form1 : Form
    {
        int n = 0;
        int[] answer; // ������ � ���������� ���������� �������
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
            // ���������� ������ ������� �� �������� �� ��������� (0)
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = 0;
            }

            // ���������� ����� ���� ������
            button3.BackColor = Control.DefaultBackColor;
            button4.BackColor = Control.DefaultBackColor;
            button2.BackColor = Control.DefaultBackColor;
        }

        private void StartNewTest()
        {
            // ���������� ������ �������
            ResetAnswers();

            // ������������� ������� ������ �� ������
            n = 0;

            // ��������� ��������� ��� ������ ������ �����
            showQuestion(n);
        }

        // � ��������� ������� �������� ���� ������ � ����������� �� ���������� ������������� ������.
        // ��� ������� ������������ ������ ��� �������� �� ���������� ������
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
            // ���������� ����� ���� ������ ����� ���������
            button3.BackColor = Control.DefaultBackColor;
            button4.BackColor = Control.DefaultBackColor;
            button2.BackColor = Control.DefaultBackColor;

            // � ����������� �� ���������� ������ ������������ ��������������� ������
            switch (answer[n])
            {
                case 1:
                    button3.BackColor = Color.Gray;  // ������������ ������ 1
                    break;
                case 2:
                    button4.BackColor = Color.Gray;  // ������������ ������ 2
                    break;
                case 3:
                    button2.BackColor = Color.Gray;  // ������������ ������ 3
                    break;
                default:
                    // ������ �� ������, ���� ��� ������
                    break;
            }
        }




        void showQuestion(int n)
        {
            // ���������� ����������� ��������
            textBox1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button1.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            textBox2.Visible = false;

            // ������ ����� � ����������� �� ������ �������
            if (n < 10)
            {
                textBox1.Text = $"������ {n + 1}";
            }
            else
            {
                // ���� ��� ��������� ������, �������� ��������� ������
                textBox1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            answer[n] = 3;  // ��������� ��������� ����� (3-� �������)

            // ����������� ������ �������, ���� �� �������� ���������� �������
            if (n < 10) n++;

            // ���������, ���� �� ��� ��������� ����� ��� ���������� �������
            if (answer[n] != 0)
            {
                colorchange1(n);  // ���� ����� ��� ��� ������, ������ ���� ������
            }
            else
            {
                // ���� ����� �� ������, ���������� ���� ������
                button3.BackColor = Control.DefaultBackColor;
                button4.BackColor = Control.DefaultBackColor;
                button2.BackColor = Control.DefaultBackColor;
            }

            // ���������� ������� showQuestion ��� ����������� ���������� �������
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
            // ������� ������ �� ������ (���� ������������ �����)
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

            // ����� �� ����� ����������
            button5.Visible = false;
            button1.Visible = false;
            button6.Visible = true;
            if (correct >= 0 && correct < 3)
            {
                textBox2.Text = "��� ��������� 1";
                textBox2.Visible = true;
            }
            else if (correct >= 3 && correct < 6)
            {
                textBox2.Text = "��� ��������� 2";
                textBox2.Visible = true;
            }
            else if (correct >= 6 && correct < 15)
            {
                textBox2.Text = "��� ��������� 3";
                textBox2.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // �������� ����� ����
            
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
