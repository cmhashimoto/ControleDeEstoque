using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLSubCategoria
    {
        private DALConexao conexao;

        public BLLSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            if (modelo.SCatNome.Trim().Length == 0)
            {
                throw new Exception("A Descrição da SubCategoria é obrigatório.");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O Código da Categoria é obrigatório.");
            }
            modelo.SCatNome = modelo.SCatNome.ToUpper();

            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.SCatCod <= 0)
            {
                throw new Exception("O Código da SubCategoria é obrigatório");
            }
            if (modelo.SCatNome.Trim().Length == 0)
            {
                throw new Exception("A Descrição da SubCategoria é obrigatório");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O Código da Categoria é obrigatório");
            }
            modelo.SCatNome = modelo.SCatNome.ToUpper();

            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Alterar(modelo);//método
        }

        public void Excluir(int codigo, int cat)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Excluir(codigo, cat);
        }

        public DataTable Localizar(String valor)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(String valor)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarPorSubCod(String valor)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.LocalizarPorSubCod(valor);
        }

        public DataTable LocalizarPorCatNome(String valor)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.LocalizarPorCatNome(valor);
        }

        public DataTable LocalizarPorCategoria(int categoria)//29.03
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.LocalizarPorCategoria(categoria);
        }

        public int VerificaSubCategoria(String valor)//27.03 pra verificar se und de medida exista
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.VerificaSubCategoria(valor);
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo, int cat)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.CarregaModeloSubCategoria(codigo, cat);
        }
    }
}
