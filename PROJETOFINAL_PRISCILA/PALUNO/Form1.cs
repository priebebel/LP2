using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PALUNO
{
    public partial class FrmPrincipal : Form
    {
        public static SqlConnection conexao;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try{
                conexao = new SqlConnection("Data Source=DESKTOP-FAKOF6O\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException errSql)
            {
                MessageBox.Show("Erro de SQL" + errSql.Message);
            }
            catch (Exception err){
                MessageBox.Show("Erro geral" + err.Message);
            }

            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidade frmCity = new FrmCidade();
            frmCity.MdiParent = this;
            frmCity.WindowState = FormWindowState.Maximized;
            frmCity.Show();

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno frmAlun = new FrmAluno();
            frmAlun.MdiParent = this;
            frmAlun.WindowState = FormWindowState.Maximized;
            frmAlun.Show();
        }
    }
}
