#include <stdio.h>
#include <stdlib.h>

void Lectura(int A[], int B);
void Impresion(int A[], int B);
void Resultado(int X[], int Y[], int Z[], int B);

void main(void)
{
    printf("Programa que toma dos arreglos y los suma inversamente.\n");
    int n;
    printf("\nIndique la cantidad de elementos que desea que tengan sus arreglos: ");
    scanf("%d", &n);

    int Array1[n], Array2[n], Res[n];
    printf("\nPrimer arreglo\n");
    Lectura(Array1, n);
    printf("\nSegundo arreglo\n");
    Lectura(Array2, n);

    printf("\nEste es el primer arreglo que ha ingresado:\n {");
    Impresion(Array1, n);
    printf("}");
    printf("\nEste es el segundo arreglo que ha ingresado:\n {");
    Impresion(Array2, n);
    printf("}");

    Resultado(Array1, Array2, Res, n);
    printf("\n\nEste es el arreglo con la suma de los opuestos:\n {");
    Impresion(Res, n);
    printf("}");
}

void Lectura(int A[], int B)
{
    int T;
    for (T=0; T<B; T++)
    {
        printf("Ingrese el %d elemento de su arreglo: ", T+1);
        scanf("%d", &A[T]);
    }
}

void Impresion(int A[], int B)
{
    int T;
    for(T=0; T<B; T++)
    {
        printf("%d\t", A[T]);
    }
}

void Resultado(int X[], int Y[], int Z[], int B)
{
    int T;
    for(T=0; T<B; T++)
    {
        Z[T] = X[T] + Y[B - (T+1)];
    }
}