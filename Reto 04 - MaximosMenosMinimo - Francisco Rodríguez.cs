//Francis Rodriguez - 1ºDAM Semipresencial

/*
 *Máximo menos mínimo
 *
 *Recibirás 3 números enteros A, B y C tales que A <= B  <=C.
 *
 *Debes encontrar el valor de max(A, B, C) - min(A, B, C)
 *
 *Formato de entrada
 *
 *La primera línea de entrada contendrá un solo entero T, que denota el 
 *número de casos de prueba.
 *
 *Cada caso de prueba consta de 3 números enteros A, B, C.
 *
 *Formato de salida
 *
 *Para cada caso de prueba, muestra el valor de max(A, B, C) - min(A, B, C).
 *
 *
 *
 *Restricciones
 *
 *1 ≤ T ≤ 10
 *
 *1 ≤ A < B < C ≤10
 *
 *
 *
 *Ejemplo de entrada
 *
 *4
 *
 *1 3 10
 *
 *5 6 7
 *
 *3 8 9
 *
 *2 5 6
 *
 *Salida para esa entrada
 *
 *9
 *
 *2
 *
 *6
 *
 *4
 */

using System;
class Reto04_MaximosMenosMinimo
{
   
    static void Main()
    {
        byte T = Convert.ToByte(Console.ReadLine());
        byte A, B, C;

        if (T >= 1 && T <= 10)
        {
            for (byte i = 0; i < T; i++)
            {
                A = Convert.ToByte(Console.ReadLine());
                B = Convert.ToByte(Console.ReadLine());
                C = Convert.ToByte(Console.ReadLine());

                if (1 <= A && A < B && B < C && C <= 10)
                {
                    Console.WriteLine(C - A);
                }
            }
        }
    }
}