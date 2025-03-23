using System;
using System.Globalization;
using System.Threading;

CultureInfo cultura = new CultureInfo("pt-BR");
Thread.CurrentThread.CurrentCulture = cultura;
Thread.CurrentThread.CurrentUICulture = cultura;

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int quadrado = numero * numero;
int somaDigitos = 0;

while (quadrado > 0)
{
    somaDigitos += quadrado % 10;
    quadrado /= 10;
}

Console.WriteLine($"A soma dos dígitos do quadrado é: {somaDigitos}");