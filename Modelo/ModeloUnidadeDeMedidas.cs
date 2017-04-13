using System;

namespace Modelo
{
    public class ModeloUnidadeDeMedidas
    {
        public ModeloUnidadeDeMedidas()
        {
            this.umed_cod = 0;
            this.umed_nome = "";
        }

        public ModeloUnidadeDeMedidas(int umedcod, String umednome)
        {
            this.umed_cod = umedcod;
            this.umed_nome = umednome;
        }

        private int umed_cod;
        public int UmedCod
        {
            get { return this.umed_cod; }
            set { this.umed_cod = value; }
        }


        private String umed_nome;

        public String UmedNome
        {
            get { return this.umed_nome; }
            set { this.umed_nome = value; }
        }
    }
}
