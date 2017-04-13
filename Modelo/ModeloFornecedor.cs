using System;

namespace Modelo
{
    public class ModeloFornecedor
    {
        public ModeloFornecedor()
        {
            this.for_cod = 0;//trocar por this.for_cod
            this.for_nome = "";
            this.for_rsocial = "";
            this.for_ie = "";
            this.for_cnpj = "";
            this.for_cep = "";
            this.for_endereco = "";
            this.for_bairro = "";
            this.for_fone = "";
            this.for_cel = "";
            this.for_email = "";
            this.for_endnumero = "";
            this.for_cidade = "";
            this.for_estado = "";
        }

        public ModeloFornecedor(int forcod, String fornome, String forrsocial, String forie,
            String forcnpj, String forcep, String forendereco, String forbairro, String forfone,
            String forcel, String foremail, String forendnumero, String forcidade, String forestado)
        {
            this.for_cod = forcod;//trocar por this.for_cod
            this.for_nome = fornome;
            this.for_rsocial = forrsocial;
            this.for_ie = forie;
            this.for_cnpj = forcnpj;
            this.for_cep = forcep;
            this.for_endereco = forendereco;
            this.for_bairro = forbairro;
            this.for_fone = forfone;
            this.for_cel = forcel;
            this.for_email = foremail;
            this.for_endnumero = forendnumero;
            this.for_cidade = forcidade;
            this.for_estado = forestado;
        }

        private int for_cod;
        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }

        private String for_nome;
        public String ForNome
        {
            get { return this.for_nome; }
            set { this.for_nome = value; }
        }

        private String for_rsocial;
        public String ForRSocial
        {
            get { return this.for_rsocial; }
            set { this.for_rsocial = value; }
        }

        private String for_ie;
        public String ForIE
        {
            get { return this.for_ie; }
            set { this.for_ie = value; }
        }

        private String for_cnpj;
        public String ForCNPJ
        {
            get { return this.for_cnpj; }
            set { this.for_cnpj = value; }
        }

        private String for_cep;
        public String ForCEP
        {
            get { return this.for_cep; }
            set { this.for_cep = value; }
        }

        private String for_endereco;
        public String ForEndereco
        {
            get { return this.for_endereco; }
            set { this.for_endereco = value; }
        }

        private String for_bairro;
        public String ForBairro
        {
            get { return this.for_bairro; }
            set { this.for_bairro = value; }
        }

        private String for_fone;
        public String ForFone
        {
            get { return this.for_fone; }
            set { this.for_fone = value; }
        }

        private String for_cel;
        public String ForCel
        {
            get { return this.for_cel; }
            set { this.for_cel = value; }
        }

        private String for_email;
        public String ForEmail
        {
            get { return this.for_email; }
            set { this.for_email = value; }
        }

        private String for_endnumero;
        public String ForEndNumero
        {
            get { return this.for_endnumero; }
            set { this.for_endnumero = value; }
        }

        private String for_cidade;
        public String ForCidade
        {
            get { return this.for_cidade; }
            set { this.for_cidade = value; }
        }

        private String for_estado;
        public String ForEstado
        {
            get { return this.for_estado; }
            set { this.for_estado = value; }
        }
    }
}
