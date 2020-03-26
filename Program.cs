using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Double valorhora=0,utilizacao=0,total=0;
	    char cartao;

        Console.WriteLine("Qual o valor hora? (valores em Euros)");
	    valorhora = Convert.ToDouble(Console.ReadLine());
	    Console.WriteLine("Qual a utilização? (valores em horas)");
	    utilizacao = Convert.ToDouble(Console.ReadLine());
	    Console.WriteLine("O cliente possui cartão de cliente? ('S' ou 's' para 'Sim' e 'N' ou 'n' para 'Não'");
	    cartao = Convert.ToChar(Console.ReadLine());

        if (cartao == 'S' || cartao == 's') {
		    total = ((valorhora * utilizacao) - ((valorhora * utilizacao) * 0.1));
	    }
	    if (cartao == 'N' || cartao=='n') {
		    total = (valorhora * utilizacao);
	    }

        Console.Write("Valor a pagar >>> {0} Euros.",total);
	    Console.ReadLine();

        }
    }
}
