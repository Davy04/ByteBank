using bytebank.titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.contas
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public double saldo = 100;

        public Cliente titular;

        public void depositar(double valor)
        {
            saldo += valor;

        }
        public bool sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                sacar(valor);
                destino.depositar(valor);
                return true;
            }
        }

        public void mostrar()
        {
            Console.WriteLine("titular: " + titular);
            Console.WriteLine("conta: " + conta);
            Console.WriteLine("número agencia: " + numero_agencia);
            Console.WriteLine("saldo: " + saldo);
        }
    }
}
