using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num =  Convert.ToInt32(txtdg.Text);

            Stopwatch sw = new Stopwatch();
            sw.Restart();

            Factorial factorial = new Factorial(num);
            txtRs.Text = factorial.ToString();

            sw.Stop();
            labMsg.Text = "耗时：" + sw.Elapsed.TotalSeconds.ToString();
        }

        int fact(int n)
        {
            if (n <= 1) return n;
            else
            {
                return n * fact((n - 1));
            }
        }

    }
}
