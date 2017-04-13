using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCliente//25.03
    {
        private DALConexao conexao;
        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into cliente(cli_nome, cli_cpfcnpj, cli_rgie, cli_rsocial, cli_tipo, cli_cep, cli_endereco, cli_bairro, cli_fone, cli_cel, cli_email, cli_endnumero, cli_cidade, cli_estado)" +
                                                  "values (@cnome, @ccpfcnpj, @crgie, @crsocial, @ctipo, @ccep, @cendereco, @cbairro, @cfone, @ccel, @cemail, @cendnumero, @ccidade, @cestado); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@cnome", modelo.CliNome);
            cmd.Parameters.AddWithValue("@ccpfcnpj", modelo.CliCPFCNPJ);
            cmd.Parameters.AddWithValue("@crgie", modelo.CliRGIE);
            cmd.Parameters.AddWithValue("@crsocial", modelo.CliRSocial);
            cmd.Parameters.AddWithValue("@ctipo", modelo.CliTipo);
            cmd.Parameters.AddWithValue("@ccep", modelo.CliCEP);
            cmd.Parameters.AddWithValue("@cendereco", modelo.CliEndereco);
            cmd.Parameters.AddWithValue("@cbairro", modelo.CliBairro);
            cmd.Parameters.AddWithValue("@cfone", modelo.CliFone);
            cmd.Parameters.AddWithValue("@ccel", modelo.CliCel);
            cmd.Parameters.AddWithValue("@cemail", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@cendnumero", modelo.CliEndNumero);
            cmd.Parameters.AddWithValue("@ccidade", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@cestado", modelo.CliEstado);
            conexao.Conectar();
            modelo.CliCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update cliente set cli_nome = @cnome," +
                                                " cli_cpfcnpj = @ccpfcnpj," +
                                                " cli_rgie = @crgie," +
                                                " cli_rsocial = @crsocial," +
                                                " cli_tipo = @ctipo," +
                                                " cli_cep = @ccep," +
                                                " cli_endereco = @cendereco," +
                                                " cli_bairro = @cbairro," +
                                                " cli_fone = @cfone," +
                                                " cli_cel = @ccel," +
                                                " cli_endnumero = @cendnumero," +
                                                " cli_email = @cemail," +
                                                " cli_cidade = @ccidade," +
                                                " cli_estado = @cestado" +
                                                " where cli_cod = @ccodigo;";
            cmd.Parameters.AddWithValue("@cnome", modelo.CliNome);
            cmd.Parameters.AddWithValue("@ccpfcnpj", modelo.CliCPFCNPJ);
            cmd.Parameters.AddWithValue("@crgie", modelo.CliRGIE);
            cmd.Parameters.AddWithValue("@crsocial", modelo.CliRSocial);
            cmd.Parameters.AddWithValue("@ctipo", modelo.CliTipo);
            cmd.Parameters.AddWithValue("@ccep", modelo.CliCEP);
            cmd.Parameters.AddWithValue("@cendereco", modelo.CliEndereco);
            cmd.Parameters.AddWithValue("@cbairro", modelo.CliBairro);
            cmd.Parameters.AddWithValue("@cfone", modelo.CliFone);
            cmd.Parameters.AddWithValue("@ccel", modelo.CliCel);
            cmd.Parameters.AddWithValue("@cendnumero", modelo.CliEndNumero);
            cmd.Parameters.AddWithValue("@cemail", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@ccidade", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@cestado", modelo.CliEstado);
            cmd.Parameters.AddWithValue("@ccodigo", modelo.CliCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from cliente where cli_cod = @ccodigo";
            cmd.Parameters.AddWithValue("@ccodigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)//25.03 dgv problema resolvido (falta de vírgula nos select)
        {
            DataTable tabela = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select cli_cod," +
                                                         " cli_nome," +
                                                         " cli_cpfcnpj," +
                                                         " cli_rgie," +
                                                         " cli_rsocial," +
                                                         " cli_tipo," +
                                                         " cli_cep," +
                                                         " cli_endereco," +
                                                         " cli_bairro," +
                                                         " cli_fone," +
                                                         " cli_cel," +
                                                         " cli_email," +
                                                         " cli_endnumero," +
                                                         " cli_cidade," +
                                                         " cli_estado" +
                                                         " from cliente where cli_nome like '%" + valor + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNome(String valor)//28/03 mesma coisa que dal localizar de cima, só foi criado pra ter localizar por nome e cpfcnpj
        {
            return Localizar(valor);
        }

        public DataTable LocalizarPorCPFCNPJ(String valor)//28/03
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select cli_cod," +
                                                         " cli_nome," +
                                                         " cli_cpfcnpj," +
                                                         " cli_rgie," +
                                                         " cli_rsocial," +
                                                         " cli_tipo," +
                                                         " cli_cep," +
                                                         " cli_endereco," +
                                                         " cli_bairro," +
                                                         " cli_fone," +
                                                         " cli_cel," +
                                                         " cli_email," +
                                                         " cli_endnumero," +
                                                         " cli_cidade," +
                                                         " cli_estado" +
                                                         " from cliente where cli_cpfcnpj like '%" + valor + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cli_cod = @ccodigo";
            cmd.Parameters.AddWithValue("@ccodigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.CliNome = Convert.ToString(registro["cli_nome"]);
                modelo.CliCPFCNPJ = Convert.ToString(registro["cli_cpfcnpj"]);
                modelo.CliRGIE = Convert.ToString(registro["cli_rgie"]);
                modelo.CliRSocial = Convert.ToString(registro["cli_rsocial"]);
                modelo.CliTipo = Convert.ToInt32(registro["cli_tipo"]);//25.03 por ser int
                modelo.CliCEP = Convert.ToString(registro["cli_cep"]);
                modelo.CliEndereco = Convert.ToString(registro["cli_endereco"]);
                modelo.CliBairro = Convert.ToString(registro["cli_bairro"]);
                modelo.CliFone = Convert.ToString(registro["cli_fone"]);
                modelo.CliCel = Convert.ToString(registro["cli_cel"]);
                modelo.CliEmail = Convert.ToString(registro["cli_email"]);
                modelo.CliEndNumero = Convert.ToString(registro["cli_endnumero"]);
                modelo.CliCidade = Convert.ToString(registro["cli_cidade"]);
                modelo.CliEstado = Convert.ToString(registro["cli_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public ModeloCliente CarregaModeloCliente(String cpfcnpj)//28.03 sobrecarga p/ verificar se existe registro de cpf cnpj existente no banco
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cli_cpfcnpj = @cpfcnpj";
            cmd.Parameters.AddWithValue("@cpfcnpj", cpfcnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.CliNome = Convert.ToString(registro["cli_nome"]);
                modelo.CliCPFCNPJ = Convert.ToString(registro["cli_cpfcnpj"]);
                modelo.CliRGIE = Convert.ToString(registro["cli_rgie"]);
                modelo.CliRSocial = Convert.ToString(registro["cli_rsocial"]);
                modelo.CliTipo = Convert.ToInt32(registro["cli_tipo"]);//25.03 por ser int
                modelo.CliCEP = Convert.ToString(registro["cli_cep"]);
                modelo.CliEndereco = Convert.ToString(registro["cli_endereco"]);
                modelo.CliBairro = Convert.ToString(registro["cli_bairro"]);
                modelo.CliFone = Convert.ToString(registro["cli_fone"]);
                modelo.CliCel = Convert.ToString(registro["cli_cel"]);
                modelo.CliEmail = Convert.ToString(registro["cli_email"]);
                modelo.CliEndNumero = Convert.ToString(registro["cli_endnumero"]);
                modelo.CliCidade = Convert.ToString(registro["cli_cidade"]);
                modelo.CliEstado = Convert.ToString(registro["cli_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
