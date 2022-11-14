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

void insertarElemento(Nodo*& lista, int n) {
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

Nodo* eliminarPrimerElemento(Nodo* lista) {
    if (!lista) return lista;

    Nodo* aux = lista;
    lista = lista->siguiente;
    delete aux;
    return lista;
}

Nodo* eliminarUltimoElemento(Nodo* lista) {
    Nodo* aux = lista;
    Nodo* anterior = lista;
    while (aux->siguiente)
    {
        anterior = aux;
        aux = aux->siguiente;
    }
    anterior->siguiente = NULL;
    delete aux;
    return lista;
}

Nodo* eliminarElementos(Nodo* lista) {
    while (lista)
    {
        lista = eliminarPrimerElemento(lista);
    }

    return lista;
}

int menu() {
    clearConsole();
    int opcion;
    int element;
    std::cout << "Elige una opcion\n";
    std::cout << "\t[1] Insertar elemento\n";
    std::cout << "\t[2] Mostrar elementos\n";
    std::cout << "\t[3] Eliminar primer elemento\n";
    std::cout << "\t[4] Eliminar ultimo elemento\n";
    std::cout << "\t[5] Eliminar todos los elementos\n";
    std::cout << "\t[6] Salir\n";
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
        lista = eliminarPrimerElemento(lista);
        std::cout << "Primer elemento eliminado\n";
        system("pause");
        break;
    case 4:
        lista = eliminarUltimoElemento(lista);
        std::cout << "Ultimo elemento eliminado\n";
        system("pause");
        break;
    case 5:
        lista = eliminarElementos(lista);
        std::cout << "Todos los elementos eliminados\n";
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