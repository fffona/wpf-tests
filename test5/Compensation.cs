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
    public partial class Compensation : Form
    {
        public Compensation()
        {
            InitializeComponent();
        }

        private void test1button_Click(object sender, EventArgs e)
        {
            CompensationTest1 test1 = new CompensationTest1();
            test1.Show();
            Hide(); //ПОМЕНЯТЬ НА CLOSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
        }

        private void test2button_Click(object sender, EventArgs e)
        {
            CompensationTest2 test2 = new CompensationTest2();
            test2.Show();
            Hide(); //ПОМЕНЯТЬ НА CLOSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
        }

        private void test3button_Click(object sender, EventArgs e)
        {
            CompensationTest3 test3 = new CompensationTest3();
            test3.Show();
            Hide(); //ПОМЕНЯТЬ НА CLOSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
        }
    }
}
