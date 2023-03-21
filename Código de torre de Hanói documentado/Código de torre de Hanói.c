/*
 5x07-Torres_de_Hanoi_parte_2
 24/01/2012

 Escribe un programa (se recomienda que sea recursivo) que dé solución al problema de las torres de Hanoi.
 El enunciado es el siguiente: Se dispone de una torre formada por varios discos de diferentes diámetros denominada torre O (origen),
 donde cada disco es de diámetro inferior a todos los que están por debajo. Se dispone de otras dos torres para dejar discos, una denominada torre A (auxiliar) y otra torre D (destino).
 El problema consiste en pasar todos los discos de la torre O a la torre D respetando dos normas muy simples:

 Los discos se pasan de una torre a otra de uno en uno.
 Nunca un disco de mayor diámetro puede estar sobre otro de menor diámetro.
 Se preguntará al inicio del programa por el tamaño de la torre O (entendiendo que tendrá el número de discos indicados, con algún límite preestablecido).
 Las torres A y D estarán inicialmente vacías.
 Se debe ofrecer la solución que da el programa a este problema paso a paso, mostrando el resultado de una forma gráfica. El inicio podría ser algo así:
         *
        ***
       *****
      *******
     *********
    ===========        ==========        ==========
 O                A                D

 Formula para calcular movimientos mínimos necesarios:
 m = 2^n -1

 http://www.rodoval.com/heureka/hanoi/
*/

#include <string.h>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
/*Se incluyen las librerías que se utilizarán: string.h, stdio.h, stdlib.h y unistd.h */

void imprime( int *tab, int fil, int col, int ultNum ) /*Se define la función imprime con cuatro parámetros,tres enteros y uno es un puntero.*/
{
    /*Descripción de parámetros.*/
    /*
    Precondición:
    *tab    Puntero a una matriz de tipo entero.
    fil        Entero que indica el número de filas de la matriz.
    col        Entero que indica el número de columnas de la matriz.
    disc    Parámetro de tipo entero que indica el número de discos usados.
    ultNum    Entero que indica el número que está usando el disco más grande.
    */

    int f, c;           /*Declaración de variables a utilizar, f, c, i, esp.*/
    int i, esp;


    for( c=col-1; c >= 0; c-- )/*Ciclo for que utiliza la variable c y la inicializa en un número menos que la cantidad de discos ingresada,
    su condición es que c sea mayor o igual a 0. */
    {
        for( f=0; f < fil; f++ ) /*Ciclo for que utiliza la variable f,inicializa en 0 y su condición es que f sea menor al número de filas, cuyo valor será dado cuando se llame la función. */
        {
            esp = ( ultNum - tab[col*f+c] )/2; /*se iguala la variable esp a la mitad de la diferencia del valor de la variable ultNum y de la matriz tab en la posición*/

// Espacios a la izquierda
            for( i=0; i < esp; i++ ) /*Se inicializa la variable i en cero y la condición del for es que i sea menor que el valor de la variable esp*/
                printf( " " ); /*Se dejan los espacios requeridos antes de colocar el/los asteriscos.*/

// Imprime los comodines
            for( i=0; i < tab[col*f+c]; i++ )/*SE inicializa la variable i en 0 nuevamente y la condición es que esta sea menor que el valor en el tablero en la posición col*f+c*/
                printf( "*" );   /*Imprime los asteriscos. */

// Espacios a la derecha
            for( i=0; i < esp; i++ ) /*Misma condición que el for anterior.*/
                printf( " " ); /*Se dejan los espacios necesarios a la izquierda del/ de los asteriscos. */

            printf( "\t" ); /*Deja un espacio para la siguiente impresión. */
        };
        printf( "\n" );/*Pasa a una nueva línea.*/
    };
};

void mueveDisco( int *tab, int fil, int col, int ultNum, int filOrig, int filDest )
/*Definición de la función mueveDisco, la cual se utilizará para mover los ´´discos´´, tiene seis parámetros, uno de ellos es un puntero*/
{
    /*
    Precondición:
    *tab    Puntero a una matriz de tipo entero.
    fil        Entero que indica el número de filas de la matriz.
    col        Entero que indica el número de columnas de la matriz.
    disc    Parámetro de tipo entero que indica el número de discos usados.
    ultNum    Entero que indica el número que esta usando el disco mas grande.
    filOrig    Entero que indica el número de fila de la matriz en la cual hay que coger el número/disco
    filDest    Entero que indica el número de fila de la matriz en la cual hay que dejar el número/disco.
    Poscondición:
    Se mueve el disco y se llama a la función que imprime el tablero.
    */
    int cO=col-1, cD=col-1; /*Se declaran dos nuevas variables y ambas serán valdrán un número menos que el valor en la variable col*/

// Se busca el disco que se encuentre mas arriba y por lo tanto el mas pequeño de la fila de origen.
    while( cO >= 0  &&  tab[col*filOrig+cO] == 0 )
    {
        cO--;/*Se le disminuye uno a la variable de cO. */
    };
    if( cO < 0 ) /*Cuando */
        cO = 0; /*Se iguala cO a 0*/
// Ahora se calcula cuál es la posición libre más arriba de la fila de destino.
    while( cD >= 0  &&  tab[col*filDest+cD] == 0 )
    {
        cD--; /*Se le disminuye uno a la variable cD. */
    };
// Se mueve el disco de la fila de origen a la de destino:
    tab[col*filDest+cD+1] = tab[col*filOrig+cO];
    tab[col*filOrig+cO] = 0;

// Se imprime el tablero:
    imprime( tab, fil, col, ultNum );/*Se llama a la función imprime y se imprime en pantalla el tablaro generado. */
};

void delay(int tiempo)
{
  //sleep(tiempo);
    int c, d; /*Declaración de variable c y d.*/
    while(tiempo >= 0) /*Inicio de ciclo while con la variable tiempo mayor o igual a 0*/
    {
        for (c = 1; c <= 10000; c++) /*Se abre un for mientras c sea menor o igual a 10 000, se abrirá otro for que utiliza la variable d. */
            for (d = 1; d <= 10000; d++)
            {}
        tiempo--; /*Se disminuye en uno el valor de la variable tiempo. */
    }

}

void hanoi( int *tab, int fil, int col, int disc, int ultNum, int O, int A, int D )
/*Se define la función Hanói, esta tiene 8 parámetros, uno de ellos es un puntero hacia*/
{
    /*
    Precondición:
     *tab    Puntero a una matriz de tipo entero.
     fil        Entero que indica el numero de filas de la matriz.
     col        Entero que indica el numero de columnas de la matriz.
     disc    Parámetro de tipo entero que indica el numero de discos usados.
     ultNum    Entero que indica el numero que esta usando el disco mas grande.
     O,A,D    Tres enteros que indican la fila desde donde se ha de coger el disco y a donde se ha de traspasar. La primera vez que se llama a hanoi tienen los valores de: 0 ,1 y 2 respectivamente.
    Poscondición:
     Se llama recursivamente a hanoi hasta resolver el tablero.
    */

    if( disc==1 )
    {
// Se borra la pantalla, se imprime la tabla y se hace una pausa que varía dependiendo del numero de discos:
        system("cls");
      //system("clear");
        mueveDisco( tab, fil, col, ultNum, O, D ); /*Llama a la función mueveDisco. */
        if(col<=5) delay(4); /*Si col es menor o igual a 5 se llama la función delay con un entero de 4. */
        else if(col<=10) delay(3); /*Si col es menor o igual a 10 se llama a la función delay con un entero de 3. */
        else if(col<=15) delay(2); /*Si col es menor o igual a 15 se llama a la función delay con un entero de 2. */
        else if(col>15) delay(1); /*Si col es mayor a 15 se llama a la función delay con un 1. */
    }
    else
    {
        hanoi( tab, fil, col, disc-1, ultNum, O, D, A ); /*Se llama a sí misma*/
        system("cls"); /*Se limpia la consola. */
        mueveDisco( tab, fil, col, ultNum, O, D ); /*Llama nuevamente a la función mueveDisco*/
        if(col<=5) delay(4); /*Si col vale igual o menos que 5 se llama a la función delay con 3.*/
        else if(col<=10) delay(3); /*Si la variable col es menor o igual a diez se llama a la función delay con 10. */
        else if(col<=15) delay(2); /*Si la variable col es menor o igual a 15 se llama a la función delay con 2. */
        else if(col>15) delay(1); /*Si col es mayor a 15 se llama a la función delay con 1. */
        hanoi( tab, fil, col, disc-1, ultNum, A, O, D ); /*La función se llama a sí misma con los últimos parámetros cambiados de orden.*/
    };
};


int main()
/*Función principal. */
{
    int fil=3, col, *tablero = NULL; /*Se declaran las variables a utilizar, se inicializa la variable fil en 3 y a la matriz tab se le declara como NULL.  */
    int f, c, disc=1, ultNum;/*Se declaran las variables locales f, c, ultNum y disc, esta última representa el ancho del disco y se inicializa en 1.*/

    printf( "Indique el numero de discos: " ); /*Se pide que ingrese el número de discos que se desea. */
    scanf( "%i", &col );/*Se almacena en la variabl col. */

    tablero = (int *)malloc( sizeof(int)*fil*col ); /*Se le asigna un espacio de memoria dinámica al puntero tablero que será de dimensiones 3*col. */

// Resetea las torres poniendo "los discos" en una de ellas y 0 en el resto.
    for( f=0; f < fil; f++ ) /*Se inicia un for utilizando la variable f, esta indica la posición vertical en la que nos encontramos y su condición es que esta sea menor que la variable fil, que vale 3, disminuirá en uno el valor de f cuando se cumpla un ciclo suyo. */

        for( c=col-1; c >= 0; c-- ) /*Se usa la variable c y se inicializa con un valor menor en uno al valor de col, y su condición es que c sea mayor o igual a 0, disminuye c en uno cada vez que se cumple un ciclo.*/
            if( f==0 ) /*Cuando f sea 0 se aplicará lo que continúa. */
            {
                tablero[col*f+c] = disc; /*Se hace que el valor de tablero en la posición col*f+c sea igual a disc, la cual está inicializada en uno. */
                disc+=2;  /*Se aumenta en dos el valor de la variable disc en cada ciclo que completa este for mientras f sea cero. */
            }
            else /*Si f no es 0, se aplica lo que sigue.*/
                tablero[col*f+c] = 0;  /*Se iguala la posición del tablero en col*f+c a 0 cuando f esté entre 1 y 3. */
    /*Este for anidado se repetirá hasta que c sea menor a cero y f sea igual a 3, */

    ultNum = disc; /*Se iguala la variable ultNum a disc, que representa qué ancho tendrá el disco más grande. */

// Se imprime el tablero antes de iniciar ningún movimiento:
    //system("cls");
    /*Borra la pantalla de la consola de comandos. */
    imprime( tablero, fil, col, ultNum ); /*Se llama a la función imprime con el tablero que se registró en la parte anterior del código en main. */
    delay(6); /*Se llama a la función delay con 6 segundos. */

// Se llama a hanói para comenzar "la partida":
    hanoi( tablero, fil, col, col, ultNum, 0, 1, 2 ); /*Se llama a la función Hanói. */
};
