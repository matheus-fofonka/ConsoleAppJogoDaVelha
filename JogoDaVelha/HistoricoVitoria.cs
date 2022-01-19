using System.Collections.Generic;

namespace JogoDaVelha
{
    internal class HistoricoVitoria
    {
        private List<EstadoCampo> listaVitoriosos { get; set; }

        public HistoricoVitoria()
        { listaVitoriosos = new List<EstadoCampo>(); }

        public int getNumeroVitorias(Jogador jogador)
        {
            return listaVitoriosos.FindAll(x => x == jogador.Simbolo).Count;
        }

        public int getNumeroEmpates()
        {
            return listaVitoriosos.FindAll(x => x == EstadoCampo.Vazio).Count;
        }

        public int getNumeroDerrotas(Jogador jogador)
        {
            return listaVitoriosos.FindAll(x => x != jogador.Simbolo && x != EstadoCampo.Vazio).Count;
        }

        public void AddVitoria(Jogador jogador)
        {
            listaVitoriosos.Add(jogador.Simbolo);
        }

        public void AddEmpate()
        {
            listaVitoriosos.Add(EstadoCampo.Vazio);
        }
    }
}