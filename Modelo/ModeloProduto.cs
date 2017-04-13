using System;
using System.IO;

namespace Modelo
{
    public class ModeloProduto//28.03
    {
        public ModeloProduto()
        {
            this.ProCod = 0;
            this.ProNome = "";
            this.ProDescricao = "";
            //this.pro_foto = "";//null
            this.ProValorPago = 0;
            this.ProValorVenda = 0;
            this.ProQtde = 0;
            this.UmedCod = 0;
            this.CatCod = 0;
            this.ScatCod = 0;
        }

        public ModeloProduto(int procod, String pronome, String prodescricao, String profoto, Double provalorpago,
                              Double provalorvenda, int proqtde, int umedcod, int catcod, int scatcod)
        {
            this.ProCod = procod;
            this.ProNome = pronome;
            this.ProDescricao = prodescricao;
            this.CarregaImagem(profoto);
            this.ProValorPago = provalorpago;
            this.ProValorVenda = provalorvenda;
            this.ProQtde = proqtde;
            this.UmedCod = umedcod;
            this.CatCod = catcod;
            this.ScatCod = scatcod;
        }

        public ModeloProduto(int procod, String pronome, String prodescricao, byte[] profoto, Double provalorpago,
                      Double provalorvenda, int proqtde, int umedcod, int catcod, int scatcod)
        {
            this.ProCod = procod;
            this.ProNome = pronome;
            this.ProDescricao = prodescricao;
            this.ProFoto = profoto;
            this.ProValorPago = provalorpago;
            this.ProValorVenda = provalorvenda;
            this.ProQtde = proqtde;
            this.UmedCod = umedcod;
            this.CatCod = catcod;
            this.ScatCod = scatcod;
        }

        private int _pro_cod;
        public int ProCod
        {
            get { return this._pro_cod; }
            set { this._pro_cod = value; }
        }

        private String _pro_nome;
        public String ProNome
        {
            get { return this._pro_nome; }
            set { this._pro_nome = value; }
        }

        private String _pro_descricao;
        public String ProDescricao
        {
            get { return this._pro_descricao; }
            set { this._pro_descricao = value; }
        }

        /// <summary>
        /// vai representar um vetor
        /// </summary>
        private byte[] _pro_foto;
        public byte[] ProFoto
        {
            get { return this._pro_foto; }
            set { this._pro_foto = value; }
        }

        public void CarregaImagem(String imgPath)
        {
            try
            {
                if (String.IsNullOrEmpty(imgPath))
                    return;
                //fornece propriedades métodos de instância para criar, copiar
                //excluir, mover, abrir arquivos ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgPath);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar
                FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória pra o vetor
                this.ProFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava os dados em um buffer fornecido.
                int iBytesRead = fs.Read(this.ProFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private Double _pro_valorpago;
        public Double ProValorPago
        {
            get { return this._pro_valorpago; }
            set { this._pro_valorpago = value; }
        }

        private Double _pro_valorvenda;
        public Double ProValorVenda
        {
            get { return this._pro_valorvenda; }
            set { this._pro_valorvenda = value; }
        }

        private int _pro_qtde;
        public int ProQtde
        {
            get { return this._pro_qtde; }
            set { this._pro_qtde = value; }
        }

        private int _umed_cod;
        public int UmedCod
        {
            get { return this._umed_cod; }
            set { this._umed_cod = value; }
        }

        private int _cat_cod;
        public int CatCod
        {
            get { return this._cat_cod; }
            set { this._cat_cod = value; }
        }

        private int _scat_cod;
        public int ScatCod
        {
            get { return this._scat_cod; }
            set { this._scat_cod = value; }
        }
    }
}
