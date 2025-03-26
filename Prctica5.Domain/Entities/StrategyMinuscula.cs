using Prctica5.Domain.Interfaces;


namespace Prctica5.Domain.Entities
{
    public class StrategyMinuscula : ITexto
    {
        public string ConvetirTexto(string texto)
        {
            return texto.ToLower();
        }
    }
}
