using Flunt.Validations;
using Simplifique.Domain.Enums;

namespace Simplifique.Domain.ValueObjects
{
    public class Documento : ObjetoDeValor
    {
        public int Numero { get; private set; }
        public TipoDocumentoEnum Tipo { get; private set; }

        public Documento(int numero, TipoDocumentoEnum tipo)
        {
            Numero = numero;
            Tipo = tipo;

            AddNotifications(new Contract().Requires().IsTrue(Validar(), "Numero Documento", "Documento Invalido"));
        }

        private bool Validar()
        {
            if (Tipo == TipoDocumentoEnum.CNPJ && Numero.ToString().Length == 14)
                return true;
            if (Tipo == TipoDocumentoEnum.CPF && Numero.ToString().Length == 11)
                return true;

            return false;
        }
    }
}
