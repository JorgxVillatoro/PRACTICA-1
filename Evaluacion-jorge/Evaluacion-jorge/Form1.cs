using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_jorge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double totalpupusasfq = 0;
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    int cantidadpupusasfq = Convert.ToInt32(textBox1.Text);
                    totalpupusasfq = cantidadpupusasfq * 0.75;
                }

                double totalpupusaschica = 0;
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    int cantidadpupusaschica = Convert.ToInt32(textBox2.Text);
                    totalpupusaschica = cantidadpupusaschica * 0.75;
                }

                double totalpupusasayo = 0;
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    int cantidadpupusasayo = Convert.ToInt32(textBox3.Text);
                    totalpupusasayo = cantidadpupusasayo * 0.80;
                }

                double totalbebidasoda = 0;
                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    int bebidasoda = Convert.ToInt32(textBox4.Text);
                    totalbebidasoda = bebidasoda * 1.00;
                }

                double totalbebidasagua = 0;
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    int bebidasagua = Convert.ToInt32(textBox5.Text);
                    totalbebidasagua = bebidasagua * 1.00;
                }

                double totalventa = totalpupusasfq + totalpupusaschica + totalpupusasayo + totalbebidasoda + totalbebidasagua;
                textBox6.Text = totalventa.ToString("0.00");
            }

            

            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        } 

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   

}
