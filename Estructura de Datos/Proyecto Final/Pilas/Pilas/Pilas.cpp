#include <iostream>

struct Nodo {
    int dato;
    Nodo* siguiente;
};

Nodo* pila;

void ClearConsole() {
    // CSI[2J clears screen, CSI[H moves the cursor to top-left corner
    std::cout << "\x1B[2J\x1B[H";
}

void Push(Nodo*& pila, int n) {
    Nodo* nuevo_nodo = new Nodo();
    nuevo_nodo->dato = n;

    if (pila) {
        nuevo_nodo->siguiente = pila;
    }

    pila = nuevo_nodo;
}

bool Pop(Nodo*& pila) {
    if (!pila) return false;

    Nodo* aux1 = pila;
    pila = pila->siguiente;
    delete aux1;
    
    return true;
}

void Cima(Nodo*& pila) {
    if (pila) {
        std::cout << pila->dato;
    }
}

void MostrarPila(Nodo*& pila) {
    Nodo* actual = pila;
    while (actual != NULL) {
        std::cout << actual->dato << " -> ";
        actual = actual->siguiente;
    }
}

int menu() {
    ClearConsole();
    int opcion;
    int element;
    std::cout << "Elige una opcion\n";
    std::cout << "\t[1] Insertar elemento (push)\n";
    std::cout << "\t[2] Eliminar elemento (pop)\n";
    std::cout << "\t[3] Mostrar pila\n";
    std::cout << "\t[5] Salir\n";
    std::cin >> opcion;

    switch (opcion)
    {
    case 1:
        std::cout << "Dame el elemento a insertar\n";
        std::cin >> element;
        Push(pila, element);
        break;
    case 2:
        if (Pop(pila)) {
            std::cout << "El primer elemento ha sido eliminado de la pila\n";
        }
        else
        {
            std::cout << "El primer elemento NO se ha podido eliminar de la pila\n";
        }

        system("pause");
        break;
    case 3:
        Cima(pila);
        std::cout << "\n\n";
        system("pause");
        break;
    case 4:
        MostrarPila(pila);
        std::cout << "\n\n";
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