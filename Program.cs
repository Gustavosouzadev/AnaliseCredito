using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            decimal valor, renda, PorCentRenda;
            int resultado, parcelas;

            Console.Write("Insira o valor solicitado de empréstimo (até R$ 10.000,00): R$ ");
            valor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            if (valor > 10000)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Atenção: Valor de empréstimo excedido.");
                Console.ResetColor();
                Environment.Exit(-1);
            }

            else if (valor <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Atenção: Valor de empréstimo inválido.");
                Console.ResetColor();
                Environment.Exit(-1);
            }

                Console.Write("Insira a quantidade de parcelas solicitado (até 12x): ");
                parcelas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (parcelas > 12)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Atenção!! Quantidade de parcela(s) excedida(s).");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }

                else if (parcelas < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Atenção!! Quantidade de parcela(s) inválida(s).");
                    Console.ResetColor();
                    Environment.Exit(0);
                }

            resultado = (int)Convert.ToDecimal(valor / parcelas);

            Console.WriteLine($"- As parcelas serão pagas em {parcelas}x de {resultado:C2}.");

            Console.Write("\nInsira o valor de renda mensal comprovada: R$ ");
            renda = Convert.ToDecimal(Console.ReadLine());

            PorCentRenda = (renda * 30) / 100;

                    if (parcelas > PorCentRenda)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Atenção!! O valor da parcela não pode exceder no máximo 30% do valor da renda.");
                        Console.ResetColor();
                        Environment.Exit(0);
                    } 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- Solicitação de empréstimo confirmada.\n");
            Console.ResetColor();

            Console.WriteLine($"Valor de empréstimo: {valor:C2}");

            Console.WriteLine($"Quantidade de parcelas: {parcelas}x.");
            
            Console.WriteLine($"Valor da(s) parcela(s): {resultado:C2}");
            
            Console.WriteLine($"Renda do solicitante: {renda:c2}");
        }
    }
}
