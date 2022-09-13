using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //Time timinho = new Time();
            //MessageBox.Show("Nome: " + timinho.Nome + "\tPais: " + timinho.Pais + "\nEstado: " + timinho.Estado +
            //    "\nTitulos : " + timinho.Titulo);




        }
        Time obj;
        Time[] v = new Time[10];
        int i = 0;

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (i<10)
            {
                obj = new Time();
                obj.Nome = textNome.Text;
                obj.Pais = textPais.Text;
                obj.Estado = textEstado.Text;
                obj.Titulo = int.Parse(textTitulo.Text);
                v[i] = obj;
                i++;
            }
            else
            {
                MessageBox.Show("Não é possivel gravar");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nome: " + obj.Nome + "\tPais: " + obj.Pais + "\nEstado: " + obj.Estado +
            //    "\nTitulos : " + obj.Titulo);

            for(int j = 0; j < 10; j++)
            {
                if (v[j].Nome.Equals(textNome.Text))
                {
                    textEstado.Text = v[j].Estado;
                    textPais.Text = v[j].Pais;
                    textTitulo.Text = v[j].Titulo.ToString();
                    j = 9;

                }
                else
                {
                   if(j==9)  MessageBox.Show("Time não encontrado");
                }
            }
        }
    }
}
