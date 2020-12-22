using Flunt.Validations;

namespace Simplifique.Domain.ValueObjects
{
    public class Cep : ObjetoDeValor
    {
        public int Numero { get; private set; }

        public Cep(int numero)
        {
            Numero = numero;

            AddNotifications(new Contract().Requires().IsFalse(Validar(),"Numero","CEP deve ter 8 caracteres"));
        }

        private bool Validar()
        {
            if (Numero.ToString().Length == 8)
                return true;

            return false;
        }
    }
}
