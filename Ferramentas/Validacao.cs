namespace Ferramentas
{
    public class Validacao
    {
        //valida o cpf
        public static bool IsCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;
            string tempCPF, digito;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

            if (cpf.Length != 11)
            {
                return false;
            }
            else
            {
                tempCPF = cpf.Substring(0, 9);
            }

            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCPF[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCPF = tempCPF + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCPF[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        //valida o cnpj
        public static bool IsCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;
            string digito, tempCNPJ;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace(" ", "");
            if (cnpj.Length != 14)
            {
                return false;
            }
            else
            {
                tempCNPJ = cnpj.Substring(0, 12);
            }

            soma = 0;
            for (int i = 0; i < 12; i++)
            {
                soma += int.Parse(tempCNPJ[i].ToString()) * multiplicador1[i];
            }

            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCNPJ = tempCNPJ + digito;

            soma = 0;
            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(tempCNPJ[i].ToString()) * multiplicador2[i];
            }

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}
