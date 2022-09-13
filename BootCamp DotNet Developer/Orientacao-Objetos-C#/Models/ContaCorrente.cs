using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_Objetos_C_.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int nummeroConta, decimal saldoInicial)
        {
            NumeroConta = nummeroConta;
            Saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal Saldo;

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o dalso disponivel");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponivel é: " + Saldo);
        }
    }
}