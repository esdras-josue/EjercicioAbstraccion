using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EjericioAbstraccion
{
    public abstract class Matematicas
    {
        /// <summary>
        /// atributos de la formula calcular la velocidad de un objeto
        /// </summary>
        protected double Distancia;
        protected double Tiempo;
        /// <summary>
        /// atributos para calcular un promedio
        /// </summary>
        protected double NumeroUno;
        protected double NumeroDos;
        protected double NumeroTres;
        /// <summary>
        /// atributos para calcular el indice de masa corporal(IMC)
        /// </summary>
        protected double Peso;
        protected double Altura;

        /// <summary>
        /// atributos para calcular un descuento
        /// </summary>
        /// 
        protected float PrecioOriginal;
        protected float PorcentajeDescuento;

        // metodo para calcular velocidad
        public abstract double CalcularVelocidad();

        // metodo para calcular promedio de tres numeros;
        public abstract double Promedio();

        // metodo para calcular indice de masa corporal (IMC)
        public abstract double IMC();

        // metodo para calcular descuento
        public abstract float Descuento();
        public abstract void Imprimir();
    }
}
