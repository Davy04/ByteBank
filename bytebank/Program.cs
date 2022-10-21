using bytebank.contas;
using bytebank.titular;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "maria souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da maria = " + contaDaMaria.saldo);

//contaDoAndre.transferir(50, contaDaMaria);

//Console.WriteLine("saldo do andré = " + contaDoAndre.saldo);
//Console.WriteLine("saldo da maria = " + contaDaMaria.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//contaDoPedro.numero_agencia = 17;
//contaDoPedro.conta = "1010-5";
//contaDoPedro.saldo = 350;

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-x";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("titular : " + conta.titular.nome);
//Console.WriteLine("CPF: "+ conta.titular.cpf);
//Console.WriteLine("Profissão: "+ conta.titular.profissao);
//Console.WriteLine("N° conta: "+ conta.conta);
//Console.WriteLine("Saldo: "+ conta.saldo);
//Console.WriteLine("N° agência: "+ conta.numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "josé Souza";
//conta2.titular.profissao = "tester";
//conta2.titular.cpf = "987654321";
//conta2.conta = "9999-x";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine("titular: " + conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.SetSaldo(200);
//conta3.Numero_agencia = 18;
//conta3.Conta = "1011-H";
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);

ContaCorrente conta4 = new ContaCorrente();
conta4.SetSaldo(500);
conta4.Numero_agencia = 18;
conta4.Titular = new Cliente();

Console.WriteLine(conta4.GetSaldo());
Console.WriteLine(conta4.Numero_agencia);