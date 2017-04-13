using System;

namespace Modelo
{
    public class ModeloSubCategoria
    {
        public ModeloSubCategoria()//construtor para iniciar as propriedades
        {
            this.scat_cod = 0;//ScatCod(maiscula) variavel da classe//28/03<<<<mudou this.scat_cod
            this.scat_nome = "";
            this.cat_cod = 0;
        }

        public ModeloSubCategoria(int scatcod, String scatnome, int catcod)
        {
            this.scat_cod = scatcod;//scatcod(minuscula) parametro
            this.scat_nome = scatnome;
            this.cat_cod = catcod;
        }

        private int scat_cod;//propriedade
        public int SCatCod
        {
            get { return this.scat_cod; }
            set { this.scat_cod = value; }
        }

        private String scat_nome;
        public String SCatNome
        {
            get { return this.scat_nome; }
            set { this.scat_nome = value; }
        }

        private int cat_cod;
        public int CatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }
    }
}
