using System;
using controller;
using model;

namespace view
{
    class JogoView
    {
        public void imprimirResultado(JogoController jogoController)
        {
            List<String> listaResultados = jogoController.getResultados();
            List<int> listaSorteados = jogoController.getSorteados();
            List<int> listaEscolhidos = jogoController.getEscolhidos();

            Console.WriteLine("------------------- A tabela de números foi -------------------");
            Console.WriteLine("|   Tentativa   |   Nº Sorteado   |   Nº Escolhido  |     Resultado    |");
            for (int i = 0; i < listaSorteados.Count; i++)
            {
                Console.WriteLine("|     {0,-9} |     {1,-11} |     {2,-11} |    {3,-14} |",
                    (i + 1), listaSorteados[i], listaEscolhidos[i], listaResultados[i]);
            }
        }

        public void exibirPontuacao(int pontuacao)
        {
            Console.WriteLine("Pontuação: " + pontuacao);
        }

        public void imprimirCabecalho()
        {

            string esp = " ";
            string texto1 = "SECRET NUMBER";
            string texto2 = "Acerte o número secreto";
            string texto3 = "e ganhe pontos!";
            string texto4 = "Pressione * ENTER * para começar!";

            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine($"| {texto1,23}{esp,11} |");
            Console.WriteLine($"| {esp,34} |");
            Console.WriteLine($"| {texto2,27}{esp,7} |");
            Console.WriteLine($"| {texto3,25}{esp,9} |");
            Console.WriteLine($"| {esp,34} |");
            Console.WriteLine($"|  {texto4,13} |");
            Console.WriteLine("------------------------------------");
            Console.ReadLine();
            Console.Clear();
        }

    }
}