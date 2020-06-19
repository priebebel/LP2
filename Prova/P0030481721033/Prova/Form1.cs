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

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] Matriz = new double[3, 4];
            string valor = "";
            string Semana = "";
            double mes, Geral = 0;

            for (int lin = 0; lin < 3; lin++)
            {
                mes = 0;
                for (int col = 0; col < 4; col++)
                {
                    valor = Interaction.InputBox("Entre com o Faturamento\n" +"Semana:" + (col + 1) +"\n"+ 
                        "Mes: " + (lin + 1), "Entrada de dados");

                    if (double.TryParse(valor, out Matriz[lin, col]))
                    {
                        Semana = "Total do Mês: " + (lin + 1) + " Semana: " + (col + 1) + " R$ = " + Matriz[lin, col].ToString("N2");
                        mes += Matriz[lin, col];
                        Geral += Matriz[lin, col];
                        lstbxCalculos.Items.Add(Semana);
                    }
                    else
                    {
                        MessageBox.Show("Favor Corrigir os dados");
                        col--;
                    }
                }
                lstbxCalculos.Items.Add("Total Mês: " + (lin+1) + " R$ = " + mes.ToString("N2"));
                lstbxCalculos.Items.Add("-----------------------");
            }
            lstbxCalculos.Items.Add("Total Geral R$ = " + Geral.ToString("N2"));
        }
    }
}
