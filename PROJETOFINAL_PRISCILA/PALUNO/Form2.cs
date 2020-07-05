using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PALUNO
{
    public partial class FrmCidade : Form
    {
        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();


        public FrmCidade()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {
            try
            {
                Cidade Cid = new Cidade();

                dsCidade.Tables.Add(Cid.Listar());
                bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                dvgCidade.DataSource = bnCidade;
                bnvCidade.BindingSource = bnCidade;

                txtId.DataBindings.Add("TEXT", bnCidade, "id_cidade");
                txtCidade.DataBindings.Add("TEXT", bnCidade, "nome_cidade");
                cbxEstado.DataBindings.Add("SelectedItem", bnCidade, "uf_cidade");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }
            bnCidade.AddNew();
            txtCidade.Enabled = true;
            cbxEstado.Enabled = true;
            cbxEstado.SelectedIndex = 0;
            txtCidade.Focus();
            btnSalvar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(txtCidade.Text == "")
            {
                MessageBox.Show("Cidade Invalida");

            }
            else
            {
                Cidade RegCid = new Cidade();

                RegCid.IdCidade = Convert.ToInt16(txtId.Text);
                RegCid.NomeCidade = txtCidade.Text;
                RegCid.UfCidade = cbxEstado.SelectedIndex.ToString();

                if (bInclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Cidade adicionada com Sucesso");

                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        cbxEstado.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;

                        bInclusao = false;

                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!");
                    }
                }
                else
                {
                    if(RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Cidade alterada com sucesso!");

                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        txtId.Enabled = false;
                        txtCidade.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar a cidade!");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0){
                tabControl1.SelectTab(1);
            }
            if (MessageBox.Show("Confirmar Exclusão", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Cidade RegCid = new Cidade();

                RegCid.IdCidade = Convert.ToInt16(txtId.Text);
                RegCid.NomeCidade = txtCidade.Text;
                RegCid.UfCidade = cbxEstado.SelectedItem.ToString();

                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Cidade Excluida com Sucesso!!");
                    Cidade R = new Cidade();
                    dsCidade.Tables.Clear();
                    dsCidade.Tables.Add(R.Listar());
                    bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir a cidade!");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            txtCidade.Enabled = true;
            cbxEstado.Enabled = true;
            txtCidade.Focus();
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            bInclusao = false;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
