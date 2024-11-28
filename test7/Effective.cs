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
    public partial class Effective : Form
    {
        public Effective()
        {
            InitializeComponent();
        }

        private void test1button_Click(object sender, EventArgs e)
        {
            EffectiveTest1 test1 = new EffectiveTest1();
            test1.Show();
            Hide(); //ПОМЕНЯТЬ НА CLOSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
        }

        private void test2button_Click(object sender, EventArgs e)
        {
            EffectiveTest2 test2 = new EffectiveTest2();
            test2.Show();
            Hide(); //ПОМЕНЯТЬ НА CLOSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
        }

        private void test3button_Click(object sender, EventArgs e)
        {
            EffectiveTest3 test3 = new EffectiveTest3();
            test3.Show();
            Hide(); //ПОМЕНЯТЬ НА CLOSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
        }
    }
}
