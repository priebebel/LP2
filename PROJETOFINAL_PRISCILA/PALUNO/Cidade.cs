using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALUNO
{
    class Cidade
    {
        private int idCidade;
        private string nomeCidade;
        private string ufCidade;

        public int IdCidade
        {
            get
            {
                return idCidade;
            }
            set
            {
                idCidade = value;
            }
        }

        public string NomeCidade
        {
            get
            {
                return nomeCidade;
            }
            set
            {
                nomeCidade = value;
            }
        }

        public string UfCidade
        {
            get
            {
                return ufCidade;
            }

            set
            {
                ufCidade = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daCidade;
            DataTable dtCidade = new DataTable();

            try {
                daCidade = new SqlDataAdapter("SELECT * FROM TBcidade", FrmPrincipal.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception err)
            {
                throw err;
            }
            return dtCidade;
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg;
                mycommand = new SqlCommand("INSERT INTO TBcidade VALUES (@nome_cidade, @uf_cidade)", FrmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@nome_cidade",SqlDbType.VarChar ));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.VarChar));
                mycommand.Parameters["@nome_cidade"].Value = nomeCidade;
                mycommand.Parameters["@uf_cidade"].Value = ufCidade;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception err)
            {
                throw err;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg = 0;
                mycommand = new SqlCommand("UPDATE TBcidade SET nome_cidade = nome_cidade, uf_cidade = @uf_cidade WHERE id_cidade = @id_cidade", FrmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_cidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.Char));

                mycommand.Parameters["@id_cidade"].Value = idCidade;
                mycommand.Parameters["@nome_cidade"].Value = nomeCidade;
                mycommand.Parameters["@uf_cidade"].Value = ufCidade;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return retorno;
        }

        public int Excluir()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM TBcidade WHERE id_cidade = @id_cidade", FrmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));
                mycommand.Parameters["@id_cidade"].Value = Convert.ToInt16(idCidade);

                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            return nReg;
        }

    }
}
