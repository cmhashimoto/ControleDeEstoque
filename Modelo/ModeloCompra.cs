using System;

namespace Modelo
{
    public class ModeloCompra
    {
        public ModeloCompra()
        {
            this.ComCod = 0;
            this.ComData = DateTime.Now;
            this.ComNFiscal = 0;
            this.ComTotal = 0;
            this.ComNparcelas = 0;
            this.ComStatus = 0;
            this.ForCod = 0;
            this.TpaCod = 0;
        }

        public ModeloCompra(int comcod, DateTime comdata, int comnfiscal, double comtotal, int comnparcelas, int comstatus, int forcod, int tpacod)
        {
            this.ComCod = comcod;
            this.ComData = comdata;
            this.ComNFiscal = comnfiscal;
            this.ComTotal = comtotal;
            this.ComNparcelas = comnparcelas;
            this.ComStatus = comstatus;
            this.ForCod = forcod;
            this.TpaCod = tpacod;
        }


        private int _com_cod;

        public int ComCod
        {
            get { return _com_cod; }
            set { _com_cod = value; }
        }

        private DateTime _com_data;

        public DateTime ComData
        {
            get { return _com_data; }
            set { _com_data = value; }
        }

        private int _com_nfiscal;

        public int ComNFiscal
        {
            get { return _com_nfiscal; }
            set { _com_nfiscal = value; }
        }

        private double _com_total;

        public double ComTotal
        {
            get { return _com_total; }
            set { _com_total = value; }
        }

        private int _com_nparcelas;

        public int ComNparcelas
        {
            get { return _com_nparcelas; }
            set { _com_nparcelas = value; }
        }

        private int _com_status;

        public int ComStatus
        {
            get { return _com_status; }
            set { _com_status = value; }
        }

        private int _for_cod;

        public int ForCod
        {
            get { return _for_cod; }
            set { _for_cod = value; }
        }

        private int _tpa_cod;

        public int TpaCod
        {
            get { return _tpa_cod; }
            set { _tpa_cod = value; }
        }
    }
}



