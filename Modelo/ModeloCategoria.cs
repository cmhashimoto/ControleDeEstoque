using System;

namespace Modelo
{
    public class ModeloCategoria
    {
        //representa todas as classes no banco de dados
        public ModeloCategoria()//metodo construtor criado qdo nao passado o parametro
        {
            this.CatCod = 0;//this.CatCod = 0;//<<<<28/03 mudou 
            this.CatNome = "";
        }

        public ModeloCategoria(int catcod, String nome)//metodo criado qdo passado parametro
        {
            this.CatCod = catcod;
            this.CatNome = nome;
        }

        private int _cat_cod;

        public int CatCod
        {
            get { return this._cat_cod; }
            set { this._cat_cod = value; }
        }

        private String _cat_nome;

        public String CatNome
        {
            get { return this._cat_nome; }
            set { this._cat_nome = value; }
        }

    }
}
