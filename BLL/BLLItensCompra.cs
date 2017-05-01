using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLItensCompra
    {
        private DALConexao conexao;

        public BLLItensCompra(DALConexao cx)//set
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O Código da Compra é obrigatório.");
            }
            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O Código do Item da Compra é obrigatório.");
            }
            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("A Quantidade deve ser maior que zero.");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O Código do Produto é obrigatório.");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O Código da Compra é obrigatório.");
            }
            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O Código do Item da Compra é obrigatório.");
            }
            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("A Quantidade deve ser maior que zero.");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O Código do Produto é obrigatório.");
            }

            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Alterar(modelo);
        }


        public void Excluir(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O Código da Compra é obrigatório.");
            }
            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O Código do Item da Compra é obrigatório.");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O Código do Produto é obrigatório.");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Excluir(modelo);
        }

        public DataTable Localizar(int comcod)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.Localizar(comcod);
        }


        public ModeloItensCompra CarregaModeloItensCompra(int itccod, int comcod, int procod)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.CarregaModeloItensCompra(itccod, comcod, procod);
        }
    }
}
