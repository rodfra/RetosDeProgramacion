//Francis Rodriguez - 1ºDAM Semipresencial

/*
 *Se denomina número reversible a aquél que al ser sumado a sí mismo tras 
 *invertir sus dígitos da como resultado un número en el que todos los dígitos 
 *son impares.
 *
 *Por ejemplo, el número 36 es reversible pues 36 + 63 = 99, y los dos dígitos 
 *de 99 son impares. Fíjate que esto significa que también el número 63 es 
 *reversible. También lo son el 409 y el 904.
 *
 *Para ser considerado número reversible, la cantidad de dígitos del número y de 
 *su versión invertida debe ser el mismo. Por tanto, el número 1000 no es 
 *reversible, incluso aunque 1000 + 0001 = 1001. No se considera válido porque 
 *0001 es en realidad el número 1, que tiene menos dígitos que 1000.
 *
 *Hay más números reversibles de lo que podría parecer. Por ejemplo, hay 20 de 2 
 *dígitos, y 100 de 3.
 *
 *Entrada
 *La entrada está compuesta de una serie de casos de prueba. Cada uno contendrá
 *una línea, con un número positivo menor que 109.
 *
 *Un caso de prueba con un 0 indica el final, y no deberá procesarse.
 *
 *Salida
 *Para cada caso de prueba el programa deberá escribir SI si el número es 
 *reversible, y NO si no lo es.
 *
 *Entrada de ejemplo
 *36
 *904
 *1000
 *37
 *209
 *0
 *
 *Salida de ejemplo
 *SI
 *SI
 *NO
 *NO
 *SI 
 */

using System;
class Reto03_numerosReversibles
{
   
    static void Main()
    {
        uint casoEnEntero = 1;
        do
        {
            casoEnEntero = Convert.ToUInt32(Console.ReadLine());

            if (casoEnEntero != 0)
            {
                string casoEnCadena = Convert.ToString(casoEnEntero);
                string casoEnCadenaReverso = "";

                for (int n = casoEnCadena.Length -1; n >= 0 ; n--)
                {
                    casoEnCadenaReverso += casoEnCadena[n];
                }

                ulong casoEnEnteroReverso = Convert.ToUInt64(casoEnCadenaReverso);
                ulong ambosEnEntero = casoEnEntero + casoEnEnteroReverso;
                string ambosEnCadena = Convert.ToString(ambosEnEntero);
                byte cadaNumero;
                byte cadaNumeroImpar = 0;

                for (int n = 0; n < ambosEnCadena.Length; n++)
                {
                    cadaNumero = Convert.ToByte((byte)(ambosEnCadena[n]) - 48);

                    if (cadaNumero / 2 != 0 || cadaNumero == 1)
                    {
                        cadaNumeroImpar++;
                    }
                }

                if (cadaNumeroImpar == ambosEnCadena.Length)
                {
                    Console.WriteLine("SI");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
        while (casoEnEntero != 0); 
    }
}