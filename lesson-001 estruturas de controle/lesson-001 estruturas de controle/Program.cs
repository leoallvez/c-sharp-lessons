using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_001_estruturas_de_controle
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 200.00;
            double valorSaque = 100.00;

            if(saldo >= valorSaque)
            {
                Console.Write("Saque realizado com sucesso");
                Console.ReadLine();
            } else
            {
                Console.Write("Saldo insuficiente");
                Console.ReadLine();
            }
        }
    }
}
