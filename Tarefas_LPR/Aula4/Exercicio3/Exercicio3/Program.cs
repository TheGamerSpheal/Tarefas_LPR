using System;
using System.Globalization;
using System.Threading;

CultureInfo cultura = new CultureInfo("pt-BR");
Thread.CurrentThread.CurrentCulture = cultura;
Thread.CurrentThread.CurrentUICulture = cultura;

Console.WriteLine("Escolha uma das classes a seguir: ");
Console.WriteLine("1 - Guerreira ");
Console.WriteLine("2 - Mago ");
Console.WriteLine("3 - Arqueira ");

int classe = Convert.ToInt32(Console.ReadLine());
if (classe == 1)
{
    Console.WriteLine("Você escolheu Guerreira. Suas abilidades são: ");
    Console.WriteLine("Ataque Pesado, Defesa Total");
}
else if (classe == 2)
{
    Console.WriteLine("Você escolheu Mago. Suas abilidades são: ");
    Console.WriteLine("Bola de Fogo, Escudo de Gelo");
}
else if (classe == 3)
{
    Console.WriteLine("Você escolheu Arqueira. Suas abilidades são: ");
    Console.WriteLine("Flecha Precisa, Disparo Triplo");
}
else
{
    Console.WriteLine("Essa não é uma opção.");
}
