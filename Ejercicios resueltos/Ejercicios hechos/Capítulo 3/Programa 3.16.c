#include <stdio.h>
 /*Calificaciones.
 El programa, al recibir un grupo de calificaciones de unalumno, ,obtiene el promedio 
 de calificaciones de cada uno de ellos y, además, los alumnos con el mejor
 y peor promedio.
 
  I, MAT, MAMAT y MEMAT: variables de tipo entero.
  CAL, SUM, MAPRO, MEPTRO y PRO: variables de tipo real.*/

void main(void)
{
 int I, MAT, MAMAT, MEMAT;
 float SUM, PRO, CAL, MAPRO = 0.0, MEPRO = 11.0;
 printf("Ingrese la matrícula del primer alumno:\t");
 scanf("%d", &MAT);
 while (MAT)
 {
    SUM = 0;
    for (I = 1; I <= 5; I++)
    {
        printf("\nIngrese la califcación del alumno: ", I);
        scanf("%f", &CAL);
        SUM += CAL;
    }
    PRO = SUM / 5;
    printf("\nMatrícula:%d\tPromedio:%.2f", MAT, PRO);
    if (PRO > MAPRO)
    {
        MAPRO = PRO;
        MAMAT = MAT;
    }
    if (PRO < MEPRO)
    {
        MEPRO = PRO;
        MEMAT = MAT;
    }
    printf("\n\nIngrese la matrícula del siguiente alumon: ");
    scanf("%d", &MAT);
 }
 printf("\n\nAlumno con mejor Promedio:\t%d\t5.2f", MAMAT, MAPRO);
 printf("\n\nAlumno con peor Promedio:\t%d\t%5.2f", MEMAT, MEPRO);
}