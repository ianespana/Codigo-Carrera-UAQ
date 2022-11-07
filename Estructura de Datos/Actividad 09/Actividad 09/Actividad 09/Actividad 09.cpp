#include <iostream>

struct Nodo {
    int index;
    char nombre[30];
    char apellido[50];
    int edad;
    char enfermedad[30];
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
    nuevo_nodo->index = n;

    Nodo* aux1 = lista;
    Nodo* aux2 = NULL;

    while (aux1 != NULL && aux1->index < n) {
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

    std::cout << "Dame el nombre del paciente\n";
    std::cin >> nuevo_nodo->nombre;

    std::cout << "Dame el apellido del paciente\n";
    std::cin >> nuevo_nodo->apellido;

    std::cout << "Dame la edad del paciente\n";
    std::cin >> nuevo_nodo->edad;

    std::cout << "Dame la enfermedad del paciente\n";
    std::cin >> nuevo_nodo->enfermedad;
}

void mostrarLista(Nodo* lista) {
    Nodo* actual = lista;
    while (actual != NULL) {
        std::cout << actual->index << " -> ";
        actual = actual->siguiente;
    }
}

SearchResults* buscarElemento(Nodo* lista, int n) {
    bool found = false;

    Nodo* actual = lista;
    Nodo* anterior = actual;

    while (actual != NULL && actual->index <= n) {
        if (actual->index == n) {
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
    SearchResults* results;
    std::cout << "Elige una opcion\n";
    std::cout << "\t[1] Insertar paciente\n";
    std::cout << "\t[2] Mostrar lista\n";
    std::cout << "\t[3] Buscar paciente\n";
    std::cout << "\t[4] Eliminar paciente\n";
    std::cout << "\t[5] Salir\n";
    std::cin >> opcion;

    switch (opcion)
    {
    case 1:
        std::cout << "Dame el expediente del paciente a insertar\n";
        std::cin >> element;
        insertarElemento(lista, element);
        break;
    case 2:
        mostrarLista(lista);
        std::cout << "\n\n";
        system("pause");
        break;
    case 3:
        std::cout << "Dame el expediente a buscar\n";
        std::cin >> element;
        results = buscarElemento(lista, element);

        if (results->found) {
            std::cout << "\nExpediente: " << results->node->index << "\n";
            std::cout << "Nombre: " << results->node->nombre << "\n";
            std::cout << "Apellido: " << results->node->apellido << "\n";
            std::cout << "Edad: " << results->node->edad << "\n";
            std::cout << "Enfermedad: " << results->node->enfermedad << "\n";
        }
        else
        {
            std::cout << "El expediente " << element << " NO ha sido encontrado en lista\n";
        }

        system("pause");
        break;
    case 4:
        std::cout << "Dame el expediente a eliminar\n";
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