using DAL;
using Modelo;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLLCliente//25.03
    {
        private DALConexao conexao;

        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O Nome do Cliente é obrigatório.");
            }
            /********************************************************************/
            if (modelo.CliCPFCNPJ.Trim().Length == 0)
            {
                throw new Exception("O CPF ou CNPJ do Cliente é obrigatório.");
            }
            /*if (modelo.CliTipo == 0)//31/03 validar cpf cnpj
            {
                //cpf
                if (Validacao.IsCPF(modelo.CliCPFCNPJ) == false)
                {
                    throw new Exception("O CPF informado é inválido.");
                }
            }
            else
            {
                //cnpj
                if (Validacao.IsCNPJ(modelo.CliCPFCNPJ) == false)
                {
                    throw new Exception("O CNPJ informado é inválido.");
                }
            }*/
            if (modelo.CliRGIE.Trim().Length == 0)
            {
                throw new Exception("O RG ou IE do Cliente é obrigatório.");
            }
            if (modelo.CliRSocial.Trim().Length == 0)
            {
                throw new Exception("A Razão Social do Cliente é obrigatório.");
            }
            /*if (modelo.CliTipo <= 0)
            {
                throw new Exception("O Tipo do Cliente é obrigatório.");
            }*/
            if (modelo.CliCEP.Trim().Length < 9)
            {
                throw new Exception("O CEP do Cliente é obrigatório.");
            }
            if (modelo.CliEndereco.Trim().Length == 0)
            {
                throw new Exception("O Endereço do Cliente é obrigatório.");
            }
            if (modelo.CliBairro.Trim().Length == 0)
            {
                throw new Exception("O Bairro do Cliente é obrigatório.");
            }
            if (modelo.CliFone.Trim().Length < 13)
            {
                throw new Exception("O Telefone do Cliente é obrigatório.");
            }
            if (modelo.CliCel.Trim().Length < 14)
            {
                throw new Exception("O Celular do Cliente é obrigatório.");
            }
            /*if (modelo.CliEmail.Trim().Length == 0)
            {
                throw new Exception("O Email do Cliente é obrigatório.");
            }*/
            String strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                              "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                              ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.CliEmail))
            {
                throw new Exception("Digite um E-Mail válido.");
            }
            ///////////////////////////////////////////////////////
            if (modelo.CliEndNumero.Trim().Length == 0)
            {
                throw new Exception("O Número de Endereço do Cliente é obrigatório.");
            }
            if (modelo.CliCidade.Trim().Length == 0)
            {
                throw new Exception("A Cidade do Cliente é obrigatório.");
            }
            if (modelo.CliEstado.Trim().Length == 0)
            {
                throw new Exception("O Estado do Cliente é obrigatório.");
            }
            /*************************************************************************/
            modelo.CliNome = modelo.CliNome.ToUpper();
            modelo.CliRSocial = modelo.CliRSocial.ToUpper();
            modelo.CliEndereco = modelo.CliEndereco.ToUpper();
            modelo.CliBairro = modelo.CliBairro.ToUpper();
            modelo.CliCidade = modelo.CliCidade.ToUpper();
            modelo.CliEstado = modelo.CliEstado.ToUpper();

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception(" O Nome do Cliente é obrigatório");
            }
            modelo.CliNome = modelo.CliNome.ToUpper();
            /**************************************************************/
            if (modelo.CliCPFCNPJ.Trim().Length == 0)
            {
                throw new Exception("O CPF ou CNPJ do Cliente é obrigatório.");
            }
            if (modelo.CliRGIE.Trim().Length == 0)
            {
                throw new Exception("O RG ou IE do Cliente é obrigatório.");
            }
            if (modelo.CliRSocial.Trim().Length == 0)
            {
                throw new Exception("A Razão Social do Cliente é obrigatório.");
            }
            /*if (modelo.CliTipo <= 0)
            {
                throw new Exception("O Tipo do Cliente é obrigatório.");
            }*/
            if (modelo.CliCEP.Trim().Length < 9)
            {
                throw new Exception("O CEP do Cliente é obrigatório.");
            }
            if (modelo.CliEndereco.Trim().Length == 0)
            {
                throw new Exception("O Endereço do Cliente é obrigatório.");
            }
            if (modelo.CliBairro.Trim().Length == 0)
            {
                throw new Exception("O Bairro do Cliente é obrigatório.");
            }
            if (modelo.CliFone.Trim().Length < 13)
            {
                throw new Exception("O Telefone do Cliente é obrigatório.");
            }
            if (modelo.CliCel.Trim().Length < 14)
            {
                throw new Exception("O Celular do Cliente é obrigatório.");
            }
            /*if (modelo.CliEmail.Trim().Length == 0)
            {
                throw new Exception("O Email do Cliente é obrigatório.");
            }*/
            String strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                  "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                  ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.CliEmail))
            {
                throw new Exception("Digite um E-Mail válido.");
            }
            if (modelo.CliEndNumero.Trim().Length == 0)
            {
                throw new Exception("O Número de Endereço do Cliente é obrigatório.");
            }
            if (modelo.CliCidade.Trim().Length == 0)
            {
                throw new Exception("A Cidade do Cliente é obrigatório.");
            }
            if (modelo.CliEstado.Trim().Length == 0)
            {
                throw new Exception("O Estado do Cliente é obrigatório.");
            }

            modelo.CliNome = modelo.CliNome.ToUpper();
            modelo.CliRSocial = modelo.CliRSocial.ToUpper();
            modelo.CliEndereco = modelo.CliEndereco.ToUpper();
            modelo.CliBairro = modelo.CliBairro.ToUpper();
            modelo.CliCidade = modelo.CliCidade.ToUpper();
            modelo.CliEstado = modelo.CliEstado.ToUpper();

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(String valor)//28/03 
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarPorCPFCNPJ(String valor)//28/03
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.LocalizarPorCPFCNPJ(valor);
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(codigo);
        }

        public ModeloCliente CarregaModeloCliente(String cpfcnpj)//28.03 overload
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(cpfcnpj);
        }
    }
}
