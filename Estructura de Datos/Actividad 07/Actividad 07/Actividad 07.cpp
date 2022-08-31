#include <iostream>

struct articulo
{
    char codigo[9];
    char producto[20];
    float precio;
};
static articulo* articulos;
static int cantArticulos = 0;

void getArts() {
    for (int i = 0; i < cantArticulos; i++) {
        articulo art = { "0000000", "DEFAULT", 0.0f };

        std::cout << "Dame el codigo del articulo " << (i + 1) << ": ";
        std::cin >> art.codigo;

        std::cout << "Dame el nombre del articulo " << (i + 1) << ": ";
        std::cin >> art.producto;

        std::cout << "Dame el precio del articulo " << (i + 1) << ": ";
        std::cin >> art.precio;

        articulos[i] = art;
    }
}

void printArt() {
    std::cout << "Codigo\tNombre\tPrecio\n";
    for (int i = 0; i < cantArticulos; i++) {
        std::cout << articulos[i].codigo << "\t" << articulos[i].producto << "\t" << articulos[i].precio << "\t" << "\n";
    }
}

void sort() {
    int pos;
    articulo aux;
    for (int i = 0; i < cantArticulos; i++) {
        pos = i;
        aux = articulos[i];

        while (pos > 0 && articulos[pos - 1].precio > aux.precio) {
            articulos[pos] = articulos[pos - 1];
            pos--;
        }
        articulos[pos] = aux;
    }
}

int main()
{
    std::cout << "Dame la cantidad de articulos: ";
    
    std::cin >> cantArticulos;
    articulos = new articulo[cantArticulos];

    getArts();
    sort();
    printArt();
}