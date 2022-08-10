#include <iostream>

int Fibonacci(int previous, int current, int count, int max) {
    if (max == 1) {
        return 0;
    }
    else if (max == 2) {
        return 1;
    }
    else if (count == max - 1) {
        return previous;
    }

    int next = previous + current;
    return Fibonacci(current, next, count + 1, max);
}

int main()
{
    int nthTerm = 0;
    std::cout << "Dame la posición a buscar:\n";
    std::cin >> nthTerm;
    std::cout << Fibonacci(0, 1, 0, nthTerm);
}