#include <iostream>

int main()
{
    int nums[] = {7, 6, 2, 4, 5};
    int aux;

    for (int i = 0; i < 5; i++) {
        for (int j = 0; j < 4; j++) {
            if (nums[j] > nums[j + 1]) {
                aux = nums[j];
                nums[j] = nums[j + 1];
                nums[j + 1] = aux;
            }
        }
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