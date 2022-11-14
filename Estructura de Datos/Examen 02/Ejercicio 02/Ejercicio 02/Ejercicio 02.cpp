#include <iostream>

struct Nodo {
    int dato;
    Nodo* siguiente;
};

struct SearchResults {
    bool found;
    Nodo* prev;
    Nodo* node;
};

Nodo* lista;

void clearConsole() {
    // CSI[2J clears screen, CSI[H moves the cursor to top-left corner
    std::cout << "\x1B[2J\x1B[H";
}

void insertarElemento(Nodo*& lista, int n, int pos) {
    Nodo* nuevo_nodo = new Nodo();
    nuevo_nodo->dato = n;

    Nodo* aux1 = lista;
    Nodo* aux2 = NULL;
    int contador = 0;

    while (aux1 != NULL && contador != pos) {
        aux2 = aux1;
        aux1 = aux1->siguiente;
        contador++;
    }

    if (lista == aux1) {
        lista = nuevo_nodo;
    }
    else if (aux2 != NULL) {
        aux2->siguiente = nuevo_nodo;
    }

    nuevo_nodo->siguiente = aux1;
}

void insertarElementoInicio(Nodo*& lista, int n) {
    insertarElemento(lista, n, 0);
}

void insertarElementoFinal(Nodo*& lista, int n) {
    int contador = 0;
    Nodo* aux = lista;
    while (aux->siguiente) {
        aux = aux->siguiente;
        contador++;
    }
    insertarElemento(lista, n, contador + 1);
}

void sumarLista(Nodo* lista) {
    Nodo* actual = lista;
    int suma = 0;
    while (actual != NULL) {
        suma += actual->dato;
        actual = actual->siguiente;
    }
    std::cout << "Total: " << suma;
}

void mostrarLista(Nodo* lista) {
    Nodo* actual = lista;
    while (actual != NULL) {
        std::cout << actual->dato << " -> ";
        actual = actual->siguiente;
    }
}

int menu() {
    clearConsole();
    int opcion;
    int element;
    int pos;
    std::cout << "Elige una opcion\n";
    std::cout << "\t[1] Insertar elemento en posicion\n";
    std::cout << "\t[2] Insertar elemento al inicio\n";
    std::cout << "\t[3] Insertar elemento al final\n";
    std::cout << "\t[4] Calcular suma\n";
    std::cout << "\t[5] Mostrar elementos\n";
    std::cout << "\t[6] Salir\n";
    std::cin >> opcion;

    switch (opcion)
    {
    case 1:
        std::cout << "Dame el elemento a insertar\n";
        std::cin >> element;
        std::cout << "Dame la posicion del elemento\n";
        std::cin >> pos;
        insertarElemento(lista, element, pos);
        break;
    case 2:
        std::cout << "Dame el elemento a insertar\n";
        std::cin >> element;
        insertarElementoInicio(lista, element);
        break;
    case 3:
        std::cout << "Dame el elemento a insertar\n";
        std::cin >> element;
        insertarElementoFinal(lista, element);
        break;
    case 4:
        sumarLista(lista);
        std::cout << "\n\n";
        system("pause");
        break;
    case 5:
        mostrarLista(lista);
        std::cout << "\n\n";
        system("pause");
        break;
    case 6:
        return 6;
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
        if (opcion == 6) break;
    } while (true);
}