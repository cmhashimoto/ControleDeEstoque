using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALTipoDePagamento
    {
        private DALConexao conexao;

        public DALTipoDePagamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoDePagamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into tipopagamento (tpa_cod, tpa_nome) values(@cod, @nome);";// select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.TpaNome);
            cmd.Parameters.AddWithValue("@cod", modelo.TpaCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();//qdo a PK da tabela é non identity execute o cmd nonquery;
            //modelo.TpaCod = modelo.TpaCod;//Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloTipoDePagamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update tipopagamento set tpa_nome = @nome, tpa_cod = @codigo where tpa_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.TpaNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.TpaCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from tipopagamento where tpa_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tipopagamento where tpa_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorCodigo(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tipopagamento where tpa_cod like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int VerificaTipoPagamento(String valor)//verifica se unidade JÁ existe( se retorna 0 não existe, senão existe)
        {
            int retorno = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from tipopagamento where tpa_nome = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                retorno = Convert.ToInt32(registro["tpa_cod"]);
            }
            conexao.Desconectar();
            return retorno;
        }

        public ModeloTipoDePagamento CarregaModeloTipoDePagamento(int codigo)
        {
            ModeloTipoDePagamento modelo = new Modelo.ModeloTipoDePagamento();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from tipopagamento where tpa_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                modelo.TpaNome = Convert.ToString(registro["tpa_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
