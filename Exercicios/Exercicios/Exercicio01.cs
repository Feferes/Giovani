using System;

namespace Exercicios.Exercicios
{
    public static class Exercicio01
    {
        public static string ResolverExercicio()
        {
            Console.WriteLine("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int _convertido01);

            Console.WriteLine("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int _convertido02);

            Console.WriteLine("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int _convertido03);

            Console.WriteLine("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int _convertido04);

            Console.WriteLine("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int _convertido05);

            Console.WriteLine("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int _convertido06);

            Console.WriteLine("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int _convertido07);

            Console.WriteLine("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int _convertido08);

            Console.WriteLine("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int _convertido09);

            Console.WriteLine("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int _convertido10);

            int _totalSomado = 0;
            int _quantidadeValoresEncontrados = 0;

            var _numerosDigitados = new int[] {
                _convertido01,
                _convertido02,
                _convertido03,
                _convertido04,
                _convertido05,
                _convertido06,
                _convertido07,
                _convertido08,
                _convertido09,
                _convertido10
            };

            for (int i = 0; i < 10; i++)
            {
                if (_numerosDigitados[i] < 0)
                {
                    _totalSomado += _numerosDigitados[i];
                    _quantidadeValoresEncontrados++;
                }
            }

            if (_quantidadeValoresEncontrados == 0)
            {
                return "Não foram encontrados números menores que 0";
            }

            return $"A média dos valores menores que 0 é: {_totalSomado / _quantidadeValoresEncontrados}";
        }
    }
}
