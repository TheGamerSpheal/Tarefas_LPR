using System;
using System.Globalization;
using System.Threading;

CultureInfo cultura = new CultureInfo("pt-BR");
Thread.CurrentThread.CurrentCulture = cultura;
Thread.CurrentThread.CurrentUICulture = cultura;

double resultado;

Console.WriteLine("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
resultado = numero%2;
if (resultado == 0){
    Console.WriteLine("Esse número é par");
}
else{
    Console.WriteLine("Esse número é ímpar");
}