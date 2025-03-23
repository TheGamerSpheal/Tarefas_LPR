#include <iostream>

using namespace std;

int main() {
    int quantidade, numero, soma_pares = 0, contador_pares = 0, contador = 0;
    
    cout << "Digite a quantidade de números: ";
    cin >> quantidade;
    
    while (contador < quantidade) {
        cout << "Digite o " << (contador + 1) << "º número: ";
        cin >> numero;
        
        if (numero % 2 == 0) {
            soma_pares += numero;
            contador_pares++;
        }
        contador++;
    }
    
    if (contador_pares > 0) {
        double media = soma_pares/contador_pares;
        cout << "A média dos números pares é: " << media << endl;
    } else {
        cout << "Nenhum número par foi digitado." << endl;
    }
    
    return 0;
}