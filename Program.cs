﻿Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

Console.WriteLine("Saldo da Conta 1");

c1.Depositar(1000.00);
c1.Sacar(200.00);


Console.WriteLine(c1.Saldo);

Console.WriteLine("Saldo da Conta 2");
c2.Depositar(200.00);
c2.Sacar(150.00);

Console.WriteLine(c2.Saldo);

Console.WriteLine("Transferir");
c1.Transferir(200.00, c2);
Console.WriteLine("Saldo da Conta 1");

Console.WriteLine(c1.Saldo);
Console.WriteLine("Saldo da Conta 2");

Console.WriteLine(c2.Saldo);
