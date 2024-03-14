using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
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
            string login = textBox2.Text;
            string senha = textBox1.Text;

            if (login == "admin" && senha =="ds@etefmc")
            {
                MessageBox.Show("Login efetuado com sucesso!");
                MessageBox.Show("Bem vindo ao MESCLA");
            }

            else
            {
                MessageBox.Show("Login inválido!");
            }
            



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
