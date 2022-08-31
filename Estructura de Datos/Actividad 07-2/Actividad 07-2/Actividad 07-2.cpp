#include <iostream>

int main()
{
    int nums[] = { 8, 9, 10, 10, 10, 10, 8, 9 };
    int aux, pos;

    for (int i = 0; i < 8; i++) {
        pos = i;
        aux = nums[i];

        while (pos > 0 && nums[pos - 1] > aux) {
            nums[pos] = nums[pos - 1];
            pos--;
        }
        nums[pos] = aux;
    }

    std::cout << "Orden Ascendente: ";
    for (int i = 0; i < 8; i++) {
        std::cout << nums[i] << " ";
    }
    std::cout << "\n";

    std::cout << "Orden Descendente: ";
    for (int i = 7; i >= 0; i--) {
        std::cout << nums[i] << " ";
    }
}