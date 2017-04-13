using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALFornecedor
    {
        private DALConexao conexao;

        public DALFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        //incluir
        public void Incluir(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into fornecedor(for_nome, for_rsocial, for_ie, for_cnpj, for_cep, for_endereco, for_bairro, for_fone, for_cel, for_email, for_endnumero, for_cidade, for_estado)" +
                                                  "values (@fnome, @frsocial, @fie, @fcnpj, @fcep, @fendereco, @fbairro, @ffone, @fcel, @femail, @fendnumero, @fcidade, @festado); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@fnome", modelo.ForNome);
            cmd.Parameters.AddWithValue("@frsocial", modelo.ForRSocial);
            cmd.Parameters.AddWithValue("@fie", modelo.ForIE);
            cmd.Parameters.AddWithValue("@fcnpj", modelo.ForCNPJ);
            cmd.Parameters.AddWithValue("@fcep", modelo.ForCEP);
            cmd.Parameters.AddWithValue("@fendereco", modelo.ForEndereco);
            cmd.Parameters.AddWithValue("@fbairro", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@ffone", modelo.ForFone);
            cmd.Parameters.AddWithValue("@fcel", modelo.ForCel);
            cmd.Parameters.AddWithValue("@femail", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@fendnumero", modelo.ForEndNumero);
            cmd.Parameters.AddWithValue("@fcidade", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@festado", modelo.ForEstado);
            conexao.Conectar();
            modelo.ForCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //alterar
        public void Alterar(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update fornecedor set for_nome = @fnome," +
                                                   " for_rsocial = @frsocial," +
                                                   " for_ie = @fie," +
                                                   " for_cnpj = @fcnpj," +
                                                   " for_cep = @fcep," +
                                                   " for_endereco = @fendereco," +
                                                   " for_bairro = @fbairro," +
                                                   " for_fone = @ffone," +
                                                   " for_cel = @fcel," +
                                                   " for_email = @femail," +
                                                   " for_endnumero = @fendnumero," +
                                                   " for_cidade = @fcidade," +
                                                   " for_estado = @festado" +
                                                   " where for_cod = @fcodigo;";
            cmd.Parameters.AddWithValue("@fnome", modelo.ForNome);
            cmd.Parameters.AddWithValue("@frsocial", modelo.ForRSocial);
            cmd.Parameters.AddWithValue("@fie", modelo.ForIE);
            cmd.Parameters.AddWithValue("@fcnpj", modelo.ForCNPJ);
            cmd.Parameters.AddWithValue("@fcep", modelo.ForCEP);
            cmd.Parameters.AddWithValue("@fendereco", modelo.ForEndereco);
            cmd.Parameters.AddWithValue("@fbairro", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@ffone", modelo.ForFone);
            cmd.Parameters.AddWithValue("@fcel", modelo.ForCel);
            cmd.Parameters.AddWithValue("@femail", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@fendnumero", modelo.ForEndNumero);
            cmd.Parameters.AddWithValue("@fcidade", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@festado", modelo.ForEstado);
            cmd.Parameters.AddWithValue("@fcodigo", modelo.ForCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //excluir
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from fornecedor where for_cod = @fcodigo";
            cmd.Parameters.AddWithValue("@fcodigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //localizar
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select for_cod," +
                                                         " for_nome," +
                                                         " for_rsocial," +
                                                         " for_cnpj," +
                                                         " for_ie," +
                                                         " for_cep," +
                                                         " for_estado," +
                                                         " for_cidade," +
                                                         " for_endereco," +
                                                         " for_endnumero," +
                                                         " for_bairro," +
                                                         " for_email," +
                                                         " for_fone," +
                                                         " for_cel" +
                                                         " from fornecedor where for_nome like '%" + valor + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNome(String valor)//28.03
        {
            return Localizar(valor);
        }

        public DataTable LocalizarPorCNPJ(String valor)//28/03
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select for_cod," +
                                                         " for_nome," +
                                                         " for_rsocial," +
                                                         " for_cnpj," +
                                                         " for_ie," +
                                                         " for_cep," +
                                                         " for_estado," +
                                                         " for_cidade," +
                                                         " for_endereco," +
                                                         " for_endnumero," +
                                                         " for_bairro," +
                                                         " for_email," +
                                                         " for_fone," +
                                                         " for_cel" +
                                                         " from fornecedor where for_cnpj like '%" + valor + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //carregamodelofornecedor
        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from fornecedor where for_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.ForNome = Convert.ToString(registro["for_nome"]);
                modelo.ForRSocial = Convert.ToString(registro["for_rsocial"]);
                modelo.ForIE = Convert.ToString(registro["for_ie"]);
                modelo.ForCNPJ = Convert.ToString(registro["for_cnpj"]);
                modelo.ForCEP = Convert.ToString(registro["for_cep"]);
                modelo.ForEndereco = Convert.ToString(registro["for_endereco"]);
                modelo.ForBairro = Convert.ToString(registro["for_bairro"]);
                modelo.ForFone = Convert.ToString(registro["for_fone"]);
                modelo.ForCel = Convert.ToString(registro["for_cel"]);
                modelo.ForEmail = Convert.ToString(registro["for_email"]);
                modelo.ForEndNumero = Convert.ToString(registro["for_endnumero"]);
                modelo.ForCidade = Convert.ToString(registro["for_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["for_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
