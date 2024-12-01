using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CalculadoraApp.Modelo
{
    public class Calculadora
    {
        // Atributos
        private double num1;
        private double num2;
        private double result;

        // Construtor
        public Calculadora(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        // Métodos
        public void Somar()
        {
            result = num1 + num2;
        }

        public void Subtrair()
        {
            result = num1 - num2;
        }

        public void Dividir()
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
        }

        public void Multiplicar()
        {
            result = num1 * num2;
        }

        // Método para obter o resultado
        public double GetResultado()
        {
            return result;
        }
    }
}
