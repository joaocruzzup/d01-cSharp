using System;
using System.Dynamic;

namespace model
{

    class Pontuacao
    {
        private int pontuacaoTotal;
        private List<String> resultados = new List<String>();
        private List<int> escolhidos = new List<int>();
        private List<int> sorteados = new List<int>();


        public void incrementarPontuacaoTotal(int pontos)
        {
            pontuacaoTotal += pontos;
        }

        public void adiconarResultados(String resultado)
        {
            this.resultados.Add(resultado);
        }

        public void adicionarSorteados(int sorteado)
        {
            this.sorteados.Add(sorteado);
        }

        public void adicionarEscolhidos(int escolhido)
        {
            this.escolhidos.Add(escolhido);
        }

        public int PontuacaoTotal
        {
            get { return pontuacaoTotal; }
            set { pontuacaoTotal = value; }
        }

        public List<int> Escolhidos
        {
            get { return escolhidos; }
            set { escolhidos = value; }
        }

         public List<int> Sorteados
        {
            get { return sorteados; }
            set { sorteados = value; }
        }

        public List<String> Resultados
        {
            get { return resultados; }
            set { resultados = value; }
        }

    }

}

