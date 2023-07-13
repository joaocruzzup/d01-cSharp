using System;
using model;

namespace controller
{
    class JogoController
    {
        private Numero numero = new Numero();
        private Pontuacao pontuacao = new Pontuacao();

        public void jogar()
        {
            int dificuldade = obterDificuldade();
            int numeroEscolhido = obterRespostaUsuario();
            int numeroAleatorio = numero.sortearNumeroAleatorio();
            Console.Clear();
            if (numeroAleatorio == numeroEscolhido)
            {
                Console.WriteLine("Parabéns! Você acertou o número! e ganhou 10 pontos :D");
                pontuacao.adicionarEscolhidos(numeroEscolhido);
                pontuacao.adicionarSorteados(numeroAleatorio);
                pontuacao.adiconarResultados("Acertou");
                pontuacao.incrementarPontuacaoTotal(10);
            }
            else if (numeroAleatorio == numeroEscolhido + 1 || numeroAleatorio == numeroEscolhido - 1)
            {
                Console.WriteLine("Por pouco! Você quase acertou o número, mas ganhou 5 pontos :) ");
                pontuacao.adicionarEscolhidos(numeroEscolhido);
                pontuacao.adicionarSorteados(numeroAleatorio);
                pontuacao.adiconarResultados("Quase acertou");

                pontuacao.incrementarPontuacaoTotal(5);
            }
            else
            {
                Console.WriteLine("Que pena! Você errou o número e não ganhou nenhum ponto :(");
                pontuacao.adicionarEscolhidos(numeroEscolhido);
                pontuacao.adicionarSorteados(numeroAleatorio);
                pontuacao.adiconarResultados("Errou");

                pontuacao.incrementarPontuacaoTotal(0);
            }

        }

        public int obterRespostaUsuario()
        {
            Console.WriteLine("Digite um número: ");
            int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
            return numeroEscolhido;
        }

        public int obterDificuldade()
        {
            Console.WriteLine("Escolha a dificuldade do jogo: \n" +
                                "1 - Fácil \n" +
                                "2 - Normal \n" +
                                "3 - Difícil \n");
            Console.WriteLine("Digite aqui o número opção: ");
            return Convert.ToInt32(Console.ReadLine());
        }


        public List<int> getEscolhidos()
        {
            return pontuacao.Escolhidos;
        }

        public List<int> getSorteados()
        {
            return pontuacao.Sorteados;
        }

        public int getPontuacaoTotal()
        {
            return pontuacao.PontuacaoTotal;
        }

        public List<String> getResultados()
        {
            return pontuacao.Resultados;
        }

    }
}