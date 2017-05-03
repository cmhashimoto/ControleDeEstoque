using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALItensCompra
    {
        private DALConexao conexao;

        public DALItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into itenscompra (itc_cod, itc_qtde, itc_valor, com_cod, pro_cod) values (@itccod, @itcqtde, @itcvalor, @comcod, @procod);";
            cmd.Parameters.AddWithValue("@itccod", modelo.ItcCod);
            cmd.Parameters.AddWithValue("@itcqtde", modelo.ItcQtde);
            cmd.Parameters.AddWithValue("@itcvalor", modelo.ItcValor);
            cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update itenscompra set itc_qtde = @itcqtde, " +
                                                     "itc_valor = @itcvalor, " +
                                                     "where itccod = @itccod and com_cod = @comcod and pro_cod = @procod;";
            cmd.Parameters.AddWithValue("@itccod", modelo.ItcCod);
            cmd.Parameters.AddWithValue("@itcqtde", modelo.ItcQtde);
            cmd.Parameters.AddWithValue("@itcvalor", modelo.ItcValor);
            cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from itenscompra where itccod = @itccod and com_cod = @comcod and pro_cod = @procod;";
            cmd.Parameters.AddWithValue("@itccod", modelo.ItcCod);
            cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(int comcod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from itenscompra where com_cod =" + comcod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloItensCompra CarregaModeloItensCompra(int Itccod, int ComCod, int ProCod)
        {
            ModeloItensCompra modelo = new ModeloItensCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from itenscompra where itccod = @itccod and com_cod = @comcod and pro_cod = @procod;";
            cmd.Parameters.AddWithValue("@itccod", Itccod);
            cmd.Parameters.AddWithValue("@comcod", ComCod);
            cmd.Parameters.AddWithValue("@procod", ProCod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ItcCod = Itccod;
                modelo.ProCod = ProCod;
                modelo.ComCod = ComCod;
                modelo.ItcQtde = Convert.ToDouble(registro["itc_qtde"]);
                modelo.ItcValor = Convert.ToDouble(registro["itc_valor"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
