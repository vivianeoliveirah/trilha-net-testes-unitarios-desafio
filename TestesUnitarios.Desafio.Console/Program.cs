using System;

namespace Desafio.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bem-vindo ao Desafio de Orientação a Objetos!");

            // Exemplo de uso do código que você implementou
            var validacoesLista = new ValidacoesLista();
            var listaOriginal = new List<int> { 5, -1, -8, 9 };

            // Testando os métodos da classe ValidacoesLista
            var listaSemNegativos = validacoesLista.RemoverNumerosNegativos(listaOriginal);
            System.Console.WriteLine("Lista sem números negativos: " + string.Join(", ", listaSemNegativos));

            var numeroParaProcurar = 9;
            var contemNumero = validacoesLista.ListaContemDeterminadoNumero(listaOriginal, numeroParaProcurar);
            System.Console.WriteLine($"A lista contém o número {numeroParaProcurar}? {contemNumero}");

            var listaMultiplicada = validacoesLista.MultiplicarNumerosLista(listaOriginal, 2);
            System.Console.WriteLine("Lista multiplicada por 2: " + string.Join(", ", listaMultiplicada));

            var maiorNumero = validacoesLista.RetornarMaiorNumeroLista(listaOriginal);
            System.Console.WriteLine("Maior número na lista: " + maiorNumero);

            var menorNumero = validacoesLista.RetornarMenorNumeroLista(listaOriginal);
            System.Console.WriteLine("Menor número na lista: " + menorNumero);

            // Exemplo de uso da classe ValidacoesString
            var validacoesString = new ValidacoesString();
            var texto = "Isso é um texto de exemplo.";

            // Testando os métodos da classe ValidacoesString
            var quantidadeCaracteres = validacoesString.RetornarQuantidadeCaracteres(texto);
            System.Console.WriteLine("Quantidade de caracteres no texto: " + quantidadeCaracteres);

            var textoProcurado = "exemplo";
            var contemTexto = validacoesString.ContemCaractere(texto, textoProcurado);
            System.Console.WriteLine($"O texto contém a palavra '{textoProcurado}'? {contemTexto}");

            var terminaComTexto = validacoesString.TextoTerminaCom(texto, "exemplo.");
            System.Console.WriteLine($"O texto termina com 'exemplo.'? {terminaComTexto}");

            System.Console.WriteLine("Pressione qualquer tecla para sair...");
            System.Console.ReadKey();
        }
    }
}
