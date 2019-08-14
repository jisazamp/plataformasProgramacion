using System;

namespace cadenasCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            generarCadenas(1000);
            Console.ReadLine();
        }

        static void generarCadenas(int n)
        {
            // Genera n cadenas aleatorias, de tamaño entre 2 y 10


            /*
             * si la longitud de la cadena que necesitamos generar
             * es menor a 4, no debemos preocuparnos por incluir vocales
             */

            Random r = new Random();
            int numConsonantes;
            String generado;
            char c;
            String vowels = "aeiou";

            for (int i = 0; i < n; i++)
            {
                // numero aleatorio longitud cadena
                int rInt = r.Next(2, 10);
                generado = "";

                if (rInt < 4)
                {
                    for (int j = 0; j < rInt; j++)
                    {
                        int rInt2 = r.Next(97, 122);
                        c = (char)(rInt2);
                        generado += c;
                    }

                    Console.WriteLine(generado);
                }


                // cuando necesitamos por lo menos una vocal
                else if (rInt > 4 && rInt < 8)
                {
                    generado = "";
                    numConsonantes = 0;

                    /*
                    for (int j = 1; j < rInt; j++)
                    {
                        int rInt2 = r.Next(97, 122);
                        c = (char)(rInt2);
                        generado += c;
                    }*/

                    for (int j = 0; j < rInt; j++)
                    {
                        int rInt2 = r.Next(97, 122);
                        if (numConsonantes == 4)
                        {
                            c = vowels[r.Next(vowels.Length)];
                            generado += c;
                        }

                        else if (rInt2 != 97 || rInt2 != 101 || rInt2 != 105 || rInt2 != 111 || rInt2 != 117)
                        {
                            numConsonantes++;
                            c = (char)rInt2;
                            generado += c;
                        }

                        else
                        {
                            c = (char)rInt2;
                            generado += c;
                        }
                    }

                    Console.WriteLine(generado);
                }

                else
                {
                    generado = "";
                    numConsonantes = 0;

                    /*
                    for (int j = 2; j < rInt; j++)
                    {
                        int rInt2 = r.Next(97, 122);
                        c = (char)(rInt2);
                        generado += c;
                    } */

                    for (int j = 0; j < rInt; j++)
                    {
                        int rInt2 = r.Next(97, 122);
                        if (numConsonantes == 4 || numConsonantes == 8)
                        {
                            c = vowels[r.Next(vowels.Length)];
                            generado += c;
                        }

                        else if (rInt2 != 97 || rInt2 != 101 || rInt2 != 105 || rInt2 != 111 || rInt2 != 117)
                        {
                            numConsonantes++;
                            c = (char)rInt2;
                            generado += c;
                        }

                        else
                        {
                            c = (char)rInt2;
                            generado += c;
                        }
                    }

                    Console.WriteLine(generado);
                }
            }             
        }
    }
}
