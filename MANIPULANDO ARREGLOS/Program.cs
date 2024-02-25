using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulando_arreglos_2
{
    class Program
    {
        static void Main()
        {
            int num_caract;
            string cadena = null;
            string[] arreglo1 = null;



            try
            {
                Console.Write("Número de caracteres del arreglo 1: ");
                num_caract = int.Parse(Console.ReadLine());
                arreglo1 = new string[num_caract];
            }
            catch (FormatException)
            {
                Console.WriteLine("el valor debe ser numerico.");
                Program.Main();
            }


            for (int i = 0; i < arreglo1.Length; i++)
            {
                Console.Write("Carácter {0}: ", i + 1);
                cadena = Console.ReadLine();


                if (Array.IndexOf(arreglo1, cadena) != -1)
                {
                    Console.WriteLine("el valor ya fue insertado , Valor insertado cancelado. siga iterando");
                    i--;
                }
                else
                {
                    arreglo1[i] = cadena;
                }


            }

            Console.WriteLine("los valores del arreglo1:");

            foreach (string datos in arreglo1)
            {
                Console.Write(datos + " ");

            }

            Console.WriteLine();


            Console.Write("Número de caracteres del arreglo 2: ");
            num_caract = int.Parse(Console.ReadLine());
            string[] arreglo2 = new string[num_caract];
            for (int i = 0; i < arreglo2.Length; i++)
            {
                Console.Write("Carácter {0} : ", i + 1);
                cadena = Console.ReadLine();
                arreglo2[i] = cadena;
            }
            Console.WriteLine("datos ingresados en el arreglo2.");
            foreach (string valor in arreglo2)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();

            Console.WriteLine("comparación entre el arreglo1 con el arreglo 2 para generar al arreglo 3 bidimensional :");
            int[] repeticiones = new int[256]; // arreglo donde almacena los caracteres del arreglo2 concidentes a los carracteres del arreglo1

            for (int i = 0; i < repeticiones.Length; i++)
            {
                repeticiones[i] = 0;
            }

            for (int i = 0; i < arreglo1.Length; i++)
            {
                for (int y = 0; y < arreglo2.Length; y++)
                {
                    if (arreglo1[i] == arreglo2[y])
                    {
                        repeticiones[(int)arreglo1[i][0]]++;// contador de repeticiones y verificador de caracter repetiddo del array o arreglo de 1 y 2. 
                    }
                }
            }
            Console.WriteLine("considencias ");
            for (int i = 0; i < repeticiones.Length; i++)
            {
                if (repeticiones[i] > 0)

                    Console.WriteLine("{0} : {1}", (char)i, repeticiones[i]);
            }


            Console.WriteLine(" la comparación del arreglo 2 con el arreglo 1");
            int[] noEncontrados = new int[256]; // arreglo donde alamacena los caracteres del arreglo2 no encontradas en el arreglo 1
            for (int i = 0; i < noEncontrados.Length; i++)
            {
                noEncontrados[i] = 0;
            }


            foreach (var c in arreglo2)
            {
                bool existe = false; // en este apartado se utilizo la bariable booleana (verdadero o falso) para condicionar
                                     // si existes el caracter que esta en el arreglo2 en el arreglo 1, y si no lo encuetra esta listo un arreglo
                                     // donde alamacena el caracter no encontrado en el arreglo1 y el contador de veces incrementa
                                     // las veces que ay en el arreglo2 pero en el arreglo1 no encuentra ninguna.
                foreach (var verificar in arreglo1)
                {

                    if (verificar == c)
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    noEncontrados[c[0]]++;
                }

            }

            for (int i = 0; i < noEncontrados.Length; i++)
            {
                if (noEncontrados[i] > 0)
                {
                    Console.WriteLine("{0} : {1}", (char)i, noEncontrados[i]);
                }

            }


            Console.ReadKey();

        }

    }
}