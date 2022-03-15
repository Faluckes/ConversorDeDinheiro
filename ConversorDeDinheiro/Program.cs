using System;

namespace ConversorDeDinheiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
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