using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericioAbstraccion
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Menu();
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // calcular la velociadad promedio de un objeto
                        Console.WriteLine("Formula para calculara la velocidad de un objeto");
                        Console.WriteLine("********************");

                        Console.WriteLine("Ingrese la distancia que va a recorrer:");
                        double distancia = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese las horas:");
                        double tiempo = double.Parse(Console.ReadLine());
                        Operacion operacionVelocidad = new Operacion(distancia, tiempo);
                        operacionVelocidad.Imprimir();
                        Console.WriteLine("********************");
                        break;
                    case 2:
                        // calcular promedio de la suma de tres numeros
                        Console.WriteLine("Calcular promedio de tres numeros");
                        Console.WriteLine("Ingrese un numero: ");
                        double numeroUno = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingres el segundo numero: ");
                        double numeroDos = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingres el tercer numero: ");
                        double numeroTres = double.Parse(Console.ReadLine());

                        Operacion operacionPromedio = new Operacion(numeroUno, numeroDos, numeroTres);
                        operacionPromedio.Imprimir();
                        Console.WriteLine("********************");
                        break;
                    case 3:
                        // calcular el IMC de una persona
                        Console.WriteLine("Calcular el IMC de una persona");
                        Console.WriteLine("Ingrese su peso en libras:");
                        int peso = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese su altura en centimetros");
                        int altura = int.Parse(Console.ReadLine());
                        Operacion operacionImc = new Operacion(peso, altura);
                        operacionImc.Imprimir();
                        Console.WriteLine("********************");
                        break;
                    case 4:
                        // Calcular descuento
                        Console.WriteLine("********************");
                        Console.WriteLine("Calcular desceunto");
                        Console.WriteLine("Ingrese el precio del producto");
                        float precio = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el porcentaje de descuento");
                        float descuento = float.Parse(Console.ReadLine());
                        Operacion operacionDescuento = new Operacion(precio, descuento);
                        operacionDescuento.Imprimir();
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar nuestro programa");
                        break;
                }
            }
            while (opcion != 5);
          
            Console.ReadKey();
        }

        public static void Menu()
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1.Calcular Velocidad" +
                "\r\n2.Calcular Promedio" +
                "\r\n3.Calcular IMC" +
                "\r\n4.Calcular Descuento" +
                "\r\n5.Salir");
        }
    }
}
