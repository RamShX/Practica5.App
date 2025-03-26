
using System.Globalization;
using Prctica5.Domain.Interfaces;

namespace Prctica5.Domain.Entities
{
    public class StrategyFormatoTitulo : ITexto
    {
        public string ConvetirTexto(string texto)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto);
        }
    }
    
}
