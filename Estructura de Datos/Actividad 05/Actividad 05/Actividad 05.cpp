#include <iostream>

int main()
{
    int nums[] = { 7, 6, 2, 4, 5 };
    int aux, min;

    for (int i = 0; i < 5; i++) {
        min = i;
        for (int j = i + 1; j < 5; j++) {
            if (nums[j] < nums[min]) {
                min = j;
            }
        }

        aux = nums[i];
        nums[i] = nums[min];
        nums[min] = aux;
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