using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLProduto
    {
        private DALConexao conexao;

        public BLLProduto(DALConexao cx)//set
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto modelo)//nome, descrição, valorvenda, umed, cat, scat e qtde >= 0;
        {
            if (modelo.ProNome.Trim().Length == 0)
            {
                throw new Exception("O Nome do Produto é obrigatório.");
            }
            if (modelo.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A Descrição do Produto é obrigatório.");
            }
            if (modelo.ProValorVenda <= 0)
            {
                throw new Exception("O Valor de Venda do Produto é obrigatório.");
            }
            if (modelo.ProQtde < 0)
            {
                throw new Exception("A Quantidade do Produto deve ser Maior ou Igual a zero.");
            }
            if (modelo.ScatCod <= 0)
            {
                throw new Exception("O Código da SubCategoria do Produto é obrigatório.");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O Código da Categoria do Produto é obrigatório.");
            }
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O Código da Unidade de Medida do Produto é obrigatório.");
            }

            modelo.ProNome = modelo.ProNome.ToUpper();
            modelo.ProDescricao = modelo.ProDescricao.ToUpper();

            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloProduto modelo)
        {
            if (modelo.ProNome.Trim().Length == 0)
            {
                throw new Exception("O Nome do Produto é obrigatório.");
            }
            if (modelo.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A Descrição do Produto é obrigatório.");
            }
            if (modelo.ProValorVenda <= 0)
            {
                throw new Exception("O Valor de Venda do Produto é obrigatório.");
            }
            if (modelo.ProQtde < 0)
            {
                throw new Exception("A Quantidade do Produto deve ser Maior ou Igual a zero.");
            }
            if (modelo.ScatCod <= 0)
            {
                throw new Exception("O Código da SubCategoria do Produto é obrigatório.");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O Código da Categoria do Produto é obrigatório.");
            }
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O Código da Unidade de Medida do Produto é obrigatório.");
            }

            modelo.ProNome = modelo.ProNome.ToUpper();
            modelo.ProDescricao = modelo.ProDescricao.ToUpper();

            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Alterar(modelo);
        }


        public void Excluir(int codigo)
        {
            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorDescricao(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.LocalizarPorDescricao(valor);
        }

        public DataTable LocalizarPorNomeCat(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.LocalizarPorNomeCat(valor);
        }

        public DataTable LocalizarPorCodigo(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.LocalizarPorCodigo(valor);
        }

        public int VerificaProduto(String valor)// pra verificar se produto existe
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.VerificaProduto(valor);
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.CarregaModeloProduto(codigo);
        }
    }
}

