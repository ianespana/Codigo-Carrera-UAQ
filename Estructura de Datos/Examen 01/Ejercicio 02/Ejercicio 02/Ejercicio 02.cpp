#include <iostream>

static char* characters;
static int charCount = 0;

void getChars() {
    for (int i = 0; i < charCount; i++) {
        char character;

        std::cout << "Dame el caracter " << (i + 1) << ": ";
        std::cin >> character;

        characters[i] = character;
    }
}

void sort() {
    int pos;
    char aux;
    for (int i = 0; i < charCount; i++) {
        pos = i;
        aux = characters[i];

        while (pos > 0 && int(characters[pos - 1]) > int(aux)) {
            characters[pos] = characters[pos - 1];
            pos--;
        }
        characters[pos] = aux;
    }
}

void printChars() {
    std::cout << "Orden Ascendente: ";
    for (int i = 0; i < charCount; i++) {
        std::cout << characters[i] << " ";
    }

    std::cout << "Orden Descendente: ";
    for (int i = charCount - 1; i >= 0; i--) {
        std::cout << characters[i] << " ";
    }
}

int main()
{
    std::cout << "Dame la cantidad de letras: ";

    std::cin >> charCount;
    characters = new char[charCount];

    getChars();
    sort();
    printChars();
}