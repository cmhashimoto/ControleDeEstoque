using System;

namespace Modelo
{
    public class ModeloCliente
    {
        public ModeloCliente()
        {
            this.CliCod = 0;
            this.CliNome = "";
            this.CliCPFCNPJ = "";
            this.CliRGIE = "";
            this.CliRSocial = "";
            this.CliTipo = 0;
            this.CliCEP = "";
            this.CliEndereco = "";
            this.CliBairro = "";
            this.CliFone = "";
            this.CliCel = "";
            this.CliEmail = "";
            this.CliEndNumero = "";
            this.CliCidade = "";
            this.CliEstado = "";
        }

        public ModeloCliente(int clicod, String clinome, String clicpfcnpj, String clirgie, String clirsocial,
                             int clitipo, String clicep, String cliendereco, String clibairro, String clifone,
                             String clicel, String cliemail, String cliendnumero, String clicidade, String cliestado)
        {
            this.CliCod = clicod;
            this.CliNome = clinome;
            this.CliCPFCNPJ = clicpfcnpj;
            this.CliRGIE = clirgie;
            this.CliRSocial = clirsocial;
            this.CliTipo = clitipo;
            this.CliCEP = clicep;
            this.CliEndereco = cliendereco;
            this.CliBairro = clibairro;
            this.CliFone = clifone;
            this.CliCel = clicel;
            this.CliEmail = cliemail;
            this.CliEndNumero = cliendnumero;
            this.CliCidade = clicidade;
            this.CliEstado = cliestado;
        }
        private int cli_cod;
        public int CliCod
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }

        private String cli_nome;
        public String CliNome
        {
            get { return this.cli_nome; }
            set { this.cli_nome = value; }
        }

        private String cli_cpfcnpj;
        public String CliCPFCNPJ
        {
            get { return this.cli_cpfcnpj; }
            set { this.cli_cpfcnpj = value; }
        }

        private String cli_rgie;
        public String CliRGIE
        {
            get { return this.cli_rgie; }
            set { this.cli_rgie = value; }
        }

        private String cli_rsocial;
        public String CliRSocial
        {
            get { return this.cli_rsocial; }
            set { this.cli_rsocial = value; }
        }

        private int cli_tipo;
        public int CliTipo
        {
            get { return this.cli_tipo; }
            set { this.cli_tipo = value; }
        }

        private String cli_cep;
        public String CliCEP
        {
            get { return this.cli_cep; }
            set { this.cli_cep = value; }
        }

        private String cli_endereco;
        public String CliEndereco
        {
            get { return this.cli_endereco; }
            set { this.cli_endereco = value; }
        }

        private String cli_bairro;
        public String CliBairro
        {
            get { return this.cli_bairro; }
            set { this.cli_bairro = value; }
        }

        private String cli_fone;
        public String CliFone
        {
            get { return this.cli_fone; }
            set { this.cli_fone = value; }
        }

        private String cli_cel;
        public String CliCel
        {
            get { return this.cli_cel; }
            set { this.cli_cel = value; }
        }

        private String cli_email;
        public String CliEmail
        {
            get { return this.cli_email; }
            set { this.cli_email = value; }
        }

        private String cli_endnumero;
        public String CliEndNumero
        {
            get { return this.cli_endnumero; }
            set { this.cli_endnumero = value; }
        }

        private String cli_cidade;
        public String CliCidade
        {
            get { return this.cli_cidade; }
            set { this.cli_cidade = value; }
        }

        private String cli_estado;
        public String CliEstado
        {
            get { return this.cli_estado; }
            set { this.cli_estado = value; }
        }
    }
}
