//Francis Rodriguez - 1ºDAM Semipresencial

/*
 * A veces, algunas palabras como "localization" o "internationalization" 
 * son tan largas que escribirlas muchas veces en un mismo texto es
 * bastante tedioso.
 * 
 * Consideremos una palabra demasiado larga, si su longitud es 
 * estrictamente superior a 10 caracteres. Todas las palabras demasiado 
 * largas deben reemplazarse con una abreviatura especial.
 * 
 * Esta abreviatura se hace así: escribimos la primera y la última letra
 * de una palabra y entre ellas escribimos el número de letras entre la
 * primera y la última letra. Ese número está en sistema decimal y no 
 * contiene ceros a la izquierda.
 * 
 * Por lo tanto, "localization" se escribirá como "l10n", e "internationalization» 
 * se escribirá como "i18n".
 * 
 * Deberás automatizar el proceso de cambiar las palabras por abreviaturas.
 * Todas las palabras demasiado largas deben ser reemplazadas por la 
 * abreviatura y las palabras que no son demasiado largas no deben 
 * sufrir ningún cambio.
 * 
 * Formato de entrada
 * 
 * La primera línea contiene un número entero n (1 ≤ n ≤ 100). Cada una 
 * de las siguientes n líneas contiene una palabra. Todas las palabras
 * consisten en letras latinas minúsculas y poseen longitudes de 1 a 100 caracteres.
 * 
 * Formato de salida
 * 
 * Debes mostrar n líneas. La i-ésima línea debe contener el resultado de 
 * reemplazar la i-ésima palabra de los datos de entrada.
 * 
 * Ejemplo de entrada
 * 4
 * word
 * localization
 * internationalization
 * pneumonoultramicroscopicsilicovolcanoconiosis
 * 
 * Ejemplo de salida para esa entrada
 * word
 * l10n
 * i18n
 * p43s
 */

using System;
class RetoWayTooLongWords
{

    static void Main()
    {
        byte n = Convert.ToByte(Console.ReadLine());
        string[] palabras = new string[n];

        if (n >= 1 && n <= 100)
        {
            for (byte i = 0; i < n; i++)
            {
                palabras[i] = Console.ReadLine();

                if (palabras[i].Length > 10)
                {
                    string inicial = 
                        palabras[i].Substring(0, 1);
                    string final = 
                        palabras[i].Substring(palabras[i].Length - 1, 1);
                    string subPalabra = 
                        palabras[i].Substring(1, palabras[i].Length - 2);
                    byte caracteres =
                        Convert.ToByte(subPalabra.Length);

                    palabras[i] = inicial + caracteres + final;
                }
            }
        }

        Console.WriteLine();

        foreach (string p in  palabras)
        {
            Console.WriteLine(p);
        }
    }
}
