using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Sum_two(int x, int y)
        {
            return x + y;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            int one = Convert.ToInt32(one_txt.Text);
            int two = Convert.ToInt32(two_txt.Text);
            otv_lbl.Text = "Сумма равна" + Sum_two(one, two).ToString();
        }
    }
}
