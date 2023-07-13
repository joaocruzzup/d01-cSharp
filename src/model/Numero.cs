using System;

namespace model
{
    class Numero
    {
        private int numeroAleatorio;
        private int dificuldade;

        public Numero()
        {
            this.dificuldade = 1;
        }

        public void setDificuldade(int dificuldade)
        {
            this.dificuldade = dificuldade;
        }

        public int sortearNumeroAleatorio()
        {
            Random random = new Random();
            this.numeroAleatorio = random.Next(1, 11 * this.dificuldade);
            return this.numeroAleatorio;
        }
    }

}
