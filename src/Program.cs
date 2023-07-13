using System;
using System.Collections.Generic;
using model;
using controller;
using view;

class Program
{
    static void Main(string[] args)
    {
        JogoController jogoController = new JogoController();
        JogoView jogoView = new JogoView();

        jogoView.imprimirCabecalho();
        while (true)
        {
            jogoController.jogar();
            Console.WriteLine("Deseja jogar novamente? (S/N)");
            string resposta = Console.ReadLine();
            Console.Clear();

            if (resposta.ToUpper() != "S")
            {
                jogoView.exibirPontuacao(jogoController.getPontuacaoTotal());
                jogoView.imprimirResultado(jogoController);
                Console.WriteLine("Digite ENTER para encerrar o programa");
                Console.ReadLine();
                break;
            }
        }
    }
}
