using bytebank.Contas;
using bytebank.Titular;


Cliente cliente = new Cliente();
cliente.Nome = "André Silva";
cliente.Cpf = "1234567890";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente(15, "1010-X");
conta.SetSaldo(100);
