//Francis Rodriguez - 1ºDAM Semipresencial

/*
 *Máximo menos mínimo V2
 *Recibirás 3 números enteros A, B y C.
 *
 *Debes encontrar el valor de max(A, B, C) - min(A, B, C)
 *
 *Formato de entrada
 *
 *La primera línea de entrada contendrá un solo entero T, que denota el número 
 *de casos de prueba.
 *
 *Cada caso de prueba consta de 3 números enteros A, B, C.
 *
 *Formato de salida
 *
 *Para cada caso de prueba, muestra el valor de max(A, B, C) - min(A, B, C).
 *
 *Restricciones
 *
 *1 ≤ T ≤ 1.000.000.000
 *
 *1 ≤ A ≤ 1 · 1012
 *
 *1 ≤ B ≤ 1 · 1012
 *
 *1 ≤ C ≤ 1 · 1012
 *
 *
 *
 *Ejemplo de entrada
 *
 *4
 *
 *1 35 10
 *
 *7 6 5
 *
 *12345678912 12345678913 12345678914
 *
 *6 6 6
 *
 *Salida para esa entrada
 *
 *34
 *
 *2
 *
 *2
 *
 *0
 */

using System;
class Reto05_MaximosMenosMinimoV2
{

    static void Main()
    {
        uint T = Convert.ToUInt32(Console.ReadLine());

        if (1 <= T && T <= 1000000000)
        {
            string cadena = "";
            ulong A, B, C, min, max;

            for (uint i = 0; i < T; i++)
            {
                cadena = Console.ReadLine();
                string[] fragmentos = cadena.Split();
                A = Convert.ToUInt64(fragmentos[0]);
                min =  max = A;

                B = Convert.ToUInt64(fragmentos[1]);
                max = B > A ? B : A;
                min = B < A ? B : A;

                C = Convert.ToUInt64(fragmentos[2]);
                if (C > max)
                    max = C;
                else if (C < min)
                    min = C;

                if ( (1 <= A && A  <= 1000000000000000000) &&
                    (1 <= B && B <= 1000000000000000000) &&
                    (1 <= C && C <= 1000000000000000000) )
                {
                    Console.WriteLine(max - min);
                }
            }
        }
    }
}