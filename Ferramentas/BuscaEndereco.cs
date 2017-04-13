using System;
using System.Data;
using System.Text.RegularExpressions;

namespace Ferramentas
{
    public class BuscaEndereco
    {
        static public String cep = "";
        static public String cidade = "";
        static public String estado = "";
        static public String endereco = "";
        static public String bairro = "";

        public static Boolean verificaCEP(String CEP)
        {
            bool flag = false;
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP);
                //ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + CEP.Replace("-", "").Trim() + "&formato=xml");
                ds.ReadXml(xml);
                endereco = ds.Tables[0].Rows[0]["logradouro"].ToString();
                bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                estado = ds.Tables[0].Rows[0]["uf"].ToString();
                cep = CEP;
                flag = true;
            }
            catch //(Exception ex)
            {
                endereco = "";
                bairro = "";
                cidade = "";
                estado = "";
                cep = "";
            }
            return flag;
        }

        //valida email
        public Boolean ValidaEmail(String email)//30/03
        {
            String strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                  "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                  ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            //return Regex.IsMatch(email, strRegex);//ou as 2 linhas de baixo
            Regex re = new Regex(strRegex);
            return re.IsMatch(email);
        }

        //valida cep
        public bool ValidaCEP(string cep)
        {
            return Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3]"));
        }
    }
}
