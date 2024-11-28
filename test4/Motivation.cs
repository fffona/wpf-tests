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
    public partial class Motivation : Form
    {
        public Motivation()
        {
            InitializeComponent();
        }

        private void test1button_Click(object sender, EventArgs e)
        {
            MotivationTest1 test1 = new MotivationTest1();
            test1.Show();
            Hide(); //ПОМЕНЯТЬ НА CLOSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
        }

        private void test2button_Click(object sender, EventArgs e)
        {
            MotivationTest2 test2 = new MotivationTest2();
            test2.Show();
            Hide(); //ПОМЕНЯТЬ НА CLOSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
        }

        private void test3button_Click(object sender, EventArgs e)
        {
            MotivationTest3 test3 = new MotivationTest3();
            test3.Show();
            Hide(); //ПОМЕНЯТЬ НА CLOSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
        }
    }
}
