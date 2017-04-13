using DAL;//ad. e ad. referencia
using Modelo;//ad. e ad. referencia
using System;
using System.Data;

namespace BLL
{
    public class BLLCategoria
    {
        private DALConexao conexao;

        public BLLCategoria(DALConexao cx)//set
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O Nome da Categoria é obrigatório.");
            }
            modelo.CatNome = modelo.CatNome.ToUpper();

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCategoria modelo)
        {
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O Código da Categoria é obrigatório.");
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O Nome da Categoria é obrigatório.");
            }
            modelo.CatNome = modelo.CatNome.ToUpper();

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Alterar(modelo);
        }


        public void Excluir(int codigo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(String valor)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorCodigo(String valor)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificaCategoria(String valor)//27.03 pra verificar se und de medida exista
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.VerificaCategoria(valor);
        }

        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.CarregaModeloCategoria(codigo);
        }
    }
}
