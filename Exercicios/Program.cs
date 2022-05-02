using Exercicios.Exercicios;
using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite qual exercicio será feito (1-10):");

                int.TryParse(Console.ReadLine(), out int _convertido);

                var _exercicioEscolhido = _convertido;

                switch ((TipoExercicio)_exercicioEscolhido)
                {
                    case TipoExercicio.Exercicio01:
                        Console.WriteLine(Exercicio01.ResolverExercicio());
                        break;
                    case TipoExercicio.Exercicio02:
                        Exercicio02.ResolverExericio();
                        break;
                    case TipoExercicio.Exercicio03:
                        break;
                    case TipoExercicio.Exercicio04:
                        break;
                    case TipoExercicio.Exercicio05:
                        break;
                    case TipoExercicio.Exercicio06:
                        break;
                    case TipoExercicio.Exercicio07:
                        break;
                    case TipoExercicio.Exercicio08:
                        break;
                    case TipoExercicio.Exercicio09:
                        break;
                    case TipoExercicio.Exercicio10:
                        break;
                    default:
                        Console.WriteLine("Exercicio digitado não encontrado.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Final da execução. tecle enter para sair.");
            Console.ReadLine();
        }
    }
}
