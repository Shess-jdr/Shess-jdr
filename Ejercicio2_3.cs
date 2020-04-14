/*Escribir un programa que a partir de tres valores enteros pedidos al usuario calcular la suma 
 y la media
*/
using System;

namespace ConsoleApp1
{
    class Ejercicio2_3
    {
        static void Main(string[] args)
        {
            int a, b, c, suma = 0;
            float media = 0;

            Console.WriteLine("Escribe el primer valor:");
            /*el metodo ReadLine recibe por defecto string, 
             asi que hay que hacer una conversion explicita al tipo de dato deseado*/
            a=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo valor:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el tercer valor:");
            c= Int32.Parse(Console.ReadLine());

            suma = a + b + c;
            media = (float) suma / 3;
            /*debe haber una conversion explicita del tipo de dato a real,
            porque sino sería menos precisa la salida*/

            Console.WriteLine ("La suma de los valores ingresados es " + suma);
            Console.WriteLine ("La media de los valores ingresados es " + media);
            Console.ReadLine();      
            
        }
    }
}
