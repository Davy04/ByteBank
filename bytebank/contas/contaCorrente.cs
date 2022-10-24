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
        public static int totalDeContas { get; private set; }
        private int numero_agencia;
         
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
           private set { 
                    if(value > 0)
                    {
                        this.numero_agencia = value; 
                    }
                }
        }

       
        public string Conta { get; set; }

        private double saldo = 100;

        public Cliente Titular { get; set; }

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

        public void SetSaldo(double valor)
        {
            if(valor < 0 )
            {
                return;
            } 
            else
            {
                this.saldo = valor;
            }
        } 
        
        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            totalDeContas++;
        }


    }
}
