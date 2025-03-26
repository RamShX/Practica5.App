using Prctica5.Domain.Interfaces;

namespace Prctica5.Domain.Entities
{
    public class StrategyMayuscula : ITexto
    {
        //Formato título. Por ejemplo: Texto Ingresado Por El Usuario
        public string ConvetirTexto(string texto)
        {
            return texto.ToUpper();
        }
    }
}
