using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLCompra
    {
        private DALConexao conexao;
        public BLLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O Valor da Compra é obrigatório.");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("O Código do Fornecedor é obrigatório.");
            }

            if (modelo.ComNparcelas <= 0)
            {
                throw new Exception("O número de Parcelas deve ser Mínimo de uma Parcela.");
            }

            /*if (modelo.ComData != DateTime.Now)
            {
                throw new Exception("A Data da Compra não corresponde a Data Atual.");
            }*/

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O Código da Compra é obrigatório.");
            }

            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O Valor da Compra é obrigatório.");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("O Código do Fornecedor é obrigatório.");
            }

            if (modelo.ComNparcelas <= 0)
            {
                throw new Exception("O número de Parcelas deve ser Mínimo de uma Parcela.");
            }

            /*if (modelo.ComData != DateTime.Now)
            {
                throw new Exception("A Data da Compra não corresponde a Data Atual.");
            }*/

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)//instanciar e chamar metodo
        {
            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(codigo);
        }

        public DataTable Localizar(String nome)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(nome);
        }

        public DataTable Localizar(DateTime datainicial, DateTime datafinal)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(datainicial, datafinal);
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.CarregaModeloCompra(codigo);
        }
    }
}
