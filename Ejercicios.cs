using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenR_Alejandro
{
    internal class Ejercicios
    {
        public void GananciasPorVendedores()
        {
            int[,] tabla =
            {
                   { 500,3000,100,400,},
                   { 1000,150,200,500,},
                   { 250,1800,2900,300,},
                   { 400,130,90,2400,},
                   { 60,20,4000,3600},
            };

            Console.WriteLine("Tabla de vendedores:");
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    Console.Write(tabla[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] gananciaProducto = new int[tabla.GetLength(1)];
            for (int j = 0; j < tabla.GetLength(1); j++)
            {
                for (int i = 0; i < tabla.GetLength(0); i++)
                {
                    gananciaProducto[j] += tabla[i, j];
                }
            }

            Console.WriteLine("Ganancia total por producto:");
            for (int j = 0; j < gananciaProducto.Length; j++)
            {
                Console.WriteLine("Producto " + (j + 1) + ":" + gananciaProducto[j]);
            }



            int[] gananciaVendedor = new int[tabla.GetLength(0)];
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    gananciaVendedor[i] += tabla[i, j];
                }
            }

            Console.WriteLine("Ganancia total de vendendores");
            for (int i = 0; i < gananciaVendedor.Length; i++)
            {
                Console.WriteLine("Vendedor " + (i + 1) + ":" + gananciaVendedor[i]);
            }

        }

        public void Curp()
        {
            Console.WriteLine("Escribe tu curp (solo 18 digitos)");

            string curp = Console.ReadLine();

            if (curp.Length >= 18)
            {
                string fechaNacimiento = curp.Substring(4, 6);
                string genero = curp.Substring(10, 1);

                string fechaCompleta = fechaNacimiento.Substring(4, 2) + fechaNacimiento.Substring(2, 2) + fechaNacimiento.Substring(0, 2);

                string generofechaCompleta = (fechaCompleta == "H") ? "Hombre" : (genero == "M") ? "Mujer" : "Curp Incorrecta";

                Console.WriteLine($"Su genero es {genero}");
                Console.WriteLine($"Y su fecha es {fechaNacimiento}");

            }


        }

        public void Calificaciones()
        {
            int[] numero = new int[10];
            Random aleatorio = new Random();

            for (int i = 0; i < numero.Length; i++)
            {
                int calificaciones = aleatorio.Next(1, 100);
                numero[i] = calificaciones;
            }

            Console.WriteLine("Calificaciones Desordenadas");
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine(numero[i]);
            }

            int temp = 0;
            for (int i = 1; i < numero.Length; i++)
            {
                for (int j = numero.Length - 1; j >= i; j--)
                {
                    if (numero[j - 1] < numero[j])
                    {
                        temp = numero[j - 1];
                        numero[j - 1] = numero[j];
                        numero[j] = temp;
                    }

                }
            }
            Console.WriteLine("Calificacion Ordenadas");
            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write(numero[i] + " ");
            }
            Console.WriteLine();
            int numero1 = 75;
            int inicio = 0;
            int fin = numero.Length - 1;




        }
    }
}
