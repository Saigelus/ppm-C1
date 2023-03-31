#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>

//Inlusión de las librerías que contienen las funciones que se utilizarán para el programa.

//Definición de nodo.
typedef struct alumno{
    char nombre[50];
    char apellido[50];
    char fecha_nacimiento[12];
    char hora_fin[10];
    struct alumno* proximo;
} Alumno;


Alumno* primer_alumno = NULL; //Inicialización de primer puntero estando vacío, lo que indica que la lista está vacía.

//Opción para crear nuevo nodo.
void nuevo_alumno()
{
    Alumno* nuevo = (Alumno*) malloc(sizeof(Alumno));

    printf("Ingrese el nombre del alumno: ");
    scanf("%s", nuevo->nombre);

    printf("Ingrese el apellido del alumno: ");
    scanf("%s", nuevo->apellido);

    printf("Ingrese la fecha de nacimiento (formato dd/mm/aaaa): ");
    scanf("%s", nuevo->fecha_nacimiento);

    printf("Ingrese la hora de fin de la clase (formato hh:mm:ss): ");
    scanf("%s", nuevo->hora_fin);

    nuevo->proximo = primer_alumno;
    primer_alumno = nuevo;

    printf("Alumno agregado exitosamente\n");
}

//Función para eliminar nodo existente.
void borrar_alumno()
{
    char nombre[50];
    char apellido[50];

    printf("Introduzca el nombre del alumno que desea borrar: ");
    scanf("%s", nombre);

    printf("Introduzca el apellido del alumno que desea borrar: ");
    scanf("%s", apellido);

    Alumno* actual = primer_alumno;
    Alumno* anterior = NULL;

    while (actual != NULL)
        {
        if (strcmp(actual->nombre, nombre) == 0 && strcmp(actual->apellido, apellido) == 0)
        {
            if (anterior == NULL)
            {
                primer_alumno = actual->proximo;
            } else
            {
                anterior->proximo = actual->proximo;
            }
            free(actual);
            printf("Alumno borrado exitosamente\n");
            return;
        }
        anterior = actual;
        actual = actual->proximo;
    }
    printf("No se encontro al alumno\n");
}

//Función principal
int main()
{
int opcion;
    do {
        //Impresión de menú.
        printf("    ***MENU***\n");
        printf("Ingrese una opcion:\n\n");
        printf("0. Salir\n");
        printf("1. Nuevo alumno\n");
        printf("2. Borrar alumno\n");
        printf("3. Buscar alumno\n");
        printf("4. Guardar alumno\n");
        printf("5. Leer alumno\n");
        scanf("%d", &opcion);

        //Selección de casos.
        switch (opcion)
        {
            case 0:
                printf("Saliendo del programa...\n");
                break;

            case 1:
                nuevo_alumno();
                break;

            case 2:
                borrar_alumno();
                break;

            case 3:
                buscar_alumno();
                break;

            case 4:
                guardar_alumnos();
                break;

            case 5:
                printf("Opcion aun no implementada, seleccione otra vez\n\n" );
                break;

            default:
                printf("Opcion invalida, seleccione otra vez\n\n");
        }
    } while (opcion != 0);
    return 0;
}

//Función para búsqueda de alumnos.
void buscar_alumno()
{
    char nombre[50];
    char apellido[50];

    printf("Ingrese el nombre del alumno que desea buscar: ");
    scanf("%s", nombre);

    printf("Ingrese el apellido del alumno que desea buscar: ");
    scanf("%s", apellido);

    Alumno* actual = primer_alumno;

while (actual != NULL)
{
    if (strcmp(actual->nombre, nombre) == 0 && strcmp(actual->apellido, apellido) == 0)
    {
        printf("Nombre: %s\n", actual->nombre);
        printf("Apellido: %s\n", actual->apellido);
        printf("Fecha de nacimiento: %s\n", actual->fecha_nacimiento);
        printf("Hora de fin de la clase: %s\n", actual->hora_fin);
        return;
    }
    actual = actual->proximo;
}

printf("No se encontro al alumno\n");
}

//Función para guardar alumnos.
void guardar_alumnos()
{
FILE* archivo;
Alumno* actual = primer_alumno;

archivo = fopen("alumnos.txt", "w");

if (archivo == NULL)
{
    printf("No se pudo crear el archivo\n");
    return;
}

while (actual != NULL)
{
    fprintf(archivo, "%s %s %s %s\n", actual->nombre, actual->apellido, actual->fecha_nacimiento, actual->hora_fin);
    actual = actual->proximo;
}
fclose(archivo);
printf("Alumnos guardados exitosamente\n");
}

