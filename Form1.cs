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
            static long fa (int n) 
            {
                long res;
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