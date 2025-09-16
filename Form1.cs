using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1._7
{
    public partial class Form1 : Form
    {

        private matriz matriz; //declaracion de atributo privado (despues creo el objeto)
        public Form1()
        {

            InitializeComponent();
            matriz = new matriz();//objeto creado
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] valores = new int[3, 3];

            //valores de la matriz
            valores[0, 0] = int.Parse(txt00.Text);
            valores[0, 1] = int.Parse(txt01.Text);
            valores[0, 2] = int.Parse(txt02.Text);

            valores[1, 0] = int.Parse(txt03.Text);
            valores[1, 1] = int.Parse(txt04.Text);
            valores[1, 2] = int.Parse(txt05.Text);

            valores[2, 0] = int.Parse(txt06.Text);
            valores[2, 1] = int.Parse(txt07.Text);
            valores[2, 2] = int.Parse(txt08.Text);

            
            matriz.AsignarValores(valores);

        
            int suma = matriz.SumarElementos();

           
            lblResultado.Text = "la suma de los valores es : " + suma;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
