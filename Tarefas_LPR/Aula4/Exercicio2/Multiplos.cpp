#include <iostream>
#include <iomanip>

using namespace std;
int main(){
    int num1, num2;
    cout << "Insira o primeiro numero: " << endl;
    cin >> num1;
    cout << "Insira o segundo numero: " << endl;
    cin >> num2;
    if(num1%num2 == 0 || num2%num1 == 0){
        cout << "Os numeros sao multiplos" << endl;
    }
    else{
        cout << "Os numeros nao sao multiplos" << endl;
    }
}