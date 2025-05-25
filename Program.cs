using POO;
////------------------------------------------------------------------------------------------------------------------------
////Exemplo 1 - Carro.cs

// Carro meuCarro = new Carro();
// meuCarro.Cor = "Vermelho";
// meuCarro.Modelo = "VW";
// meuCarro.Acelerar();

////------------------------------------------------------------------------------------------------------------------------
////Exemplo 2 - Animais.cs

// Animal meuCachorro = new Cachorro();
// meuCachorro.FazerSom();

// Animal meuGato = new Gato();
// meuGato.FazerSom();

////------------------------------------------------------------------------------------------------------------------------
////Exemplo 3 - Funcionario.cs

// Gerente meuGerente = new Gerente();
// meuGerente.Nome = "Carlos";
// meuGerente.Salario = 3000;
// meuGerente.Setor = "TI";
// Console.WriteLine($"Nome: {meuGerente.Nome}, Salario: {meuGerente.Salario}, Sertor: {meuGerente.Setor}");

////------------------------------------------------------------------------------------------------------------------------
////Exemplo 4 - ContaBancaria.cs

ContaBancaria conta = new ContaBancaria();
conta.Depositar(1000);
Console.WriteLine($"O saldo da conta é: {conta.ObterSaldo()}");
conta.Sacar(500);
Console.WriteLine($"O saldo da conta é: {conta.ObterSaldo()}");