using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int NumberSymbols(string stroka, char symbol)
        {
            int k = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == symbol)
                {
                    k += 1;
                }
            }
            return k;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = NumberSymbols(textBox1.Text, 'а').ToString();
            string b = "ма";
            textBox3.Text = ((textBox1.Text.Length - textBox1.Text.Replace(b, "").Length) / b.Length).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
