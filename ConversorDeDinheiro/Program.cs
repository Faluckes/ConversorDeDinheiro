using System;
using System.Text.RegularExpressions;

namespace ConversorDeDinheiro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoTeste = "Meu nome é Faluckes, me ligue em 987515619";

            Match resultado = Regex.Match(textoTeste, padrao);
            Console.WriteLine(resultado.Value);

            Console.ReadLine();






            string urlTestee = "https://www.ConverterMoney.com/cambio";
            int indiceConverterMoney = urlTestee.IndexOf("https://www.ConverterMoney.com");
            Console.WriteLine(urlTestee.StartsWith("https://www.ConverterMoney.com"));
            Console.WriteLine(urlTestee.EndsWith("cambio"));

            Console.WriteLine(urlTestee.Contains("converterMoney"));


            Console.WriteLine(indiceConverterMoney == 0);
            Console.ReadLine();



            //pagina?argumento
            //012345678


            string urlParametros = "https://www.ConverterMoney.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=4000";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string moedaDestino = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine($"Valor moedaDestino: {moedaDestino}");
            string moedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine($"Valor moedaOrigem {moedaOrigem}");
            Console.WriteLine(extratorDeValores.GetValor("Valor"));



            Console.ReadLine();

            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(null);

            //string url = "pagina?modedaOrigem=real&moedaDestino=dolar";

            //int indiceInterrogacao = url.IndexOf('?');

            //Console.WriteLine(indiceInterrogacao);

            //Console.WriteLine(url);

            //string argumentos = url.Substring(indiceInterrogacao + 1);

            //Console.WriteLine(argumentos);

            //Console.ReadLine();
        }
    }
}