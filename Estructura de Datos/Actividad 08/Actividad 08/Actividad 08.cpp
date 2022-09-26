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

SearchResults* buscarElemento(Nodo* lista, int n) {
    bool found = false;

    Nodo* actual = lista;
    Nodo* anterior = actual;

    while (actual != NULL && actual->dato <= n) {
        if (actual->dato == n) {
            found = true;
            break;
        }

        anterior = actual;
        actual = actual->siguiente;
    }

    SearchResults* res = new SearchResults();
    res->found = found;
    res->prev = anterior;
    res->node = actual;

    return res;
}

bool eliminarElemento(Nodo* lista, int n) {
    SearchResults* res = buscarElemento(lista, n);
    if (!res->found) return false;

    res->prev->siguiente = res->node->siguiente;
    delete res->node;
    return true;
}

int menu() {
    clearConsole();
    int opcion;
    int element;
    std::cout << "Elige una opcion\n";
    std::cout << "\t[1] Insertar elemento\n";
    std::cout << "\t[2] Mostrar lista\n";
    std::cout << "\t[3] Buscar elemento\n";
    std::cout << "\t[4] Eliminar elemento\n";
    std::cout << "\t[5] Salir\n";
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

            if (buscarElemento(lista, element)->found) {
                std::cout << "Elemento " << element << " SI ha sido encontrado en lista\n";
            }
            else
            {
                std::cout << "Elemento " << element << " NO ha sido encontrado en lista\n";
            }

            system("pause");
            break;
        case 4:
            std::cout << "Dame el elemento a eliminar\n";
            std::cin >> element;

            if (eliminarElemento(lista, element)) {
                std::cout << "Elemento " << element << " ha sido eliminado de la lista\n";
            }
            else
            {
                std::cout << "Elemento " << element << " NO se ha podido eliminar de la lista\n";
            }

            system("pause");
            break;
        case 5:
            return 5;
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
        if (opcion == 5) break;
    } while (true);
}