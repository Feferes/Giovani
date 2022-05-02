using System;
using System.Globalization;

namespace Exercicios.Exercicios
{
    static class Exercicio02
    {
        public static void ResolverExericio()
        {
            var pagamentosEmCartao = new decimal[50];
            var pagamentosEmCheque = new decimal[50];
            var pagamentosEmDinheiro = new decimal[50];

            /*Exemplo de valores que foram pagos*/
            for (int i = 0; i < 50; i++)
            {
                pagamentosEmCartao[i] = (i * 20);
            }

            for (int i = 0; i < 50; i++)
            {
                pagamentosEmCheque[i] = (i * 33);
            }

            for (int i = 0; i < 50; i++)
            {
                pagamentosEmDinheiro[i] = (i * 47);
            }


            var _totalPagoEmCartao = decimal.Zero;
            for (int i = 0; i < pagamentosEmCartao.Length; i++)
            {
                _totalPagoEmCartao += pagamentosEmCartao[i];
            }

            var _totalPagoEmCheque = decimal.Zero;
            for (int i = 0; i < pagamentosEmCheque.Length; i++)
            {
                _totalPagoEmCheque += pagamentosEmCheque[i];
            }

            var _totalPagoEmDinheiro = decimal.Zero;
            for (int i = 0; i < pagamentosEmDinheiro.Length; i++)
            {
                _totalPagoEmDinheiro += pagamentosEmDinheiro[i];
            }

            Console.WriteLine($"O Valor total em cartão foi: {_totalPagoEmCartao.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"O Valor total em cheques foi: {_totalPagoEmCheque.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"O Valor total em dinheiro foi: {_totalPagoEmDinheiro.ToString("C", CultureInfo.CurrentCulture)}");
        }
    }
}
