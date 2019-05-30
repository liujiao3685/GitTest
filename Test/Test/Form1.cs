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
            int num = Convert.ToInt32(txtdg.Text);

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

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 3, 9, 45, 7, 20 };
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                txtrs2.Text += arr[i] + ",";
            }
        }
    }
}
