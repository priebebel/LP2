using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[5];
            string[] nomes = new string[5];
            string nome;
            int i, cont;
            string auxiliar = "";
            int somatoria;

           for(cont = 0; cont < 5; cont++)
           {
                nome = Interaction.InputBox("Digite o nome da pessoa: ", "Entrada de dados");
                somatoria = 0;

                for(i = 0; i < nome.Length; i++)
                {
                    if (nome[i] != ' ')
                        somatoria++;
                }

                vetor[cont] = somatoria;
                nomes[cont] = nome;
            }

            for (cont = 0; cont < 5; cont++)
                lsboxNomes.Items.Add("O nome: " + nomes[cont] + " tem " + vetor[cont] + " caracteres");
        }
    }
}