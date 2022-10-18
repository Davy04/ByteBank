using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public double saldo = 100;

        public string titular;

        public void depositar(double valor)
        {
            this.saldo += valor;

        }
        public bool sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            } 
            else
            {
                return false;
            }
        }

        public bool transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.sacar(valor);
                destino.depositar(valor);
                return true;
            }
        }

        public void mostrar()
        {
            Console.WriteLine("titular: "+ titular);
            Console.WriteLine("conta: "+ conta);
            Console.WriteLine("número agencia: "+ numero_agencia);
            Console.WriteLine("saldo: "+ saldo);
        }
    }
}
