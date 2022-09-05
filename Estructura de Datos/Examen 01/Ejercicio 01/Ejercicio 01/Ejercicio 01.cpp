#include <iostream>

int main()
{
    int num;
    std::cout << "Dame un numero: ";
    std::cin >> num;

    if (num % 2 == 0) {
        std::cout << "\nEs un numero par.";
    } else {
        std::cout << "\nEs un numero impar.";
    }
}