using System;

namespace TrabalhandoComString
{
    class TiposVariaveis
    {
        static void Main(string[] args)
        {
            string strPrimeira = "Alo ";
            string strSegunda = "Mundo";

            string strTerceira = strPrimeira + strSegunda;

            Console.WriteLine(strTerceira);

            int cchTamanho = strTerceira.Length;

            string strQuarta = "Tamanho = " + cchTamanho.ToString();
            Console.WriteLine(strQuarta);

            Console.WriteLine(strTerceira.Substring(0, 5));
        }
    }
}