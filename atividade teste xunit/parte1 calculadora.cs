using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace atividade_louc
{
    public class CalcTest
    {
        [Fact]
        public void TestarSomar() 
        {
            // when
            double resultado = Calculadora.Somar(3,5);

            //then
            Assert.Equal(8, resultado);
        }
        [Fact]
        public void TestarMultiplicacao()
        {
            // when
            double resultado = Calculadora.Multiplicar(3, 5);

            //then
            Assert.Equal(15, resultado);
        }
        [Fact]
        public void TestarsSubtrair()
        {
            // when
            double resultado = Calculadora.Subtrair(3, 5);

            //then
            Assert.Equal(-2, resultado);
        }
        [Fact]
        public void TestarDividir()
        {
            // when
            double resultado = Calculadora.Dividir(3, 5);

            //then
            Assert.Equal(0.6, resultado);
        }
        [Fact]
        public void DivididoPorZero()
        {
            double resultado = Calculadora.dividir (3, 0);

            Assert.Equal(Double.PositiveInfinity, resultado);
        }
    }
}

