using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeDinheiro
{
    public class ExtratorValorDeArgumentosURL
    {

        private readonly string _argument;
        public string URL { get;}


        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento não pode ser vazio ou nulo", nameof(url));
            }

               URL = url;

            int indiceInterrogacao = URL.IndexOf('?');

            _argument = URL.Substring(indiceInterrogacao + 1);

        }

        // moedaOrigem=real&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentCaixaAlta = _argument.ToUpper(); // MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR&VALOR

            string termo = nomeParametro + "="; //moedaDestino
            int indiceTermo = argumentCaixaAlta.IndexOf(termo); // x

            string resultado = _argument.Substring(indiceTermo + termo.Length); // dolar
            int indiceEComercial = resultado.IndexOf("&");  
            
            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);  
        }


    }
}
