using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTipoDePagamento
    {
        //tpa_cod tpa_nome
        public ModeloTipoDePagamento()
        {
            this.tpa_cod = 0;
            this.tpa_nome = "";
        }

        public ModeloTipoDePagamento(int tpacod, String tpanome)
        {
            this.tpa_cod = tpacod;
            this.tpa_nome = tpanome;
        }

        private int tpa_cod;
        public int TpaCod
        {
            get { return this.tpa_cod; }
            set { this.tpa_cod = value; }
        }

        private String tpa_nome;

        public String TpaNome
        {
            get { return this.tpa_nome; }
            set { this.tpa_nome = value; }
        }
    }
}
