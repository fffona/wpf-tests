namespace puirchr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateTabControl();
            this.ClientSize = new Size(800, 600);
            CreateExitButtonPanel();
        }

        private void CreateTabControl()
        {
            TabControl tabControl = new TabControl
            {
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 14)
            };

            string[] categories = {
                "Делегирование полномочий и принятие решений",
                "Отбор персонала",
                "Адаптация сотрудников",
                "Мотивация персонала",
                "Системы компенсации и стимулирования персонала",
                "Управление проблемными сотрудниками",
                "Создание эффективной команды"
            };

            for (int i = 0; i < categories.Length; i++)
            {
                TabPage tabPage = new TabPage(categories[i]);

                CreateCenteredButtons(tabPage, i + 1);

                tabControl.TabPages.Add(tabPage);
            }

            this.Controls.Add(tabControl);
        }

        private void CreateCenteredButtons(TabPage tabPage, int categoryNumber)
        {
            TableLayoutPanel tableLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3, 
                Padding = new Padding(20),
                AutoSize = false 
            };

            for (int i = 0; i < tableLayout.RowCount; i++)
            {
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33f));
            }

            for (int i = 0; i < 3; i++)
            {
                int testNumber = (categoryNumber - 1) * 3 + i + 1;

                Button btn = new Button
                {
                    Text = $"Тест {i + 1}",
                    Width = 300, 
                    Height = 100, 
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    ForeColor = Color.White, 
                    BackColor = Color.FromArgb(0, 122, 204),
                    FlatStyle = FlatStyle.Flat, 
                    Tag = testNumber, 
                    Anchor = AnchorStyles.None
                };

                btn.FlatAppearance.BorderSize = 0; 
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 184); 
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 92, 174); 

                btn.Click += TestButton_Click;
                tableLayout.Controls.Add(btn, 0, i);
            }

            tabPage.Controls.Add(tableLayout);
        }

        private void CreateExitButtonPanel()
        {
            Panel bottomPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                BackColor = Color.LightGray
            };

            Button exitButton = new Button
            {
                Text = "Выход",
                Width = 120,
                Height = 40,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Red,
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.None
            };

            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseOverBackColor = Color.DarkRed;

            exitButton.Click += (s, e) => Application.Exit();

            // Центрируем кнопку внутри панели
            exitButton.Location = new Point((bottomPanel.Width - exitButton.Width) / 2, (bottomPanel.Height - exitButton.Height) / 2);

            // Перерисовка при изменении размеров
            bottomPanel.Resize += (s, e) =>
            {
                exitButton.Location = new Point((bottomPanel.Width - exitButton.Width) / 2, (bottomPanel.Height - exitButton.Height) / 2);
            };

            bottomPanel.Controls.Add(exitButton);
            this.Controls.Add(bottomPanel);
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                int testNumber = (int)button.Tag;
                OpenTestForm(testNumber);
            }
        }

        private void OpenTestForm(int testNumber)
        {
            Form testForm = GetTestForm(testNumber);
            if (testForm != null)
            {
                testForm.ShowDialog();
                Hide();
            }
            else
            {
                MessageBox.Show($"Форма для Теста {testNumber} не найдена.", "Ошибка");
            }
        }

        private Form GetTestForm(int testNumber)
        {
            switch (testNumber)
            {
                case 1: return new delegateTest1();
                case 2: return new delegateTest2();
                case 3: return new delegateTest3();
                case 4: return new OtborTest1();
                case 5: return new OtborTest2();
                case 6: return new OtborTest3();
                case 7: return new AdaptationTest1();
                case 8: return new AdaptationTest2();
                case 9: return new AdaptationTest3();
                case 10: return new MotivationTest1();
                case 11: return new MotivationTest2();
                case 12: return new MotivationTest3();
                case 13: return new CompensationTest1();
                case 14: return new CompensationTest2();
                case 15: return new CompensationTest3();
                case 16: return new ManagmentTest1();
                case 17: return new ManagmentTest2();
                case 18: return new ManagmentTest3();
                case 19: return new EffectiveTest1();
                case 20: return new EffectiveTest2();
                case 21: return new EffectiveTest3();
                default: return null;
            }
        }
    }
}
