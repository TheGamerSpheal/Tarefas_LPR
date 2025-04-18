#include <iostream>
#include <limits>

using namespace std;

void calcularMediaPares(int quantidade) {
    int numero, soma_pares = 0, contador_pares = 0;

    for (int i = 0; i < quantidade; i++) {
        cout << "Digite o " << (i + 1) << "º número: ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma_pares += numero;
            contador_pares++;
        }
    }

    if (contador_pares > 0) {
        double media = static_cast<double>(soma_pares) / contador_pares;
        cout << "A média dos números pares é: " << media << endl;
    } else {
        cout << "Nenhum número par foi digitado." << endl;
    }
}

void somarImparesMultiplosDeTres(int inicio = 50, int fim = 500) {
    int soma = 0;

    for (int i = inicio; i <= fim; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }

    cout << "A soma dos números ímpares múltiplos de 3 entre " << inicio << " e " << fim << " é: " << soma << endl;
}

void somaDigitosDoQuadrado(int numero) {
    int quadrado = numero * numero;
    int soma_digitos = 0;

    while (quadrado > 0) {
        soma_digitos += quadrado % 10;
        quadrado /= 10;
    }

    cout << "A soma dos dígitos do quadrado é: " << soma_digitos << endl;
}

int main() {
    int escolha;

    do {
        cout << "1 - Calcular média dos números pares" << endl;
        cout << "2 - Somar ímpares múltiplos de 3 entre 50 e 500" << endl;
        cout << "3 - Somar dígitos do quadrado de um número" << endl;
        cout << "0 - Sair" << endl;
        cout << "Escolha uma opção: ";
        cin >> escolha;

        switch (escolha) {
            case 1: {
                int quantidade;
                cout << "Digite a quantidade de números: ";
                cin >> quantidade;
                calcularMediaPares(quantidade);
                break;
            }
            case 2:
                somarImparesMultiplosDeTres();
                break;
            case 3: {
                int numero;
                cout << "Digite um número: ";
                cin >> numero;
                somaDigitosDoQuadrado(numero);
                break;
            }
            case 0:
                cout << "Encerrando o programa." << endl;
                break;
            default:
                cout << "Opção inválida. Tente novamente." << endl;
        }

    } while (escolha != 0);

    return 0;
}