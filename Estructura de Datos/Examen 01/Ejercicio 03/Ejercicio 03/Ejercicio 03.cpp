#include <iostream>

struct student
{
    char name[50];
    float grade;
};
static student* students;
static int studentCount = 0;

void getStudents() {
    for (int i = 0; i < studentCount; i++) {
        student stdnt = { "0000000", 0.0f };

        std::cout << "Dame el nombre del estudiante " << (i + 1) << ": ";
        std::cin >> stdnt.name;

        std::cout << "Dame el promedio " << (i + 1) << ": ";
        std::cin >> stdnt.grade;

        students[i] = stdnt;
    }
}

void sort() {
    int pos;
    student aux;
    for (int i = 0; i < studentCount; i++) {
        pos = i;
        aux = students[i];

        while (pos > 0 && students[pos - 1].grade < aux.grade) {
            students[pos] = students[pos - 1];
            pos--;
        }
        students[pos] = aux;
    }
}

void printStudents() {
    std::cout << "Nombre\tPromedio\n";
    for (int i = 0; i < (studentCount / 3); i++) {
        std::cout << students[i].name << "\t" << students[i].grade << "\n";
    }
}

int main()
{
    std::cout << "Dame la cantidad de alumnos: ";

    std::cin >> studentCount;
    students = new student[studentCount];

    getStudents();
    sort();
    printStudents();
}