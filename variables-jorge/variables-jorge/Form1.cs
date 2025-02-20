using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variables_jorge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double majonchocost;
        int cantidaddemajonchos;
        double totalmajonchocost;
        private void button1_Click(object sender, EventArgs e)
        {
            majonchocost = Convert.ToDouble(textBox2.Text);
            cantidaddemajonchos = Convert.ToInt32(textBox1.Text);
            totalmajonchocost = majonchocost * cantidaddemajonchos;
            textBox3.Text = (totalmajonchocost - 5).ToString();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
