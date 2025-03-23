using System;
using System.Globalization;
using System.Threading;

CultureInfo cultura = new CultureInfo("pt-BR");
Thread.CurrentThread.CurrentCulture = cultura;
Thread.CurrentThread.CurrentUICulture = cultura;

Console.Write("Digite o número de horas de treinamento por dia: ");
int horasPorDia = Convert.ToInt32(Console.ReadLine());

int diasPorSemana = 5;
int horasPorSemana = horasPorDia * diasPorSemana;
int totalHoras = 1000;

int totalDias = (totalHoras + horasPorDia - 1) / horasPorDia;
int totalSemanas = (totalHoras + horasPorSemana - 1) / horasPorSemana;
double totalMeses = totalSemanas / 4.5;

Console.WriteLine($"Total de horas por semana: {horasPorSemana}");
Console.WriteLine($"Serão necessários:");
Console.WriteLine($"{totalDias} dias");
Console.WriteLine($"{totalSemanas} semanas");
Console.WriteLine($"{totalMeses:F1} meses");