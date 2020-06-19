using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;

namespace Atividade7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLerNumeros_Click(object sender, EventArgs e)
        {
            
            int[] vetor = new int[20];
            int cont = 0;
            string auxiliar = "";
            string valor = "";

            for(cont = 0; cont < 20; cont++)
            {
                valor = Interaction.InputBox("Digite o dado: " + (cont+1), "Entrada de dados");

                if (int.TryParse(valor, out vetor[cont]))
                    auxiliar = vetor[cont].ToString() + "\n" + auxiliar;
                else
                {
                    MessageBox.Show("Número inválido!");
                    cont--;
                }
            }

            MessageBox.Show(auxiliar);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            int cont;
            int[] vetor = new int[20];
            string auxiliar = "";
            string valor = "";
            
            for(cont = 0; cont < 20; cont++)
            {
                valor = Interaction.InputBox("Digite o dado da posição " + (cont + 1), " Digitação dos dados");

                if(!int.TryParse(valor, out vetor[cont]))
                {
                    MessageBox.Show("Número inválido!!!");
                    cont--;
                }
               
            }

            Array.Reverse(vetor);

            for (cont = 0; cont < 20; cont++)
                auxiliar += vetor[cont] + "\n";

            MessageBox.Show(auxiliar);
        }

        private void btnMercadorias_Click(object sender, EventArgs e)
        {
            double[] vetor = new double[10];
            int cont;
            string quantidade = "";
            string preco = "";
            double quantidade2 = 0;
            double preco2 = 0;
            double total = 0;

            for(cont = 0; cont < 10; cont++)
            {
                quantidade = Interaction.InputBox("Digite a quantidade de mercadoria " + (cont + 1), "Digitação dos dados");
                preco = Interaction.InputBox("Digite o preço do produto " + (cont + 1), "Digitação dos dados");

                if(double.TryParse(quantidade, out vetor[cont]) && double.TryParse(preco, out vetor[cont]))
                {
                    quantidade2 = Convert.ToDouble(quantidade);
                    preco2 = Convert.ToDouble(preco);
                    total += quantidade2 * preco2;
                }
                else
                {
                    MessageBox.Show("Numero inválido!");
                    cont--;
                }
            }

            MessageBox.Show("Faturamento mensal total = " + total.ToString("N2"));
        }

        private void btnVarTotal_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
            Int32 I, Total = 0; 
            Int32 N = Alunos.Length; 

            for (I = 0; I < N - 1; I++) 
                Total += Alunos[I].Length;

            MessageBox.Show(Total.ToString());
        }

        private void btnUsoArray_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>(new string[] 
            { "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" });

            //lista.Remove("Otávio");
            lista.RemoveAt(6);

            foreach (string elemento in lista)
            {
                MessageBox.Show("Nome = " + elemento.ToString());
            }

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[20, 3];
            int lin, col;
            string valor = "";
            double Media ;
            string auxiliar = "";

            for (lin = 0; lin < 20; lin++)
            {
                Media = 0;
                for (col = 0; col < 3; col++)
                {
                    valor = Interaction.InputBox("Digite a nota: " + (col + 1) + " do aluno " + (lin + 1), " Digitação dos dados");

                    if (double.TryParse(valor, out matriz[lin,col]))              
                        Media += Convert.ToDouble(valor);
                    else
                    {
                        MessageBox.Show("Numero inválido!");
                        col--;
                    }
                    
                }
                auxiliar += "Aluno: " + (lin + 1) + " Media " + (Media / 3).ToString("N2") + "\n";
            }

            MessageBox.Show(auxiliar);
        }

        private void btnExe7_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();

            novo.Show();

            this.Visible = false;
        }

    }
}
