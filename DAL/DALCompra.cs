using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCompra
    {
        private DALConexao conexao;

        public DALCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into compra ( com_data," +
                                                  " com_nfiscal," +
                                                  " com_total," +
                                                  " com_nparcelas," +
                                                  " com_status," +
                                                  " for_cod," +
                                                  " tpa_cod )" +
                                                  " values ( @data," +
                                                           " @nfiscal," +
                                                           " @total," +
                                                           " @nparcelas," +
                                                           " @status," +
                                                           " @forcod," +
                                                           " @tpacod); select @@IDENTITY;";
            //qdo o valor for uma data
            cmd.Parameters.Add("@data", SqlDbType.DateTime);//indica primeiro qual o parametro
            cmd.Parameters["@data"].Value = modelo.ComData;//insere a informaçao do parametro

            //dados primitivos
            cmd.Parameters.AddWithValue("@nfiscal", modelo.ComNFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.ComTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.ComNparcelas);
            cmd.Parameters.AddWithValue("@status", modelo.ComStatus);
            cmd.Parameters.AddWithValue("@forcod", modelo.ForCod);
            cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);

            conexao.Conectar();
            modelo.ComCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update compra set com_data = @comdata" +
                                               " com_nfiscal = @comnfiscal" +
                                               " com_total = @comtotal" +
                                               " com_nparcelas = @comnparcelas" +
                                               " com_status = @comstatus" +
                                               " for_cod = @forcod" +
                                               " tpa_cod = @tpacod" +
                                               "where com_ cod = @codigo;";
            //qdo o valor for uma data
            cmd.Parameters.Add("@data", SqlDbType.DateTime);//indica primeiro qual o parametro
            cmd.Parameters["@data"].Value = modelo.ComData;//insere a informaçao do parametro

            //dados primitivos
            cmd.Parameters.AddWithValue("@nfiscal", modelo.ComNFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.ComTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.ComNparcelas);
            cmd.Parameters.AddWithValue("@status", modelo.ComStatus);
            cmd.Parameters.AddWithValue("@forcod", modelo.ForCod);
            cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from compra where com_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(int codigo)// localizar por codigo do fornecedor
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.com_cod," +
                                                         " c.com_data," +
                                                         " c.com_nfiscal," +
                                                         " c.com_total," +
                                                         " c.com_nparcelas," +
                                                         " c.com_status," +
                                                         " c.tpa_cod" +
                                                         " f.for_nome," +
                                                         " from compra c inner join fornecedor f on c.for_cod = f.for_cod" +
                                                         " where for_cod = " + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizar(String nome)// localizar por nome do fornecedor
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.com_cod," +
                                                         " c.com_data," +
                                                         " c.com_nfiscal," +
                                                         " c.com_total," +
                                                         " c.com_nparcelas," +
                                                         " c.com_status," +
                                                         " c.tpa_cod" +
                                                         " f.for_nome," +
                                                         " from compra c inner join fornecedor f on c.for_cod = f.for_cod" +
                                                         " where f.for_nome like '%" + nome + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizar(DateTime datainicial, DateTime datafinal)// localizar entre duas datas
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select c.com_cod," +
                                    " c.com_data," +
                                    " c.com_nfiscal," +
                                    " c.com_total," +
                                    " c.com_nparcelas," +
                                    " c.com_status," +
                                    " f.for_nome," +
                                    " c.tpa_cod" +
                                    " from compra c inner join fornecedor f on c.for_cod = f.for_cod" +
                                    " where c.com_data between @datainicial and @datafinal;";
            //
            cmd.Parameters.Add("@datainicial", SqlDbType.DateTime);//define o tipo
            cmd.Parameters["@datainicial"].Value = datainicial;//insere o valor
            cmd.Parameters.Add("@datafinal", SqlDbType.DateTime);
            cmd.Parameters["@datafinal"].Value = datainicial;
            //
            //conexao.Conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);//funciona de acordo com o camando informado
            da.Fill(tabela);
            //conexao.Desconectar();
            return tabela;
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            ModeloCompra modelo = new ModeloCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from compra where com_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ComCod = Convert.ToInt32(registro["com_cod"]);
                modelo.ComData = Convert.ToDateTime(registro["com_data"]);
                modelo.ComNFiscal = Convert.ToInt32(registro["com_nfiscal"]);
                modelo.ComTotal = Convert.ToDouble(registro["com_total"]);
                modelo.ComNparcelas = Convert.ToInt32(registro["com_nparcelas"]);
                modelo.ComStatus = Convert.ToInt32(registro["com_status"]);
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
