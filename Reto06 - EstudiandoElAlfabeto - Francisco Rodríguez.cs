//Francis Rodriguez - 1ºDAM Semipresencial

/*
 * Estudiando el alfabeto
 * Chef tiene un hermano menor, Jeff, que está aprendiendo a leer.
 * 
 * Sólo conoce algunas letras del alfabeto. Para ayudar a Jeff a estudiar, Chef
 * le dio un libro con el texto compuesto por N palabras. Jeff puede leer una
 * palabra si sólo está formada por las letras que conoce.
 * 
 * Ahora Chef siente curiosidad por saber qué palabras podrá leer su hermano
 * y cuáles no. ¿Puedes ayudarle?
 * 
 * Entrada
 * 
 * La primera línea de la entrada contiene una cadena de letras minúsculas S, 
 * que consta de las letras que Jeff puede leer. Cada letra aparecerá en S no más 
 * de una vez.
 * 
 * La segunda línea de la entrada contiene un número entero N que indica el 
 * número de palabras del libro.
 * 
 * Cada una de las siguientes N líneas contiene una sola cadena de letras latinas 
 * minúsculas Wi, que denota la i-ésima palabra del libro.
 * 
 * Salida
 * 
 * Para cada una de las palabras, debes escribir "Yes" (sin comillas) en caso de 
 * que Jeff pueda leerlo y "No" (sin comillas) en caso contrario.
 * 
 * Restricciones
 * 
 * 1 ≤ |S| ≤ 26
 * 
 * 1 ≤ N ≤ 1000
 * 
 * 1 ≤ |Wi| ≤ 12
 * 
 * Cada letra aparecerá en S no más de una vez.
 * 
 * S, Wi están formadas sólo por letras latinas minúsculas.
 * 
 * Ejemplo de entrada
 * 
 * act
 * 
 * 2
 * 
 * cat
 * 
 * dog
 * 
 * Salida para esa entrada
 * 
 * Yes
 * 
 * No
 * 
 * Explicación
 * 
 * La primera palabra se puede leer.
 * 
 * La segunda palabra contiene las letras d, o y g que Jeff no conoce.
 */

using System;
class Alfabeto
{
    static void Main()
    {     
        string S = Console.ReadLine();

        if (S.Length >= 1 && S.Length <= 26)
        {
            char[] letrasConocidas = new char[S.Length];
            bool todoMinusculas = true;
            byte contadorRepetidas;
            bool letrasNoRepetidas = true;

            for (int i = 0; i < S.Length; i++)
            {
                letrasConocidas[i] = S[i];

                if (S[i] <'a' || S[i] > 'z' || S[i] == 'ñ')
                {
                    todoMinusculas = false;
                }

                contadorRepetidas = 0;
                for (int j = 0; j < S.Length; j++)
                {
                    if (letrasConocidas[i] == S[j])
                    {
                        contadorRepetidas++;
                    }

                    if (contadorRepetidas >= 2)
                    {
                        letrasNoRepetidas = false;
                    }
                }
            }

            if (todoMinusculas && letrasNoRepetidas) 
            {
                ushort N = Convert.ToUInt16 (Console.ReadLine());
                if (N >= 1 && N <= 1000)
                {
                    char[] letrasDePalabras;
                    string Wi = "";
                    for (int i = 0; i < N; i++)
                    {
                        Wi =  Console.ReadLine();
                        letrasDePalabras = new char[Wi.Length];
                        todoMinusculas = false;
                        letrasNoRepetidas = true;

                        for (int j = 0; j < Wi.Length; j++)
                        {
                            todoMinusculas = true;

                            if (Wi[j] < 'a' || Wi[j] > 'z' || Wi[j] == 'ñ')
                            {
                                todoMinusculas = false;
                            }
                        }

                        bool coincidenTodasLasLetras = false;
                        if (todoMinusculas && letrasNoRepetidas)
                        {
                            coincidenTodasLasLetras = true;
                            int contadorDeCoincidencias;

                            for (int k = 0; k < Wi.Length; k++)
                            {
                                contadorDeCoincidencias = 0;

                                for (int l = 0; l < S.Length; l++)
                                {
                                    if (Wi[k] == S[l])
                                    {
                                        contadorDeCoincidencias++;
                                    }
                                }

                                if (contadorDeCoincidencias == 0)
                                    coincidenTodasLasLetras = false;
                            }

                            if (coincidenTodasLasLetras)
                                Console.WriteLine("Yes");
                            else
                                Console.WriteLine("No");
                        }
                    }
                }
            }
        }
    }
}