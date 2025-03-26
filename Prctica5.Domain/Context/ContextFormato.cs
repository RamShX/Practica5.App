
using Prctica5.Domain.Interfaces;

namespace Prctica5.Domain.Context
{
    public class ContextFormato
    {
        private readonly ITexto _texto;
        public ContextFormato(ITexto texto) 
        {
            _texto = texto;
        }

        public string AplicarConversor(string texto)
        {
            if(texto == null)
            {
                throw new Exception("El txto está vacío");
            }
            return _texto.ConvetirTexto(texto);
        }
    }
}
