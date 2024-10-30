using System.Runtime.CompilerServices;
using Bunifu.UI.WinForms;
using Bunifu.Licensing;

namespace puirchr
{
    public partial class Form1 : Form
    {
        int n = 0;
        int[] answer; // ������ � ���������� ���������� �������
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
        void ResetButtonColors()
        {
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



        // ���� 1
        void showQuestion(int n)
        {
            

            ResetButtonColors();
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
            if (n < 20)
            {
                textBox1.Text = $"������ {n + 1} �� 10";
                if (n == 0){
                    textBox1.Text = $"������ {n + 1} �� 10. ���������� �� � ��� ���������������� ������ � ��������� ���� ������� ������������? ";
                }
                if (n == 1)
                {
                    textBox1.Text = $"������ {n + 1} �� 10. �������� �� �� ������������ ������ ����� �����������, ������� ���� �������� ������? ";
                }
                if (n == 2)
                {
                    textBox1.Text = $"������ {n + 1} �� 10. ������� �� �� ������ ������������� �������� ���������� (������������ �������� �������, ��������������� ����������� ��������� � �������������� ��������� �������, ���������� ������������ ������� ������ ����� � �.�.)?";
                }
                if (n == 3)
                {
                    textBox1.Text = $"������ {n + 1} �� 10. ��������� �� �� ���� ��������� ��� ������ ��������� � ������ ������������ �� ��������� ��������? ";
                }
                if (n == 4)
                {
                    textBox1.Text = $"������ {n + 1} �� 10. ������ �� �� �������������� ���������� ���������? ";
                }
                if (n == 5)
                {
                    textBox1.Text = $"������ {n + 1} �� 10. ������ �� �� �������� ����� ����������� ����� ������ ���������� ������? ";
                }
                if (n == 6)
                {
                    textBox1.Text = $"������ {n + 1} �� 10. �������� �� �� ������������ ������� �� ��������� ������������ �������� ��������� �������? ";
                }
                if (n == 7)
                {
                    textBox1.Text = $"������ {n + 1} �� 10. ������ �� �� ���������� ����� ������������� � ����� ������������ �� ��������� ��� ��� ���? ";
                }
                if (n == 8)
                {
                    textBox1.Text = $"������ {n + 1} �� 10. ���� ��� �������� ������ ����� � ����� ��������� � ���������, ������� �� ��, ��� ��������� � ��� ��������� ���������? ";
                }
                if (n == 9)
                {
                    textBox1.Text = $"������ {n + 1} �� 10. ������ �� �� ������� ��������, ���� � ��� ��� ����������� � ���, ��� ������� ��� ���������? ";
                }
                if (n == 10)
                {
                    textBox1.Text = $"������ {n + 1} �� 10. ������ �� ��21312312 ������� ��������, ���� � ��� ��� ����������� � ���, ��� ������� ��� ���������? ";
                }

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

        // ���� 2
        void showQuestion2(int n)
        {

            answer = new int[21];
            ResetButtonColors();
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
            if (n < 21)
            {
                textBox1.Text = $"������ {n + 1} 11111";
                if (n == 0)
                {
                    textBox1.Text = $"������ {n + 1} �� 21. ���������� �67676767� � ��� ���������������� ������ � ��������� ���� ������� ������������? ";
                }
                if (n == 1)
                {
                    textBox1.Text = $"������ {n + 1} �� 21. �������� �� �� ������������ ������ ����� �����������, ������� ���� �������� ������? ";
                }
                if (n == 2)
                {
                    textBox1.Text = $"������ {n + 1} �� 21. ������� �� �� ������ ������������� �������� ���������� (������������ �������� �������, ��������������� ����������� ��������� � �������������� ��������� �������, ���������� ������������ ������� ������ ����� � �.�.)?";
                }
                if (n == 3)
                {
                    textBox1.Text = $"������ {n + 1} �� 21. ��������� �� �� ���� ��������� ��� ������ ��������� � ������ ������������ �� ��������� ��������? ";
                }
                if (n == 4)
                {
                    textBox1.Text = $"������ {n + 1} �� 21. ������ �� �� �������������� ���������� ���������? ";
                }
                if (n == 5)
                {
                    textBox1.Text = $"������ {n + 1} �� 21. ������ �� �� �������� ����� ����������� ����� ������ ���������� ������? ";
                }
                if (n == 6)
                {
                    textBox1.Text = $"������ {n + 1} �� 21. �������� �� �� ������������ ������� �� ��������� ������������ �������� ��������� �������? ";
                }
                if (n == 7)
                {
                    textBox1.Text = $"������ {n + 1} �� 21. ������ �� �� ���������� ����� ������������� � ����� ������������ �� ��������� ��� ��� ���? ";
                }
                if (n == 8)
                {
                    textBox1.Text = $"������ {n + 1} �� 21. ���� ��� �������� ������ ����� � ����� ��������� � ���������, ������� �� ��, ��� ��������� � ��� ��������� ���������? ";
                }
                if (n == 9)
                {
                    textBox1.Text = $"������ {n + 1} �� 21. ������ �� �� ������� ��������, ���� � ��� ��� ����������� � ���, ��� ������� ��� ���������? ";
                }
                if (n == 10)
                {
                    textBox1.Text = $"������ {n + 1} �� 21. ������ ��23232 �� ������� ��������, ���� � ��� ��� ����������� � ���, ��� ������� ��� ���������? ";
                }
                
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

        // ���� 3
        void showQuestion3(int n)
        {
            ResetButtonColors();
            // ���������� ����������� ��������
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
            if (n < 21) n++;

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

        //����� ����� 1
        private void button5_Click(object sender, EventArgs e)
        {
            // ������� ������ �� ������ (���� ������������ �����)
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

            // ����� �� ����� ����������
            button5.Visible = false;
            button1.Visible = false;
            button6.Visible = true;
            if (correct >= 0 && correct < 40)
            {
                textBox2.Text = $"�� ������� {correct} ������. �� 0 �� 39 - ����� ����������� �� ������ � ���������������� �����������.";
                textBox2.Visible = true;
            }
            else if (correct >= 40 && correct < 80)
            {
                textBox2.Text = $"�� ������� {correct} ������. �� 40 �� 79 - ��� ��� ���������, ���������� �� � ��� ������� ������ �������������.";
                textBox2.Visible = true;
            }
            else if (correct >= 80 && correct < 124)
            {
                textBox2.Text = $"�� ������� {correct} ������. �� 80 �� 124 - ����� �������� �� ������.";
                textBox2.Visible = true;
            }
        }


        

        private void button6_Click(object sender, EventArgs e)
        {
            // �������� ����� ����

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













