using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            string[] customerss = File.ReadAllLines("customerss.csv");
            for (int i = 0; i < customerss.Length; i++)
            {
                listBox1.Items.Add(customerss[i]);
                //چیکارکنیم.هر.بارفرم.شومیشه.اپدیت.شه لیستمون؟
                //ایا میشه لیست رو تغییراتی توش انجام داد؟            
            }
        }
    }
}
