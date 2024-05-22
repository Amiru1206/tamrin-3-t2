namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            f2.Show();
        }
        Form3 f3 = new Form3();
        private void button2_Click(object sender, EventArgs e)
        {
            f3.Show();
        }
        Form4 f4 = new Form4();
        private void button3_Click(object sender, EventArgs e)
        {
            f4.Show();
        }
        Form5 f5 = new Form5();
        private void button4_Click(object sender, EventArgs e)
        {
            f5.Show();
        }
    }
}
