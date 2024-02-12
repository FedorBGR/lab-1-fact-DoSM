using System.Numerics;

namespace lab_1_fact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            

            static BigInteger fa (int n) 
            {
                if (n < 0)
            {
                    {MessageBox.Show("Ошибка", "Факториала отрицательных чисел не существует", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }

            if (n == 0)
            {
                    return 1;
                    
             }
                BigInteger res;
                res = 1;
                for(int i = 1; i <= n; i++)
                {
                    res *= i;
                }
                return res;
            }
            
            textBox2.Text = n.ToString() + "! = " + fa(n);
        }
    }
}