using System;

class ProgramaMarvel {
    static void Main(string[] args) {
        menuPrincipal();
    }

    static void cadastrarHeroi(
        ref string h1Nome, ref string h1Poder, ref int h1Pts,
        ref string h2Nome, ref string h2Poder, ref int h2Pts,
        ref string h3Nome, ref string h3Poder, ref int h3Pts,
        ref string h4Nome, ref string h4Poder, ref int h4Pts,
        ref string h5Nome, ref string h5Poder, ref int h5Pts
    ) {
        Console.WriteLine("Cadastro de até 5 heróis:");

        Console.Write("Herói 1 - Nome: ");
        h1Nome = Console.ReadLine();
        Console.Write("Herói 1 - Poder: ");
        h1Poder = Console.ReadLine();
        Console.Write("Herói 1 - Pontuação: ");
        h1Pts = int.Parse(Console.ReadLine());

        Console.Write("Herói 2 - Nome: ");
        h2Nome = Console.ReadLine();
        Console.Write("Herói 2 - Poder: ");
        h2Poder = Console.ReadLine();
        Console.Write("Herói 2 - Pontuação: ");
        h2Pts = int.Parse(Console.ReadLine());

        Console.Write("Herói 3 - Nome: ");
        h3Nome = Console.ReadLine();
        Console.Write("Herói 3 - Poder: ");
        h3Poder = Console.ReadLine();
        Console.Write("Herói 3 - Pontuação: ");
        h3Pts = int.Parse(Console.ReadLine());

        Console.Write("Herói 4 - Nome: ");
        h4Nome = Console.ReadLine();
        Console.Write("Herói 4 - Poder: ");
        h4Poder = Console.ReadLine();
        Console.Write("Herói 4 - Pontuação: ");
        h4Pts = int.Parse(Console.ReadLine());

        Console.Write("Herói 5 - Nome: ");
        h5Nome = Console.ReadLine();
        Console.Write("Herói 5 - Poder: ");
        h5Poder = Console.ReadLine();
        Console.Write("Herói 5 - Pontuação: ");
        h5Pts = int.Parse(Console.ReadLine());
    }

    static void selecionarEquipe(
        string h1Nome, int h1Pts,
        string h2Nome, int h2Pts,
        string h3Nome, int h3Pts,
        string h4Nome, int h4Pts,
        string h5Nome, int h5Pts,
        out int sel1, out int sel2, out int sel3
    ) {
        Console.WriteLine("\nSelecione 3 heróis para sua equipe:");
        Console.WriteLine($"1 - {h1Nome} ({h1Pts} pts)");
        Console.WriteLine($"2 - {h2Nome} ({h2Pts} pts)");
        Console.WriteLine($"3 - {h3Nome} ({h3Pts} pts)");
        Console.WriteLine($"4 - {h4Nome} ({h4Pts} pts)");
        Console.WriteLine($"5 - {h5Nome} ({h5Pts} pts)");

        Console.Write("Escolha o 1º herói (1 a 5): ");
        sel1 = int.Parse(Console.ReadLine());
        Console.Write("Escolha o 2º herói (1 a 5): ");
        sel2 = int.Parse(Console.ReadLine());
        Console.Write("Escolha o 3º herói (1 a 5): ");
        sel3 = int.Parse(Console.ReadLine());
    }

    static int calcularPontuacaoTotal(
        int sel1, int sel2, int sel3,
        int h1Pts, int h2Pts, int h3Pts, int h4Pts, int h5Pts
    ) {
        int total = 0;
        total += (sel1 == 1) ? h1Pts : (sel1 == 2) ? h2Pts : (sel1 == 3) ? h3Pts : (sel1 == 4) ? h4Pts : h5Pts;
        total += (sel2 == 1) ? h1Pts : (sel2 == 2) ? h2Pts : (sel2 == 3) ? h3Pts : (sel2 == 4) ? h4Pts : h5Pts;
        total += (sel3 == 1) ? h1Pts : (sel3 == 2) ? h2Pts : (sel3 == 3) ? h3Pts : (sel3 == 4) ? h4Pts : h5Pts;
        return total;
    }

    static void exibirEquipe(
        int sel1, int sel2, int sel3,
        string h1Nome, string h1Poder, int h1Pts,
        string h2Nome, string h2Poder, int h2Pts,
        string h3Nome, string h3Poder, int h3Pts,
        string h4Nome, string h4Poder, int h4Pts,
        string h5Nome, string h5Poder, int h5Pts,
        int totalPts
    ) {
        Console.WriteLine("\n--- Sua Equipe ---");

        void mostrar(int sel) {
            switch (sel) {
                case 1: Console.WriteLine($"{h1Nome} - Poder: {h1Poder} - Pontos: {h1Pts}"); break;
                case 2: Console.WriteLine($"{h2Nome} - Poder: {h2Poder} - Pontos: {h2Pts}"); break;
                case 3: Console.WriteLine($"{h3Nome} - Poder: {h3Poder} - Pontos: {h3Pts}"); break;
                case 4: Console.WriteLine($"{h4Nome} - Poder: {h4Poder} - Pontos: {h4Pts}"); break;
                case 5: Console.WriteLine($"{h5Nome} - Poder: {h5Poder} - Pontos: {h5Pts}"); break;
            }
        }

        mostrar(sel1);
        mostrar(sel2);
        mostrar(sel3);
        Console.WriteLine($"Pontuação total da equipe: {totalPts}\n");
    }

    static void menuPrincipal() {
        string h1Nome = "", h2Nome = "", h3Nome = "", h4Nome = "", h5Nome = "";
        string h1Poder = "", h2Poder = "", h3Poder = "", h4Poder = "", h5Poder = "";
        int h1Pts = 0, h2Pts = 0, h3Pts = 0, h4Pts = 0, h5Pts = 0;

        int sel1 = 0, sel2 = 0, sel3 = 0;
        int totalPts = 0;

        bool executando = true;

        while (executando) {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Cadastrar Heróis");
            Console.WriteLine("2. Selecionar Equipe");
            Console.WriteLine("3. Exibir Equipe");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    cadastrarHeroi(
                        ref h1Nome, ref h1Poder, ref h1Pts,
                        ref h2Nome, ref h2Poder, ref h2Pts,
                        ref h3Nome, ref h3Poder, ref h3Pts,
                        ref h4Nome, ref h4Poder, ref h4Pts,
                        ref h5Nome, ref h5Poder, ref h5Pts
                    );
                    break;

                case "2":
                    selecionarEquipe(
                        h1Nome, h1Pts, h2Nome, h2Pts, h3Nome, h3Pts,
                        h4Nome, h4Pts, h5Nome, h5Pts,
                        out sel1, out sel2, out sel3
                    );
                    totalPts = calcularPontuacaoTotal(
                        sel1, sel2, sel3,
                        h1Pts, h2Pts, h3Pts, h4Pts, h5Pts
                    );
                    break;

                case "3":
                    exibirEquipe(
                        sel1, sel2, sel3,
                        h1Nome, h1Poder, h1Pts,
                        h2Nome, h2Poder, h2Pts,
                        h3Nome, h3Poder, h3Pts,
                        h4Nome, h4Poder, h4Pts,
                        h5Nome, h5Poder, h5Pts,
                        totalPts
                    );
                    break;

                case "0":
                    executando = false;
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}