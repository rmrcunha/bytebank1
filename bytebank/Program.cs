using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia =  15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da conta do André = "+contaDoAndre.saldo);
//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria =" + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo do André =" + contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria =" + contaDoAndre.saldo);

Cliente cliente = new Cliente();
cliente.Nome = "André Silva";
cliente.Cpf = "1234567890";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente(15, "1010-X");
conta.SetSaldo(100);
