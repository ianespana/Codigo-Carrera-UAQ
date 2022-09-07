#include <iostream>

void recursive(bool par, int num, int contador) {
    if (contador < num) {
        recursive(!par, num, contador + 1);
    }
    else if (par) {
        std::cout << "\nEs un numero par.";
    }
    else {
        std::cout << "\nEs un numero impar.";
    }
}

int main()
{
    int num;
    std::cout << "Dame un numero: ";
    std::cin >> num;
    recursive(true, num, 0);
}