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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string[] productss = File.ReadAllLines("productss.csv");
            for (int i = 0; i < productss.Length; i++)
            {
                listBox1.Items.Add(productss[i]);
            }
        }
    }
}
