using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLUnidadeDeMedida
    {

        private DALConexao conexao;

        public BLLUnidadeDeMedida(DALConexao cx)//set
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeDeMedidas modelo)
        {
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("A Descrição da Unidade de Medidas é obrigatório.");
            }
            modelo.UmedNome = modelo.UmedNome.ToUpper();

            DALUnidadeDeMedida DALobj = new DAL.DALUnidadeDeMedida(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloUnidadeDeMedidas modelo)
        {
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O Código da Unidade de Medidas é obrigatório.");
            }
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("A Descrição do Unidade de Medidas é obrigatório.");
            }
            modelo.UmedNome = modelo.UmedNome.ToUpper();

            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            DALobj.Alterar(modelo);
        }


        public void Excluir(int codigo)
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(String valor)
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            return DALobj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarPorCodigo(String valor)
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            return DALobj.LocalizarPorCodigo(valor);
        }

        public int VerificaUnidadeDeMedida(String valor)//pra verificar se und de medida exista
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            return DALobj.VerificaUnidadeDeMedida(valor);
        }

        public ModeloUnidadeDeMedidas CarregaModeloUnidadeDeMedidas(int codigo)
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            return DALobj.CarregaModuloUndMedidas(codigo);
        }
    }
}
