using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALSubCategoria
    {
        private DALConexao conexao;

        public DALSubCategoria(DALConexao cx)//construtor
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into subcategoria(scat_nome, cat_cod) values ( @nome, @catcod); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@nome", modelo.SCatNome);
                conexao.Conectar();
                modelo.SCatCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally//certo ou erro realizará
            {
                conexao.Desconectar();
            }
        }

        public void Alterar(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update subcategoria set scat_nome = @nome, cat_cod = @catcod where scat_cod = @scatcod and cat_cod = @catcod;";
                cmd.Parameters.AddWithValue("@nome", modelo.SCatNome);
                cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@scatcod", modelo.SCatCod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Excluir(int scod, int catcod)//dois parametros
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from subcategoria where scat_cod = @codigo and cat_cod = @catcod;";//CORRIGIR?
                cmd.Parameters.AddWithValue("@codigo", scod);
                cmd.Parameters.AddWithValue("@catcod", catcod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from subcategoria where scat_nome like '%" + valor + "%';", conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("select sc.scat_cod, sc.scat_nome, sc.cat_cod, c.cat_nome from subcategoria sc inner join categoria c on sc.cat_cod = c.cat_cod where scat_nome like '%" + valor + "%'; ", conexao.StringConexao);//("select * from subcategoria where scat_nome like '%" + valor + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNome(String valor)
        {
            return Localizar(valor);
        }

        public DataTable LocalizarPorSubCod(String valor)
        {
            DataTable tabela = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from subcategoria where scat_nome like '%" + valor + "%';", conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("select sc.scat_cod, sc.scat_nome, sc.cat_cod, c.cat_nome from subcategoria sc inner join categoria c on sc.cat_cod = c.cat_cod where scat_cod like '%" + valor + "%'; ", conexao.StringConexao);//("select * from subcategoria where scat_nome like '%" + valor + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorCatNome(String valor)
        {
            DataTable tabela = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from subcategoria where scat_nome like '%" + valor + "%';", conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("select sc.scat_cod, sc.scat_nome, sc.cat_cod, c.cat_nome from subcategoria sc inner join categoria c on sc.cat_cod = c.cat_cod where c.cat_nome like '%" + valor + "%'; ", conexao.StringConexao);//("select * from subcategoria where scat_nome like '%" + valor + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorCategoria(int categoria)//29.03
        {
            DataTable tabela = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from subcategoria where scat_nome like '%" + valor + "%';", conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("select sc.scat_cod, sc.scat_nome, sc.cat_cod, c.cat_nome from subcategoria sc inner join categoria c on sc.cat_cod = c.cat_cod where sc.cat_cod = " + categoria.ToString(), conexao.StringConexao);//("select * from subcategoria where scat_nome like '%" + valor + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int VerificaSubCategoria(String valor)//27.03 verifica se unidade JÁ existe( se retorna 0 não existe, senão existe)
        {
            int retorno = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from subcategoria where scat_nome = @scnome";
            cmd.Parameters.AddWithValue("@scnome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                retorno = Convert.ToInt32(registro["cat_cod"]);
            }
            conexao.Desconectar();
            return retorno;
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int scatcod, int catcod)
        {
            ModeloSubCategoria modelo = new ModeloSubCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from subcategoria where scat_cod = @scatcod and cat_cod = @catcod;";
            cmd.Parameters.AddWithValue("@scatcod", scatcod);
            cmd.Parameters.AddWithValue("@catcod", catcod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.SCatCod = Convert.ToInt32(registro["scat_cod"]);
                modelo.SCatNome = Convert.ToString(registro["scat_nome"]);
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
