using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALProduto//28.03 e 29.03
    {
        private DALConexao conexao;
        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into produto (pro_nome, pro_descricao, pro_foto, pro_valorpago, pro_valorvenda, pro_qtde, umed_cod, cat_cod, scat_cod) values (@nome, @descricao, @foto, @valorpago, @valorvenda, @qtde, @umedcod, @catcod, @scatcod); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@nome", modelo.ProNome);
            cmd.Parameters.AddWithValue("@descricao", modelo.ProDescricao);
            cmd.Parameters.Add("@foto", SqlDbType.Image);
            if (modelo.ProFoto == null)//se igual null não foi informado parâmetro algum 
            {
                //cmd.Parameters.AddWithValue("@pro_foto", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@pro_foto", obj.ProFoto);
                cmd.Parameters["@foto"].Value = modelo.ProFoto;
            }
            cmd.Parameters.AddWithValue("@valorpago", modelo.ProValorPago);
            cmd.Parameters.AddWithValue("@valorvenda", modelo.ProValorVenda);
            cmd.Parameters.AddWithValue("@qtde", modelo.ProQtde);
            cmd.Parameters.AddWithValue("@umedcod", modelo.UmedCod);
            cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
            cmd.Parameters.AddWithValue("@scatcod", modelo.ScatCod);
            conexao.Conectar();
            modelo.ProCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from produto where (pro_cod) = (@pcodigo)";
            cmd.Parameters.AddWithValue("@pcodigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloProduto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update produto set pro_nome = @nome," +
                                                " pro_descricao = @descricao," +
                                                " pro_foto = @foto," +
                                                " pro_valorpago = @valorpago," +
                                                " pro_valorvenda = @valorvenda," +
                                                " pro_qtde = @qtde," +
                                                " umed_cod = @umedcod," +
                                                " cat_cod = @catcod," +
                                                " scat_cod = @scatcod" +
                                                " where pro_cod = @pcodigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.ProNome);
            cmd.Parameters.AddWithValue("@descricao", modelo.ProDescricao);
            cmd.Parameters.AddWithValue("@foto", SqlDbType.Image);
            if (modelo.ProFoto == null)
            {
                //cmd.Parameters.AddWithValue("@foto", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@foto", obj.ProFoto);
                cmd.Parameters["@foto"].Value = modelo.ProFoto;
            }
            cmd.Parameters.AddWithValue("@valorpago", modelo.ProValorPago);
            cmd.Parameters.AddWithValue("@valorvenda", modelo.ProValorVenda);
            cmd.Parameters.AddWithValue("@qtde", modelo.ProQtde);
            cmd.Parameters.AddWithValue("@umedcod", modelo.UmedCod);
            cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
            cmd.Parameters.AddWithValue("@scatcod", modelo.ScatCod);
            cmd.Parameters.AddWithValue("@pcodigo", modelo.ProCod);
        }

        public DataTable Localizar(string valor)//select p.pro_cod, p.pro_nome, p.pro_descricao, p.pro_foto, p.pro_valorpago, p.pro_valorvenda, p.pro_qtde, p.umed_cod, p.cat_cod, p.scat_cod, u.umed_nome, c.cat_nome, sc.scat_nome from produto p inner join undmedida u on p.cat_cod = u.umed_cod inner join categoria c on p.cat_cod = c.cat_cod inner join subcategoria sc on p.scat_cod = sc.scat_cod;
        {
            DataTable tabela = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from produto where pro_nome like '%" + valor + "%';", conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("select p.pro_cod, p.pro_nome, p.pro_descricao, p.pro_foto, p.pro_valorpago, p.pro_valorvenda, p.pro_qtde, u.umed_nome, p.cat_cod, p.scat_cod, u.umed_cod, c.cat_nome, sc.scat_nome from produto p inner join undmedida u on p.umed_cod = u.umed_cod inner join categoria c on p.cat_cod = c.cat_cod inner join subcategoria sc on p.scat_cod = sc.scat_cod where p.pro_nome like '%" + valor + "%';", conexao.StringConexao); //29.03
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorDescricao(string valor)//select p.pro_cod, p.pro_nome, p.pro_descricao, p.pro_foto, p.pro_valorpago, p.pro_valorvenda, p.pro_qtde, p.umed_cod, p.cat_cod, p.scat_cod, u.umed_nome, c.cat_nome, sc.scat_nome from produto p inner join undmedida u on p.cat_cod = u.umed_cod inner join categoria c on p.cat_cod = c.cat_cod inner join subcategoria sc on p.scat_cod = sc.scat_cod;
        {
            DataTable tabela = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from produto where pro_nome like '%" + valor + "%';", conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("select p.pro_cod, p.pro_nome, p.pro_descricao, p.pro_foto, p.pro_valorpago, p.pro_valorvenda, p.pro_qtde, u.umed_nome, p.cat_cod, p.scat_cod, u.umed_cod, c.cat_nome, sc.scat_nome from produto p inner join undmedida u on p.umed_cod = u.umed_cod inner join categoria c on p.cat_cod = c.cat_cod inner join subcategoria sc on p.scat_cod = sc.scat_cod where p.pro_descricao like '%" + valor + "%';", conexao.StringConexao); //29.03
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNomeCat(string valor)//select p.pro_cod, p.pro_nome, p.pro_descricao, p.pro_foto, p.pro_valorpago, p.pro_valorvenda, p.pro_qtde, p.umed_cod, p.cat_cod, p.scat_cod, u.umed_nome, c.cat_nome, sc.scat_nome from produto p inner join undmedida u on p.cat_cod = u.umed_cod inner join categoria c on p.cat_cod = c.cat_cod inner join subcategoria sc on p.scat_cod = sc.scat_cod;
        {
            DataTable tabela = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from produto where pro_nome like '%" + valor + "%';", conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("select p.pro_cod, p.pro_nome, p.pro_descricao, p.pro_foto, p.pro_valorpago, p.pro_valorvenda, p.pro_qtde, u.umed_nome, p.cat_cod, p.scat_cod, u.umed_cod, c.cat_nome, sc.scat_nome from produto p inner join undmedida u on p.umed_cod = u.umed_cod inner join categoria c on p.cat_cod = c.cat_cod inner join subcategoria sc on p.scat_cod = sc.scat_cod where c.cat_nome like '%" + valor + "%';", conexao.StringConexao); //29.03
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorCodigo(string valor)//select p.pro_cod, p.pro_nome, p.pro_descricao, p.pro_foto, p.pro_valorpago, p.pro_valorvenda, p.pro_qtde, p.umed_cod, p.cat_cod, p.scat_cod, u.umed_nome, c.cat_nome, sc.scat_nome from produto p inner join undmedida u on p.cat_cod = u.umed_cod inner join categoria c on p.cat_cod = c.cat_cod inner join subcategoria sc on p.scat_cod = sc.scat_cod;
        {
            DataTable tabela = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from produto where pro_nome like '%" + valor + "%';", conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("select p.pro_cod, p.pro_nome, p.pro_descricao, p.pro_foto, p.pro_valorpago, p.pro_valorvenda, p.pro_qtde, u.umed_nome, p.cat_cod, p.scat_cod, u.umed_cod, c.cat_nome, sc.scat_nome from produto p inner join undmedida u on p.umed_cod = u.umed_cod inner join categoria c on p.cat_cod = c.cat_cod inner join subcategoria sc on p.scat_cod = sc.scat_cod where p.pro_cod like '%" + valor + "%';", conexao.StringConexao); //29.03
            da.Fill(tabela);
            return tabela;
        }


        public int VerificaProduto(String valor)//verifica se produto JÁ existe( se retorna 0 não existe, senão existe)
        {
            int retorno = 0;// 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from produto where pro_nome = @pnome";
            cmd.Parameters.AddWithValue("@pnome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                retorno = Convert.ToInt32(registro["pro_cod"]);
            }
            conexao.Desconectar();
            return retorno;
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from produto where pro_cod = @pcodigo;";
            cmd.Parameters.AddWithValue("@pcodigo", codigo);
            //cmd.CommandText = "select * from produto where pro_cod =" + codigo.ToString();//msm de cima
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                modelo.ProNome = Convert.ToString(registro["pro_nome"]);
                modelo.ProDescricao = Convert.ToString(registro["pro_descricao"]);
                try
                {
                    modelo.ProFoto = (byte[])registro["pro_foto"];/////////////////foto29.03
                }
                catch { }
                {
                }
                modelo.ProValorPago = Convert.ToDouble(registro["pro_valorpago"]);
                modelo.ProValorVenda = Convert.ToDouble(registro["pro_valorvenda"]);
                modelo.ProQtde = Convert.ToInt32(registro["pro_qtde"]);
                modelo.UmedCod = Convert.ToInt32(registro["umed_cod"]);
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.ScatCod = Convert.ToInt32(registro["scat_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
