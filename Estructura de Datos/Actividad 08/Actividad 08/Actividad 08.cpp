#include <iostream>

struct Nodo {
    int dato;
    Nodo* siguiente;
};

Nodo* lista;

void clearConsole() {
    // CSI[2J clears screen, CSI[H moves the cursor to top-left corner
    std::cout << "\x1B[2J\x1B[H";
}

void insertarElemento(Nodo* &lista, int n) {
    Nodo* nuevo_nodo = new Nodo();
    nuevo_nodo->dato = n;

    Nodo* aux1 = lista;
    Nodo* aux2 = NULL;

    while (aux1 != NULL && aux1->dato < n) {
        aux2 = aux1;
        aux1 = aux1->siguiente;
    }

    if (lista == aux1) {
        lista = nuevo_nodo;
    }
    else if (aux2 != NULL) {
        aux2->siguiente = nuevo_nodo;
    }

    nuevo_nodo->siguiente = aux1;
}

void mostrarLista(Nodo* lista) {
    Nodo* actual = lista;
    while (actual != NULL) {
        std::cout << actual->dato << " -> ";
        actual = actual->siguiente;
    }
}

void buscarElemento(Nodo* lista, int n) {
    bool found = false;

    Nodo* actual = lista;

    while (actual != NULL && actual->dato <= n) {
        if (actual->dato == n) {
            found = true;
        }

        actual = actual->siguiente;
    }

    if (found) {
        std::cout << "Elemento " << n << " SI ha sido encontrado en lista\n";
    }
    else
    {
        std::cout << "Elemento " << n << " NO ha sido encontrado en lista\n";
    }
}

int menu() {
    clearConsole();
    int opcion;
    int element;
    std::cout << "Elige una opcion\n";
    std::cout << "\t[1] Insertar elemento\n";
    std::cout << "\t[2] Mostrar lista\n";
    std::cout << "\t[3] Buscar elemento\n";
    std::cin >> opcion;

    switch (opcion)
    {
        case 1:
            std::cout << "Dame el elemento a insertar\n";
            std::cin >> element;
            insertarElemento(lista, element);
            break;
        case 2:
            mostrarLista(lista);
            std::cout << "\n\n";
            system("pause");
            break;
        case 3:
            std::cout << "Dame el elemento a buscar\n";
            std::cin >> element;
            buscarElemento(lista, element);
            system("pause");
            break;
        default:
            return 0;
    }

    return opcion;
}

int main()
{
    do
    {
        int opcion = menu();
        if (opcion == 0) break;
    } while (true);
}