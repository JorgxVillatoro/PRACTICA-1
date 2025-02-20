using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2_jorge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1Teoria = double.Parse(textBox1.Text);
            double nota2Teoria = double.Parse(textBox2.Text);
            double nota3Teoria = double.Parse(textBox3.Text);
            double nota1Lab = double.Parse(textBox4.Text);
            double nota2Lab = double.Parse(textBox5.Text);
            double nota3Lab = double.Parse(textBox6.Text);

            if (nota1Teoria < 0 || nota1Teoria > 10 ||
               nota2Teoria < 0 || nota2Teoria > 10 ||
               nota3Teoria < 0 || nota3Teoria > 10 ||
               nota1Lab < 0 || nota1Lab > 10 ||
               nota2Lab < 0 || nota2Lab > 10 ||
               nota3Lab < 0 || nota3Lab > 10)
            {
                MessageBox.Show("Alguna de las notas ingresadas no está en el rango válido (0.00 a 10.00).");
                return;
            }

            // Calcular el promedio final
            double promedioTeoria = (nota1Teoria + nota2Teoria + nota3Teoria) / 3;
            double promedioLab = (nota1Lab + nota2Lab + nota3Lab) / 3;
            double promedioFinal = (promedioTeoria + promedioLab) / 2;

            // Determinar si el estudiante aprobó o reprobó
            string resultadoFinal;
            string imagenResultado;
            if (promedioFinal >= 7.0)
            {
                resultadoFinal = "Grandioso, Excelente... continúa así...";
                imagenResultado = "C:\\Users\\villa\\Downloads\\felicidades.jpg";
                pictureBox2.ImageLocation = imagenResultado;
            }
            else if (promedioFinal >= 6.0)
            {
                resultadoFinal = "Muy bien... pero trata de mejorar tu promedio";
                imagenResultado = "C:\\Users\\villa\\Downloads\\bien.jpg";
                pictureBox2.ImageLocation = imagenResultado;
            }
            else if (promedioFinal >= 3.0)
            {
                resultadoFinal = "Más dedicación estudiante, debe mejorar sus notas";
                imagenResultado = "C:\\Users\\villa\\Downloads\\mejore.jpg";
                pictureBox2.ImageLocation = imagenResultado;
            }
            else
            {
                resultadoFinal = "Pongase las pilas mi hijito";
                imagenResultado = "C:\\Users\\villa\\Downloads\\mal.gif";
                pictureBox2.ImageLocation = imagenResultado;
            }

            // Mostrar los resultados
            textBox7.Text = promedioFinal.ToString("0.00");
            textBox8.Text = resultadoFinal;
            



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
  