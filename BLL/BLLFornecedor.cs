using DAL;
using Modelo;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLLFornecedor
    {
        private DALConexao conexao;

        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O Nome do Fornecedor é obrigatório.");
            }
            /********************************************************************/
            if (modelo.ForRSocial.Trim().Length == 0)
            {
                throw new Exception("A Razão Social do Fornecedor é obrigatório.");
            }
            if (modelo.ForCNPJ.Trim().Length < 18)
            {
                throw new Exception("O CNPJ do Fornecedor é obrigatório.");
            }
            if (modelo.ForIE.Trim().Length < 15)
            {
                throw new Exception("A Inscrição Estadual do Fornecedor é obrigatório.");
            }
            if (modelo.ForCEP.Trim().Length < 9)
            {
                throw new Exception("O CEP do Fornecedor é obrigatório.");
            }
            if (modelo.ForEstado.Trim().Length == 0)
            {
                throw new Exception("O Estado do Fornecedor é obrigatório.");
            }
            if (modelo.ForCidade.Trim().Length == 0)
            {
                throw new Exception("A Cidade do Fornecedor é obrigatório.");
            }
            if (modelo.ForEndereco.Trim().Length == 0)
            {
                throw new Exception("O Endereço do Fornecedor é obrigatório.");
            }
            if (modelo.ForEndNumero.Trim().Length == 0)
            {
                throw new Exception("O Número de Endereço do Fornecedor é obrigatório.");
            }
            if (modelo.ForBairro.Trim().Length == 0)
            {
                throw new Exception("O Bairro do Fornecedor é obrigatório.");
            }
            /*if (modelo.ForEmail.Trim().Length == 0)
            {
                throw new Exception("O Email do Fornecedor é obrigatório.");
            }*/
            String strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                  "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                  ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<30.03 validação de email
            if (!re.IsMatch(modelo.ForEmail))
            {
                throw new Exception("Digite um E-Mail válido.");
            }
            if (modelo.ForFone.Trim().Length < 13)
            {
                throw new Exception("O Telefone do Fornecedor é obrigatório.");
            }
            if (modelo.ForCel.Trim().Length < 14)
            {
                throw new Exception("O Celular do Fornecedor é obrigatório.");
            }
            /*************************************************************************/
            modelo.ForNome = modelo.ForNome.ToUpper();
            modelo.ForRSocial = modelo.ForRSocial.ToUpper();
            modelo.ForEndereco = modelo.ForEndereco.ToUpper();
            modelo.ForBairro = modelo.ForBairro.ToUpper();
            modelo.ForCidade = modelo.ForCidade.ToUpper();
            modelo.ForEstado = modelo.ForEstado.ToUpper();

            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception(" O Nome do Fornecedor é obrigatório");
            }
            //modelo.ForNome = modelo.ForNome.ToUpper();
            /**************************************************************/
            if (modelo.ForRSocial.Trim().Length == 0)
            {
                throw new Exception("A Razão Social do Fornecedor é obrigatório.");
            }
            if (modelo.ForIE.Trim().Length < 15)
            {
                throw new Exception("A Inscrição Estadual do Fornecedor é obrigatório.");
            }
            if (modelo.ForCNPJ.Trim().Length < 18)
            {
                throw new Exception("O CNPJ do Fornecedor é obrigatório.");
            }
            if (modelo.ForCEP.Trim().Length < 9)
            {
                throw new Exception("O CEP do Fornecedor é obrigatório.");
            }
            if (modelo.ForEndereco.Trim().Length == 0)
            {
                throw new Exception("O Endereço do Fornecedor é obrigatório.");
            }
            if (modelo.ForBairro.Trim().Length == 0)
            {
                throw new Exception("O Bairro do Fornecedor é obrigatório.");
            }
            if (modelo.ForFone.Trim().Length < 13)
            {
                throw new Exception("O Telefone do Fornecedor é obrigatório.");
            }
            if (modelo.ForCel.Trim().Length < 14)
            {
                throw new Exception("O Celular do Fornecedor é obrigatório.");
            }
            /*if (modelo.ForEmail.Trim().Length == 0)
            {
                throw new Exception("O Email do Fornecedor é obrigatório.");
            }*/
            String strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                  "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                  ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.ForEmail))
            {
                throw new Exception("Digite um E-Mail válido.");
            }
            if (modelo.ForEndNumero.Trim().Length == 0)
            {
                throw new Exception("O Número de Endereço do Fornecedor é obrigatório.");
            }
            if (modelo.ForCidade.Trim().Length == 0)
            {
                throw new Exception("A Cidade do Fornecedor é obrigatório.");
            }
            if (modelo.ForEstado.Trim().Length == 0)
            {
                throw new Exception("O Estado do Fornecedor é obrigatório.");
            }


            modelo.ForNome = modelo.ForNome.ToUpper();
            modelo.ForRSocial = modelo.ForRSocial.ToUpper();
            modelo.ForEndereco = modelo.ForEndereco.ToUpper();
            modelo.ForBairro = modelo.ForBairro.ToUpper();
            modelo.ForCidade = modelo.ForCidade.ToUpper();
            modelo.ForEstado = modelo.ForEstado.ToUpper();

            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarPorCNPJ(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.LocalizarPorCNPJ(valor);
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(codigo);
        }
    }
}
