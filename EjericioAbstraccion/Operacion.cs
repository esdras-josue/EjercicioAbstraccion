using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EjericioAbstraccion
{
    public class Operacion : Matematicas
    {
        public Operacion() { }
        // constructor que inicizliza atributos para calcular velocidad
        public Operacion(double distancia, double tiempo)
        {
            Distancia = distancia;
            Tiempo = tiempo;
        }

        // constructor que inicializa atributos para calcular promedio de tres numeros
        public Operacion(double numeroUno, double numeroDos, double numeroTres)
        {
            NumeroUno = numeroUno;
            NumeroDos = numeroDos;
            NumeroTres = numeroTres;
        }

        // constructor que inicializa atributos para calcular el IMC de una persona
        public Operacion(int peso, int altura)
        {
            Peso = peso;
            Altura = altura;
        }

        // constructor que inicializa atributos para calcular un descuento
        public Operacion(float precio, float descuento)
        {
            PrecioOriginal = precio;
            PorcentajeDescuento = descuento;
        }


        // metodo para calcular velocidad
        public override double CalcularVelocidad()
        {
            double velocidad = Distancia / Tiempo;
            return velocidad;
        }

        // metodo para calcular promedio de tres numeros
        public override double Promedio()
        {
            double promedio = (NumeroUno + NumeroDos + NumeroTres) / 3;
            return promedio;
        }

        // metodo para calcular el IMC de una persona
        public override double IMC()
        {
            double Imc = Peso/Altura;
            return Imc;
        }

        // metodo para calcular descuento de un articulo
        public override float Descuento()
        {
            float montoDescuento = (PrecioOriginal * PorcentajeDescuento) / 3;
            float precioFinal = PrecioOriginal - PorcentajeDescuento;
            return precioFinal;
             
        }
        public override void Imprimir()
        {
            if (Distancia != 0 && Tiempo != 0)
            {
                Console.WriteLine($"Velocidad: {CalcularVelocidad()} KM/H");
            }

            if (NumeroUno != 0 || NumeroDos != 0 || NumeroTres != 0)
            {
                Console.WriteLine($"Promedio: {Promedio()}");
            }

            if(Peso != 0 && Altura != 0)
            {
                Console.WriteLine($"Indice de masa corporal: {IMC()}.");
            }
            
            if(PrecioOriginal != 0 && PorcentajeDescuento != 0)
            {
                Console.WriteLine($"Precio final: {Descuento()} HNL.");
            }
        }
       
    }
}
