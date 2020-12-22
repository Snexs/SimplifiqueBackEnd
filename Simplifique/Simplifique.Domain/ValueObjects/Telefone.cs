namespace Simplifique.Domain.ValueObjects
{
    public class Telefone : ObjetoDeValor
    {
        public int Ddd { get; private set; }
        public int Numero { get; private set; }

        public Telefone(int ddd,int numero)
        {
            Ddd = ddd;
            Numero = numero;
        }
    }
}
