using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALUnidadeDeMedida
    {
        private DALConexao conexao;
        public DALUnidadeDeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeDeMedidas modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;//conexao 
            cmd.CommandText = "insert into undmedida (umed_nome) values (@nome);select @@IDENTITY;";//cmd 
            cmd.Parameters.AddWithValue("@nome", modelo.UmedNome);//parametros 
            conexao.Conectar();//conectar 
            modelo.UmedCod = Convert.ToInt32(cmd.ExecuteScalar());//converter 
            conexao.Desconectar();//desconectar
        }

        public void Alterar(ModeloUnidadeDeMedidas modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;//conexao 
            cmd.CommandText = "update undmedida set umed_nome = @nome where umed_cod = @codigo;";//cmd 
            cmd.Parameters.AddWithValue("@nome", modelo.UmedNome);//parametros 
            cmd.Parameters.AddWithValue("@codigo", modelo.UmedCod);//parameters
            conexao.Conectar();//conectar 
            cmd.ExecuteNonQuery();//cmd executenonquery
            conexao.Desconectar();//desconectar
        }

        //excluir
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;//conexao 
            cmd.CommandText = "delete from undmedida where umed_cod = @codigo;";//cmd 
            cmd.Parameters.AddWithValue("@codigo", codigo);//parameters
            conexao.Conectar();//conectar 
            cmd.ExecuteNonQuery();//cmd executenonquery
            conexao.Desconectar();//desconectar
        }


        //localizar
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from undmedida where umed_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNome(String valor)
        {

            return Localizar(valor);
        }

        public DataTable LocalizarPorCodigo(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select umed_cod, umed_nome from undmedida where umed_cod like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int VerificaUnidadeDeMedida(String valor)//verifica se unidade JÁ existe( se retorna 0 não existe, senão existe)
        {
            int retorno = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from undmedida where umed_nome = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                retorno = Convert.ToInt32(registro["umed_cod"]);
            }
            conexao.Desconectar();
            return retorno;
        }

        //carrega modelo
        public ModeloUnidadeDeMedidas CarregaModuloUndMedidas(int codigo)
        {
            ModeloUnidadeDeMedidas modelo = new ModeloUnidadeDeMedidas();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from undmedida where umed_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UmedCod = Convert.ToInt32(registro["umed_cod"]);
                modelo.UmedNome = Convert.ToString(registro["umed_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
