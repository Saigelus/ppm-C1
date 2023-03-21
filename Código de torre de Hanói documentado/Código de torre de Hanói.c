/*
 5x07-Torres_de_Hanoi_parte_2
 24/01/2012

 Escribe un programa (se recomienda que sea recursivo) que d� soluci�n al problema de las torres de Hanoi.
 El enunciado es el siguiente: Se dispone de una torre formada por varios discos de diferentes di�metros denominada torre O (origen),
 donde cada disco es de di�metro inferior a todos los que est�n por debajo. Se dispone de otras dos torres para dejar discos, una denominada torre A (auxiliar) y otra torre D (destino).
 El problema consiste en pasar todos los discos de la torre O a la torre D respetando dos normas muy simples:

 Los discos se pasan de una torre a otra de uno en uno.
 Nunca un disco de mayor di�metro puede estar sobre otro de menor di�metro.
 Se preguntar� al inicio del programa por el tama�o de la torre O (entendiendo que tendr� el n�mero de discos indicados, con alg�n l�mite preestablecido).
 Las torres A y D estar�n inicialmente vac�as.
 Se debe ofrecer la soluci�n que da el programa a este problema paso a paso, mostrando el resultado de una forma gr�fica. El inicio podr�a ser algo as�:
         *
        ***
       *****
      *******
     *********
    ===========        ==========        ==========
 O                A                D

 Formula para calcular movimientos m�nimos necesarios:
 m = 2^n -1

 http://www.rodoval.com/heureka/hanoi/
*/

#include <string.h>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
/*Se incluyen las librer�as que se utilizar�n: string.h, stdio.h, stdlib.h y unistd.h */

void imprime( int *tab, int fil, int col, int ultNum ) /*Se define la funci�n imprime con cuatro par�metros,tres enteros y uno es un puntero.*/
{
    /*Descripci�n de par�metros.*/
    /*
    Precondici�n:
    *tab    Puntero a una matriz de tipo entero.
    fil        Entero que indica el n�mero de filas de la matriz.
    col        Entero que indica el n�mero de columnas de la matriz.
    disc    Par�metro de tipo entero que indica el n�mero de discos usados.
    ultNum    Entero que indica el n�mero que est� usando el disco m�s grande.
    */

    int f, c;           /*Declaraci�n de variables a utilizar, f, c, i, esp.*/
    int i, esp;


    for( c=col-1; c >= 0; c-- )/*Ciclo for que utiliza la variable c y la inicializa en un n�mero menos que la cantidad de discos ingresada,
    su condici�n es que c sea mayor o igual a 0. */
    {
        for( f=0; f < fil; f++ ) /*Ciclo for que utiliza la variable f,inicializa en 0 y su condici�n es que f sea menor al n�mero de filas, cuyo valor ser� dado cuando se llame la funci�n. */
        {
            esp = ( ultNum - tab[col*f+c] )/2; /*se iguala la variable esp a la mitad de la diferencia del valor de la variable ultNum y de la matriz tab en la posici�n*/

// Espacios a la izquierda
            for( i=0; i < esp; i++ ) /*Se inicializa la variable i en cero y la condici�n del for es que i sea menor que el valor de la variable esp*/
                printf( " " ); /*Se dejan los espacios requeridos antes de colocar el/los asteriscos.*/

// Imprime los comodines
            for( i=0; i < tab[col*f+c]; i++ )/*SE inicializa la variable i en 0 nuevamente y la condici�n es que esta sea menor que el valor en el tablero en la posici�n col*f+c*/
                printf( "*" );   /*Imprime los asteriscos. */

// Espacios a la derecha
            for( i=0; i < esp; i++ ) /*Misma condici�n que el for anterior.*/
                printf( " " ); /*Se dejan los espacios necesarios a la izquierda del/ de los asteriscos. */

            printf( "\t" ); /*Deja un espacio para la siguiente impresi�n. */
        };
        printf( "\n" );/*Pasa a una nueva l�nea.*/
    };
};

void mueveDisco( int *tab, int fil, int col, int ultNum, int filOrig, int filDest )
/*Definici�n de la funci�n mueveDisco, la cual se utilizar� para mover los ��discos��, tiene seis par�metros, uno de ellos es un puntero*/
{
    /*
    Precondici�n:
    *tab    Puntero a una matriz de tipo entero.
    fil        Entero que indica el n�mero de filas de la matriz.
    col        Entero que indica el n�mero de columnas de la matriz.
    disc    Par�metro de tipo entero que indica el n�mero de discos usados.
    ultNum    Entero que indica el n�mero que esta usando el disco mas grande.
    filOrig    Entero que indica el n�mero de fila de la matriz en la cual hay que coger el n�mero/disco
    filDest    Entero que indica el n�mero de fila de la matriz en la cual hay que dejar el n�mero/disco.
    Poscondici�n:
    Se mueve el disco y se llama a la funci�n que imprime el tablero.
    */
    int cO=col-1, cD=col-1; /*Se declaran dos nuevas variables y ambas ser�n valdr�n un n�mero menos que el valor en la variable col*/

// Se busca el disco que se encuentre mas arriba y por lo tanto el mas peque�o de la fila de origen.
    while( cO >= 0  &&  tab[col*filOrig+cO] == 0 )
    {
        cO--;/*Se le disminuye uno a la variable de cO. */
    };
    if( cO < 0 ) /*Cuando */
        cO = 0; /*Se iguala cO a 0*/
// Ahora se calcula cu�l es la posici�n libre m�s arriba de la fila de destino.
    while( cD >= 0  &&  tab[col*filDest+cD] == 0 )
    {
        cD--; /*Se le disminuye uno a la variable cD. */
    };
// Se mueve el disco de la fila de origen a la de destino:
    tab[col*filDest+cD+1] = tab[col*filOrig+cO];
    tab[col*filOrig+cO] = 0;

// Se imprime el tablero:
    imprime( tab, fil, col, ultNum );/*Se llama a la funci�n imprime y se imprime en pantalla el tablaro generado. */
};

void delay(int tiempo)
{
  //sleep(tiempo);
    int c, d; /*Declaraci�n de variable c y d.*/
    while(tiempo >= 0) /*Inicio de ciclo while con la variable tiempo mayor o igual a 0*/
    {
        for (c = 1; c <= 10000; c++) /*Se abre un for mientras c sea menor o igual a 10 000, se abrir� otro for que utiliza la variable d. */
            for (d = 1; d <= 10000; d++)
            {}
        tiempo--; /*Se disminuye en uno el valor de la variable tiempo. */
    }

}

void hanoi( int *tab, int fil, int col, int disc, int ultNum, int O, int A, int D )
/*Se define la funci�n Han�i, esta tiene 8 par�metros, uno de ellos es un puntero hacia*/
{
    /*
    Precondici�n:
     *tab    Puntero a una matriz de tipo entero.
     fil        Entero que indica el numero de filas de la matriz.
     col        Entero que indica el numero de columnas de la matriz.
     disc    Par�metro de tipo entero que indica el numero de discos usados.
     ultNum    Entero que indica el numero que esta usando el disco mas grande.
     O,A,D    Tres enteros que indican la fila desde donde se ha de coger el disco y a donde se ha de traspasar. La primera vez que se llama a hanoi tienen los valores de: 0 ,1 y 2 respectivamente.
    Poscondici�n:
     Se llama recursivamente a hanoi hasta resolver el tablero.
    */

    if( disc==1 )
    {
// Se borra la pantalla, se imprime la tabla y se hace una pausa que var�a dependiendo del numero de discos:
        system("cls");
      //system("clear");
        mueveDisco( tab, fil, col, ultNum, O, D ); /*Llama a la funci�n mueveDisco. */
        if(col<=5) delay(4); /*Si col es menor o igual a 5 se llama la funci�n delay con un entero de 4. */
        else if(col<=10) delay(3); /*Si col es menor o igual a 10 se llama a la funci�n delay con un entero de 3. */
        else if(col<=15) delay(2); /*Si col es menor o igual a 15 se llama a la funci�n delay con un entero de 2. */
        else if(col>15) delay(1); /*Si col es mayor a 15 se llama a la funci�n delay con un 1. */
    }
    else
    {
        hanoi( tab, fil, col, disc-1, ultNum, O, D, A ); /*Se llama a s� misma*/
        system("cls"); /*Se limpia la consola. */
        mueveDisco( tab, fil, col, ultNum, O, D ); /*Llama nuevamente a la funci�n mueveDisco*/
        if(col<=5) delay(4); /*Si col vale igual o menos que 5 se llama a la funci�n delay con 3.*/
        else if(col<=10) delay(3); /*Si la variable col es menor o igual a diez se llama a la funci�n delay con 10. */
        else if(col<=15) delay(2); /*Si la variable col es menor o igual a 15 se llama a la funci�n delay con 2. */
        else if(col>15) delay(1); /*Si col es mayor a 15 se llama a la funci�n delay con 1. */
        hanoi( tab, fil, col, disc-1, ultNum, A, O, D ); /*La funci�n se llama a s� misma con los �ltimos par�metros cambiados de orden.*/
    };
};


int main()
/*Funci�n principal. */
{
    int fil=3, col, *tablero = NULL; /*Se declaran las variables a utilizar, se inicializa la variable fil en 3 y a la matriz tab se le declara como NULL.  */
    int f, c, disc=1, ultNum;/*Se declaran las variables locales f, c, ultNum y disc, esta �ltima representa el ancho del disco y se inicializa en 1.*/

    printf( "Indique el numero de discos: " ); /*Se pide que ingrese el n�mero de discos que se desea. */
    scanf( "%i", &col );/*Se almacena en la variabl col. */

    tablero = (int *)malloc( sizeof(int)*fil*col ); /*Se le asigna un espacio de memoria din�mica al puntero tablero que ser� de dimensiones 3*col. */

// Resetea las torres poniendo "los discos" en una de ellas y 0 en el resto.
    for( f=0; f < fil; f++ ) /*Se inicia un for utilizando la variable f, esta indica la posici�n vertical en la que nos encontramos y su condici�n es que esta sea menor que la variable fil, que vale 3, disminuir� en uno el valor de f cuando se cumpla un ciclo suyo. */

        for( c=col-1; c >= 0; c-- ) /*Se usa la variable c y se inicializa con un valor menor en uno al valor de col, y su condici�n es que c sea mayor o igual a 0, disminuye c en uno cada vez que se cumple un ciclo.*/
            if( f==0 ) /*Cuando f sea 0 se aplicar� lo que contin�a. */
            {
                tablero[col*f+c] = disc; /*Se hace que el valor de tablero en la posici�n col*f+c sea igual a disc, la cual est� inicializada en uno. */
                disc+=2;  /*Se aumenta en dos el valor de la variable disc en cada ciclo que completa este for mientras f sea cero. */
            }
            else /*Si f no es 0, se aplica lo que sigue.*/
                tablero[col*f+c] = 0;  /*Se iguala la posici�n del tablero en col*f+c a 0 cuando f est� entre 1 y 3. */
    /*Este for anidado se repetir� hasta que c sea menor a cero y f sea igual a 3, */

    ultNum = disc; /*Se iguala la variable ultNum a disc, que representa qu� ancho tendr� el disco m�s grande. */

// Se imprime el tablero antes de iniciar ning�n movimiento:
    //system("cls");
    /*Borra la pantalla de la consola de comandos. */
    imprime( tablero, fil, col, ultNum ); /*Se llama a la funci�n imprime con el tablero que se registr� en la parte anterior del c�digo en main. */
    delay(6); /*Se llama a la funci�n delay con 6 segundos. */

// Se llama a han�i para comenzar "la partida":
    hanoi( tablero, fil, col, col, ultNum, 0, 1, 2 ); /*Se llama a la funci�n Han�i. */
};
