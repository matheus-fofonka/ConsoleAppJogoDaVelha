namespace JogoDaVelha
{
    public class Jogador
    {
        public string Nome { get; set; }
        public EstadoCampo Simbolo { get; set; }
        public Jogador Next { get; set; }

        public Jogador()
        {
        }
    }
}