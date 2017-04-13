using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLTipoDePagamento
    {
        private DALConexao conexao;

        public BLLTipoDePagamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoDePagamento modelo)
        {
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("A Descrição do Tipo de Pagamento é obrigatório.");
            }
            if (modelo.TpaCod <= 0)
            {
                throw new Exception("O Código do Tipo de Pagamento é obrigatório.");
            }
            modelo.TpaNome = modelo.TpaNome.ToUpper();
            DALTipoDePagamento DALobj = new DALTipoDePagamento(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloTipoDePagamento modelo)
        {
            if (modelo.TpaCod <= 0)
            {
                throw new Exception("O Código do Tipo de Pagamento é obrigatório.");
            }
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O Nome do Tipo de Pagamento é obrigatório.");
            }
            modelo.TpaNome = modelo.TpaNome.ToUpper();

            DALTipoDePagamento DALobj = new DALTipoDePagamento(conexao);
            DALobj.Alterar(modelo);
        }


        public void Excluir(int codigo)
        {
            DALTipoDePagamento DALobj = new DALTipoDePagamento(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALTipoDePagamento DALobj = new DALTipoDePagamento(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorCodigo(String valor)
        {
            DALTipoDePagamento DALobj = new DALTipoDePagamento(conexao);
            return DALobj.LocalizarPorCodigo(valor);
        }

        public int VerificaTipoDePagamento(String valor)//27.03 pra verificar se und de medida exista
        {
            DALTipoDePagamento DALobj = new DALTipoDePagamento(conexao);
            return DALobj.VerificaTipoPagamento(valor);
        }

        public ModeloTipoDePagamento CarregaModeloTipoDePagamento(int codigo)
        {
            DALTipoDePagamento DALobj = new DALTipoDePagamento(conexao);
            return DALobj.CarregaModeloTipoDePagamento(codigo);
        }
    }
}
