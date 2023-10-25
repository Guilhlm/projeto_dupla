using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetin_pai_pedro_e_eu_
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float.Parse(textBox2.Text);

            float altura = float.Parse(textBox2.Text) * float.Parse(textBox2.Text);

            int peso =  int.Parse(textBox3.Text);

            float imc = peso / altura ;

            textBox4.Text = imc.ToString();

         

            
            if(imc <= 18)
            {
                textBox4.Text = "vc eh magro " + imc;
            }
            else if(imc >= 19 && imc <= 25) 
            {
                textBox4.Text = "normal " + imc;
            }
            else if(imc >= 26 && imc <= 30) 
            {
                textBox4.Text = "gordinho " + imc;
            }
            else if (imc > 40)
            {
                textBox4.Text = "procure ajuda ta mt gordinho " + imc;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(textbox1.Text);

            

     

            if(idade <= 17)
            {
                textbox1.Text = "voce eh menor de idade nao pode hehe";
            }
            else
            {
                textbox1.Text = "voce eh maior de idade e pode dirigir e pagar as contas";
            }

        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            float divida = float.Parse(textBox5.Text);

            int parcela = int.Parse(textBox6.Text);

            double juros = double.Parse(textBox7.Text);

            double juros2 = double.Parse(textBox7.Text);



            juros = divida * 0.25;

            juros2 = divida * 0.50;




            if (divida < 50000)
            {
                textBox7.Text = "seu juros eh " + juros;
            }
            else
            {
                textBox7.Text = "seu juros eh " + juros2;
            }





        }
    }
}
