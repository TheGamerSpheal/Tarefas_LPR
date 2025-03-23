using System;
using System.Globalization;
using System.Threading;

CultureInfo cultura = new CultureInfo("pt-BR");
Thread.CurrentThread.CurrentCulture = cultura;
Thread.CurrentThread.CurrentUICulture = cultura;

Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1, 100);

Console.WriteLine("Um número de 1 a 100 foi gerado, tente acertá-lo");
int tentativas = 1;

do
{
    int chute = Convert.ToInt32(Console.ReadLine());
    if (chute == valorInteiro)
    {
        Console.WriteLine("Você acertou o número gerado");
        Console.WriteLine($"O número de tentativas foi: {tentativas}");
        break;
    }
    else
    {
        while (chute != valorInteiro)
        {
            if (chute > valorInteiro)
            {
                Console.WriteLine("O número que você chutou é maior que o número gerado, tente novamente: ");
                tentativas++;
                break;
            }
            else if (chute < valorInteiro)
            {
                Console.WriteLine("O número que você chutou é menor que o número gerado, tente novamente: ");
                tentativas++;
                break;
            }
        }
    }
} while (true);