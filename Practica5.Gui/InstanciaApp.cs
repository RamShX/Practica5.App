
using Prctica5.Domain.Context;
using Prctica5.Domain.Entities;
using Prctica5.Domain.Interfaces;

namespace Practica5.Gui
{
    public class InstaciaApp
    {
        
        public void Funcionalidad()
        {
            bool exit = true;

            while (exit)
            {
                Console.Clear();
                Console.WriteLine("Escribe tu cadena de string:");
                string texto = Console.ReadLine()!;
                Console.WriteLine("");
                Console.WriteLine("Formato");
                Console.WriteLine("[1] Mayúsculas");
                Console.WriteLine("[2] Mínúsculas");
                Console.WriteLine("[3] Tipo Título");
                Console.WriteLine("[4] Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("El valor ingresado no es valido");
                    continue;
                }

                if (opcion == 4)
                {
                    exit = false;
                    Console.WriteLine("Saliste");
                    continue;
                }

                //Le haré un factory cuando tenga tiempo en la noche en mi casa C: mi github para ver la actualización final https://github.com/RamShX/Practica5.App
                ContextFormato conversor = null;
                switch (opcion)
                {
                    case 1:
                        ITexto textoMayuscula = new StrategyMayuscula();
                        conversor = new ContextFormato(textoMayuscula);
                        break;
                    case 2:
                        ITexto textoMinuscula = new StrategyMinuscula();
                        conversor = new ContextFormato(textoMinuscula);
                        break;
                    case 3:
                        ITexto textoTitulo = new StrategyFormatoTitulo();
                        conversor = new ContextFormato(textoTitulo);
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                try
                {
                    
                    Console.WriteLine($"Converson final: {conversor.AplicarConversor(texto)}");
                }
                catch (Exception e)
                {

                    Console.WriteLine($"Error: {e.Message}");
                }

                Console.WriteLine("Presiona cualquier tecla para avanzar...");
                Console.ReadKey();

            }
        }

        private void AgregarEmpleado()
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine()!;
            Console.WriteLine("Ingrese el salario del empleado: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal salario) || salario < 0)
            {
                Console.WriteLine("Salario no válido");
                return;
            }

            Console.WriteLine("Ingrese el tipo de empleado: ");
            Console.WriteLine("1. Empleado de tiempo completo");
            Console.WriteLine("2. Empleado de medio tiempo");
            Console.WriteLine("3. Empleado por contrato");
            if (!int.TryParse(Console.ReadLine(), out int tipo) || tipo < 1 || tipo > 3)
            {
                Console.WriteLine("Tipo de empleado no válido");
                return;
            }

            try
            {
                

            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
            }
        }


        private void ExportarEmpleado()
        {
            Console.WriteLine("Seleccione el Formato que quiere exportar");
            Console.WriteLine("[1] Excel");
            Console.WriteLine("[2] Txt");
            Console.WriteLine("[3] Json");
            if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Opción de de elegir no válida");
                return;
            }

            try
            {
                
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
            }

        }
    }
}
