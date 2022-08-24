#include <iostream>

int main()
{
    int nums[] = { 7, 6, 2, 4, 5 };
    int aux, pos;

    for (int i = 0; i < 5; i++) {
        pos = i;
        aux = nums[i];

        while (pos > 0 && nums[pos - 1] > aux) {
            nums[pos] = nums[pos - 1];
            pos--;
        }
        nums[pos] = aux;
    }

    std::cout << "Orden Ascendente: ";
    for (int i = 0; i < 5; i++) {
        std::cout << nums[i] << " ";
    }

    std::cout << "Orden Descendente: ";
    for (int i = 4; i >= 0; i--) {
        std::cout << nums[i] << " ";
    }
}
