using System;

namespace DAL
{
    public class DadosDaConexao//.\SQLEXPRESS******//srv_novo---PPR0560967W10-1
    {
        public static String servidor = @".\SQLEXPRESS";
        public static String banco = "ControleDeEstoque";
        public static String usuario = "sa";
        public static String senha = "123456";

        public static String StringDeConexao
        {
            get
            {
                return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
            }

        }
    }
}
