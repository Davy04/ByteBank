using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

contaDoAndre.depositar(100);

Console.WriteLine("Saldo da conta pós deposito = " + contaDoAndre.saldo);

contaDoAndre.sacar(50);

if (contaDoAndre.sacar(300) == true)
{
    Console.WriteLine("saldo da conta pós saque = " + contaDoAndre.saldo);
} 
else
{
    Console.WriteLine("saldo insuficiente");
}
 
