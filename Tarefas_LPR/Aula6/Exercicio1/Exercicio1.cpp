#include <iostream>
#include <limits>
#include <cmath>

using namespace std;

int inverterNumero(int numero) {
    int reverso = 0;
    int sinal = numero < 0 ? -1 : 1;
    numero = abs(numero);

    while (numero != 0) {
        int digito = numero % 10;

        // Verificação preventiva contra transbordo aritmético
        if (reverso > (numeric_limits<int>::max() - digito) / 10) {
            cerr << "Erro: estouro de capacidade ao inverter o número." << endl;
            return 0;
        }

        reverso = reverso * 10 + digito;
        numero /= 10;
    }

    return reverso * sinal;
}

int main() {
    int numero;
    cout << "Digite um número inteiro: ";
    cin >> numero;

    int resultado = inverterNumero(numero);
    cout << "Reverso: " << resultado << endl;

    return 0;
}